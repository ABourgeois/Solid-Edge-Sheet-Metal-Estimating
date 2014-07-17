Public Class UpdateWindow
    Dim TypeOfOperation As Integer
    Dim TableName As String
    Sub SetOperation(ByVal xTypeOfOperation As Integer)
        TypeOfOperation = xTypeOfOperation
    End Sub

    Sub SetTableName(ByVal xTableName As Integer)
        TableName = xTableName
    End Sub
    Private Sub UpdateWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case TypeOfOperation
            Case 1

            Case 2

            Case 3

        End Select
    End Sub
End Class