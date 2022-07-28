Option Strict Off
Public Class Network

    Public Property routerList As New SortedList(Of String, Router)
    Public Property linkList As New SortedList(Of String, Link)

    Public ReadOnly Property RouterCount As Integer
        Get
            Return routerList.Count
        End Get
    End Property

    Public ReadOnly Property LinkCount As Integer
        Get
            Return linkList.Count
        End Get
    End Property

    ' Add router to network
    Public Function AddRouter(n As Router) As Boolean
        Try
            If routerList.ContainsKey(n.ID) Then
                Throw New Exception("Router " & n.ID & " already exists.")
            End If
            routerList.Add(n.ID, n)
            'RaiseEvent Changed(Me)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Router exists")
            Return False
        End Try
    End Function

    ' Add router to network using + operator
    Public Shared Operator +(net As Network, id As Integer) As Network
        'net.AddRouter(id)
        Return net
    End Operator

    ' Return router instance given id
    Public Function GetRouter(id As String) As Router
        Try
            If Not routerList.ContainsKey(id) Then
                Throw New Exception("Router " & id & " does not exist.")
            End If
            Return routerList(id)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Router error")
            Return Nothing
        End Try
    End Function

    ' Return link instance given source and destination router

    'Create the Id of the link using the source and destination router info - "t" & "-TO-" & h
    Public Function GetLink(t As String, h As String) As Link
        Try
            Dim id As String = t & "-TO-" & h
            If Not linkList.ContainsKey(id) Then
                Throw New Exception("Link" & id & " does not exist.")
            End If
            Return linkList(id)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Link error")
            Return Nothing
        End Try
    End Function

    ' Add link to network given tail and head ids
    Public Function AddLink(sourceID As String, destID As String) As Boolean

        '' Create head or tail routers if not existent
        'If Not routerList.ContainsKey(tailID) Then
        '    AddRouter(tailID)
        'End If

        'If Not routerList.ContainsKey(headID) Then
        '    AddRouter(headID)
        'End If

        ' Create the link, add it to network, and update tail and head router lists
        Dim t As Router = GetRouter(sourceID)
        Dim h As Router = GetRouter(destID)
        Dim a = New Link(t, h)
        If linkList.ContainsKey(a.ID) Then
            MessageBox.Show("link " & a.ID & " already exists.")
            Return False
        Else
            linkList.Add(a.ID, a)
            t.LinksOut.Add(a)
            h.LinksIn.Add(a)
            ' RaiseEvent Changed(Me)
            Return True
        End If

        End
    End Function

    ' This function will return the maximumbandwidth, if it exists, between the source and 
    'destination Router 
    ' Function returns a list of Links; maxBW will contain the maximum bandwidth possible on 
    'that path

    Public Function CalculateMaximumBandwidthPath(orig As String, dest As String, ByRef maxBW As Decimal) As List(Of Link)

        Dim permList As New List(Of String) 'this list is used to store the Routers for which max bandwidth has been calculated 

        Dim tempList As New List(Of String) 'this list is the working list - as the 
        'algortihm goes through the iterations, the Routers for which the max bandwidth path Is 
        'Not yet calculated it stored here 

        Dim labelList As New SortedList(Of String, Decimal) 'contains the maximum 
        'bandwidth of a Router through the algorithm And the value Is updated if a better max 
        'bandwidth path Is found 

        Dim trackList As New SortedList(Of String, Link)

        Dim inf As Decimal = 1000000000  ' set a large value to represent infinity 

        ' initialization 

        For Each n In routerList.Values
            tempList.Add(n.ID) 'Add all Routers to the tempList  
            labelList.Add(n.ID, 0) 'Assign bandwidth value to 0 for all Routers in the 
            'labelList -initial max bandwidth Is assigned 0 for all Routers 
            trackList.Add(n.ID, Nothing) 'add all Routers to the trackList and assign 
            'nothing  
        Next


        'some basic checks to ensure that the orig and dest are not the same 
        Try
            If Not routerList.ContainsKey(orig) Or Not routerList.ContainsKey(dest) Then
                Throw New Exception("Error in origin or destination")
            End If
            If orig = dest Then
                Throw New Exception("Origin and destination are the same")
            End If

            permList.Add(orig) ' add the originating Router to permList becaue the 
            'bandwidth of the orig Router Is inf And so needs no further processing 

            labelList(orig) = inf 'Set the bandwidth of the origin to infinity 

            tempList.Remove(orig) 'remove the prog Router from the templist because the 
            'max bandwidth of the origin Is inf And it Is the final value.  

            'This is the mian loop of the algorithm - iteratively go through the Links 
            Do Until permList.Contains(dest) ' tempList.Count > 0 
                'Update labels 
                For Each a1 In linkList.Values 'look at Link in LinkList 
                    If permList.Contains(a1.Source.ID) And
                    tempList.Contains(a1.Destination.ID) Then 'if permlist has the tail and templist has the head
                        Dim newlabel = Math.Min(labelList(a1.Source.ID), a1.Bandwidth)
                        'minimum of these two 
                        If newlabel > labelList(a1.Destination.ID) Then
                            labelList(a1.Destination.ID) = newlabel
                            trackList(a1.Destination.ID) = a1
                        End If
                    End If
                Next
                'find smallest labeled temp Router 
                Dim maxlabel As Integer = 0
                Dim maxID As String = Nothing
                For Each t In tempList
                    If labelList(t) > maxlabel Then
                        maxlabel = labelList(t)
                        maxID = t
                    End If
                Next
                If maxID = Nothing And tempList.Count > 0 Then
                    Throw New Exception("No path exists.")
                End If
                'make smallest labeled temp Router permanent 
                permList.Add(maxID)
                tempList.Remove(maxID)

            Loop

            ' backtrack shortest path 
            Dim path As New List(Of Link)
            Dim a As Link = trackList(dest)

            Do
                path.Insert(0, a)
                a = trackList(a.Source.ID)
            Loop Until a Is Nothing
            maxBW = labelList(dest)
            Return path
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error") 
            Return Nothing
        End Try
    End Function


End Class
