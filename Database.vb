Option Strict Off
Imports System.Data.OleDb

Public Class Database

    Public myDataSet As New DataSet
    Public RoutersDA As OleDbDataAdapter
    Public LinksDA As OleDbDataAdapter
    Dim userDA As OleDbDataAdapter

    Public Sub New()
        RoutersDA = GetDataAdapter("SELECT * FROM Routers")
        RoutersDA.Fill(myDataSet, "Routers")
        LinksDA = GetDataAdapter("SELECT * FROM Links")
        LinksDA.Fill(myDataSet, "Links")
    End Sub

    Public Sub New(IsUserData As Boolean)
        userDA = GetDataAdapter("SELECT * FROM Users")
        userDA.Fill(myDataSet, "Users")
    End Sub

    Public Function GetDataAdapter(mySQL As String) As OleDbDataAdapter

        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            Application.StartupPath & "\NetworkData.accdb"
        Return New OleDbDataAdapter(mySQL, connStr)
    End Function

    ' Returns number of Routers in network from Routers table
    Public Function GetNumRouters() As Integer
        Return myDataSet.Tables("Routers").Rows.Count
    End Function

    ' Returns number of Links in network from Links table
    Public Function GetNumLinks() As Integer
        Return myDataSet.Tables("Links").Rows.Count
    End Function

    Public Function GetRouterName(id As Integer) As String
        Dim r() As DataRow = myDataSet.Tables("Routers").Select("ID = " & id)
        If r.Length > 0 Then
            Return r(0)("Name").ToString
        Else
            Return Nothing
        End If
    End Function

    ' Retruns a router with router name and coordinates given router id
    Public Function GetRouter(id As String) As Router
        Dim r() As DataRow = myDataSet.Tables("Routers").Select("ID = " & id)
        If r.Length > 0 Then
            Dim n As New Router(r(0)("Name").ToString)
            n.Xcoord = r(0)("Xcoord")
            n.Ycoord = r(0)("Ycoord")
            Return n
        Else
            Return Nothing
        End If
    End Function



    ' Returns router id given router name
    Public Function GetRouterID(name As String) As Integer
        Dim r() As DataRow = myDataSet.Tables("Routers").Select("Name = '" & name & "'")
        If r.Length > 0 Then
            Return CInt(r(0)("ID"))
        Else
            Return -1
        End If
    End Function

    ' Returns the bandwidth between two Routers given router names
    Public Function GetBandwidth(name1 As String, name2 As String) As Decimal
        Dim i1 As Integer = GetRouterID(name1)
        Dim i2 As Integer = GetRouterID(name2)
        Dim r() As DataRow = myDataSet.Tables("Links").Select("Source = " & i1 & " AND Destination = " & i2)
        If r.Length > 0 Then
            Return CDec(r(0)("Bandwidth"))
        Else
            Return -1
        End If
    End Function

    Public Sub UpdateDatabase(da As OleDbDataAdapter, ds As DataSet, table As String)

        Dim myCommandBuilder As New OleDbCommandBuilder(da)

        da.UpdateCommand = myCommandBuilder.GetUpdateCommand
        da.InsertCommand = myCommandBuilder.GetInsertCommand
        da.DeleteCommand = myCommandBuilder.GetDeleteCommand

        Dim updateCount As Integer = da.Update(myDataSet.Tables(table))

        MessageBox.Show(updateCount & " records updated")

    End Sub

End Class
