Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        If util.Text = "" Or m.Text = "" Then
            MsgBox("Renseignez les champs")

        ElseIf util.Text = "niagate" And m.Text = "souleymane00" Then
            Form3.Show()
            Me.Hide()
            Exit Sub
        Else
            MsgBox("Ce compte n'existe pas")
            Exit Sub
        End If
    End Sub
End Class
