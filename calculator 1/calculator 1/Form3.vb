Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Move

        Label1.Text = "Thank You for using the calculator "

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Move
        Label2.Text = "Project by Dheeraj Chettiar"
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Close()
        Form1.Close()
        Form2.Close()
    End Sub
End Class