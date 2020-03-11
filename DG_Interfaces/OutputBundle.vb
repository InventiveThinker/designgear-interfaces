Public Class OutputBundle
    '<DB> Database Id
    Public Property Id As Long

    '<Internal> Internal Component Id
    Public Property InternalId As String

    'Reference to the source component bundle
    Public Property ComponentBundleId As String

    'List of required files
    Public Property Dependencies As New List(Of Dependency)
End Class
