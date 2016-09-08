Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declares the variables:
        Dim decDollars As Decimal
        Dim decTotal As Decimal

        'Assigns the variable to the text box:
        Decimal.TryParse(txtDollars.Text, decDollars)

        'Decision structure:
        Select Case True
            Case rdoCanadian.Checked
                decTotal = decDollars * 0.9776
                lblTotal.Text = decTotal.ToString("N3") & " Canadian dollars."
            Case rdoEuro.Checked
                decTotal = decDollars * 0.7722
                lblTotal.Text = decTotal.ToString("N3") & " Euros."
            Case rdoIndian.Checked
                decTotal = decDollars * 54.26
                lblTotal.Text = decTotal.ToString("N3") & " Indian rand."
            Case rdoJapan.Checked
                decTotal = decDollars * 78.24
                lblTotal.Text = decTotal.ToString("N3") & " Japanese yen."
            Case rdoMexico.Checked
                decTotal = decDollars * 12.9002
                lblTotal.Text = decTotal.ToString("N3") & " Mexican pesos."
            Case rdoSouthAfrica.Checked
                decTotal = decDollars * 8.327
                lblTotal.Text = decTotal.ToString("N3") & " South African rand."
            Case rdoBritish.Checked
                decTotal = decDollars * 0.6172
                lblTotal.Text = decTotal.ToString("N3") & " British pounds."
        End Select

    End Sub
End Class
