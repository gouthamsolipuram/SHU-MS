Public Class Form1

    Private Sub btnCalculateGrossPay_Click(sender As Object, e As EventArgs) Handles btnCalculateGrossPay.Click
        Dim nethours As Integer
        Dim netpay As Integer
        Dim grosspay As Integer
        nethours = txtHoursWorked.Text
        netpay = txtPayRate.Text
        grosspay = nethours * netpay
        lbldisplay.Text = grosspay

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class
