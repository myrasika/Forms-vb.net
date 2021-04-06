Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number_in_textbox As Integer

        number_in_textbox = Val(TextBox1.Text)

        If number_in_textbox > 10 And number_in_textbox < 20 Then

            MessageBox.Show("Number entered was: " & number_in_textbox)

        Else

            MessageBox.Show("Number entered was not between 10 and 20")
            TextBox1.Text = ""

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyVariable As String

        MyVariable = ComboBox1.Text

        Select Case MyVariable

            Case "Data Science"

                MessageBox.Show("Combines domain expertise, programming skills, and knowledge of mathematics and statistics to extract meaningful insights from data " & MyVariable & ", .")

            Case "Data Mining"

                MessageBox.Show("Process used by companies to turn raw data into useful information. By using software to look for patterns in large batches of data " & MyVariable & "...")

            Case "Data Engineering"

                MessageBox.Show("Finding trends in data sets and developing algorithms to help make raw data more useful to the enterprise" & MyVariable & "!")

            Case "Data Manipulation"
                MessageBox.Show(MyVariable & "? Process of adjusting data to make it organised and easier to read!")


        End Select


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
