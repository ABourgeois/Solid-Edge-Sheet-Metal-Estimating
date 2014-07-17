Imports System.Runtime.InteropServices


Module SolidEdgeConnection

    Sub Connect_to_solidEdge(ByRef xApplication As SolidEdgeFramework.Application)
        'Dim objApp As SolidEdgeFramework.Application = Nothing
        Try
            ' Connect to a running instance of Solid Edge
            xApplication = Marshal.GetActiveObject("SolidEdge.Application")
        Catch ex As Exception
            MsgBox("Solid Edge needs to be running to use App")
            End
        Finally
        End Try
    End Sub

    Sub Disconnect_to_solidEdge(ByRef xApplication As SolidEdgeFramework.Application)
        If Not (xApplication Is Nothing) Then
            Marshal.ReleaseComObject(xApplication)
            xApplication = Nothing
        End If
    End Sub


End Module
