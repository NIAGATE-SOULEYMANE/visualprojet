Public Class Form2
    Dim operation As New Double
    Dim s As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "0"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox1.Text = "" Then
            operation = "0"
            s = "*"
        Else
            operation = TextBox1.Text
            TextBox1.Clear()
            s = "*"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox1.Text = "" Then
            operation = "0"
            s = "/"
        Else
            operation = TextBox1.Text
            TextBox1.Clear()
            s = "/"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox1.Text = "" Then
            operation = "0"
            s = "+"
        Else
            operation = TextBox1.Text
            TextBox1.Clear()
            s = "+"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox1.Text = "" Then
            operation = "0"
            s = "-"
        Else
            operation = TextBox1.Text
            TextBox1.Clear()
            s = "-"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If s = "+" And TextBox1.Text = "" Then
            TextBox1.Text = "0"
            operation = operation + TextBox1.Text
            TextBox1.Text = operation
        ElseIf s = "+" Then
            operation = operation + TextBox1.Text
            TextBox1.Text = operation
        ElseIf s = "-" And TextBox1.Text = "" Then
            TextBox1.Text = "0"
            operation = operation - TextBox1.
                Text
            TextBox1.Text = operation
        ElseIf s = "-" Then
            operation = operation - TextBox1.Text
            TextBox1.Text = operation
        ElseIf s = "*" And TextBox1.Text = "" Then
            TextBox1.Text = "0"
            operation = operation * TextBox1.Text
            TextBox1.Text = operation
        ElseIf s = "*" Then
            operation = operation * TextBox1.Text
            TextBox1.Text = operation
        ElseIf s = "/" Then
            operation = operation / TextBox1.Text
            TextBox1.Text = operation
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class