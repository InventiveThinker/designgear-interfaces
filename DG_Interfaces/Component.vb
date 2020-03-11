


Public Class Component
    '<DB> Database Id
    Public Property Id As Long

    '<Internal> Interlal Component Id
    Public Property InternalId As String

    '<UI> Component bag type
    Public Property Type As ComponetTypeEnum

    '<UI> Allows editing
    Public Property IsReadOnly As Boolean

    '<UI> Controls visibility in the UI
    Public Property IsHidden As Boolean

    '<UI> List of configurations
    Public Property Configurations As New List(Of Configuration)

    '<UI> Configuration to use by default. Use first if empty
    Public Property DefaultConfigurationId As String

    '<UI> Dynamic list of subcomponents.
    'Sub components are not always equal to the Inventor parts or assembles.
    'Components could represent groups of instances with common parameters,
    'such as MatrixAssembly, MatrixAssemblyHeader or MatrixAssemblyInstance
    Public Property Components As New List(Of Component)

    '<UI> Allow user to add sub components
    Property AllowAddComponents As Boolean

    '<UI> List of sub component templates
    Public Property ComponentTemplates As New List(Of Component)

    Public Property CurrentConfiguration As Configuration

    Public Property Dependencies As New List(Of DG_Interfaces.Dependency)

End Class
Public Enum ComponetTypeEnum
    PartInstance 'Does not have sub components
    AssemblyInstance
    ComponentGroup 'A virtual group of components
    MatrixAssembly
    MatrixAssemblyHeader
End Enum