
Public Class Configuration
    '<DB> Database Id
    Public Property Id As Long

    '<Internal> Interlal Id
    Public Property InternalId As String

    '<UI> Configuration Display Name
    Public Property Name As String

    '<UI> Comment
    Public Property Comment As String

    '<UI> Model interface parameters
    Public Property Parameters As New List(Of Parameter)

End Class

