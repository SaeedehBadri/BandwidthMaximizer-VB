
Imports System.Data.OleDb

Public Class frmDatabase

    Public Property DS As DataSet
    Public Property DA As OleDbDataAdapter

    Public Property DB As Database

    Public Property Tablename As String

    Public Sub RefreshTable()

        dgvData.DataSource = DS.Tables(Tablename).DefaultView

    End Sub

    Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdateDatabase_Click(sender As Object, e As EventArgs) Handles btnUpdateDatabase.Click

        DB.UpdateDatabase(DA, DS, Tablename)

    End Sub

    Private Sub btnBacktoMain_Click(sender As Object, e As EventArgs) Handles btnBacktoMain.Click

        Hide()

    End Sub
End Class