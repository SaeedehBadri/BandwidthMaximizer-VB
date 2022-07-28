Public Class Router
    Public Property ID As String
    Public Property LinksIn As List(Of Link)
    Public Property LinksOut As List(Of Link)
    Public Property Xcoord As Decimal
    Public Property Ycoord As Decimal

    Public Property Operational As Boolean

    Public Sub New()

    End Sub

    ' Creates Node instance given id with incoming and outgoing arc lists
    Public Sub New(value As String)
        ID = value
        LinksIn = New List(Of Link)
        LinksOut = New List(Of Link)
    End Sub


End Class
