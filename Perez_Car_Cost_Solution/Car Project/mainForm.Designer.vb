<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTotalMiles = New System.Windows.Forms.TextBox()
        Me.txtCar2Cost = New System.Windows.Forms.TextBox()
        Me.txtCar1Cost = New System.Windows.Forms.TextBox()
        Me.txtCar2mpg = New System.Windows.Forms.TextBox()
        Me.txtCar1mpg = New System.Windows.Forms.TextBox()
        Me.txtTotalCost1 = New System.Windows.Forms.TextBox()
        Me.txtTotalCost2 = New System.Windows.Forms.TextBox()
        Me.lblCar1 = New System.Windows.Forms.Label()
        Me.lblCar2 = New System.Windows.Forms.Label()
        Me.lblCostOfGas = New System.Windows.Forms.Label()
        Me.lblTotalSavings = New System.Windows.Forms.Label()
        Me.lblMostEfficient = New System.Windows.Forms.Label()
        Me.lblTotalMiles = New System.Windows.Forms.Label()
        Me.gbxUserInfo = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxCarComparison = New System.Windows.Forms.GroupBox()
        Me.txtTotalSavings = New System.Windows.Forms.TextBox()
        Me.txtBestOption = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxUserInfo.SuspendLayout()
        Me.gbxCarComparison.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTotalMiles
        '
        Me.txtTotalMiles.Location = New System.Drawing.Point(125, 68)
        Me.txtTotalMiles.Name = "txtTotalMiles"
        Me.txtTotalMiles.Size = New System.Drawing.Size(129, 23)
        Me.txtTotalMiles.TabIndex = 1
        '
        'txtCar2Cost
        '
        Me.txtCar2Cost.Location = New System.Drawing.Point(125, 290)
        Me.txtCar2Cost.Name = "txtCar2Cost"
        Me.txtCar2Cost.Size = New System.Drawing.Size(129, 23)
        Me.txtCar2Cost.TabIndex = 5
        '
        'txtCar1Cost
        '
        Me.txtCar1Cost.Location = New System.Drawing.Point(125, 153)
        Me.txtCar1Cost.Name = "txtCar1Cost"
        Me.txtCar1Cost.Size = New System.Drawing.Size(129, 23)
        Me.txtCar1Cost.TabIndex = 3
        '
        'txtCar2mpg
        '
        Me.txtCar2mpg.Location = New System.Drawing.Point(125, 261)
        Me.txtCar2mpg.Name = "txtCar2mpg"
        Me.txtCar2mpg.Size = New System.Drawing.Size(129, 23)
        Me.txtCar2mpg.TabIndex = 4
        '
        'txtCar1mpg
        '
        Me.txtCar1mpg.Location = New System.Drawing.Point(125, 124)
        Me.txtCar1mpg.Name = "txtCar1mpg"
        Me.txtCar1mpg.Size = New System.Drawing.Size(129, 23)
        Me.txtCar1mpg.TabIndex = 2
        Me.txtCar1mpg.Text = " "
        '
        'txtTotalCost1
        '
        Me.txtTotalCost1.Location = New System.Drawing.Point(107, 86)
        Me.txtTotalCost1.Name = "txtTotalCost1"
        Me.txtTotalCost1.ReadOnly = True
        Me.txtTotalCost1.Size = New System.Drawing.Size(89, 23)
        Me.txtTotalCost1.TabIndex = 5
        Me.txtTotalCost1.TabStop = False
        '
        'txtTotalCost2
        '
        Me.txtTotalCost2.Location = New System.Drawing.Point(213, 86)
        Me.txtTotalCost2.Name = "txtTotalCost2"
        Me.txtTotalCost2.ReadOnly = True
        Me.txtTotalCost2.Size = New System.Drawing.Size(89, 23)
        Me.txtTotalCost2.TabIndex = 6
        Me.txtTotalCost2.TabStop = False
        '
        'lblCar1
        '
        Me.lblCar1.AutoSize = True
        Me.lblCar1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCar1.Location = New System.Drawing.Point(129, 57)
        Me.lblCar1.Name = "lblCar1"
        Me.lblCar1.Size = New System.Drawing.Size(48, 21)
        Me.lblCar1.TabIndex = 7
        Me.lblCar1.Text = "Car 1"
        '
        'lblCar2
        '
        Me.lblCar2.AutoSize = True
        Me.lblCar2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCar2.Location = New System.Drawing.Point(234, 57)
        Me.lblCar2.Name = "lblCar2"
        Me.lblCar2.Size = New System.Drawing.Size(48, 21)
        Me.lblCar2.TabIndex = 8
        Me.lblCar2.Text = "Car 2"
        '
        'lblCostOfGas
        '
        Me.lblCostOfGas.AutoSize = True
        Me.lblCostOfGas.Location = New System.Drawing.Point(19, 94)
        Me.lblCostOfGas.Name = "lblCostOfGas"
        Me.lblCostOfGas.Size = New System.Drawing.Size(70, 15)
        Me.lblCostOfGas.TabIndex = 9
        Me.lblCostOfGas.Text = "Cost of Gas:"
        '
        'lblTotalSavings
        '
        Me.lblTotalSavings.AutoSize = True
        Me.lblTotalSavings.Location = New System.Drawing.Point(79, 184)
        Me.lblTotalSavings.Name = "lblTotalSavings"
        Me.lblTotalSavings.Size = New System.Drawing.Size(81, 15)
        Me.lblTotalSavings.TabIndex = 10
        Me.lblTotalSavings.Text = "Total Savings: "
        '
        'lblMostEfficient
        '
        Me.lblMostEfficient.AutoSize = True
        Me.lblMostEfficient.Location = New System.Drawing.Point(56, 140)
        Me.lblMostEfficient.Name = "lblMostEfficient"
        Me.lblMostEfficient.Size = New System.Drawing.Size(104, 15)
        Me.lblMostEfficient.TabIndex = 11
        Me.lblMostEfficient.Text = "Most Efficient Car:"
        '
        'lblTotalMiles
        '
        Me.lblTotalMiles.AutoSize = True
        Me.lblTotalMiles.Location = New System.Drawing.Point(23, 76)
        Me.lblTotalMiles.Name = "lblTotalMiles"
        Me.lblTotalMiles.Size = New System.Drawing.Size(63, 15)
        Me.lblTotalMiles.TabIndex = 12
        Me.lblTotalMiles.Text = "Total Miles"
        '
        'gbxUserInfo
        '
        Me.gbxUserInfo.Controls.Add(Me.Label4)
        Me.gbxUserInfo.Controls.Add(Me.Label3)
        Me.gbxUserInfo.Controls.Add(Me.Label2)
        Me.gbxUserInfo.Controls.Add(Me.Label1)
        Me.gbxUserInfo.Controls.Add(Me.lblTotalMiles)
        Me.gbxUserInfo.Controls.Add(Me.txtCar1mpg)
        Me.gbxUserInfo.Controls.Add(Me.txtCar2mpg)
        Me.gbxUserInfo.Controls.Add(Me.txtCar1Cost)
        Me.gbxUserInfo.Controls.Add(Me.txtCar2Cost)
        Me.gbxUserInfo.Controls.Add(Me.txtTotalMiles)
        Me.gbxUserInfo.Location = New System.Drawing.Point(8, 12)
        Me.gbxUserInfo.Name = "gbxUserInfo"
        Me.gbxUserInfo.Size = New System.Drawing.Size(299, 405)
        Me.gbxUserInfo.TabIndex = 13
        Me.gbxUserInfo.TabStop = False
        Me.gbxUserInfo.Text = "Enter Your trip information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Car 1's MPG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Car 2's MPG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Car 1's Cost / G"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Car 2's Cost / G"
        '
        'gbxCarComparison
        '
        Me.gbxCarComparison.Controls.Add(Me.txtTotalSavings)
        Me.gbxCarComparison.Controls.Add(Me.txtBestOption)
        Me.gbxCarComparison.Controls.Add(Me.lblMostEfficient)
        Me.gbxCarComparison.Controls.Add(Me.lblTotalSavings)
        Me.gbxCarComparison.Controls.Add(Me.lblCostOfGas)
        Me.gbxCarComparison.Controls.Add(Me.lblCar2)
        Me.gbxCarComparison.Controls.Add(Me.lblCar1)
        Me.gbxCarComparison.Controls.Add(Me.txtTotalCost2)
        Me.gbxCarComparison.Controls.Add(Me.txtTotalCost1)
        Me.gbxCarComparison.Location = New System.Drawing.Point(323, 12)
        Me.gbxCarComparison.Name = "gbxCarComparison"
        Me.gbxCarComparison.Size = New System.Drawing.Size(385, 247)
        Me.gbxCarComparison.TabIndex = 14
        Me.gbxCarComparison.TabStop = False
        Me.gbxCarComparison.Text = "Car Comparison"
        '
        'txtTotalSavings
        '
        Me.txtTotalSavings.Location = New System.Drawing.Point(166, 181)
        Me.txtTotalSavings.Name = "txtTotalSavings"
        Me.txtTotalSavings.ReadOnly = True
        Me.txtTotalSavings.Size = New System.Drawing.Size(89, 23)
        Me.txtTotalSavings.TabIndex = 13
        Me.txtTotalSavings.TabStop = False
        '
        'txtBestOption
        '
        Me.txtBestOption.Location = New System.Drawing.Point(166, 132)
        Me.txtBestOption.Name = "txtBestOption"
        Me.txtBestOption.ReadOnly = True
        Me.txtBestOption.Size = New System.Drawing.Size(89, 23)
        Me.txtBestOption.TabIndex = 12
        Me.txtBestOption.TabStop = False
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(370, 317)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(113, 59)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(523, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 59)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.gbxCarComparison)
        Me.Controls.Add(Me.gbxUserInfo)
        Me.Name = "frmMain"
        Me.Text = "Car Project"
        Me.gbxUserInfo.ResumeLayout(False)
        Me.gbxUserInfo.PerformLayout()
        Me.gbxCarComparison.ResumeLayout(False)
        Me.gbxCarComparison.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTotalMiles As TextBox
    Friend WithEvents txtCar2Cost As TextBox
    Friend WithEvents txtCar1Cost As TextBox
    Friend WithEvents txtCar2mpg As TextBox
    Friend WithEvents txtCar1mpg As TextBox
    Friend WithEvents txtTotalCost1 As TextBox
    Friend WithEvents txtTotalCost2 As TextBox
    Friend WithEvents lblCar1 As Label
    Friend WithEvents lblCar2 As Label
    Friend WithEvents lblCostOfGas As Label
    Friend WithEvents lblTotalSavings As Label
    Friend WithEvents lblMostEfficient As Label
    Friend WithEvents lblTotalMiles As Label
    Friend WithEvents gbxUserInfo As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbxCarComparison As GroupBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtTotalSavings As TextBox
    Friend WithEvents txtBestOption As TextBox
End Class
