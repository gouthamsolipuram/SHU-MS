Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtHoursWorked.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPayRate.TextChanged

    End Sub

    Private Sub btnCalculateGrossPay_Click(sender As Object, e As EventArgs) Handles btnCalculateGrossPay.Click
        Dim nethours As Integer
        Dim netpay As Integer
        Dim grosspay As Integer
        nethours = txtHoursWorked.Text
        netpay = txtPayRate.Text
        grosspay = nethours * netpay
        lbldisplay.Text = grosspay

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles lbldisplay.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
