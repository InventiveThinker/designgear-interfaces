Public Class Parameter
    '<DB> Database Id
    Public Property Id As String

    '<Internal> Internal Component Id
    Public Property InternalId As String

    '<Internal> Internal (Inventor) parameter name
    Public Property Name As String

    '<UI> Display name to show in the configurator UI
    Public Property DisplayName As String

    '<UI> Parameter Value 
    Public Property Value As String

    '<UI> The same as Inventor value type
    Public Property Type As ValueTypeEnum

    '<UI> Value unit
    Public Property Unit As String

    '<UI> Parameter comment
    Public Property Comment As String

    '<UI> Display parameter as a drop-down
    Public Property IsMultivalue As Boolean

    '<UI> Allows user to edit the value
    Public Property IsReadOnly As Boolean

    '<UI> Controls visibility in the UI
    Public Property IsHidden As Boolean

    '<UI> List of values
    Public Property ValueList As String()

    '<UI> Allows to override custom values
    Public Property AllowCustomValues As Boolean

    '<UI> Regex pattern for value validation
    Public Property ValidationString As String

    '<UI> User tip on validation error
    Public Property ValidationTip As String
End Class

Public Enum ValueTypeEnum
    [String]
    [Double]
    [Boolean]
End Enum