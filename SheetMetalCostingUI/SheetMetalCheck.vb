Module SheetMetalCheck
    Dim CheckedPartData As SheetMetalData


    Sub LoadData(ByRef xPartData As SheetMetalData)
        CheckedPartData = xPartData
    End Sub

    Function CheckForMaterial() As Boolean
        Select Case CheckedPartData.Plant
            Case 1
                If CheckedPartData.Wpg_Part_num <> "      -" Then
                    Return True
                End If
            Case 2 To 3
                If CheckedPartData.Atl_Part_num <> "      -" Then
                    Return True
                End If
            Case 4
                If CheckedPartData.Phx_Part_num <> "      -" Then
                    Return True
                End If
        End Select
        Return False
    End Function

    Function CheckForFlatPattern(objPart As SolidEdgePart.SheetMetalDocument) As Boolean
        If (objPart.FlatPatternModels.Count = 0) Then
            Return False
        Else
            Return True
        End If

    End Function

    Function FlatPatternValid(objpart As SolidEdgePart.SheetMetalDocument) As Boolean
        Dim objFlatPatternModel As SolidEdgePart.FlatPatternModel
        objFlatPatternModel = objpart.FlatPatternModels.Item(1)
        Dim xValue, yValue As Double
        Try
            objFlatPatternModel.GetCutSize(xValue, yValue)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Function PaintCheck(ByVal Cost As Double) As Boolean
        If Cost > 0 Then
            Return True
        End If
        Return False
    End Function

    Sub CheckProp(ByRef fieldName As String, ByRef xProperties As SolidEdgeFramework.Properties, ByRef xProperty As SolidEdgeFramework.Property)
        Try
            If (xProperties.Item(fieldName) Is Nothing) Then
            End If
        Catch ex As Exception
            xProperty = xProperties.Add(fieldName, "")
        End Try
    End Sub

    Sub Check_custom_props(ByRef objpart As SolidEdgePart.SheetMetalDocument)
        Dim objPropertySets As SolidEdgeFramework.PropertySets = Nothing
        Dim objProperties As SolidEdgeFramework.Properties = Nothing
        Dim objProperty As SolidEdgeFramework.Property = Nothing

        ' Get a reference to the document's property sets collection 
        objPropertySets = objpart.Properties

        Try
            objProperties = objPropertySets.Item("Custom")
            CheckProp("Dash_Number", objProperties, objProperty)

            CheckProp("UserInitials", objProperties, objProperty)
            CheckProp("Pur_Number", objProperties, objProperty)
            CheckProp("Atl_Material", objProperties, objProperty)
            CheckProp("Atl_Part_num", objProperties, objProperty)
            CheckProp("Phx_Material", objProperties, objProperty)
            CheckProp("Phx_Part_num", objProperties, objProperty)
            CheckProp("PurchasedCost", objProperties, objProperty)

            For t = 1 To 4
                CheckProp("Description" + t.ToString, objProperties, objProperty)
            Next
            objPropertySets.Save()
        Catch ex As Exception
            MsgBox("crashed check_custom : " + ex.Message)
        Finally

        End Try
    End Sub

End Module
