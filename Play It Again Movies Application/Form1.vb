' Name:         Play It Again Application
' Purpose:      Calculates the total number
'               of discs sold and the total
'               sales amount
' Programmer:   Amel Sejranic on 15.11.2015

Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDvds.Text = String.Empty
        txtBluRays.Text = String.Empty
        txtTotalDiscs.Text = String.Empty
        txtTotalSales.Text = String.Empty
        ' send the focus to the DVDs box
        txtDvds.Focus()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print the sales receipt

        Me.Width = Me.Width - 165
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Me.Width = Me.Width + 165

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of discs sold and total sales

        txtTotalDiscs.Text = Val(txtDvds.Text) + Val(txtBluRays.Text)
        txtTotalSales.Text = Val(txtTotalDiscs.Text) * 7
        txtTotalSales.Text = Format(txtTotalSales.Text, "Currency")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
