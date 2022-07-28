Public Class frmMap

    Public Property MapImage As Image = My.Resources.US_Map

    Public Property Net As New Network()
    Public Property Map As New Database()

    Public Property Path As List(Of Link)

    Public Property Orig As String
    Public Property Dest As String

    Private Property Count As Integer

    Public Sub DrawNode(size As Integer, text As String, xcoord As Integer,
                        ycoord As Integer, filled As Boolean, borderpen As Pen, fillbrush As Brush, textbrush As Brush, e As PaintEventArgs)


        Dim x As Integer = CInt(xcoord - size / 2)

        Dim y As Integer = CInt(ycoord - size / 2)


        e.Graphics.FillEllipse(fillbrush, x, y, size, size)
        e.Graphics.DrawEllipse(borderpen, x, y, size, size)

        Dim fontsize As Integer = CInt(size / 3)
        If fontsize = 0 Then
            fontsize = 1
        End If
        Dim afont As New System.Drawing.Font("Courier New", fontsize, FontStyle.Bold)

        Dim textwidth As Integer = text.Count * fontsize
        Dim tx As Integer = CInt(xcoord - textwidth / 2)
        Dim ty As Integer = CInt(ycoord - afont.GetHeight() / 2)

        e.Graphics.DrawString(text, afont, textbrush, tx, ty)

    End Sub
    Private Sub frmMap_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim xscale As Decimal = CDec(Me.ClientRectangle.Width / MapImage.Width)

        Dim yscale As Decimal = CDec(Me.ClientRectangle.Height / MapImage.Height)


        e.Graphics.Clear(Color.White) 'clearing any background image

        Dim rect As New Rectangle(0, 0, MapImage.Width, MapImage.Height)

        e.Graphics.DrawImage(MapImage, Me.ClientRectangle, rect, GraphicsUnit.Pixel)

        Me.BackgroundImageLayout = ImageLayout.Center


        'Draw an arc


        Dim arcpen As New Pen(Color.Gray)

        arcpen.Width = 2

        'e.Graphics.DrawLine(arcpen, xscale * 195, yscale * 17, xscale * 91, yscale * 42)


        For Each a As Link In Net.linkList.Values
            e.Graphics.DrawLine(arcpen, xscale * a.Source.Xcoord, yscale * a.Source.Ycoord,
                                xscale * a.Destination.Xcoord, yscale * a.Destination.Ycoord)
        Next

        ' setting properties of pen to draw flow arcs
        Dim flowpen As New Pen(Color.Black)
        flowpen.Width = 6

        ' creating flow arcs from the flows list
        If Path IsNot Nothing Then
            For Each a In Path
                e.Graphics.DrawLine(flowpen, xscale * a.Source.Xcoord, yscale * a.Source.Ycoord,
                                         xscale * a.Destination.Xcoord, yscale * a.Destination.Ycoord)
            Next
        End If


        ' ########################################################################


        'Draw the nodes

        Dim minscale As Decimal = xscale

        If yscale < xscale Then
            minscale = yscale
        End If


        Dim borderpen As New Pen(Color.Black)
        borderpen.Width = 2

        Dim fillbrush As New SolidBrush(Color.White)
        Dim fontbrush As New SolidBrush(Color.Black)


        'DrawNode(CInt(minscale * 20), "R0", CInt(xscale * 195), CInt(yscale * 17), False, borderpen, fillbrush, fontbrush, e)

        'DrawNode(CInt(minscale * 20), "R1", CInt(xscale * 91), CInt(yscale * 42), False, borderpen, fillbrush, fontbrush, e)

        '################ code For PROJECT To draw the routers And label them Using the routerList ###########################

        'Remove the lines 74 and 76

        For Each n As Router In Net.routerList.Values
            If n.ID = Orig Then ' source node is blue with white font
                fillbrush.Color = Color.Blue
                fontbrush.Color = Color.Black
            ElseIf n.ID = Dest Then ' destination node is red with white font
                fillbrush.Color = Color.Red
                fontbrush.Color = Color.Black
            End If

            ' creating the node by calling DrawNode
            DrawNode(CInt(minscale * 20), n.ID, CInt(xscale * n.Xcoord), CInt(yscale * n.Ycoord), False,
                     borderpen, fillbrush, fontbrush, e)
            ' resetting fill brush to white and font brush to black 

            fillbrush.Color = Color.White
            fontbrush.Color = Color.Black
        Next

        '#####################################################################################################################



    End Sub
    Private Sub frmMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class