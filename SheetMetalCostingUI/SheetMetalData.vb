Imports System.Data.OleDb
Public Class SheetMetalData
    'Material Numbers and Description
    Private _Phx_part_num As String
    Private _Phx_part_Desr As String
    Private _Phx_Width As Double
    Private _Phx_Height As Double
    Private _Phx_Cost As Double

    Private _Atl_Part_num As String
    Private _Atl_Part_Desr As String
    Private _Atl_Width As Double
    Private _Atl_Height As Double
    Private _Atl_cost As Double

    Private _Wpg_Part_num As String
    Private _Wpg_part_Desr As String
    Private _Wpg_Width As Double
    Private _Wpg_Height As Double
    Private _Wpg_Cost As Double

    'File Properties
    Private _width As Double
    Private _length As Double
    Private _Cost As Double
    Private _plant As Integer

    Private _PartNum As String
    Private _Filename As String
    Private _Folder As String

    'Painted option
    Private _Painted As Double

    'Welding option
    Private _Weld As Double

    Private PurchasedCost As String

    'DataBase connection
    Dim cn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\AndrewB\Documents\Visual Studio 2012\Projects\SheetMetalCostingUI\SheetMetalCostingUI\Database\CostingDB.accdb")
    Dim da As New OleDbDataAdapter()
    Dim dt As New DataTable()

    Public Sub ReadData(ByRef xfile As SolidEdgePart.SheetMetalDocument)
        Dim objPropertySets As SolidEdgeFramework.PropertySets = Nothing

        Dim objProperty As SolidEdgeFramework.Property = Nothing

        ' Get a reference to the document's property sets collection 
        objPropertySets = xfile.Properties
        _Filename = xfile.Name
        _Folder = xfile.Path

        SetMaterialProperties(objPropertySets)

    End Sub

    Private Sub SetMaterialProperties(ByRef xPropertySet As SolidEdgeFramework.PropertySets)
        Dim strMaterialInfo(0 To 4) As String
        Dim objProperties As SolidEdgeFramework.Properties = Nothing

        objProperties = xPropertySet.Item("MechanicalModeling")
        _Wpg_Part_num = objProperties.Item("Material").Value
        strMaterialInfo = GetMaterialInfo(_Wpg_Part_num)

        _Wpg_part_Desr = strMaterialInfo(0)
        _Wpg_Width = strMaterialInfo(1)
        _Wpg_Height = strMaterialInfo(2)
        _Wpg_Cost = strMaterialInfo(3)

        objProperties = xPropertySet.Item("Custom")
        _Atl_Part_num = objProperties.Item("Atl_Part_num").Value
        strMaterialInfo = GetMaterialInfo(_Atl_Part_num)

        _Atl_Part_Desr = strMaterialInfo(0)
        _Atl_Width = strMaterialInfo(1)
        _Atl_Height = strMaterialInfo(2)
        _Atl_cost = strMaterialInfo(3)

        _Phx_part_num = objProperties.Item("Phx_Part_num").Value
        strMaterialInfo = GetMaterialInfo(_Phx_part_num)
        _Phx_part_Desr = strMaterialInfo(0)
        _Phx_Width = strMaterialInfo(1)
        _Phx_Height = strMaterialInfo(2)
        _Phx_Cost = strMaterialInfo(3)

    End Sub
    Private Function GetMaterialInfo(ByRef strMaterial As String) As String()
        Dim sqlString As String
        Dim Return_String(0 To 4) As String
        sqlString = "select Description,Width,Length,Cost,Plant from Material where ItemNumber ='" & strMaterial & "'"
        Dim SelectCommand = New OleDbCommand(sqlString, cn)
        cn.Open()
        Dim reader As OleDbDataReader = SelectCommand.ExecuteReader
        reader.Read()
        Try
            Return_String(0) = reader(0).ToString
            Return_String(1) = reader(1).ToString
            Return_String(2) = reader(2).ToString
            Return_String(3) = reader(3).ToString
            Return_String(4) = reader(4).ToString
        Catch ex As Exception
            Return_String(0) = "Material Not enter for plant"
        End Try
        reader.Close()
        cn.Close()
        Return Return_String
    End Function

    Public Property Filename() As String
        Get
            Return _Filename
        End Get
        Set(value As String)
            _Filename = value
        End Set
    End Property

    Public Property Folder() As String
        Get
            Return _Folder
        End Get
        Set(value As String)
            _Folder = value
        End Set
    End Property

    Public Property Wpg_Part_num() As String
        Get
            Return _Wpg_Part_num
        End Get
        Set(value As String)
            _Wpg_Part_num = value
        End Set
    End Property

    Public Property Wpg_part_Desr() As String
        Get
            Return _Wpg_part_Desr
        End Get
        Set(value As String)
            _Wpg_part_Desr = value
        End Set
    End Property

    Public Property Atl_Part_num() As String
        Get
            Return _Atl_Part_num
        End Get
        Set(value As String)
            _Atl_Part_num = value
        End Set
    End Property

    Public Property Atl_part_Desr() As String
        Get
            Return _Atl_Part_Desr
        End Get
        Set(value As String)
            _Atl_Part_Desr = value
        End Set
    End Property

    Public Property Phx_Part_num() As String
        Get
            Return _Phx_part_num
        End Get
        Set(value As String)
            _Phx_part_num = value
        End Set
    End Property

    Public Property Phx_part_Desr() As String
        Get
            Return _Phx_part_Desr
        End Get
        Set(value As String)
            _Phx_part_Desr = value
        End Set
    End Property

    Public Property Plant() As String
        Get
            Return _plant
        End Get
        Set(value As String)
            _plant = value
        End Set
    End Property

    Public Property Wpg_Width() As String
        Get
            Return _Wpg_Width
        End Get
        Set(value As String)
            _Wpg_Width = value
        End Set
    End Property

    Public Property Wpg_Height() As String
        Get
            Return _Wpg_Height
        End Get
        Set(value As String)
            _Wpg_Height = value
        End Set
    End Property

    Public Property Wpg_Cost() As String
        Get
            Return _Wpg_Cost
        End Get
        Set(value As String)
            _Wpg_Cost = value
        End Set
    End Property

    Public Property Atl_Width() As String
        Get
            Return _Atl_Width
        End Get
        Set(value As String)
            _Atl_Width = value
        End Set
    End Property

    Public Property Atl_Height() As String
        Get
            Return _Atl_Height
        End Get
        Set(value As String)
            _Atl_Height = value
        End Set
    End Property

    Public Property Atl_Cost() As String
        Get
            Return _Atl_cost
        End Get
        Set(value As String)
            _Atl_cost = value
        End Set
    End Property

    Public Property Phx_Width() As String
        Get
            Return _Phx_Width
        End Get
        Set(value As String)
            _Phx_Width = value
        End Set
    End Property

    Public Property Phx_Height() As String
        Get
            Return _Phx_Height
        End Get
        Set(value As String)
            _Phx_Height = value
        End Set
    End Property

    Public Property phx_Cost() As String
        Get
            Return _Phx_Cost
        End Get
        Set(value As String)
            _Phx_Cost = value
        End Set
    End Property

    Public Property Painted() As Double
        Get
            Return _Painted
        End Get
        Set(value As Double)
            _Painted = value
        End Set
    End Property

    Public Property Weld() As Double
        Get
            Return _Weld
        End Get
        Set(value As Double)
            _Weld = value
        End Set
    End Property
End Class
