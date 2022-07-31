Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Now.ToString("D")
        lblTime.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim roomCharge As Decimal
        Dim additionalCharge As Decimal
        Dim subTotal As Decimal
        Dim tax As Decimal
        Dim total As Decimal
        Const TAX_RATE = 0.08D
        Try
            roomCharge = CDbl(txtNight.Text) * CDbl(txtNoNight.Text)
            lblRoomcharge.Text = roomCharge.ToString("c")
            additionalCharge = CDbl(txtRoomservice.Text) + CDbl(txtTelephone.Text) + CDbl(txtMSC.Text)
            lblAdditionalCharge.Text = additionalCharge.ToString("c")
            subTotal = roomCharge + additionalCharge
            lblSubTotal.Text = subTotal.ToString("c")
            tax = subTotal * TAX_RATE
            lbltax.Text = tax.ToString("c")
            total = subTotal + tax
            lbltotalCharge.Text = total.ToString("c")
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNight.Clear()
        txtNoNight.Clear()
        txtRoomservice.Clear()
        txtTelephone.Clear()
        txtMSC.Clear()

        lblRoomcharge.Text = String.Empty
        lblAdditionalCharge.Text = String.Empty
        lblSubTotal.Text = String.Empty
        lbltotalCharge.Text = String.Empty
        lbltax.Text = String.Empty

        lblDate.Text = Now.ToString("D")
        lblTime.Text = Now.ToString("T")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
