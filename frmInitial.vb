Option Strict Off
Public Class frmInitial
    Private Sub frmInitial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        spcMain.Dock = DockStyle.Fill

        'CreateForm(New frmMap, spcMain.Panel1)
        CreateForm(New frmMain, spcMain.Panel1)
        CreateForm(New frmDatabase, spcMain.Panel2)
        CreateForm(New frmMap, spcMain.Panel2)
        'CreateForm(New frmDatabase, spcMain.Panel2)


    End Sub

    'Function to load a form in a specific panel
    Public Sub CreateForm(frm As Form, panel As System.Windows.Forms.SplitterPanel)

        frm.MdiParent = Me
        panel.Controls.Add(frm)
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

    End Sub

    Public Shared Function getform(text As String) As Form
        Dim frm As Form = Nothing

        For Each f In Application.OpenForms
            If f.text = text Then
                frm = f
            End If

        Next

        Return frm

    End Function

    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click


        Application.Exit()


    End Sub

    Private Sub DatabseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem.Click



    End Sub


    Private Sub EditRoutersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditRoutersToolStripMenuItem.Click

        Dim dataform As frmDatabase = frmInitial.getform("frmDatabase")

        Dim tname As String = "Routers" '.text property contains the table selected


        'set the properties of the form "frmDatabase"
        ' dataform.Text = tname
        dataform.Tablename = tname
        dataform.DS = frmMain.myData.myDataSet
        dataform.DB = frmMain.myData

        'set the property DA

        Select Case tname
            Case "Links"
                dataform.DA = frmMain.myData.LinksDA
            Case "Routers"
                dataform.DA = frmMain.myData.RoutersDA

            Case Else
                Throw New Exception("Please Select a table")

        End Select

        With dataform 'use a With construct instead of "dataform.RefershTable(), dataform.Show(), etc.
            .RefreshTable()
            .Show()
            .BringToFront()
        End With


    End Sub

    Private Sub EditLinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditLinksToolStripMenuItem.Click
        Dim dataform As frmDatabase = frmInitial.getform("frmDatabase")

        Dim tname As String = "Links" '.text property contains the table selected


        'set the properties of the form "frmDatabase"
        dataform.Text = tname
        dataform.Tablename = tname
        dataform.DS = frmMain.myData.myDataSet
        dataform.DB = frmMain.myData

        'set the property DA

        Select Case tname
            Case "Links"
                dataform.DA = frmMain.myData.LinksDA
            Case "Routers"
                dataform.DA = frmMain.myData.RoutersDA

            Case Else
                Throw New Exception("Please select a table")

        End Select

        With dataform 'use a With construct instead of "dataform.RefershTable(), dataform.Show(), etc.
            .RefreshTable()
            .Show()
            .BringToFront()
        End With

    End Sub

    Private Sub ShowMapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowNetworkMapToolStripMenuItem.Click
        CreateForm(New frmMap, spcMain.Panel2)

        Dim newMap As frmMap = frmInitial.getform("frmMap")

        newMap.Net = frmMain.myNet
        newMap.Orig = ""
        newMap.Dest = ""
        newMap.Path = Nothing
        newMap.Map = frmMain.myData

        newMap.Refresh()
        newMap.BringToFront()

    End Sub

    Private Sub spcMain_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles spcMain.Panel1.Paint

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem.Click

    End Sub

    Private Sub NetworkMapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NetworkMapToolStripMenuItem.Click

    End Sub

    Private Sub ShowNetworkMapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowNetworkMapToolStripMenuItem.Click

    End Sub
End Class