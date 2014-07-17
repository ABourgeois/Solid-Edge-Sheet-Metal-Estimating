Public Class FrmCalcProgressBar

    Private Sub CalcProgressBar_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.CenterToParent()
    End Sub
    Sub updateBar(ByVal xvalue As Integer)
        ProgressBar.Value = ProgressBar.Value + xvalue
    End Sub
    Sub UpdateDisplay(ByVal xText As String)
        lblDisplay.Text = xText
    End Sub

End Class