Imports System.Runtime.InteropServices
Imports SolidEdgeDraft
Imports System.Threading

Module SheetMetalEstimate
    Sub ProgressBarSwitch(ByVal xVisible As Boolean)
        FrmSheetMetalCostUI.ProgressPanel.Location = New Point(65, (FrmSheetMetalCostUI.Size.Height / 2) - 100)
        FrmSheetMetalCostUI.ProgressPanel.Visible = xVisible
        FrmSheetMetalCostUI.lblDisplay.Visible = xVisible
        FrmSheetMetalCostUI.lblStatus.Visible = xVisible
        FrmSheetMetalCostUI.StatusProgressBar.Visible = xVisible
        FrmSheetMetalCostUI.StatusProgressBar.Value = 0

        FrmSheetMetalCostUI.gbxPlant.Enabled = Not xVisible
        FrmSheetMetalCostUI.gbpForming.Enabled = Not xVisible
        FrmSheetMetalCostUI.gbpCncInfo.Enabled = Not xVisible
        FrmSheetMetalCostUI.gbpMaterial.Enabled = Not xVisible
        FrmSheetMetalCostUI.gbpPaintWeld.Enabled = Not xVisible
        FrmSheetMetalCostUI.gbpCost.Enabled = Not xVisible
    End Sub

    Sub progressBarMove()
        For i = 1 To 10
            FrmSheetMetalCostUI.StatusProgressBar.Value += 1
            FrmSheetMetalCostUI.Refresh()
            Thread.Sleep(75)
        Next
    End Sub




    Sub RunEstimate(ByRef xPart As SolidEdgePart.SheetMetalDocument, ByVal xCurrentClass As SheetMetalData)
        Dim Flange As Integer
        Dim PerimaterLength As Double
        Dim dblCncCost As Double
        Dim dblFormedCost As Double
        Dim dblMaterialCost As Double
        Dim dblPaintCost As Double
        Dim dblSetupCost As Double
        Dim dblweldCost As Double
        Dim dblWeldHours As Double
        Dim totalCost As Double

        ProgressBarSwitch(True)


        FrmSheetMetalCostUI.lblDisplay.Text = "Calculating CNC Cost"
        progressBarMove()


        PerimaterLength = FindFlatPerimeter(xPart, Flange)


        dblCncCost = CalculateCncCost(PerimaterLength, FrmSheetMetalCostUI.txtCncCost.Text, FrmSheetMetalCostUI.txtCncInchesPerMinute.Text, FrmSheetMetalCostUI.txtCncEfficiency.Text)
        FrmSheetMetalCostUI.lblCNCValue.Text = FormatCurrency(dblCncCost, , , TriState.True, TriState.True)

        FrmSheetMetalCostUI.lblDisplay.Text = "Calculating Forming Cost"
        progressBarMove()


        dblFormedCost = CalculateFormCost(Flange, FrmSheetMetalCostUI.txtFormPerHour.Text, FrmSheetMetalCostUI.txtFormCost.Text, FrmSheetMetalCostUI.txtFormEfficiency.Text)
        FrmSheetMetalCostUI.lblFormValue.Text = FormatCurrency(dblFormedCost, , , TriState.True, TriState.True)

        FrmSheetMetalCostUI.lblDisplay.Text = "Calculating Material Cost"
     progressBarMove()

        dblMaterialCost = CalculateMaterialCost(xCurrentClass, xPart)
        FrmSheetMetalCostUI.lblMaterialValue.Text = FormatCurrency(dblMaterialCost, , , TriState.True, TriState.True)

        FrmSheetMetalCostUI.lblDisplay.Text = "Calculating Paint Cost"
        progressBarMove()

        If FrmSheetMetalCostUI.chkPartPainted.Checked Then
            dblPaintCost = CalculatePaint(xCurrentClass, xPart)
            FrmSheetMetalCostUI.lblPaintValue.Text = FormatCurrency(dblPaintCost, , , TriState.True, TriState.True)
        Else
            FrmSheetMetalCostUI.lblPaintValue.Text = FormatCurrency(0, , , TriState.True, TriState.True)
        End If

        FrmSheetMetalCostUI.lblDisplay.Text = "Calculating Setup Cost"
        progressBarMove()

        dblSetupCost = CalculateSetup(FrmSheetMetalCostUI.txtFormSetupTime.Text, _
                                      FrmSheetMetalCostUI.txtFormCost.Text, _
                                       FrmSheetMetalCostUI.txtFormEfficiency.Text, _
                                       FrmSheetMetalCostUI.txtCncSetupTime.Text, _
                                       FrmSheetMetalCostUI.txtCncCost.Text, _
                                       FrmSheetMetalCostUI.txtCncEfficiency.Text, _
                                       FrmSheetMetalCostUI.txtQty.Text)
        FrmSheetMetalCostUI.lblSetupValue.Text = FormatCurrency(dblSetupCost, , , TriState.True, TriState.True)

        FrmSheetMetalCostUI.lblDisplay.Text = "Calculating Welding Cost"
        progressBarMove()

        If FrmSheetMetalCostUI.chkWeld.Checked Then

            Double.TryParse(FrmSheetMetalCostUI.txtWeldingHours.Text, dblWeldHours)
            dblweldCost = xCurrentClass.Weld * dblWeldHours
        End If
        FrmSheetMetalCostUI.lblWeldValue.Text = FormatCurrency(dblweldCost, , , TriState.True, TriState.True)

        totalCost = dblCncCost + dblFormedCost + dblMaterialCost + dblPaintCost + dblSetupCost + dblweldCost
        FrmSheetMetalCostUI.lblEstimateCost.Text = FormatCurrency(totalCost, , , TriState.True, TriState.True)

        FrmSheetMetalCostUI.lblCncPercent.Text = FormatPercent(dblCncCost / totalCost, , TriState.True, TriState.True)
        FrmSheetMetalCostUI.lblFormingPercent.Text = FormatPercent(dblFormedCost / totalCost, , TriState.True, TriState.True)
        FrmSheetMetalCostUI.lblMaterialPercent.Text = FormatPercent(dblMaterialCost / totalCost, , TriState.True, TriState.True)
        FrmSheetMetalCostUI.lblPaintPercent.Text = FormatPercent(dblPaintCost / totalCost, , TriState.True, TriState.True)
        FrmSheetMetalCostUI.lblSetupPercent.Text = FormatPercent(dblSetupCost / totalCost, , TriState.True, TriState.True)
        FrmSheetMetalCostUI.lblWeldPercent.Text = FormatPercent(dblweldCost / totalCost, , TriState.True, TriState.True)

        ProgressBarSwitch(False)
    End Sub
    Public Structure GraphicMembersValues
        Dim Angle As Double
        Dim Length As Double
        Dim Type As Long
        Dim count As Integer
    End Structure

    Function FindFlatPerimeter(ByRef refDocument As SolidEdgePart.SheetMetalDocument, ByRef flangecount As Integer) As Double
        Dim PerimeterLength As Double
        Dim objFlatPatternModels As SolidEdgePart.FlatPatternModels
        Dim objFlatPatternModel As SolidEdgePart.FlatPatternModel
        Dim objFlatPattern As SolidEdgePart.FlatPattern
        Dim objFlatPatterns As SolidEdgePart.FlatPatterns
        Dim objBody As SolidEdgeGeometry.Body
        Dim objVertex1 As SolidEdgeGeometry.Vertex
        Dim dblStartPtData(0 To 2) As Double
        Dim dblEndPtData(0 To 2) As Double
        Dim dblPoint(0 To 2) As Double
        Dim dblVector(0 To 2) As Double
        Dim intCounter As Integer = 0
        Dim intCounter2 As Integer = 0
        Dim dblLength As Double = 0
        Dim bFoundCenter As Boolean = False

        Dim objEdgeUse(0 To 1) As Object

        objFlatPatternModels = refDocument.FlatPatternModels
        objFlatPatternModel = objFlatPatternModels.Item(1)
        objFlatPatterns = objFlatPatternModel.FlatPatterns      ' Get the Faces collection

        objFlatPatternModel.Update()
        Dim xValue, yValue As Double

        objFlatPatternModel.GetCutSize(xValue, yValue)




        'txtFlatX.Text = FormatNumber((xValue * 39.3701), 3)
        'txtFlatY.Text = FormatNumber((yValue * 39.3701), 3)

        Dim objDraft As SolidEdgeDraft.DraftDocument = Nothing
        Dim objSheet As SolidEdgeDraft.Sheet = Nothing
        Dim objModelLinks As SolidEdgeDraft.ModelLinks = Nothing
        Dim objModelLink As SolidEdgeDraft.ModelLink = Nothing
        Dim objDrawingViews As SolidEdgeDraft.DrawingViews = Nothing
        Dim objDrawingView As SolidEdgeDraft.DrawingView = Nothing
        Dim objDocuments As SolidEdgeFramework.Documents = Nothing
        Dim objGraphicMembers As SolidEdgeDraft.GraphicMembers
        Dim counter As Integer = 0
        PerimeterLength = 0


        objDocuments = FrmSheetMetalCostUI.objApplication.Documents
        'FrmSheetMetalCostUI.objApplication.ScreenUpdating = False
        objDraft = objDocuments.Add("SolidEdge.DraftDocument", Application.StartupPath + "\Costing_Draft.dft")
        '   filename = refDocument.Substring(0, filename.LastIndexOf(".") + 4)
        objDraft.PopulateQuicksheetTemplate(refDocument.Path + "\" + refDocument.Name)
        'objApplication.DoIdle()
        'FrmSheetMetalCostUI.objApplication.ScreenUpdating = True


        objSheet = objDraft.Sheets(0)
        objDrawingViews = objSheet.DrawingViews
        objDrawingView = objDrawingViews.Item(1)
        sizeDrawingView(objDrawingView, 0.35)
        objGraphicMembers = objDrawingView.GraphicMembers
        For Each DrawingObject As Object In objGraphicMembers

            If DrawingObject.EdgeTYPE = GraphicMemberEdgeTypeConstants.seBendCenterlineEdgeType Then
                counter = counter + 1
            End If
        Next
        Dim CenterlineArray(counter - 1) As GraphicMembersValues
        counter = 0
        
        For Each DrawingObject As Object In objGraphicMembers

            If DrawingObject.EdgeTYPE = GraphicMemberEdgeTypeConstants.seBendCenterlineEdgeType Then

                CenterlineArray(counter).Angle = DrawingObject.Angle
                CenterlineArray(counter).Length = DrawingObject.Length
                CenterlineArray(counter).Type = DrawingObject.Type
                CenterlineArray(counter).count = 0
                counter = counter + 1
                PerimeterLength = PerimeterLength - (DrawingObject.Length * 3)
                'MsgBox("Object type: " + counter.ToString)
            End If
        Next
        flangecount = counter
        counter = 0
        Dim Inner As Integer = 0
        Dim outer As Integer = 0
        For Each DrawingObject As Object In objGraphicMembers
            If (DrawingObject.TYPE = SolidEdgeFramework.ObjectType.seDVLine2d) Then
                PerimeterLength = PerimeterLength + DrawingObject.Length
            End If
            If (DrawingObject.TYPE = SolidEdgeFramework.ObjectType.seDVArc2d) Then
                PerimeterLength = PerimeterLength + (DrawingObject.SweepAngle * DrawingObject.Radius)
            End If
            If (DrawingObject.TYPE = SolidEdgeFramework.ObjectType.seDVCircle2d) Then
                'Dim dblCutVsPunch As Double
                'Double.TryParse(txtCutVsPunch.Text, dblCutVsPunch)
                'If DrawingObject.Radius >= ((dblCutVsPunch / 2) / 39.3701) Then
                '    PerimeterLength = PerimeterLength + ((2 * Math.PI) * DrawingObject.Radius)
                'End If
            End If
        Next


        'objApplication.DoIdle()
        objDocuments.Item(objDocuments.Count).close(SaveChanges:=False)
        'objApplication.DoIdle()
        objVertex1 = Nothing
        objBody = Nothing




        If Not (objFlatPatternModels Is Nothing) Then
            Marshal.ReleaseComObject(objFlatPatternModels)
            objFlatPatternModels = Nothing
        End If

        If Not (objFlatPatternModel Is Nothing) Then
            Marshal.ReleaseComObject(objFlatPatternModel)
            objFlatPatternModel = Nothing
        End If

        'If Not (objFlatPattern Is Nothing) Then
        '    Marshal.ReleaseComObject(objFlatPattern)
        '    objFlatPattern = Nothing
        'End If

        If Not (objFlatPatterns Is Nothing) Then
            Marshal.ReleaseComObject(objFlatPatterns)
            objFlatPatterns = Nothing
        End If

        If Not (objBody Is Nothing) Then
            Marshal.ReleaseComObject(objBody)
            objBody = Nothing
        End If

        If Not (objVertex1 Is Nothing) Then
            Marshal.ReleaseComObject(objVertex1)
            objVertex1 = Nothing
        End If

        If Not (objDraft Is Nothing) Then
            Marshal.ReleaseComObject(objDraft)
            objDraft = Nothing
        End If

        If Not (objSheet Is Nothing) Then
            Marshal.ReleaseComObject(objSheet)
            objSheet = Nothing
        End If
        If Not (objModelLinks Is Nothing) Then
            Marshal.ReleaseComObject(objModelLinks)
            objModelLinks = Nothing
        End If
        If Not (objModelLink Is Nothing) Then
            Marshal.ReleaseComObject(objModelLink)
            objModelLink = Nothing
        End If

        If Not (objDrawingViews Is Nothing) Then
            Marshal.ReleaseComObject(objDrawingViews)
            objDrawingViews = Nothing
        End If
        If Not (objDrawingView Is Nothing) Then
            Marshal.ReleaseComObject(objDrawingView)
            objDrawingView = Nothing
        End If
        If Not (objDocuments Is Nothing) Then
            Marshal.ReleaseComObject(objDocuments)
            objDocuments = Nothing
        End If
        If Not (objGraphicMembers Is Nothing) Then
            Marshal.ReleaseComObject(objGraphicMembers)
            objGraphicMembers = Nothing
        End If

        GC.Collect()
        'objApplication.DoIdle()
        'oForceGarbageCollection()


        Return PerimeterLength
    End Function

    Sub sizeDrawingView(ByRef DrawingView As SolidEdgeDraft.DrawingView, ByRef Scale As Double)
        Dim left, right, top, bottom, height, width As Double
        Dim scaleToSet As Double
        Dim toLarge As Boolean = True
        Do While toLarge
            left = DrawingView.CropLeft
            right = DrawingView.CropRight
            top = DrawingView.CropTop
            bottom = DrawingView.CropBottom

            width = left - right
            height = bottom - top

            If left > Scale Or top > Scale Then
                scaleToSet = DrawingView.ScaleFactor
                'System.Threading.Thread.Sleep(25)
                DrawingView.ScaleFactor = scaleToSet - 0.01
                ' objDrawingView2.ScaleFactor = objDrawingView.ScaleFactor
            Else
                toLarge = False
            End If
        Loop
    End Sub

    Function CalculateCncCost(ByVal xCutLength As Double, ByVal xHourlyRate As String, ByVal xFeedRate As String, ByVal xEfficiency As String) As Double
        'Calculate the laser cutting
        Dim dblCncCost As Double
        Dim dblCutLength As Double
        Dim dblFeedRate, dblHourlyRate, dblEfficeiency As Double


        xHourlyRate = xHourlyRate.Replace("$", "")
        Double.TryParse(xFeedRate, dblFeedRate)
        Double.TryParse(xHourlyRate, dblHourlyRate)
        Double.TryParse(xEfficiency, dblEfficeiency)

        dblCutLength = xCutLength * 39.37

        dblCncCost = ((dblCutLength / xFeedRate) * (xHourlyRate / 60)) / (xEfficiency)
        Return dblCncCost
    End Function

    Function CalculateFormCost(ByVal xFlanges As Integer, _
                               ByVal xTimePerBend As String, _
                               ByVal xHourlyRate As String, _
                               ByVal xEfficiency As String)
        Dim dblTimePerBend As Double
        Dim dblHourlyRate As Double
        Dim dblEfficeiency As Double
        Dim dblFormedCost As Double
        'Calculate Flange cost
        xHourlyRate = xHourlyRate.Replace("$", "")
        Double.TryParse(xTimePerBend, dblTimePerBend)
        Double.TryParse(xHourlyRate, dblHourlyRate)
        Double.TryParse(xEfficiency, dblEfficeiency)

        dblFormedCost = ((xFlanges * (60 / dblTimePerBend)) * (dblHourlyRate / 60)) / (dblEfficeiency)
        Return dblFormedCost

    End Function

    Function CalculateMaterialCost(ByVal xPartClass As SheetMetalData, ByVal xOpenPart As SolidEdgePart.SheetMetalDocument) As Double
        Dim dblheight, dblLength, dblCost, dblCostSqInch As Double
        Dim dblMaterialCost As Double
        'Calculate Material Cost
        Select Case xPartClass.Plant
            Case 1
                Double.TryParse(xPartClass.Wpg_Height, dblheight)
                Double.TryParse(xPartClass.Wpg_Width, dblLength)
                Double.TryParse(xPartClass.Wpg_Cost, dblCost)
            Case 2 To 3
                Double.TryParse(xPartClass.Atl_Height, dblheight)
                Double.TryParse(xPartClass.Atl_Width, dblLength)
                Double.TryParse(xPartClass.Atl_Cost, dblCost)
            Case 4
                Double.TryParse(xPartClass.Phx_Height, dblheight)
                Double.TryParse(xPartClass.Phx_Width, dblLength)
                Double.TryParse(xPartClass.phx_Cost, dblCost)
        End Select

        Dim objFlatPatternModel As SolidEdgePart.FlatPatternModel
        objFlatPatternModel = xOpenPart.FlatPatternModels.Item(1)
        Dim xValue, yValue As Double

        objFlatPatternModel.GetCutSize(xValue, yValue)

        dblCostSqInch = dblCost / ((dblheight * dblLength))
        dblMaterialCost = dblCostSqInch * ((FormatNumber((xValue * 39.3701), 3) * FormatNumber((yValue * 39.3701), 3)) * 1.2)

        Return dblMaterialCost

    End Function


    Function CalculatePaint(ByVal xPartClass As SheetMetalData, ByVal xOpenPart As SolidEdgePart.SheetMetalDocument) As Double
        Dim objFlatPatternModel As SolidEdgePart.FlatPatternModel

        objFlatPatternModel = xOpenPart.FlatPatternModels.Item(1)

        Dim xValue, yValue As Double
        Dim dblPaintCost As Double
        objFlatPatternModel.GetCutSize(xValue, yValue)

        'Painted Cost
        If xValue > yValue Then
            dblPaintCost = ((((FormatNumber((xValue * 39.3701), 3)) / 12) + 0.33333) / (1020 * 1)) * xPartClass.Painted
        Else
            dblPaintCost = ((((FormatNumber((yValue * 39.3701), 3)) / 12) + 0.33333) / (1020 * 1)) * xPartClass.Painted
        End If


        Return dblPaintCost

    End Function

    Function CalculateSetup(ByVal xFormSetupTime As String, _
                            ByVal xFormHourlyRate As String, _
                            ByVal xFormEfficiency As String,
                            ByVal xCncSetupTime As String, _
                            ByVal xCncHourlyRate As String, _
                            ByVal xCncEfficiency As String, _
                            ByVal xQty As String) As Double
        Dim dblSetupCost As Double
        Dim dblFormSetupTime, dblFormHourRate, dblFormEfficiency As Double
        Dim dblCncSetupTime, dblCncHourRate, dblCncEfficiency As Double
        Dim intQty As Integer

        xFormHourlyRate = xFormHourlyRate.Replace("$", "")
        xCncHourlyRate = xCncHourlyRate.Replace("$", "")

        Double.TryParse(xFormSetupTime, dblFormSetupTime)
        Double.TryParse(xFormHourlyRate, dblFormHourRate)
        Double.TryParse(xFormEfficiency, dblFormEfficiency)
        Double.TryParse(xCncSetupTime, dblCncSetupTime)
        Double.TryParse(xCncHourlyRate, dblCncHourRate)
        Double.TryParse(xCncEfficiency, dblCncEfficiency)
        Integer.TryParse(xQty, intQty)
        dblSetupCost = ((dblFormSetupTime * (dblFormHourRate / 60)) / (dblFormEfficiency)) / intQty
        dblSetupCost = dblSetupCost + ((dblCncSetupTime * (dblCncHourRate / 60)) / (dblCncEfficiency)) / intQty
        Return dblSetupCost

    End Function

    'Calculate punched hole cost
    '    temp5 = ((PunchedHoles) * (1 / 60)) / (temp4 / 100)
    '    dblCostPerPart = dblCostPerPart + temp5

    '    If TabPage2.Visible = True Then
    '        txtPunchedCost.Text = FormatCurrency(temp5, , , TriState.True, TriState.True)
    '    End If
    '    If TabPage3.Visible = True Then
    '        dgvCell = New DataGridViewTextBoxCell()
    '        dgvCell.Value = FormatCurrency(temp5, , , TriState.True, TriState.True)
    '        dgvRow.Cells.Add(dgvCell)
    '    End If


    'Calculate Setup Charges
    '    If TabPage2.Visible = True Then
    '        temp5 = (temp3 * (temp2 / 60)) / (temp4 / 100)
    '        dblCostPerPart = dblCostPerPart + temp5

    '        txtSetupCost.Text = FormatCurrency(temp5, , , TriState.True, TriState.True)


    '    End If

    'Dim dblsetupCost As Double
    '    If TabPage3.Visible = True Then
    'Dim batchsize As Integer

    '        Integer.TryParse(txtBatchSize.Text, batchsize)

    '        dblsetupCost = ((temp3 * (temp2 / 60)) / (temp4 / 100)) / batchsize
    'dblCostPerPart = dblCostPerPart + temp5

    '        dgvCell = New DataGridViewTextBoxCell()
    '        dgvCell.Value = FormatCurrency((dblsetupCost), , , TriState.True, TriState.True)
    '        dgvRow.Cells.Add(dgvCell)

    '    End If

    'Calculate Material Cost


    '    strMaterialInfo = GetMaterialInfo(strMaterial)

    '    strRemoveCurreny = txtPaintRate.Text
    '    strRemoveCurreny = strRemoveCurreny.Replace("$", "")
    '    Double.TryParse(txtFlatX.Text, dblFlatX)
    '    Double.TryParse(txtFlatY.Text, dblFlatY)
    '    Double.TryParse(strRemoveCurreny, dblPaintRate)
    '    Double.TryParse(strMaterialInfo(0), dblHeight)
    '    Double.TryParse(strMaterialInfo(1), dblLength)
    '    Double.TryParse(strMaterialInfo(2), dblCost)

    '    dblCostSqInch = dblCost / ((dblHeight * dblLength))

    '    dblMaterialCost = dblCostSqInch * ((dblFlatX * dblFlatY) * 1.2)

    'Painted Cost
    '    If dblFlatX > dblFlatY Then
    '        dblPaintCost = (((dblFlatX / 12) + 0.33333) / (1020 * 1)) * dblPaintRate
    '    Else
    '        dblPaintCost = (((dblFlatY / 12) + 0.33333) / (1020 * 1)) * dblPaintRate
    '    End If

    '    dblCostPerPart = dblCostPerPart + dblMaterialCost + dblPaintCost

End Module
