Imports System.Web.Script.Serialization


'DA Activities and work Items derive from the component bundle
Public Class ComponentBundle
    '<DB> Database Id
    Public Property Id As String

    '<Internal> Internal Component Id
    Public Property InternalId As String

    'Target Document File Name
    Public Property TargetDocument As String

    'List of required files
    Public Property Dependencies As New List(Of Dependency)
    Public Property Tasks As New List(Of DaTask)
    Public Property AllowedTasks As New List(Of DaTask)

    Public Property ComponentDefinition As Component

#Region "Serialize/De-serialize"
    Public Shared Function LoadFromJson(filePath As String) As ComponentBundle
        'Read file content into a string
        Dim fileContent = IO.File.ReadAllText(filePath)
        'Create serializer
        Dim jsSerialiser As New JavaScriptSerializer()

        Dim out = jsSerialiser.Deserialize(Of ComponentBundle)(fileContent)

        Return out
    End Function

    Public Sub SaveToJsonFile(filePath As String)
        'Create serializer
        Dim jsSerialiser As New JavaScriptSerializer()
        Dim outStr = jsSerialiser.Serialize(Me)
        IO.File.WriteAllText(filePath, outStr)
    End Sub
#End Region
End Class
