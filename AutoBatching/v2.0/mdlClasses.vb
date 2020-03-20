Imports System.IO
Imports AutoBatchingLibrary.Automation
Imports System.Xml.Serialization

<XmlRoot("Configuration")> Public Class clsConfig
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

Public Class XmlSerialization
    Public Shared Sub WriteToFile(filePath As String, _type As Object)
        Dim w As TextWriter = Nothing
        Dim s As New XmlSerializer(_type.GetType)
        w = File.CreateText(filePath)
        s.Serialize(w, _type)
        w.Close()
    End Sub

    Public Shared Function ReadFromFile(ByVal filename As String, item As Object)
        Dim newTemplate As Object = Nothing
        Dim r As TextReader = Nothing
        Dim s As New XmlSerializer(item.GetType)
        r = New StreamReader(filename)
        newTemplate = s.Deserialize(r)
        r.Close()
        Return newTemplate
    End Function
End Class

Public Class BatcherInfo

    Public TempDirectory As String
    Public LogConnectionPath As String
    Public DuplicateString As String
    Public SourceLocation As String
    Public TargetLocation As String
    Public TemplateLocation As String
    Public SourceDateFormat As String
    Public ExeName As String
    Public Client As String
    Public Job As String
    Public Type As String
    Public Basis As New Batching.Basis

    Public ReadOnly Property ExeLocation As String
        Get
            Return Path.Combine(ExeDirectory, ExeName)
        End Get
    End Property

    Public ReadOnly Property Duplicate As Boolean
        Get
            Return Not DuplicateString = ""
        End Get
    End Property

    Sub New()

    End Sub

    Sub New(tmp As Batching.Template)
        Client = tmp.Client
        Job = tmp.Job
        Type = tmp.Type

        ExeName = tmp.ExeLocation
        SourceLocation = tmp.SourceLocation
        TargetLocation = tmp.TargetLocation
        TemplateLocation = tmp.TemplateLocation
        SourceDateFormat = tmp.DownloadDateFormat
        Basis = tmp.Basis
    End Sub
End Class

Public Class BatchInfo
    Public Batcher As BatcherInfo
    Public ItemHolder As ListViewItem

    Public ListTime As Date
    Public StartTime As Date
    Public EndTime As Date

    Public ElapseTime As TimeSpan

    Public Status As String
    Public ErrorMsg As String = ""

End Class

Public Class BatchItemBasis1
    Public Type As String
    Public Keystring As String
    Public Substring As String

    Public ReadOnly Property IsValid As Boolean
        Get
            Return (Not Type = "" And Not Keystring = "" And Not Substring = "" And Char.IsNumber(Substring))
        End Get
    End Property

    Public ReadOnly Property SubstringStartIndex As Integer
        Get
            Dim spltr As String() = Substring.Split(",")
            If spltr.Length > 1 Then
                Return spltr(0)
            Else : Return Substring
            End If
        End Get
    End Property

    Public ReadOnly Property SubstringLength As Integer
        Get
            Dim spltr As String() = Substring.Split(",")
            If spltr.Length > 1 Then
                Return spltr(1)
            Else : Return ""
            End If
        End Get
    End Property

End Class

'Public Class MDBInfo
'    Private con As OleDb.OleDbConnection
'    Private _list As New List(Of DataTable)
'    Sub New(path As String)
'        '\\Connect

'        MsgBox("path not exist.")

'      End Sub

'    Sub New()

'    End Sub

'    Public Function Insert(fld As String(), val As String()) As Boolean

'        Return True
'    End Function

'    Public Property tables As List(Of DataTable)
'        Get
'            Return _list
'        End Get
'        Set(value As List(Of DataTable))
'            _list = value
'        End Set
'    End Property
'End Class