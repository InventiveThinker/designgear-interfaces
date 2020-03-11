Public Class DaTask
    Public Property Id As Long
    Public Property Type As DaTaskTypeEnum
End Class

Public Enum DaTaskTypeEnum
    UpdateModel
    PublishDocummentation
End Enum