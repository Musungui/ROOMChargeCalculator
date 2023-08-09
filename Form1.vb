Public Class Form1
    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Create a Date variable
        Dim TodayDate As Date = DateTime.Now

        lblDateToday.Text = TodayDate.ToString("D")

        'create a time variable 
        Dim CurrentTime As DateTime = DateTime.Now

        lblTimeToday.Text = CurrentTime.ToString("T")



    End Sub
    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles lblAddCharges.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decRoomCharges As Decimal, decAddCharges As Decimal, decSubTotal As Decimal
        Dim decTax As Decimal, decTotal As Decimal, decNights As Decimal, decNightlyCharge As Decimal
        Const decTAX_RATE As Double = 0.08

        decNights = txtNights.Text
        decNightlyCharge = txtNightlyCharge.Text

        decRoomCharges = (decNights * decNightlyCharge)
        lblRoomCharges.Text = decRoomCharges.ToString("C")

        Dim dbRoomService As Double, dbTelephone As Double, dbMisc As Double
        dbRoomService = CDec(txtRoomService.Text)
        dbTelephone = CDec(txtTelephone.Text)
        dbMisc = CDec(txtMisc.Text)

        decAddCharges = dbRoomService + dbTelephone + dbMisc
        lblAddCharges.Text = decAddCharges.ToString("C")

        decSubTotal = decRoomCharges + decAddCharges
        lblSubtotal.Text = decSubTotal.ToString("C")

        decTax = decSubTotal * decTAX_RATE
        lblTax.Text = decTax.ToString("C")

        decTotal = decSubTotal + decTax
        lblTotal.Text = decTotal.ToString("C")



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Clear()
        txtNightlyCharge.Clear()
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()


        lblRoomCharges.Text = " "
        lblAddCharges.Text = " "
        lblSubtotal.Text = " "
        lblTax.Text = " "
        lblTotal.Text = " "

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblDateToday_Click(sender As Object, e As EventArgs) Handles lblDateToday.Click


    End Sub

    Private Sub lblTimeToday_Click(sender As Object, e As EventArgs) Handles lblTimeToday.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

End Class
