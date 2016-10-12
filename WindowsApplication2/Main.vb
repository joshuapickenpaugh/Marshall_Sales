Option Strict On

Public Class frmMain

    Dim comcalc As New CommissionCalculator()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Decimal.TryParse(txtSales.Text, comcalc.Sales)

        If chkOver10.Checked Then
            comcalc.OverTenYears = True
        Else
            comcalc.OverTenYears = False
        End If

        If chkTraveling.Checked Then
            comcalc.Traveling = True
        Else
            comcalc.Traveling = False
        End If

        lblTtlCommission.Text = 

    End Sub
End Class
