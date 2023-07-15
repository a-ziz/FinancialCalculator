<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepreciation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFinalValue = New System.Windows.Forms.TextBox()
        Me.txtInitialCost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstDepreciation = New System.Windows.Forms.ListBox()
        Me.cboLife = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFinalValue
        '
        Me.txtFinalValue.Location = New System.Drawing.Point(132, 35)
        Me.txtFinalValue.Name = "txtFinalValue"
        Me.txtFinalValue.Size = New System.Drawing.Size(100, 20)
        Me.txtFinalValue.TabIndex = 12
        Me.txtFinalValue.Tag = "Final Value"
        '
        'txtInitialCost
        '
        Me.txtInitialCost.Location = New System.Drawing.Point(132, 11)
        Me.txtInitialCost.Name = "txtInitialCost"
        Me.txtInitialCost.Size = New System.Drawing.Size(100, 20)
        Me.txtInitialCost.TabIndex = 8
        Me.txtInitialCost.Tag = "Initial Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "SYD Depreciation:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstDepreciation
        '
        Me.lstDepreciation.Location = New System.Drawing.Point(12, 107)
        Me.lstDepreciation.Name = "lstDepreciation"
        Me.lstDepreciation.Size = New System.Drawing.Size(220, 69)
        Me.lstDepreciation.TabIndex = 17
        Me.lstDepreciation.TabStop = False
        '
        'cboLife
        '
        Me.cboLife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLife.DropDownWidth = 160
        Me.cboLife.Location = New System.Drawing.Point(132, 59)
        Me.cboLife.Name = "cboLife"
        Me.cboLife.Size = New System.Drawing.Size(100, 21)
        Me.cboLife.TabIndex = 14
        Me.cboLife.Tag = "Life of Asset"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Life of Asset in Years:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Final Value of Asset:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Initial Cost of Asset:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.CausesValidation = False
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(157, 191)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "C&lose"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(76, 191)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "&Calculate"
        '
        'frmDepreciation
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(250, 226)
        Me.Controls.Add(Me.txtFinalValue)
        Me.Controls.Add(Me.txtInitialCost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstDepreciation)
        Me.Controls.Add(Me.cboLife)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmDepreciation"
        Me.Text = "SYD Depreciation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtFinalValue As System.Windows.Forms.TextBox
    Private WithEvents txtInitialCost As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents lstDepreciation As System.Windows.Forms.ListBox
    Private WithEvents cboLife As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnCalculate As System.Windows.Forms.Button
End Class
