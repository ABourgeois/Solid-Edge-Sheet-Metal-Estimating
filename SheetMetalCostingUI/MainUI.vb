Imports System.Data.OleDb
Public Class FrmSheetMetalCostUI
    Public objApplication As SolidEdgeFramework.Application = Nothing
    Public CurrentPart As New SheetMetalData

    Dim RefreshCheck As Boolean = True
    'DataBase connection
    Dim cn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\AndrewB\Documents\Visual Studio 2012\Projects\SheetMetalCostingUI\SheetMetalCostingUI\Database\CostingDB.accdb")
    Dim da As New OleDbDataAdapter()
    Dim dt As New DataTable()

    Private Sub Slider(ByRef xChecked As Boolean, ByRef xObject As Object, ByRef xhigh As Integer, ByRef xLow As Integer)
        If xChecked = True Then

            Do While (xObject.Height < xhigh)
                xObject.Height += 13
                xObject.refresh()
            Loop
        Else
            Do While xObject.Height > xLow
                xObject.Height -= 13
                xObject.Refresh()
            Loop
        End If
    End Sub



    Private Sub ChkCncDetail_Click(sender As Object, e As EventArgs) Handles ChkCncDetail.Click
        Slider(ChkCncDetail.Checked, gbpCncInfo, 223, 80)

    End Sub

    Private Sub gbpCncInfo_SizeChanged(sender As Object, e As EventArgs) Handles gbpCncInfo.SizeChanged
        MovedGroup(gbpCncInfo, gbpMaterial)
        MovedGroup(gbpMaterial, gbpPaintWeld)
        MovedGroup(gbpPaintWeld, gbpCost)

    End Sub

    Private Sub gbpForming_SizeChanged(sender As Object, e As EventArgs) Handles gbpForming.SizeChanged
        MovedGroup(gbpForming, gbpCncInfo)
        MovedGroup(gbpCncInfo, gbpMaterial)
        MovedGroup(gbpMaterial, gbpPaintWeld)
        MovedGroup(gbpPaintWeld, gbpCost)
    End Sub
    Private Sub refreshWindows()
        If RefreshCheck Then
            Me.Refresh()
            RefreshCheck = False
        Else
            RefreshCheck = True
        End If
    End Sub
    Private Sub chkFormCheck_Click(sender As Object, e As EventArgs) Handles chkFormCheck.Click
        Slider(chkFormCheck.Checked, gbpForming, 223, 80)
    End Sub

    Private Sub MovedGroup(ByRef xTop As Object, ByRef xBottom As Object)
        Dim LocationY As Integer
        LocationY = (xTop.Location.Y + xTop.Height + 6)
        xBottom.Location = New Point(12, LocationY)
        Me.Height = gbpCost.Location.Y + gbpCost.Height + 56
        refreshWindows()
    End Sub
    Sub temp()
        ProgressBar2.Maximum = 50 * 100
        ProgressBar2.Update()
        ProgressBar2.Value = ProgressBar2.Maximum
        ProgressBar2.Update()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


        Bar1.Maximum = ProgressBar2.Maximum
        Bar1.Update()
        Bar1.Value = 15 * 100

        Bar1.Update()
    End Sub

    Private Sub FrmSheetMetalCostUI_Load(sender As Object, e As EventArgs) Handles Me.Load
       
        objApplication = System.Runtime.InteropServices.Marshal.GetActiveObject("SolidEdge.Application")
        If objApplication.ActiveEnvironment <> "SheetMetal" Then
            ' An assembly document is not open, notify user and then exit.
            MsgBox("This program must be run with an sheetmetal document open." & Chr(10) & Chr(13) & "Please open an sheetmetal document and retry.")
            End
        End If
        CurrentPart.Plant = 1
        Check_custom_props(objApplication.ActiveDocument)
        CurrentPart.ReadData(objApplication.ActiveDocument)
        Me.Text = Me.Text + " (" + CurrentPart.Filename + ")"
        LoadMaterial(CurrentPart.Plant)
        LoadPlant()
        LoadFormed()
        QueryFormDetail()
        LoadCNC()
        QueryCNCDetail()
        QueryPlantEfficency()
        QueryPaintCost()

    End Sub

    Private Sub LoadMaterial(ByVal xPlant As Integer)
        Select Case xPlant
            Case 1
                mtbMtrPartNum.Text = CurrentPart.Wpg_Part_num
                txtMtrDescription.Text = CurrentPart.Wpg_part_Desr
            Case 2 To 3
                mtbMtrPartNum.Text = CurrentPart.Atl_Part_num
                txtMtrDescription.Text = CurrentPart.Atl_part_Desr
            Case 4
                mtbMtrPartNum.Text = CurrentPart.Phx_Part_num
                txtMtrDescription.Text = CurrentPart.Phx_part_Desr
        End Select
    End Sub

    Private Sub LoadPlant()

        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\AndrewB\Documents\Visual Studio 2012\Projects\SheetMetalCostingUI\SheetMetalCostingUI\Database\CostingDB.accdb")
        Dim cmd As New OleDbCommand("Select id,location from plant", con)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            cboPlant.DataSource = dt
            cboPlant.DisplayMember = "location"
            cboPlant.ValueMember = "id"
        Else
            MessageBox.Show("Empty")
        End If
    End Sub

    Private Sub LoadFormed()

        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\AndrewB\Documents\Visual Studio 2012\Projects\SheetMetalCostingUI\SheetMetalCostingUI\Database\CostingDB.accdb")
        Dim cmd As New OleDbCommand("Select * from Forming_Operation where Plant = " + cboPlant.SelectedValue.ToString, con)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            cboFormMachine.DataSource = dt
            cboFormMachine.DisplayMember = "Machine"
            cboFormMachine.ValueMember = "ID"
        Else
            MessageBox.Show("Empty")
        End If
    End Sub

    Private Sub LoadCNC()

        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\AndrewB\Documents\Visual Studio 2012\Projects\SheetMetalCostingUI\SheetMetalCostingUI\Database\CostingDB.accdb")
        Dim cmd As New OleDbCommand("Select * from CNC_Operation where Plant = " + cboPlant.SelectedValue.ToString, con)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            cboCncMachine.DataSource = dt
            cboCncMachine.DisplayMember = "Machine"
            cboCncMachine.ValueMember = "ID"
        Else
            MessageBox.Show("Empty")
        End If
    End Sub

    Private Sub QueryFormDetail() 'ByRef xSQLstring As String) 'As String()
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\AndrewB\Documents\Visual Studio 2012\Projects\SheetMetalCostingUI\SheetMetalCostingUI\Database\CostingDB.accdb")
        Dim cmd As New OleDbCommand("Select * from Forming_Operation where Plant = " + cboPlant.SelectedValue.ToString + " and ID = " + cboFormMachine.SelectedValue.ToString, con)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtFormSetupTime.Text = dt.Rows.Item(0).Item(2).ToString
            txtFormPerHour.Text = dt.Rows.Item(0).Item(3).ToString
            txtFormCost.Text = FormatCurrency(dt.Rows.Item(0).Item(4).ToString, , , TriState.True, TriState.True)

        Else
            MessageBox.Show("Empty")
        End If
    End Sub

    Private Sub QueryCNCDetail() 'ByRef xSQLstring As String) 'As String()
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\AndrewB\Documents\Visual Studio 2012\Projects\SheetMetalCostingUI\SheetMetalCostingUI\Database\CostingDB.accdb")
        Dim cmd As New OleDbCommand("Select * from CNC_Operation where Plant = " + cboPlant.SelectedValue.ToString + " and ID = " + cboCncMachine.SelectedValue.ToString, con)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtCncSetupTime.Text = dt.Rows.Item(0).Item(2).ToString
            txtCncInchesPerMinute.Text = dt.Rows.Item(0).Item(3).ToString
            txtCncCost.Text = FormatCurrency(dt.Rows.Item(0).Item(5).ToString, , , TriState.True, TriState.True)

        Else
            MessageBox.Show("Empty")
        End If
    End Sub

    Private Sub QueryPaintCost() 'ByRef xSQLstring As String) 'As String()
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\AndrewB\Documents\Visual Studio 2012\Projects\SheetMetalCostingUI\SheetMetalCostingUI\Database\CostingDB.accdb")
        Dim cmd As New OleDbCommand("Select Cost_per_hour from Paint_Operation where Plant = " + cboPlant.SelectedValue.ToString, con)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            CurrentPart.Painted = dt.Rows.Item(0).Item(0)
        Else
            MessageBox.Show("Empty")
        End If
    End Sub

    Private Sub QueryWeldCost() 'ByRef xSQLstring As String) 'As String()
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\AndrewB\Documents\Visual Studio 2012\Projects\SheetMetalCostingUI\SheetMetalCostingUI\Database\CostingDB.accdb")
        Dim cmd As New OleDbCommand("Select Cost_per_hour from Welding_Operation where Plant = " + cboPlant.SelectedValue.ToString, con)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            CurrentPart.Weld = dt.Rows.Item(0).Item(0)
        Else
            MessageBox.Show("Empty")
        End If
    End Sub


    Private Sub cboPlant_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPlant.SelectionChangeCommitted
        CurrentPart.Plant = cboPlant.SelectedValue
        LoadFormed()
        QueryFormDetail()
        LoadCNC()
        QueryCNCDetail()
        LoadMaterial(cboPlant.SelectedValue)
        QueryPlantEfficency()
        chkPartPainted.Checked = False
        QueryPaintCost()
        If btnRunEstimate.Visible Then
            btnRunCheck.Visible = True
            btnRunEstimate.Visible = False
        End If
    End Sub

    Private Sub cboFormMachine_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboFormMachine.SelectionChangeCommitted
        QueryFormDetail()
    End Sub

    Private Sub cboCncMachine_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCncMachine.SelectionChangeCommitted
        QueryCNCDetail()
    End Sub

    Private Sub btnRunCheck_Click(sender As Object, e As EventArgs) Handles btnRunCheck.Click
        LoadData(CurrentPart)
        objApplication.ActiveDocument.save()
        'CurrentPart.Painted = chkPartPainted.CheckState
     
        FrmCheckUI.Updates(CheckForMaterial(), FrmCheckUI.txtMaterialStatus)
        FrmCheckUI.Updates(CheckForFlatPattern(objApplication.ActiveDocument), FrmCheckUI.txtFlatExist)
        FrmCheckUI.Updates(FlatPatternValid(objApplication.ActiveDocument), FrmCheckUI.txtFlatValid)
        FrmCheckUI.Updates(PaintCheck(CurrentPart.Painted), FrmCheckUI.txtPaintCheck)

        FrmCheckUI.ShowDialog()

    End Sub

    Private Sub btnRunEstimate_Click(sender As Object, e As EventArgs) Handles btnRunEstimate.Click
        RunEstimate(objApplication.ActiveDocument, CurrentPart)
    End Sub

    Private Sub QueryPlantEfficency()
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\AndrewB\Documents\Visual Studio 2012\Projects\SheetMetalCostingUI\SheetMetalCostingUI\Database\CostingDB.accdb")
        Dim cmd As New OleDbCommand("Select Efficiency from Plant where ID = " + cboPlant.SelectedValue.ToString, con)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtCncEfficiency.Text = dt.Rows.Item(0).Item(0).ToString
            txtFormEfficiency.Text = dt.Rows.Item(0).Item(0).ToString
        Else
            MessageBox.Show("Empty")
        End If
    End Sub

    Private Sub chkPartPainted_CheckedChanged(sender As Object, e As EventArgs) Handles chkPartPainted.CheckedChanged
        QueryPaintCost()
    End Sub

    Private Sub chkWeld_CheckedChanged(sender As Object, e As EventArgs) Handles chkWeld.CheckedChanged
        QueryWeldCost()
    End Sub

    Private Sub btnFormAdd_Click(sender As Object, e As EventArgs) Handles btnFormAdd.Click

    End Sub
End Class
