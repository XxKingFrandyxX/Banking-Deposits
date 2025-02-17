''' <summary>
''' Author: King Frandy
''' Date: 17/02/25
''' Title: Banking Deposits
''' </summary>
Public Class Form1
    'Global Variables
    Dim account(10) As Decimal
    Dim CurrentTransactions As Integer = 0
    Dim Balance As Decimal = 0
    Private Sub BTNadd_Click(sender As Object, e As EventArgs) Handles BTNadd.Click
        'Variable
        Dim userinput As Decimal = TXTone.Text

        'IF statement that checks that CurrentTransaction is under 10
        If CurrentTransactions <= 10 Then
            'Accepts users input and adds to the total Balance
            Balance = Balance + userinput
            CurrentTransactions = CurrentTransactions + 1
        ElseIf CurrentTransactions > 10 Then
            'If over 10 display message
            TXTone.Text = "Have exceeded the amout of transactions"
        End If

        'display balance
        TXTthree.Text = Balance
    End Sub

    Private Sub BTNtake_Click(sender As Object, e As EventArgs) Handles BTNtake.Click
        'Varible 
        Dim userinput As Decimal = TXTtwo.Text

        'IF statement that checks that CurrentTransaction is under 10
        If CurrentTransactions <= 10 Then
            'Accepts users input and minuses to the total Balance
            Balance = Balance - userinput
            CurrentTransactions = CurrentTransactions + 1
        ElseIf CurrentTransactions > 10 Then
            'If over 10 display message
            TXTtwo.Text = "Have exceeded the amout of transactions"
        End If

        ' A IF statement that checks if theres any money to withdraw
        If Balance < 0 Then
            'IF not enough money display message
            TXTtwo.Text = "Not Enough Money"
            Balance = 0
        End If

        'display balance
        TXTthree.Text = Balance
    End Sub

    Private Sub BTNexit_Click(sender As Object, e As EventArgs) Handles BTNexit.Click
        'Ends application
        End
    End Sub
End Class
