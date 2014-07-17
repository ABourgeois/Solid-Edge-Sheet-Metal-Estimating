<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSheetMetalCostUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSheetMetalCostUI))
        Me.gbpCncInfo = New System.Windows.Forms.GroupBox()
        Me.btnCncUpdate = New System.Windows.Forms.Button()
        Me.btnCncRemove = New System.Windows.Forms.Button()
        Me.btnCncAdd = New System.Windows.Forms.Button()
        Me.txtCncEfficiency = New System.Windows.Forms.TextBox()
        Me.lblCncEfficiency = New System.Windows.Forms.Label()
        Me.ChkCncDetail = New System.Windows.Forms.CheckBox()
        Me.txtCncCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCncInchesPerMinute = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCncSetupTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCncMachine = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbpMaterial = New System.Windows.Forms.GroupBox()
        Me.txtMtrDescription = New System.Windows.Forms.TextBox()
        Me.mtbMtrPartNum = New System.Windows.Forms.MaskedTextBox()
        Me.lblMtrDescription = New System.Windows.Forms.Label()
        Me.lblMateriaPartNum = New System.Windows.Forms.Label()
        Me.gbpForming = New System.Windows.Forms.GroupBox()
        Me.btnFormRemove = New System.Windows.Forms.Button()
        Me.btnFormAdd = New System.Windows.Forms.Button()
        Me.txtFormEfficiency = New System.Windows.Forms.TextBox()
        Me.lblFormEfficiency = New System.Windows.Forms.Label()
        Me.chkFormCheck = New System.Windows.Forms.CheckBox()
        Me.txtFormCost = New System.Windows.Forms.TextBox()
        Me.lblFormCostRate = New System.Windows.Forms.Label()
        Me.txtFormPerHour = New System.Windows.Forms.TextBox()
        Me.lblOperationPerHour = New System.Windows.Forms.Label()
        Me.txtFormSetupTime = New System.Windows.Forms.TextBox()
        Me.lblSetupTime = New System.Windows.Forms.Label()
        Me.cboFormMachine = New System.Windows.Forms.ComboBox()
        Me.lblFormMachine = New System.Windows.Forms.Label()
        Me.gbxPlant = New System.Windows.Forms.GroupBox()
        Me.cboPlant = New System.Windows.Forms.ComboBox()
        Me.lblPlant = New System.Windows.Forms.Label()
        Me.gbpPaintWeld = New System.Windows.Forms.GroupBox()
        Me.chkWeld = New System.Windows.Forms.CheckBox()
        Me.chkPartPainted = New System.Windows.Forms.CheckBox()
        Me.txtWeldingHours = New System.Windows.Forms.TextBox()
        Me.lblWeldingHours = New System.Windows.Forms.Label()
        Me.gbpCost = New System.Windows.Forms.GroupBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.btnRunCheck = New System.Windows.Forms.Button()
        Me.gbpBreakdown = New System.Windows.Forms.GroupBox()
        Me.lblSetupPercent = New System.Windows.Forms.Label()
        Me.lblSetupValue = New System.Windows.Forms.Label()
        Me.lblSetupCost = New System.Windows.Forms.Label()
        Me.lblWeldPercent = New System.Windows.Forms.Label()
        Me.lblPaintPercent = New System.Windows.Forms.Label()
        Me.lblMaterialPercent = New System.Windows.Forms.Label()
        Me.lblCncPercent = New System.Windows.Forms.Label()
        Me.lblFormingPercent = New System.Windows.Forms.Label()
        Me.lblWeldValue = New System.Windows.Forms.Label()
        Me.lblPaintValue = New System.Windows.Forms.Label()
        Me.lblMaterialValue = New System.Windows.Forms.Label()
        Me.lblCNCValue = New System.Windows.Forms.Label()
        Me.lblFormValue = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPaint = New System.Windows.Forms.Label()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblForming = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Bar1 = New System.Windows.Forms.ProgressBar()
        Me.lblBaselineCost = New System.Windows.Forms.Label()
        Me.lblCurrentPrice = New System.Windows.Forms.Label()
        Me.lblDollarValue = New System.Windows.Forms.Label()
        Me.lblEstimateCost = New System.Windows.Forms.Label()
        Me.btnRunEstimate = New System.Windows.Forms.Button()
        Me.ProgressPanel = New System.Windows.Forms.Panel()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.StatusProgressBar = New System.Windows.Forms.ProgressBar()
        Me.btnFormUpdate = New System.Windows.Forms.Button()
        Me.gbpCncInfo.SuspendLayout()
        Me.gbpMaterial.SuspendLayout()
        Me.gbpForming.SuspendLayout()
        Me.gbxPlant.SuspendLayout()
        Me.gbpPaintWeld.SuspendLayout()
        Me.gbpCost.SuspendLayout()
        Me.gbpBreakdown.SuspendLayout()
        Me.ProgressPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbpCncInfo
        '
        Me.gbpCncInfo.Controls.Add(Me.btnCncUpdate)
        Me.gbpCncInfo.Controls.Add(Me.btnCncRemove)
        Me.gbpCncInfo.Controls.Add(Me.btnCncAdd)
        Me.gbpCncInfo.Controls.Add(Me.txtCncEfficiency)
        Me.gbpCncInfo.Controls.Add(Me.lblCncEfficiency)
        Me.gbpCncInfo.Controls.Add(Me.ChkCncDetail)
        Me.gbpCncInfo.Controls.Add(Me.txtCncCost)
        Me.gbpCncInfo.Controls.Add(Me.Label2)
        Me.gbpCncInfo.Controls.Add(Me.txtCncInchesPerMinute)
        Me.gbpCncInfo.Controls.Add(Me.Label3)
        Me.gbpCncInfo.Controls.Add(Me.txtCncSetupTime)
        Me.gbpCncInfo.Controls.Add(Me.Label4)
        Me.gbpCncInfo.Controls.Add(Me.cboCncMachine)
        Me.gbpCncInfo.Controls.Add(Me.Label5)
        Me.gbpCncInfo.Location = New System.Drawing.Point(10, 161)
        Me.gbpCncInfo.Name = "gbpCncInfo"
        Me.gbpCncInfo.Size = New System.Drawing.Size(443, 80)
        Me.gbpCncInfo.TabIndex = 2
        Me.gbpCncInfo.TabStop = False
        Me.gbpCncInfo.Text = "CNC  Information"
        '
        'btnCncUpdate
        '
        Me.btnCncUpdate.Location = New System.Drawing.Point(336, 187)
        Me.btnCncUpdate.Name = "btnCncUpdate"
        Me.btnCncUpdate.Size = New System.Drawing.Size(96, 23)
        Me.btnCncUpdate.TabIndex = 18
        Me.btnCncUpdate.Text = "Update Machine"
        Me.btnCncUpdate.UseVisualStyleBackColor = True
        '
        'btnCncRemove
        '
        Me.btnCncRemove.Location = New System.Drawing.Point(229, 186)
        Me.btnCncRemove.Name = "btnCncRemove"
        Me.btnCncRemove.Size = New System.Drawing.Size(101, 23)
        Me.btnCncRemove.TabIndex = 17
        Me.btnCncRemove.Text = "Remove Machine"
        Me.btnCncRemove.UseVisualStyleBackColor = True
        '
        'btnCncAdd
        '
        Me.btnCncAdd.Location = New System.Drawing.Point(143, 187)
        Me.btnCncAdd.Name = "btnCncAdd"
        Me.btnCncAdd.Size = New System.Drawing.Size(80, 23)
        Me.btnCncAdd.TabIndex = 16
        Me.btnCncAdd.Text = "Add Machine"
        Me.btnCncAdd.UseVisualStyleBackColor = True
        '
        'txtCncEfficiency
        '
        Me.txtCncEfficiency.Location = New System.Drawing.Point(143, 160)
        Me.txtCncEfficiency.Name = "txtCncEfficiency"
        Me.txtCncEfficiency.Size = New System.Drawing.Size(291, 20)
        Me.txtCncEfficiency.TabIndex = 11
        '
        'lblCncEfficiency
        '
        Me.lblCncEfficiency.AutoSize = True
        Me.lblCncEfficiency.Location = New System.Drawing.Point(23, 163)
        Me.lblCncEfficiency.Name = "lblCncEfficiency"
        Me.lblCncEfficiency.Size = New System.Drawing.Size(81, 13)
        Me.lblCncEfficiency.TabIndex = 10
        Me.lblCncEfficiency.Text = "CNC Efficiency:"
        '
        'ChkCncDetail
        '
        Me.ChkCncDetail.AutoSize = True
        Me.ChkCncDetail.Location = New System.Drawing.Point(26, 52)
        Me.ChkCncDetail.Name = "ChkCncDetail"
        Me.ChkCncDetail.Size = New System.Drawing.Size(83, 17)
        Me.ChkCncDetail.TabIndex = 9
        Me.ChkCncDetail.Text = "Show Detail"
        Me.ChkCncDetail.UseVisualStyleBackColor = True
        '
        'txtCncCost
        '
        Me.txtCncCost.Location = New System.Drawing.Point(143, 134)
        Me.txtCncCost.Name = "txtCncCost"
        Me.txtCncCost.Size = New System.Drawing.Size(291, 20)
        Me.txtCncCost.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cost Per Hour:"
        '
        'txtCncInchesPerMinute
        '
        Me.txtCncInchesPerMinute.Location = New System.Drawing.Point(143, 108)
        Me.txtCncInchesPerMinute.Name = "txtCncInchesPerMinute"
        Me.txtCncInchesPerMinute.Size = New System.Drawing.Size(291, 20)
        Me.txtCncInchesPerMinute.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Inches Per Minute:"
        '
        'txtCncSetupTime
        '
        Me.txtCncSetupTime.Location = New System.Drawing.Point(143, 81)
        Me.txtCncSetupTime.Name = "txtCncSetupTime"
        Me.txtCncSetupTime.Size = New System.Drawing.Size(291, 20)
        Me.txtCncSetupTime.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Setup Time:"
        '
        'cboCncMachine
        '
        Me.cboCncMachine.FormattingEnabled = True
        Me.cboCncMachine.Location = New System.Drawing.Point(146, 19)
        Me.cboCncMachine.Name = "cboCncMachine"
        Me.cboCncMachine.Size = New System.Drawing.Size(291, 21)
        Me.cboCncMachine.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Machine:"
        '
        'gbpMaterial
        '
        Me.gbpMaterial.Controls.Add(Me.txtMtrDescription)
        Me.gbpMaterial.Controls.Add(Me.mtbMtrPartNum)
        Me.gbpMaterial.Controls.Add(Me.lblMtrDescription)
        Me.gbpMaterial.Controls.Add(Me.lblMateriaPartNum)
        Me.gbpMaterial.Location = New System.Drawing.Point(10, 247)
        Me.gbpMaterial.Name = "gbpMaterial"
        Me.gbpMaterial.Size = New System.Drawing.Size(443, 85)
        Me.gbpMaterial.TabIndex = 1
        Me.gbpMaterial.TabStop = False
        Me.gbpMaterial.Text = "Material Information"
        '
        'txtMtrDescription
        '
        Me.txtMtrDescription.Location = New System.Drawing.Point(146, 51)
        Me.txtMtrDescription.Name = "txtMtrDescription"
        Me.txtMtrDescription.Size = New System.Drawing.Size(291, 20)
        Me.txtMtrDescription.TabIndex = 4
        '
        'mtbMtrPartNum
        '
        Me.mtbMtrPartNum.Location = New System.Drawing.Point(146, 23)
        Me.mtbMtrPartNum.Mask = "######-###"
        Me.mtbMtrPartNum.Name = "mtbMtrPartNum"
        Me.mtbMtrPartNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mtbMtrPartNum.Size = New System.Drawing.Size(65, 20)
        Me.mtbMtrPartNum.TabIndex = 3
        Me.mtbMtrPartNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMtrDescription
        '
        Me.lblMtrDescription.AutoSize = True
        Me.lblMtrDescription.Location = New System.Drawing.Point(23, 54)
        Me.lblMtrDescription.Name = "lblMtrDescription"
        Me.lblMtrDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblMtrDescription.TabIndex = 2
        Me.lblMtrDescription.Text = "Description:"
        '
        'lblMateriaPartNum
        '
        Me.lblMateriaPartNum.AutoSize = True
        Me.lblMateriaPartNum.Location = New System.Drawing.Point(23, 26)
        Me.lblMateriaPartNum.Name = "lblMateriaPartNum"
        Me.lblMateriaPartNum.Size = New System.Drawing.Size(69, 13)
        Me.lblMateriaPartNum.TabIndex = 0
        Me.lblMateriaPartNum.Text = "Part Number:"
        '
        'gbpForming
        '
        Me.gbpForming.Controls.Add(Me.btnFormUpdate)
        Me.gbpForming.Controls.Add(Me.btnFormRemove)
        Me.gbpForming.Controls.Add(Me.btnFormAdd)
        Me.gbpForming.Controls.Add(Me.txtFormEfficiency)
        Me.gbpForming.Controls.Add(Me.lblFormEfficiency)
        Me.gbpForming.Controls.Add(Me.chkFormCheck)
        Me.gbpForming.Controls.Add(Me.txtFormCost)
        Me.gbpForming.Controls.Add(Me.lblFormCostRate)
        Me.gbpForming.Controls.Add(Me.txtFormPerHour)
        Me.gbpForming.Controls.Add(Me.lblOperationPerHour)
        Me.gbpForming.Controls.Add(Me.txtFormSetupTime)
        Me.gbpForming.Controls.Add(Me.lblSetupTime)
        Me.gbpForming.Controls.Add(Me.cboFormMachine)
        Me.gbpForming.Controls.Add(Me.lblFormMachine)
        Me.gbpForming.Location = New System.Drawing.Point(12, 75)
        Me.gbpForming.Name = "gbpForming"
        Me.gbpForming.Size = New System.Drawing.Size(443, 80)
        Me.gbpForming.TabIndex = 3
        Me.gbpForming.TabStop = False
        Me.gbpForming.Text = "Forming Information"
        '
        'btnFormRemove
        '
        Me.btnFormRemove.Location = New System.Drawing.Point(227, 188)
        Me.btnFormRemove.Name = "btnFormRemove"
        Me.btnFormRemove.Size = New System.Drawing.Size(101, 23)
        Me.btnFormRemove.TabIndex = 14
        Me.btnFormRemove.Text = "Remove Machine"
        Me.btnFormRemove.UseVisualStyleBackColor = True
        '
        'btnFormAdd
        '
        Me.btnFormAdd.Location = New System.Drawing.Point(141, 188)
        Me.btnFormAdd.Name = "btnFormAdd"
        Me.btnFormAdd.Size = New System.Drawing.Size(80, 23)
        Me.btnFormAdd.TabIndex = 13
        Me.btnFormAdd.Text = "Add Machine"
        Me.btnFormAdd.UseVisualStyleBackColor = True
        '
        'txtFormEfficiency
        '
        Me.txtFormEfficiency.Location = New System.Drawing.Point(141, 161)
        Me.txtFormEfficiency.Name = "txtFormEfficiency"
        Me.txtFormEfficiency.Size = New System.Drawing.Size(291, 20)
        Me.txtFormEfficiency.TabIndex = 12
        '
        'lblFormEfficiency
        '
        Me.lblFormEfficiency.AutoSize = True
        Me.lblFormEfficiency.Location = New System.Drawing.Point(23, 164)
        Me.lblFormEfficiency.Name = "lblFormEfficiency"
        Me.lblFormEfficiency.Size = New System.Drawing.Size(96, 13)
        Me.lblFormEfficiency.TabIndex = 11
        Me.lblFormEfficiency.Text = "Forming Efficiency:"
        '
        'chkFormCheck
        '
        Me.chkFormCheck.AutoSize = True
        Me.chkFormCheck.Location = New System.Drawing.Point(26, 51)
        Me.chkFormCheck.Name = "chkFormCheck"
        Me.chkFormCheck.Size = New System.Drawing.Size(83, 17)
        Me.chkFormCheck.TabIndex = 10
        Me.chkFormCheck.Text = "Show Detail"
        Me.chkFormCheck.UseVisualStyleBackColor = True
        '
        'txtFormCost
        '
        Me.txtFormCost.Location = New System.Drawing.Point(141, 135)
        Me.txtFormCost.Name = "txtFormCost"
        Me.txtFormCost.Size = New System.Drawing.Size(291, 20)
        Me.txtFormCost.TabIndex = 8
        '
        'lblFormCostRate
        '
        Me.lblFormCostRate.AutoSize = True
        Me.lblFormCostRate.Location = New System.Drawing.Point(23, 138)
        Me.lblFormCostRate.Name = "lblFormCostRate"
        Me.lblFormCostRate.Size = New System.Drawing.Size(76, 13)
        Me.lblFormCostRate.TabIndex = 7
        Me.lblFormCostRate.Text = "Cost Per Hour:"
        '
        'txtFormPerHour
        '
        Me.txtFormPerHour.Location = New System.Drawing.Point(141, 109)
        Me.txtFormPerHour.Name = "txtFormPerHour"
        Me.txtFormPerHour.Size = New System.Drawing.Size(291, 20)
        Me.txtFormPerHour.TabIndex = 6
        '
        'lblOperationPerHour
        '
        Me.lblOperationPerHour.AutoSize = True
        Me.lblOperationPerHour.Location = New System.Drawing.Point(23, 112)
        Me.lblOperationPerHour.Name = "lblOperationPerHour"
        Me.lblOperationPerHour.Size = New System.Drawing.Size(106, 13)
        Me.lblOperationPerHour.TabIndex = 5
        Me.lblOperationPerHour.Text = "Operations Per Hour:"
        '
        'txtFormSetupTime
        '
        Me.txtFormSetupTime.Location = New System.Drawing.Point(141, 85)
        Me.txtFormSetupTime.Name = "txtFormSetupTime"
        Me.txtFormSetupTime.Size = New System.Drawing.Size(291, 20)
        Me.txtFormSetupTime.TabIndex = 4
        '
        'lblSetupTime
        '
        Me.lblSetupTime.AutoSize = True
        Me.lblSetupTime.Location = New System.Drawing.Point(23, 86)
        Me.lblSetupTime.Name = "lblSetupTime"
        Me.lblSetupTime.Size = New System.Drawing.Size(64, 13)
        Me.lblSetupTime.TabIndex = 3
        Me.lblSetupTime.Text = "Setup Time:"
        '
        'cboFormMachine
        '
        Me.cboFormMachine.FormattingEnabled = True
        Me.cboFormMachine.Location = New System.Drawing.Point(146, 19)
        Me.cboFormMachine.Name = "cboFormMachine"
        Me.cboFormMachine.Size = New System.Drawing.Size(291, 21)
        Me.cboFormMachine.TabIndex = 2
        '
        'lblFormMachine
        '
        Me.lblFormMachine.AutoSize = True
        Me.lblFormMachine.Location = New System.Drawing.Point(23, 26)
        Me.lblFormMachine.Name = "lblFormMachine"
        Me.lblFormMachine.Size = New System.Drawing.Size(51, 13)
        Me.lblFormMachine.TabIndex = 0
        Me.lblFormMachine.Text = "Machine:"
        '
        'gbxPlant
        '
        Me.gbxPlant.Controls.Add(Me.cboPlant)
        Me.gbxPlant.Controls.Add(Me.lblPlant)
        Me.gbxPlant.Location = New System.Drawing.Point(12, 12)
        Me.gbxPlant.Name = "gbxPlant"
        Me.gbxPlant.Size = New System.Drawing.Size(443, 57)
        Me.gbxPlant.TabIndex = 4
        Me.gbxPlant.TabStop = False
        Me.gbxPlant.Text = "Manufacturing Plant"
        '
        'cboPlant
        '
        Me.cboPlant.FormattingEnabled = True
        Me.cboPlant.Location = New System.Drawing.Point(146, 23)
        Me.cboPlant.Name = "cboPlant"
        Me.cboPlant.Size = New System.Drawing.Size(291, 21)
        Me.cboPlant.TabIndex = 1
        '
        'lblPlant
        '
        Me.lblPlant.AutoSize = True
        Me.lblPlant.Location = New System.Drawing.Point(23, 26)
        Me.lblPlant.Name = "lblPlant"
        Me.lblPlant.Size = New System.Drawing.Size(79, 13)
        Me.lblPlant.TabIndex = 0
        Me.lblPlant.Text = "Selected Plant:"
        '
        'gbpPaintWeld
        '
        Me.gbpPaintWeld.Controls.Add(Me.chkWeld)
        Me.gbpPaintWeld.Controls.Add(Me.chkPartPainted)
        Me.gbpPaintWeld.Controls.Add(Me.txtWeldingHours)
        Me.gbpPaintWeld.Controls.Add(Me.lblWeldingHours)
        Me.gbpPaintWeld.Location = New System.Drawing.Point(10, 338)
        Me.gbpPaintWeld.Name = "gbpPaintWeld"
        Me.gbpPaintWeld.Size = New System.Drawing.Size(443, 85)
        Me.gbpPaintWeld.TabIndex = 5
        Me.gbpPaintWeld.TabStop = False
        Me.gbpPaintWeld.Text = "Painting/Welding Information"
        '
        'chkWeld
        '
        Me.chkWeld.AutoSize = True
        Me.chkWeld.Location = New System.Drawing.Point(26, 25)
        Me.chkWeld.Name = "chkWeld"
        Me.chkWeld.Size = New System.Drawing.Size(15, 14)
        Me.chkWeld.TabIndex = 6
        Me.chkWeld.UseVisualStyleBackColor = True
        '
        'chkPartPainted
        '
        Me.chkPartPainted.AutoSize = True
        Me.chkPartPainted.Location = New System.Drawing.Point(26, 52)
        Me.chkPartPainted.Name = "chkPartPainted"
        Me.chkPartPainted.Size = New System.Drawing.Size(161, 17)
        Me.chkPartPainted.TabIndex = 5
        Me.chkPartPainted.Text = "Part is required to be painted"
        Me.chkPartPainted.UseVisualStyleBackColor = True
        '
        'txtWeldingHours
        '
        Me.txtWeldingHours.Location = New System.Drawing.Point(146, 23)
        Me.txtWeldingHours.Name = "txtWeldingHours"
        Me.txtWeldingHours.Size = New System.Drawing.Size(291, 20)
        Me.txtWeldingHours.TabIndex = 4
        '
        'lblWeldingHours
        '
        Me.lblWeldingHours.AutoSize = True
        Me.lblWeldingHours.Location = New System.Drawing.Point(52, 26)
        Me.lblWeldingHours.Name = "lblWeldingHours"
        Me.lblWeldingHours.Size = New System.Drawing.Size(80, 13)
        Me.lblWeldingHours.TabIndex = 0
        Me.lblWeldingHours.Text = "Welding Hours:"
        '
        'gbpCost
        '
        Me.gbpCost.Controls.Add(Me.txtQty)
        Me.gbpCost.Controls.Add(Me.lblQty)
        Me.gbpCost.Controls.Add(Me.btnRunCheck)
        Me.gbpCost.Controls.Add(Me.gbpBreakdown)
        Me.gbpCost.Controls.Add(Me.ProgressBar2)
        Me.gbpCost.Controls.Add(Me.Bar1)
        Me.gbpCost.Controls.Add(Me.lblBaselineCost)
        Me.gbpCost.Controls.Add(Me.lblCurrentPrice)
        Me.gbpCost.Controls.Add(Me.lblDollarValue)
        Me.gbpCost.Controls.Add(Me.lblEstimateCost)
        Me.gbpCost.Controls.Add(Me.btnRunEstimate)
        Me.gbpCost.Location = New System.Drawing.Point(10, 429)
        Me.gbpCost.Name = "gbpCost"
        Me.gbpCost.Size = New System.Drawing.Size(443, 336)
        Me.gbpCost.TabIndex = 6
        Me.gbpCost.TabStop = False
        Me.gbpCost.Text = "Estimated Cost Per Part"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(244, 27)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(48, 20)
        Me.txtQty.TabIndex = 14
        Me.txtQty.Text = "1"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(205, 31)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(32, 13)
        Me.lblQty.TabIndex = 13
        Me.lblQty.Text = "QTY:"
        '
        'btnRunCheck
        '
        Me.btnRunCheck.Location = New System.Drawing.Point(334, 26)
        Me.btnRunCheck.Name = "btnRunCheck"
        Me.btnRunCheck.Size = New System.Drawing.Size(100, 23)
        Me.btnRunCheck.TabIndex = 11
        Me.btnRunCheck.Text = "Check Model"
        Me.btnRunCheck.UseVisualStyleBackColor = True
        '
        'gbpBreakdown
        '
        Me.gbpBreakdown.Controls.Add(Me.lblSetupPercent)
        Me.gbpBreakdown.Controls.Add(Me.lblSetupValue)
        Me.gbpBreakdown.Controls.Add(Me.lblSetupCost)
        Me.gbpBreakdown.Controls.Add(Me.lblWeldPercent)
        Me.gbpBreakdown.Controls.Add(Me.lblPaintPercent)
        Me.gbpBreakdown.Controls.Add(Me.lblMaterialPercent)
        Me.gbpBreakdown.Controls.Add(Me.lblCncPercent)
        Me.gbpBreakdown.Controls.Add(Me.lblFormingPercent)
        Me.gbpBreakdown.Controls.Add(Me.lblWeldValue)
        Me.gbpBreakdown.Controls.Add(Me.lblPaintValue)
        Me.gbpBreakdown.Controls.Add(Me.lblMaterialValue)
        Me.gbpBreakdown.Controls.Add(Me.lblCNCValue)
        Me.gbpBreakdown.Controls.Add(Me.lblFormValue)
        Me.gbpBreakdown.Controls.Add(Me.Label7)
        Me.gbpBreakdown.Controls.Add(Me.lblPaint)
        Me.gbpBreakdown.Controls.Add(Me.lblMaterial)
        Me.gbpBreakdown.Controls.Add(Me.Label6)
        Me.gbpBreakdown.Controls.Add(Me.lblForming)
        Me.gbpBreakdown.Location = New System.Drawing.Point(17, 124)
        Me.gbpBreakdown.Name = "gbpBreakdown"
        Me.gbpBreakdown.Size = New System.Drawing.Size(415, 206)
        Me.gbpBreakdown.TabIndex = 10
        Me.gbpBreakdown.TabStop = False
        Me.gbpBreakdown.Text = "Cost Breakdown"
        '
        'lblSetupPercent
        '
        Me.lblSetupPercent.AutoSize = True
        Me.lblSetupPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetupPercent.Location = New System.Drawing.Point(352, 168)
        Me.lblSetupPercent.Name = "lblSetupPercent"
        Me.lblSetupPercent.Size = New System.Drawing.Size(29, 18)
        Me.lblSetupPercent.TabIndex = 17
        Me.lblSetupPercent.Text = "0%"
        '
        'lblSetupValue
        '
        Me.lblSetupValue.AutoSize = True
        Me.lblSetupValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetupValue.Location = New System.Drawing.Point(188, 168)
        Me.lblSetupValue.Name = "lblSetupValue"
        Me.lblSetupValue.Size = New System.Drawing.Size(44, 18)
        Me.lblSetupValue.TabIndex = 16
        Me.lblSetupValue.Text = "$0.00"
        Me.lblSetupValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSetupCost
        '
        Me.lblSetupCost.AutoSize = True
        Me.lblSetupCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetupCost.Location = New System.Drawing.Point(35, 168)
        Me.lblSetupCost.Name = "lblSetupCost"
        Me.lblSetupCost.Size = New System.Drawing.Size(50, 18)
        Me.lblSetupCost.TabIndex = 15
        Me.lblSetupCost.Text = "Setup:"
        '
        'lblWeldPercent
        '
        Me.lblWeldPercent.AutoSize = True
        Me.lblWeldPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeldPercent.Location = New System.Drawing.Point(352, 140)
        Me.lblWeldPercent.Name = "lblWeldPercent"
        Me.lblWeldPercent.Size = New System.Drawing.Size(29, 18)
        Me.lblWeldPercent.TabIndex = 14
        Me.lblWeldPercent.Text = "0%"
        '
        'lblPaintPercent
        '
        Me.lblPaintPercent.AutoSize = True
        Me.lblPaintPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaintPercent.Location = New System.Drawing.Point(352, 112)
        Me.lblPaintPercent.Name = "lblPaintPercent"
        Me.lblPaintPercent.Size = New System.Drawing.Size(29, 18)
        Me.lblPaintPercent.TabIndex = 13
        Me.lblPaintPercent.Text = "0%"
        '
        'lblMaterialPercent
        '
        Me.lblMaterialPercent.AutoSize = True
        Me.lblMaterialPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterialPercent.Location = New System.Drawing.Point(352, 84)
        Me.lblMaterialPercent.Name = "lblMaterialPercent"
        Me.lblMaterialPercent.Size = New System.Drawing.Size(29, 18)
        Me.lblMaterialPercent.TabIndex = 12
        Me.lblMaterialPercent.Text = "0%"
        '
        'lblCncPercent
        '
        Me.lblCncPercent.AutoSize = True
        Me.lblCncPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCncPercent.Location = New System.Drawing.Point(352, 55)
        Me.lblCncPercent.Name = "lblCncPercent"
        Me.lblCncPercent.Size = New System.Drawing.Size(29, 18)
        Me.lblCncPercent.TabIndex = 11
        Me.lblCncPercent.Text = "0%"
        '
        'lblFormingPercent
        '
        Me.lblFormingPercent.AutoSize = True
        Me.lblFormingPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormingPercent.Location = New System.Drawing.Point(352, 29)
        Me.lblFormingPercent.Name = "lblFormingPercent"
        Me.lblFormingPercent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFormingPercent.Size = New System.Drawing.Size(29, 18)
        Me.lblFormingPercent.TabIndex = 10
        Me.lblFormingPercent.Text = "0%"
        '
        'lblWeldValue
        '
        Me.lblWeldValue.AutoSize = True
        Me.lblWeldValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeldValue.Location = New System.Drawing.Point(188, 140)
        Me.lblWeldValue.Name = "lblWeldValue"
        Me.lblWeldValue.Size = New System.Drawing.Size(44, 18)
        Me.lblWeldValue.TabIndex = 9
        Me.lblWeldValue.Text = "$0.00"
        Me.lblWeldValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPaintValue
        '
        Me.lblPaintValue.AutoSize = True
        Me.lblPaintValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaintValue.Location = New System.Drawing.Point(188, 112)
        Me.lblPaintValue.Name = "lblPaintValue"
        Me.lblPaintValue.Size = New System.Drawing.Size(44, 18)
        Me.lblPaintValue.TabIndex = 8
        Me.lblPaintValue.Text = "$0.00"
        Me.lblPaintValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMaterialValue
        '
        Me.lblMaterialValue.AutoSize = True
        Me.lblMaterialValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterialValue.Location = New System.Drawing.Point(188, 84)
        Me.lblMaterialValue.Name = "lblMaterialValue"
        Me.lblMaterialValue.Size = New System.Drawing.Size(44, 18)
        Me.lblMaterialValue.TabIndex = 7
        Me.lblMaterialValue.Text = "$0.00"
        Me.lblMaterialValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCNCValue
        '
        Me.lblCNCValue.AutoSize = True
        Me.lblCNCValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNCValue.Location = New System.Drawing.Point(188, 55)
        Me.lblCNCValue.Name = "lblCNCValue"
        Me.lblCNCValue.Size = New System.Drawing.Size(44, 18)
        Me.lblCNCValue.TabIndex = 6
        Me.lblCNCValue.Text = "$0.00"
        Me.lblCNCValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFormValue
        '
        Me.lblFormValue.AutoSize = True
        Me.lblFormValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormValue.Location = New System.Drawing.Point(188, 29)
        Me.lblFormValue.Name = "lblFormValue"
        Me.lblFormValue.Size = New System.Drawing.Size(44, 18)
        Me.lblFormValue.TabIndex = 5
        Me.lblFormValue.Text = "$0.00"
        Me.lblFormValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Welding:"
        '
        'lblPaint
        '
        Me.lblPaint.AutoSize = True
        Me.lblPaint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaint.Location = New System.Drawing.Point(35, 112)
        Me.lblPaint.Name = "lblPaint"
        Me.lblPaint.Size = New System.Drawing.Size(45, 18)
        Me.lblPaint.TabIndex = 3
        Me.lblPaint.Text = "Paint:"
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterial.Location = New System.Drawing.Point(35, 84)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(64, 18)
        Me.lblMaterial.TabIndex = 2
        Me.lblMaterial.Text = "Material:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "CNC:"
        '
        'lblForming
        '
        Me.lblForming.AutoSize = True
        Me.lblForming.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForming.Location = New System.Drawing.Point(35, 29)
        Me.lblForming.Name = "lblForming"
        Me.lblForming.Size = New System.Drawing.Size(67, 18)
        Me.lblForming.TabIndex = 0
        Me.lblForming.Text = "Forming:"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(86, 84)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(346, 23)
        Me.ProgressBar2.TabIndex = 9
        '
        'Bar1
        '
        Me.Bar1.Location = New System.Drawing.Point(86, 55)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(346, 23)
        Me.Bar1.TabIndex = 8
        '
        'lblBaselineCost
        '
        Me.lblBaselineCost.AutoSize = True
        Me.lblBaselineCost.Location = New System.Drawing.Point(23, 90)
        Me.lblBaselineCost.Name = "lblBaselineCost"
        Me.lblBaselineCost.Size = New System.Drawing.Size(48, 13)
        Me.lblBaselineCost.TabIndex = 3
        Me.lblBaselineCost.Text = "Previous"
        '
        'lblCurrentPrice
        '
        Me.lblCurrentPrice.AutoSize = True
        Me.lblCurrentPrice.Location = New System.Drawing.Point(29, 61)
        Me.lblCurrentPrice.Name = "lblCurrentPrice"
        Me.lblCurrentPrice.Size = New System.Drawing.Size(41, 13)
        Me.lblCurrentPrice.TabIndex = 2
        Me.lblCurrentPrice.Text = "Current"
        '
        'lblDollarValue
        '
        Me.lblDollarValue.AutoSize = True
        Me.lblDollarValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollarValue.Location = New System.Drawing.Point(121, 31)
        Me.lblDollarValue.Name = "lblDollarValue"
        Me.lblDollarValue.Size = New System.Drawing.Size(78, 18)
        Me.lblDollarValue.TabIndex = 1
        Me.lblDollarValue.Text = "CAD/Part"
        '
        'lblEstimateCost
        '
        Me.lblEstimateCost.AutoSize = True
        Me.lblEstimateCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstimateCost.Location = New System.Drawing.Point(22, 27)
        Me.lblEstimateCost.Name = "lblEstimateCost"
        Me.lblEstimateCost.Size = New System.Drawing.Size(0, 24)
        Me.lblEstimateCost.TabIndex = 0
        '
        'btnRunEstimate
        '
        Me.btnRunEstimate.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnRunEstimate.Location = New System.Drawing.Point(298, 26)
        Me.btnRunEstimate.Name = "btnRunEstimate"
        Me.btnRunEstimate.Size = New System.Drawing.Size(136, 23)
        Me.btnRunEstimate.TabIndex = 12
        Me.btnRunEstimate.Text = "Run Cost Estimate"
        Me.btnRunEstimate.UseVisualStyleBackColor = True
        Me.btnRunEstimate.Visible = False
        '
        'ProgressPanel
        '
        Me.ProgressPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProgressPanel.Controls.Add(Me.lblDisplay)
        Me.ProgressPanel.Controls.Add(Me.lblStatus)
        Me.ProgressPanel.Controls.Add(Me.StatusProgressBar)
        Me.ProgressPanel.Location = New System.Drawing.Point(65, 380)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Size = New System.Drawing.Size(320, 98)
        Me.ProgressPanel.TabIndex = 7
        Me.ProgressPanel.Visible = False
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(103, 8)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 20)
        Me.lblDisplay.TabIndex = 5
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(30, 8)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(67, 20)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusProgressBar
        '
        Me.StatusProgressBar.Location = New System.Drawing.Point(29, 42)
        Me.StatusProgressBar.Maximum = 60
        Me.StatusProgressBar.Name = "StatusProgressBar"
        Me.StatusProgressBar.Size = New System.Drawing.Size(262, 33)
        Me.StatusProgressBar.TabIndex = 3
        Me.StatusProgressBar.Visible = False
        '
        'btnFormUpdate
        '
        Me.btnFormUpdate.Location = New System.Drawing.Point(331, 188)
        Me.btnFormUpdate.Name = "btnFormUpdate"
        Me.btnFormUpdate.Size = New System.Drawing.Size(101, 23)
        Me.btnFormUpdate.TabIndex = 15
        Me.btnFormUpdate.Text = "Update Machine"
        Me.btnFormUpdate.UseVisualStyleBackColor = True
        '
        'FrmSheetMetalCostUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 777)
        Me.Controls.Add(Me.ProgressPanel)
        Me.Controls.Add(Me.gbxPlant)
        Me.Controls.Add(Me.gbpForming)
        Me.Controls.Add(Me.gbpCncInfo)
        Me.Controls.Add(Me.gbpMaterial)
        Me.Controls.Add(Me.gbpPaintWeld)
        Me.Controls.Add(Me.gbpCost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSheetMetalCostUI"
        Me.Text = "Sheet Metal Costing Analysis"
        Me.gbpCncInfo.ResumeLayout(False)
        Me.gbpCncInfo.PerformLayout()
        Me.gbpMaterial.ResumeLayout(False)
        Me.gbpMaterial.PerformLayout()
        Me.gbpForming.ResumeLayout(False)
        Me.gbpForming.PerformLayout()
        Me.gbxPlant.ResumeLayout(False)
        Me.gbxPlant.PerformLayout()
        Me.gbpPaintWeld.ResumeLayout(False)
        Me.gbpPaintWeld.PerformLayout()
        Me.gbpCost.ResumeLayout(False)
        Me.gbpCost.PerformLayout()
        Me.gbpBreakdown.ResumeLayout(False)
        Me.gbpBreakdown.PerformLayout()
        Me.ProgressPanel.ResumeLayout(False)
        Me.ProgressPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbpCncInfo As System.Windows.Forms.GroupBox
    Friend WithEvents ChkCncDetail As System.Windows.Forms.CheckBox
    Friend WithEvents txtCncCost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCncInchesPerMinute As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCncSetupTime As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCncMachine As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbpMaterial As System.Windows.Forms.GroupBox
    Friend WithEvents txtMtrDescription As System.Windows.Forms.TextBox
    Friend WithEvents mtbMtrPartNum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblMtrDescription As System.Windows.Forms.Label
    Friend WithEvents lblMateriaPartNum As System.Windows.Forms.Label
    Friend WithEvents gbpForming As System.Windows.Forms.GroupBox
    Friend WithEvents chkFormCheck As System.Windows.Forms.CheckBox
    Friend WithEvents txtFormCost As System.Windows.Forms.TextBox
    Friend WithEvents lblFormCostRate As System.Windows.Forms.Label
    Friend WithEvents txtFormPerHour As System.Windows.Forms.TextBox
    Friend WithEvents lblOperationPerHour As System.Windows.Forms.Label
    Friend WithEvents txtFormSetupTime As System.Windows.Forms.TextBox
    Friend WithEvents lblSetupTime As System.Windows.Forms.Label
    Friend WithEvents cboFormMachine As System.Windows.Forms.ComboBox
    Friend WithEvents lblFormMachine As System.Windows.Forms.Label
    Friend WithEvents gbxPlant As System.Windows.Forms.GroupBox
    Friend WithEvents cboPlant As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlant As System.Windows.Forms.Label
    Friend WithEvents gbpPaintWeld As System.Windows.Forms.GroupBox
    Friend WithEvents chkPartPainted As System.Windows.Forms.CheckBox
    Friend WithEvents txtWeldingHours As System.Windows.Forms.TextBox
    Friend WithEvents lblWeldingHours As System.Windows.Forms.Label
    Friend WithEvents gbpCost As System.Windows.Forms.GroupBox
    Friend WithEvents btnRunCheck As System.Windows.Forms.Button
    Friend WithEvents gbpBreakdown As System.Windows.Forms.GroupBox
    Friend WithEvents lblWeldPercent As System.Windows.Forms.Label
    Friend WithEvents lblPaintPercent As System.Windows.Forms.Label
    Friend WithEvents lblMaterialPercent As System.Windows.Forms.Label
    Friend WithEvents lblCncPercent As System.Windows.Forms.Label
    Friend WithEvents lblFormingPercent As System.Windows.Forms.Label
    Friend WithEvents lblWeldValue As System.Windows.Forms.Label
    Friend WithEvents lblPaintValue As System.Windows.Forms.Label
    Friend WithEvents lblMaterialValue As System.Windows.Forms.Label
    Friend WithEvents lblCNCValue As System.Windows.Forms.Label
    Friend WithEvents lblFormValue As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPaint As System.Windows.Forms.Label
    Friend WithEvents lblMaterial As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblForming As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Bar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblBaselineCost As System.Windows.Forms.Label
    Friend WithEvents lblCurrentPrice As System.Windows.Forms.Label
    Friend WithEvents lblDollarValue As System.Windows.Forms.Label
    Friend WithEvents lblEstimateCost As System.Windows.Forms.Label
    Friend WithEvents btnRunEstimate As System.Windows.Forms.Button
    Friend WithEvents txtFormEfficiency As System.Windows.Forms.TextBox
    Friend WithEvents lblFormEfficiency As System.Windows.Forms.Label
    Friend WithEvents txtCncEfficiency As System.Windows.Forms.TextBox
    Friend WithEvents lblCncEfficiency As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblSetupPercent As System.Windows.Forms.Label
    Friend WithEvents lblSetupValue As System.Windows.Forms.Label
    Friend WithEvents lblSetupCost As System.Windows.Forms.Label
    Friend WithEvents chkWeld As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressPanel As System.Windows.Forms.Panel
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents StatusProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnFormRemove As System.Windows.Forms.Button
    Friend WithEvents btnFormAdd As System.Windows.Forms.Button
    Friend WithEvents btnCncUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCncRemove As System.Windows.Forms.Button
    Friend WithEvents btnCncAdd As System.Windows.Forms.Button
    Friend WithEvents btnFormUpdate As System.Windows.Forms.Button

End Class
