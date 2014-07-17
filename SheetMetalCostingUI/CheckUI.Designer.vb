<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCheckUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCheckUI))
        Me.lblMaterialCheck = New System.Windows.Forms.Label()
        Me.txtMaterialStatus = New System.Windows.Forms.TextBox()
        Me.txtFlatExist = New System.Windows.Forms.TextBox()
        Me.lblFlatExist = New System.Windows.Forms.Label()
        Me.txtFlatValid = New System.Windows.Forms.TextBox()
        Me.lblFlatValid = New System.Windows.Forms.Label()
        Me.txtPaintCheck = New System.Windows.Forms.TextBox()
        Me.lblPaintCheck = New System.Windows.Forms.Label()
        Me.txtWeldCheck = New System.Windows.Forms.TextBox()
        Me.lblWeldCheck = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMaterialCheck
        '
        Me.lblMaterialCheck.AutoSize = True
        Me.lblMaterialCheck.Location = New System.Drawing.Point(12, 23)
        Me.lblMaterialCheck.Name = "lblMaterialCheck"
        Me.lblMaterialCheck.Size = New System.Drawing.Size(87, 13)
        Me.lblMaterialCheck.TabIndex = 0
        Me.lblMaterialCheck.Text = "Materical Check:"
        '
        'txtMaterialStatus
        '
        Me.txtMaterialStatus.BackColor = System.Drawing.Color.White
        Me.txtMaterialStatus.ForeColor = System.Drawing.SystemColors.Info
        Me.txtMaterialStatus.Location = New System.Drawing.Point(129, 20)
        Me.txtMaterialStatus.Name = "txtMaterialStatus"
        Me.txtMaterialStatus.Size = New System.Drawing.Size(142, 20)
        Me.txtMaterialStatus.TabIndex = 1
        Me.txtMaterialStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFlatExist
        '
        Me.txtFlatExist.BackColor = System.Drawing.Color.White
        Me.txtFlatExist.ForeColor = System.Drawing.SystemColors.Info
        Me.txtFlatExist.Location = New System.Drawing.Point(130, 46)
        Me.txtFlatExist.Name = "txtFlatExist"
        Me.txtFlatExist.Size = New System.Drawing.Size(142, 20)
        Me.txtFlatExist.TabIndex = 3
        Me.txtFlatExist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFlatExist
        '
        Me.lblFlatExist.AutoSize = True
        Me.lblFlatExist.Location = New System.Drawing.Point(12, 49)
        Me.lblFlatExist.Name = "lblFlatExist"
        Me.lblFlatExist.Size = New System.Drawing.Size(86, 13)
        Me.lblFlatExist.TabIndex = 2
        Me.lblFlatExist.Text = "Flat Exist Check:"
        '
        'txtFlatValid
        '
        Me.txtFlatValid.BackColor = System.Drawing.Color.White
        Me.txtFlatValid.ForeColor = System.Drawing.SystemColors.Info
        Me.txtFlatValid.Location = New System.Drawing.Point(129, 72)
        Me.txtFlatValid.Name = "txtFlatValid"
        Me.txtFlatValid.Size = New System.Drawing.Size(142, 20)
        Me.txtFlatValid.TabIndex = 5
        Me.txtFlatValid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFlatValid
        '
        Me.lblFlatValid.AutoSize = True
        Me.lblFlatValid.Location = New System.Drawing.Point(11, 75)
        Me.lblFlatValid.Name = "lblFlatValid"
        Me.lblFlatValid.Size = New System.Drawing.Size(87, 13)
        Me.lblFlatValid.TabIndex = 4
        Me.lblFlatValid.Text = "Flat Valid Check:"
        '
        'txtPaintCheck
        '
        Me.txtPaintCheck.BackColor = System.Drawing.Color.White
        Me.txtPaintCheck.ForeColor = System.Drawing.SystemColors.Info
        Me.txtPaintCheck.Location = New System.Drawing.Point(129, 98)
        Me.txtPaintCheck.Name = "txtPaintCheck"
        Me.txtPaintCheck.Size = New System.Drawing.Size(142, 20)
        Me.txtPaintCheck.TabIndex = 7
        Me.txtPaintCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPaintCheck
        '
        Me.lblPaintCheck.AutoSize = True
        Me.lblPaintCheck.Location = New System.Drawing.Point(11, 101)
        Me.lblPaintCheck.Name = "lblPaintCheck"
        Me.lblPaintCheck.Size = New System.Drawing.Size(68, 13)
        Me.lblPaintCheck.TabIndex = 6
        Me.lblPaintCheck.Text = "Paint Check:"
        '
        'txtWeldCheck
        '
        Me.txtWeldCheck.BackColor = System.Drawing.Color.White
        Me.txtWeldCheck.ForeColor = System.Drawing.SystemColors.Info
        Me.txtWeldCheck.Location = New System.Drawing.Point(129, 124)
        Me.txtWeldCheck.Name = "txtWeldCheck"
        Me.txtWeldCheck.Size = New System.Drawing.Size(142, 20)
        Me.txtWeldCheck.TabIndex = 9
        Me.txtWeldCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWeldCheck
        '
        Me.lblWeldCheck.AutoSize = True
        Me.lblWeldCheck.Location = New System.Drawing.Point(11, 127)
        Me.lblWeldCheck.Name = "lblWeldCheck"
        Me.lblWeldCheck.Size = New System.Drawing.Size(69, 13)
        Me.lblWeldCheck.TabIndex = 8
        Me.lblWeldCheck.Text = "Weld Check:"
        '
        'FrmCheckUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.txtWeldCheck)
        Me.Controls.Add(Me.lblWeldCheck)
        Me.Controls.Add(Me.txtPaintCheck)
        Me.Controls.Add(Me.lblPaintCheck)
        Me.Controls.Add(Me.txtFlatValid)
        Me.Controls.Add(Me.lblFlatValid)
        Me.Controls.Add(Me.txtFlatExist)
        Me.Controls.Add(Me.lblFlatExist)
        Me.Controls.Add(Me.txtMaterialStatus)
        Me.Controls.Add(Me.lblMaterialCheck)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCheckUI"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Model Validation"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaterialCheck As System.Windows.Forms.Label
    Friend WithEvents txtMaterialStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtFlatExist As System.Windows.Forms.TextBox
    Friend WithEvents lblFlatExist As System.Windows.Forms.Label
    Friend WithEvents txtFlatValid As System.Windows.Forms.TextBox
    Friend WithEvents lblFlatValid As System.Windows.Forms.Label
    Friend WithEvents txtPaintCheck As System.Windows.Forms.TextBox
    Friend WithEvents lblPaintCheck As System.Windows.Forms.Label
    Friend WithEvents txtWeldCheck As System.Windows.Forms.TextBox
    Friend WithEvents lblWeldCheck As System.Windows.Forms.Label
End Class
