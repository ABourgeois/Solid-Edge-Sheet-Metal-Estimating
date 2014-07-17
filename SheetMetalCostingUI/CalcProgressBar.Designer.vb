<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalcProgressBar
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
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(10, 37)
        Me.ProgressBar.Maximum = 60
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(262, 33)
        Me.ProgressBar.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(12, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(67, 20)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(85, 9)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 20)
        Me.lblDisplay.TabIndex = 2
        '
        'FrmCalcProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 82)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.ProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCalcProgressBar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
End Class
