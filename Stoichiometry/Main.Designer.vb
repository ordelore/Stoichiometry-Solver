﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.grpAdd = New System.Windows.Forms.GroupBox()
        Me.btnEquOK = New System.Windows.Forms.Button()
        Me.txtEquation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpConversion = New System.Windows.Forms.GroupBox()
        Me.btnConvertOK = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAmountA = New System.Windows.Forms.TextBox()
        Me.cmbUnitsB = New System.Windows.Forms.ComboBox()
        Me.cmbUnitsA = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMolB = New System.Windows.Forms.ComboBox()
        Me.cmbMolA = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpAdd.SuspendLayout()
        Me.grpConversion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAdd
        '
        Me.grpAdd.Controls.Add(Me.btnEquOK)
        Me.grpAdd.Controls.Add(Me.txtEquation)
        Me.grpAdd.Controls.Add(Me.Label2)
        Me.grpAdd.Controls.Add(Me.Label1)
        Me.grpAdd.Location = New System.Drawing.Point(13, 13)
        Me.grpAdd.Name = "grpAdd"
        Me.grpAdd.Size = New System.Drawing.Size(351, 120)
        Me.grpAdd.TabIndex = 0
        Me.grpAdd.TabStop = False
        Me.grpAdd.Text = "Equation"
        '
        'btnEquOK
        '
        Me.btnEquOK.Location = New System.Drawing.Point(138, 88)
        Me.btnEquOK.Name = "btnEquOK"
        Me.btnEquOK.Size = New System.Drawing.Size(75, 23)
        Me.btnEquOK.TabIndex = 3
        Me.btnEquOK.Text = "OK"
        Me.btnEquOK.UseVisualStyleBackColor = True
        '
        'txtEquation
        '
        Me.txtEquation.Location = New System.Drawing.Point(54, 60)
        Me.txtEquation.Name = "txtEquation"
        Me.txtEquation.Size = New System.Drawing.Size(242, 22)
        Me.txtEquation.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "[2] Means a subscript of 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Example: 2H[2] + O[2] = 2H[2]O"
        '
        'grpConversion
        '
        Me.grpConversion.Controls.Add(Me.btnConvertOK)
        Me.grpConversion.Controls.Add(Me.Label5)
        Me.grpConversion.Controls.Add(Me.txtAmountA)
        Me.grpConversion.Controls.Add(Me.cmbUnitsB)
        Me.grpConversion.Controls.Add(Me.cmbUnitsA)
        Me.grpConversion.Controls.Add(Me.Label4)
        Me.grpConversion.Controls.Add(Me.cmbMolB)
        Me.grpConversion.Controls.Add(Me.cmbMolA)
        Me.grpConversion.Controls.Add(Me.Label3)
        Me.grpConversion.Location = New System.Drawing.Point(13, 140)
        Me.grpConversion.Name = "grpConversion"
        Me.grpConversion.Size = New System.Drawing.Size(357, 139)
        Me.grpConversion.TabIndex = 1
        Me.grpConversion.TabStop = False
        Me.grpConversion.Text = "Molecules"
        Me.grpConversion.Visible = False
        '
        'btnConvertOK
        '
        Me.btnConvertOK.Location = New System.Drawing.Point(141, 109)
        Me.btnConvertOK.Name = "btnConvertOK"
        Me.btnConvertOK.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertOK.TabIndex = 8
        Me.btnConvertOK.Text = "OK"
        Me.btnConvertOK.UseVisualStyleBackColor = True
        Me.btnConvertOK.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "How Much?"
        '
        'txtAmountA
        '
        Me.txtAmountA.Location = New System.Drawing.Point(9, 84)
        Me.txtAmountA.Name = "txtAmountA"
        Me.txtAmountA.Size = New System.Drawing.Size(121, 22)
        Me.txtAmountA.TabIndex = 6
        '
        'cmbUnitsB
        '
        Me.cmbUnitsB.FormattingEnabled = True
        Me.cmbUnitsB.Items.AddRange(New Object() {"Grams", "Moles", "Liters"})
        Me.cmbUnitsB.Location = New System.Drawing.Point(230, 53)
        Me.cmbUnitsB.Name = "cmbUnitsB"
        Me.cmbUnitsB.Size = New System.Drawing.Size(121, 24)
        Me.cmbUnitsB.TabIndex = 5
        '
        'cmbUnitsA
        '
        Me.cmbUnitsA.FormattingEnabled = True
        Me.cmbUnitsA.Items.AddRange(New Object() {"Grams", "Moles", "Liters"})
        Me.cmbUnitsA.Location = New System.Drawing.Point(9, 53)
        Me.cmbUnitsA.Name = "cmbUnitsA"
        Me.cmbUnitsA.Size = New System.Drawing.Size(121, 24)
        Me.cmbUnitsA.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Units"
        '
        'cmbMolB
        '
        Me.cmbMolB.FormattingEnabled = True
        Me.cmbMolB.Location = New System.Drawing.Point(230, 22)
        Me.cmbMolB.Name = "cmbMolB"
        Me.cmbMolB.Size = New System.Drawing.Size(121, 24)
        Me.cmbMolB.TabIndex = 2
        '
        'cmbMolA
        '
        Me.cmbMolA.FormattingEnabled = True
        Me.cmbMolA.Location = New System.Drawing.Point(9, 22)
        Me.cmbMolA.Name = "cmbMolA"
        Me.cmbMolA.Size = New System.Drawing.Size(121, 24)
        Me.cmbMolA.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Convert to"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(33, 286)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(317, 25)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.Text = "(MolA) + (units) -> (MolB) + (Units)"
        Me.lblOutput.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(8, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(378, 29)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Troubleshooting And Bug Reports"
        '
        'Main
        '
        Me.AcceptButton = Me.btnEquOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 355)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.grpConversion)
        Me.Controls.Add(Me.grpAdd)
        Me.Name = "Main"
        Me.Text = "Stoichiometry Solver"
        Me.grpAdd.ResumeLayout(False)
        Me.grpAdd.PerformLayout()
        Me.grpConversion.ResumeLayout(False)
        Me.grpConversion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAdd As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEquation As System.Windows.Forms.TextBox
    Friend WithEvents btnEquOK As System.Windows.Forms.Button
    Friend WithEvents grpConversion As System.Windows.Forms.GroupBox
    Friend WithEvents cmbUnitsB As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUnitsA As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbMolB As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMolA As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAmountA As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnConvertOK As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
