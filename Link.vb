Public Class Link

    Public Property ID As String
    Public Property Source As Router
    Public Property Destination As Router
    Public Property Bandwidth As Decimal

    Public Sub New(s As Router, d As Router)
        Try
            If s Is Nothing Or s Is Nothing Then
                Throw New Exception("Source or head node does not exist.")
            End If
            Source = s
            Destination = d
            ID = Source.ID & "-TO-" & Destination.ID
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Link error")
        End Try
    End Sub

End Class
