Imports System.Xml.Serialization

<XmlRoot("Configuration")> Public Class BatchingConfiguration
    <XmlIgnore> Public Templates As New List(Of Batching.Template)
    Public ThreadCount As Integer
    Public DaysToBatch As Integer

    Sub New()
        'ThreadCount = My.Settings.threadcount
        'DaysToBatch = My.Settings.daystobatch
        'TemplateDirectory = My.Settings.SavedTemplatePath

        '  Templates = Batching.CollectTemplate(TemplateDirectory)
    End Sub

    Public Function GetTemplate(idx As Integer) As Batching.Template
        Return Templates(idx)
    End Function
End Class
