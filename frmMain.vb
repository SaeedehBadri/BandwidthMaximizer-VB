Option Strict Off
Public Class frmMain


    Public myData As New Database()
    Public myNet As New Network()


    Private Sub frmMBWPR2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        BuildNetwork()

        For i = 0 To myData.GetNumRouters() - 1

            cboDestRouter.Items.Add(myData.GetRouter(i).ID)
            cboOrigRouter.Items.Add(myData.GetRouter(i).ID)

        Next

        lstDataTables.Items.Clear()

        For Each t In myData.myDataSet.Tables
            lstDataTables.Items.Add(t.TableName)
        Next
        frmInitial.CreateForm(New frmMap, frmInitial.spcMain.Panel2)
        Dim newMap As frmMap = frmInitial.getform("frmMap")

        newMap.Net = myNet
        newMap.Orig = ""
        newMap.Dest = ""
        newMap.Path = Nothing
        newMap.Map = myData

        newMap.Refresh()
        newMap.BringToFront()

    End Sub



    'Private Sub ShowNetworkMapToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    '    Dim newMap As frmMap = frmInitial.getform("Map")

    '    newMap.Net = frmMain.mynet
    '    newMap.Orig = ""
    '    newMap.Dest = ""
    '    newMap.Path = Nothing
    '    newMap.Map = frmMain.myData

    '    newMap.Refresh()
    '    newMap.BringToFront()

    'End Sub



    Private Sub showLinks_Click(sender As Object, e As EventArgs) Handles btnCalculateMaxBW.Click
        lstPath.Items.Clear()
        lstDataTables.Items.Clear()
        Dim orig = cboOrigRouter.SelectedItem.ToString
        Dim dest = cboDestRouter.SelectedItem.ToString
        Dim maxBW As Decimal
        'copy the orig and dest router information from the two combo-boxes

        Dim maxList As New List(Of Link)
        maxList = myNet.CalculateMaximumBandwidthPath(orig, dest, maxBW)
        'CalculateMaximumBandwidthPath(orig As String, dest As String, ByRef maxBW As Decimal)
        Dim temp As String
        Dim temp2 As String
        Dim value As String
        Dim flg As Integer = 0
        For Each i In maxList
            'lstPath.Items.Add(i.Bandwidth)
            value += i.Source.ID & "-->"
            If flg = 0 Then
                flg = 1
                temp = "(" + i.Source.ID
                temp2 = CStr(i.Bandwidth)
            ElseIf flg = 1 Then
                flg = 2
                temp = temp + "," + i.Source.ID + ") Bandwidth: " + temp2
                lstPath.Items.Add(temp)
                temp = "(" + i.Source.ID
                temp2 = CStr(i.Bandwidth)
            ElseIf flg = 2 Then
                flg = 1
                temp = temp + "," + i.Source.ID + ") Bandwidth: " + temp2
                lstPath.Items.Add(temp)
                temp = "(" + i.Source.ID
                temp2 = CStr(i.Bandwidth)
            End If
        Next
        temp = temp + "," + dest + ") Bandwidth: " + temp2
        lstPath.Items.Add(temp)

        value += dest

        lblRoutes.Text = value
        lblResult.Text = maxList(0).Bandwidth

        lstDataTables.Items.Add("Routers")
        lstDataTables.Items.Add("Links")


        Dim OrigRouter As String
        Dim DestRouter As String
        Dim BW As List(Of Link)
        Dim maxBandwidth As Decimal

        OrigRouter = cboOrigRouter.SelectedItem.ToString
        DestRouter = cboDestRouter.SelectedItem.ToString
        BW = myNet.CalculateMaximumBandwidthPath(OrigRouter, DestRouter, maxBandwidth)

        'lblMaxBWPossible.Visible = True
        'lblMaxBWPossible.Text = True
        'lblResult.Visible = True
        'lblRoutes.Visible = True

        'Dim y As String
        'For Each r In BW
        '    Dim s = r.ID & r.Bandwidth
        '    lstPath.Items.Add(s)
        '    y += r.Source.ID & "-->" & r.Source.ID
        'Next
        '
        'y += DestRouter
        '
        'lblResult.Text = y
        'lblRoutes.Text = BW(0).Bandwidth

        Dim newMap As frmMap = frmInitial.getform("frmMap")

        newMap.Net = myNet
        newMap.Orig = OrigRouter
        newMap.Dest = DestRouter
        newMap.Path = BW
        newMap.Map = myData

        newMap.Refresh()
        newMap.BringToFront()


        'Show the maximum bandwidth path in a label as shown in the form below and also
        'the value of the maximum bandwidth possible between the two routers.
        'You can use a For Each loop on the returned list(of link) and use some string
        'concatenation. 
        'Show the paths traversed And the bandwidth of each path in the lstbox.

        'lstLinksIn.Items.Clear()
        'lstLinksOut.Items.Clear()

        'Dim linksInList = From ai In mynet.linkList.Values
        '                  Where ai.Destination.ID = cboFrom.SelectedItem.ToString
        '                  Select ai.ID

        'Dim linksOutList = From ao In mynet.linkList.Values
        '                   Where ao.Source.ID = cboFrom.SelectedItem.ToString
        '                   Select ao.ID


        'For Each ai In linksInList

        '    ' MsgBox(a)
        '    lstLinksIn.Items.Add(ai.ToString)
        'Next


        'For Each a In linksOutList

        '    lstLinksOut.Items.Add(a.ToString)
        'Next



    End Sub

    Private Sub BuildNetwork()


        myNet.routerList.Clear()
        myNet.linkList.Clear()

        For i = 0 To myData.GetNumRouters() - 1
            Dim n As New Router
            n = myData.GetRouter(i)
            myNet.AddRouter(n)
        Next

        For Each n1 In myNet.routerList.Keys
            For Each n2 In myNet.routerList.Keys
                Dim bw As Decimal = myData.GetBandwidth(n1, n2)
                If n1 <> n2 And bw > 0 Then
                    myNet.AddLink(n1, n2)
                    Dim a As Link = myNet.GetLink(n1, n2)
                    a.Bandwidth = bw

                End If
            Next

        Next

    End Sub

    Private Sub lstDataTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDataTables.SelectedIndexChanged

        Dim dataform As New frmDatabase

        Dim tname As String = lstDataTables.Text

        dataform.Text = tname
        dataform.Tablename = tname
        dataform.DS = myData.myDataSet
        dataform.DB = myData

        Select Case tname
            Case "Links"
                dataform.DA = myData.LinksDA
            Case "Routers"
                dataform.DA = myData.RoutersDA

            Case Else
                Throw New Exception("Please select a table")

        End Select

        With dataform
            .RefreshTable()
            .Show()
            .BringToFront()
        End With

    End Sub

    Private Sub lstPath_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPath.SelectedIndexChanged

    End Sub

    Private Sub lblRoutes_Click(sender As Object, e As EventArgs) Handles lblRoutes.Click

    End Sub
End Class
