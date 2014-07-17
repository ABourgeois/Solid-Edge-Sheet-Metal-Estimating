<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateWindow))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.txtFive = New System.Windows.Forms.TextBox()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.txtFour = New System.Windows.Forms.TextBox()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.txtThree = New System.Windows.Forms.TextBox()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(116, 152)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(197, 152)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'txtFive
        '
        Me.txtFive.Location = New System.Drawing.Point(128, 126)
        Me.txtFive.Name = "txtFive"
        Me.txtFive.Size = New System.Drawing.Size(144, 20)
        Me.txtFive.TabIndex = 20
        '
        'lblFive
        '
        Me.lblFive.AutoSize = True
        Me.lblFive.Location = New System.Drawing.Point(10, 129)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(96, 13)
        Me.lblFive.TabIndex = 19
        Me.lblFive.Text = "Forming Efficiency:"
        '
        'txtFour
        '
        Me.txtFour.Location = New System.Drawing.Point(128, 100)
        Me.txtFour.Name = "txtFour"
        Me.txtFour.Size = New System.Drawing.Size(144, 20)
        Me.txtFour.TabIndex = 18
        '
        'lblFour
        '
        Me.lblFour.AutoSize = True
        Me.lblFour.Location = New System.Drawing.Point(10, 103)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(76, 13)
        Me.lblFour.TabIndex = 17
        Me.lblFour.Text = "Cost Per Hour:"
        '
        'txtThree
        '
        Me.txtThree.Location = New System.Drawing.Point(128, 74)
        Me.txtThree.Name = "txtThree"
        Me.txtThree.Size = New System.Drawing.Size(144, 20)
        Me.txtThree.TabIndex = 16
        '
        'lblThree
        '
        Me.lblThree.AutoSize = True
        Me.lblThree.Location = New System.Drawing.Point(10, 77)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(106, 13)
        Me.lblThree.TabIndex = 15
        Me.lblThree.Text = "Operations Per Hour:"
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(128, 50)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(144, 20)
        Me.txtTwo.TabIndex = 14
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Location = New System.Drawing.Point(10, 51)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(64, 13)
        Me.lblTwo.TabIndex = 13
        Me.lblTwo.Text = "Setup Time:"
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Location = New System.Drawing.Point(12, 25)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(51, 13)
        Me.lblOne.TabIndex = 21
        Me.lblOne.Text = "Machine:"
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(128, 26)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(144, 20)
        Me.txtOne.TabIndex = 22
        '
        'UpdateWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 190)
        Me.Controls.Add(Me.txtOne)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.txtFive)
        Me.Controls.Add(Me.lblFive)
        Me.Controls.Add(Me.txtFour)
        Me.Controls.Add(Me.lblFour)
        Me.Controls.Add(Me.txtThree)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateWindow"
        Me.Text = "UpdateWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents txtFive As System.Windows.Forms.TextBox
    Friend WithEvents lblFive As System.Windows.Forms.Label
    Friend WithEvents txtFour As System.Windows.Forms.TextBox
    Friend WithEvents lblFour As System.Windows.Forms.Label
    Friend WithEvents txtThree As System.Windows.Forms.TextBox
    Friend WithEvents lblThree As System.Windows.Forms.Label
    Friend WithEvents txtTwo As System.Windows.Forms.TextBox
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents txtOne As System.Windows.Forms.TextBox
End Class
