Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height As Double
        Dim base As Double
        Dim area As Double
        height = Val(TextBox1.Text)
        base = Val(TextBox2.Text)
        area = 0.5 * height * base
        TextBox3.Text = area

    End Sub

End Class