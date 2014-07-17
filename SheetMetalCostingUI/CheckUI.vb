Public Class FrmCheckUI

    Sub Updates(ByRef xResults As Boolean, ByRef xObj As Object)
        If xResults Then
            xObj.BackColor = Color.Green
            xObj.Text = "Passed"
        Else
            xObj.BackColor = Color.Red
            xObj.Text = "Failed"
        End If
        xObj.ReadOnly = True
    End Sub

    Sub MaterialUpdate(ByRef xResults As Boolean)
        If xResults Then
            txtMaterialStatus.BackColor = Color.Green
            txtMaterialStatus.Text = "Passed"
        Else
            txtMaterialStatus.BackColor = Color.Red
            txtMaterialStatus.Text = "Failed"
        End If
        txtMaterialStatus.ReadOnly = True
    End Sub

    Sub FlatPatternlUpdate(ByRef xResults As Boolean)
        If xResults Then
            txtFlatExist.BackColor = Color.Green
            txtFlatExist.Text = "Passed"
        Else
            txtFlatExist.BackColor = Color.Red
            txtFlatExist.Text = "Failed"
        End If
        txtFlatExist.ReadOnly = True
    End Sub

    Sub FlatValidUpdate(ByRef xResults As Boolean)
        If xResults Then
            txtFlatValid.BackColor = Color.Green
            txtFlatValid.Text = "Passed"
        Else
            txtFlatValid.BackColor = Color.Red
            txtFlatValid.Text = "Failed"
        End If
        txtFlatValid.ReadOnly = True
    End Sub

    Sub PaintUpdate(ByRef xResults As Boolean)
        If xResults Then
            txtPaintCheck.BackColor = Color.Green
            txtFlatValid.Text = "Passed"
        Else
            txtFlatValid.BackColor = Color.Red
            txtFlatValid.Text = "Failed"
        End If
        txtFlatValid.ReadOnly = True
    End Sub

    Private Sub FrmCheckUI_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If txtMaterialStatus.Text = "Passed" And _
           txtFlatExist.Text = "Passed" And _
           txtFlatValid.Text = "Passed" And _
           txtPaintCheck.Text = "Passed" Then

            FrmSheetMetalCostUI.btnRunCheck.Visible = False
            FrmSheetMetalCostUI.btnRunEstimate.Visible = True
        End If
    End Sub



    Private Sub FrmCheckUI_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.CenterToParent()
    End Sub

    Private Sub txtMaterialStatus_GotFocus(sender As Object, e As EventArgs) Handles txtMaterialStatus.GotFocus
        txtMaterialStatus.SelectionStart = txtMaterialStatus.Text.Length
    End Sub




End Class