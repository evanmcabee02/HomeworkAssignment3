Public Class frmPlatters
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer

        If IsNumeric(txtPoints.Text) Then
            intPoints = Convert.ToInt32(txtPoints.Text)
            strPoints = " after discount of " & intPoints.ToString() & " loyalty points."
            ' MsgBox(intPoints)

            If radCheese.Checked Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf radWrap.Checked Then
                decCost = 59.99D
                strOrder = "Wrap"
            ElseIf radVeggie.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf radSausage.Checked Then
                decCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf radFruit.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If

            If radPre.Checked Then
                strPay = " using Pre-Pay"
            ElseIf radPick.Checked Then
                strPay = " with Pay upon Pickup"
            End If

            intPoints = Convert.ToInt32(intPoints / 10I)
            'MsgBox(intPoints)

            decPoints = (intPoints * cdecDiscount) / 100
            MsgBox(decPoints)

            If decPoints > 1 Then
                decPoints = 1
            End If

            MsgBox(decPoints)

            decFinal = decCost * (1 - decPoints)
            MsgBox(decFinal)

            lblPayment.Text = "Your order " & strOrder & " platter costs " & decFinal.ToString("C") & strPay & strPoints
        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            Me.btnClear.PerformClick()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPoints.Text = ""
        radCheese.Checked = True
        radPre.Checked = True
        lblPayment.Text = ""

    End Sub

    Private Sub frmPlatters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnClear.PerformClick()
    End Sub
End Class
