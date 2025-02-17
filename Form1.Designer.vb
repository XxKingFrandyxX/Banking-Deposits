<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LBLone = New Label()
        Label2 = New Label()
        LBLthree = New Label()
        BTNadd = New Button()
        BTNtake = New Button()
        BTNexit = New Button()
        TXTthree = New TextBox()
        TXTtwo = New TextBox()
        TXTone = New TextBox()
        SuspendLayout()
        ' 
        ' LBLone
        ' 
        LBLone.AutoSize = True
        LBLone.Location = New Point(25, 52)
        LBLone.Name = "LBLone"
        LBLone.Size = New Size(189, 20)
        LBLone.TabIndex = 0
        LBLone.Text = "Deposit Amount:               $"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 20)
        Label2.TabIndex = 1
        Label2.Text = "Withdrawal amount:         $"
        ' 
        ' LBLthree
        ' 
        LBLthree.AutoSize = True
        LBLthree.Location = New Point(25, 471)
        LBLthree.Name = "LBLthree"
        LBLthree.Size = New Size(162, 20)
        LBLthree.TabIndex = 2
        LBLthree.Text = "Account Balance:          "
        ' 
        ' BTNadd
        ' 
        BTNadd.Location = New Point(125, 111)
        BTNadd.Margin = New Padding(3, 4, 3, 4)
        BTNadd.Name = "BTNadd"
        BTNadd.Size = New Size(337, 36)
        BTNadd.TabIndex = 3
        BTNadd.Text = "Add To Account"
        BTNadd.UseVisualStyleBackColor = True
        ' 
        ' BTNtake
        ' 
        BTNtake.Location = New Point(125, 384)
        BTNtake.Margin = New Padding(3, 4, 3, 4)
        BTNtake.Name = "BTNtake"
        BTNtake.Size = New Size(337, 36)
        BTNtake.TabIndex = 4
        BTNtake.Text = "Take From Account"
        BTNtake.UseVisualStyleBackColor = True
        ' 
        ' BTNexit
        ' 
        BTNexit.Location = New Point(478, 495)
        BTNexit.Margin = New Padding(3, 4, 3, 4)
        BTNexit.Name = "BTNexit"
        BTNexit.Size = New Size(127, 36)
        BTNexit.TabIndex = 5
        BTNexit.Text = "Exit"
        BTNexit.UseVisualStyleBackColor = True
        ' 
        ' TXTthree
        ' 
        TXTthree.Location = New Point(311, 471)
        TXTthree.Margin = New Padding(3, 4, 3, 4)
        TXTthree.Name = "TXTthree"
        TXTthree.Size = New Size(150, 27)
        TXTthree.TabIndex = 6
        ' 
        ' TXTtwo
        ' 
        TXTtwo.Location = New Point(201, 272)
        TXTtwo.Margin = New Padding(3, 4, 3, 4)
        TXTtwo.Name = "TXTtwo"
        TXTtwo.Size = New Size(150, 27)
        TXTtwo.TabIndex = 7
        ' 
        ' TXTone
        ' 
        TXTone.Location = New Point(201, 48)
        TXTone.Margin = New Padding(3, 4, 3, 4)
        TXTone.Name = "TXTone"
        TXTone.Size = New Size(150, 27)
        TXTone.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(617, 600)
        Controls.Add(TXTone)
        Controls.Add(TXTtwo)
        Controls.Add(TXTthree)
        Controls.Add(BTNexit)
        Controls.Add(BTNtake)
        Controls.Add(BTNadd)
        Controls.Add(LBLthree)
        Controls.Add(Label2)
        Controls.Add(LBLone)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Banking Deposits"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LBLone As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBLthree As Label
    Friend WithEvents BTNadd As Button
    Friend WithEvents BTNtake As Button
    Friend WithEvents BTNexit As Button
    Friend WithEvents TXTthree As TextBox
    Friend WithEvents TXTtwo As TextBox
    Friend WithEvents TXTone As TextBox

End Class
