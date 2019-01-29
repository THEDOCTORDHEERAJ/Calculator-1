Public Class Form1
    Dim Num_1 As Decimal
    Dim Num_2 As Decimal
    Dim Operation As Integer
    Dim Operation_selector As Boolean = False




    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Operation_selector = True Then
            Num_2 = TextBox1.Text
            If Operation = 1 Then
                TextBox1.Text = Num_1 + Num_2
            ElseIf Operation = 2 Then
                TextBox1.Text = Num_1 - Num_2
            ElseIf Operation = 3 Then
                TextBox1.Text = Num_1 * Num_2
            ElseIf Operation = 5 Then
                TextBox1.Text = Num_1 * Num_1
            ElseIf Operation = 6 Then
                If (TextBox1.Text.Contains("-")) Then
                    TextBox1.Text = -1 * TextBox1.Text
                Else
                    TextBox1.Text = TextBox1.Text
                End If

            ElseIf Operation = 8 Then
                TextBox1.Text = (Num_1 / Num_2) * 100
            ElseIf Operation = 9 Then
                TextBox1.Text = Math.Sqrt(TextBox1.Text)
            ElseIf Operation = 10 Then
                Dim i As Integer
                Dim Fact = 1
                For i = 1 To Num_1
                    Fact = Fact * i
                Next
                TextBox1.Text = Fact

            ElseIf Num_2 = 0 Then

                TextBox1.Text = "E"
            Else textbox1.Text = Num_1 / Num_2
            End If
            Operation_selector = False
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Num_1 = TextBox1.Text
        TextBox1.Text = "0"
        Operation_selector = True
        Operation = 8 ' %
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click, Button27.Click
        Num_1 = TextBox1.Text
        Operation_selector = True
        Operation = 9 'sqrt
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click, Button28.Click
        Num_1 = TextBox1.Text
        Operation_selector = True
        Operation = 5 'x^2
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Num_1 = TextBox1.Text
        Operation_selector = True
        Operation = 10 '!
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Num_1 = TextBox1.Text
        TextBox1.Text = "0"
        Operation_selector = True
        Operation = 4 '/
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        Num_1 = TextBox1.Text
        Operation_selector = True
        Operation = 7 'delete
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Num_1 = TextBox1.Text
        TextBox1.Text = "0"
        Operation_selector = True
        Operation = 1 '+

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Num_1 = TextBox1.Text
        TextBox1.Text = "0"
        Operation_selector = True
        Operation = 2 '_
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Num_1 = TextBox1.Text
        TextBox1.Text = "0"
        Operation_selector = True
        Operation = 3 '*
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click, Button25.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        Else
            TextBox1.Text = "0"
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (TextBox1.Text.Contains("-")) Then
            TextBox1.Text = "0"
            TextBox1.Text = -1 * TextBox1.Text
        Else
            TextBox1.Text = "-" + TextBox1.Text
        End If
    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Invalidated
        Label2.Text = Now
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub
End Class

