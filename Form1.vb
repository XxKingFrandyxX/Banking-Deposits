Public Class LBLtwo
    Dim account(10) As Decimal
    Dim CurrentTransactions As Integer
    Dim Balance As Decimal = 0
    Private Sub BTNadd_Click(sender As Object, e As EventArgs) Handles BTNadd.Click
        Dim userinput As Decimal = TXTone.Text

        If CurrentTransactions <= 10 Then
            TXTthree.Text = Balance + userinput
        End If
    End Sub
End Class
