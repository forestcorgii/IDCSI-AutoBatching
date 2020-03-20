Imports System.IO

Public Class clsConfig
    Public Items As List(Of BatcherInfo)
    Public ThreadCount As Integer
    Public DaysToBatch As Integer

    Sub New()
        Items = New List(Of BatcherInfo)
        ThreadCount = My.Settings.threadcount
        DaysToBatch = My.Settings.daystobatch

        CollectItems(Items)
    End Sub
End Class

Public Class BatcherInfo
    Public Client As String
    Public Job As String
    Public Type As String

    Public RootDirectory As String
    Public TargetDirectory As String
    Public TempDirectory As String
    Public ExeName As String
    Public BatchCount As String
    Public FileType As String

    Public DuplicateString As String = ""

    Private ValFlag As Boolean

    Public Basis As New List(Of BatchItemBasis1)

    Public LogConnectionPath As String

    Public ReadOnly Property Duplicate As Boolean
        Get
            Return Not DuplicateString = ""
        End Get
    End Property

    Public ReadOnly Property Types As List(Of String)
        Get
            Return Type.Split("|").ToList()
        End Get
    End Property

    Public ReadOnly Property ExeFilePath As String
        Get
            If Not ExeName = "" Then
                Return ExeDirectory & ExeName
            Else : Return ""
            End If
        End Get
    End Property

    Public ReadOnly Property hasType As Boolean
        Get
            Return Not Type = ""
        End Get
    End Property

    Public ReadOnly Property hasJob As Boolean
        Get
            Return Not Job = ""
        End Get
    End Property

    Public Function isValid() As Boolean
        ValFlag = True
        CheckRequired("Client", Client)
        CheckRequired("Root Directory", RootDirectory)
        CheckRequired("Target Directory", TargetDirectory)
        CheckRequired("Exe Name", ExeFilePath)
        '   CheckRequired("File Type", FileType)

        CheckDirExist("Root Directory", RootDirectory)
        CheckDirExist("Target Directory", TargetDirectory)

        CheckFileExist("Exe Name", ExeFilePath)
        '  checkBasis()
        Return ValFlag
    End Function

    Private Sub checkBasis()
        If ValFlag Then
            If Not Basis.Count = 0 Then
                For Each _basis As BatchItemBasis1 In Basis
                    If Not _basis.IsValid Then
                        ValFlag = False
                        MessageBox.Show("Type " & _basis.Type & " is Invalid!", "Invalid Item Basis", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit For
                    End If
                Next
            Else : MessageBox.Show("Item Basis is Invalid!", "Should not be Empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ValFlag = False
            End If
        End If
    End Sub

    Private Sub CheckRequired(Fieldname As String, FieldValue As String)
        If ValFlag And FieldValue = "" Then
            MessageBox.Show(Fieldname & " is a required field!", "Should not be Blank", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ValFlag = False
        End If
    End Sub

    Private Sub CheckDirExist(fldname As String, fldvalue As String)
        If ValFlag Then
            If Not Directory.Exists(fldvalue.Trim) Then
                MessageBox.Show(fldname & " >> " & fldvalue, "Directory not Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ValFlag = False
            End If
        End If
    End Sub

    Private Sub CheckFileExist(fldname As String, fldvalue As String)
        If ValFlag Then
            If Not File.Exists(fldvalue.Trim) Then
                MessageBox.Show(fldname & " >> " & fldvalue, "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ValFlag = False
            End If
        End If
    End Sub

    Public Overrides Function ToString() As String
        If hasType And hasJob And Not Types.Count > 1 Then
            Return String.Format("{0}-{1}-{2}", Client, Job, Type)
        ElseIf hasJob Or Types.Count > 1 Then
            Return String.Format("{0}-{1}", Client, Job)
        ElseIf hasType And Not hasJob And Not Types.Count > 1 Then
            Return String.Format("{0}-{1}", Client, Type)
        ElseIf Client = "" Then
            Return "BlankItem"
        Else : Return Client : End If
    End Function

    Public Function toArray() As String()
        Dim itemInfo As New List(Of String)
        With itemInfo
            .Add(Client)
            .Add(Job)
            .Add(Type)
            .Add(RootDirectory)
            .Add(TargetDirectory)
            .Add(ExeName)
            .Add(BatchCount)
            .Add(FileType)
        End With
        Return itemInfo.ToArray
    End Function

    Public Sub New()

    End Sub

    Sub New(_batcher As BatcherInfo)
        With _batcher
            Client = .Client
            Job = .Job
            Type = .Type

            RootDirectory = .RootDirectory
            TargetDirectory = .TargetDirectory
            ExeName = .ExeName
            BatchCount = .BatchCount
            FileType = .FileType

            DuplicateString = .DuplicateString

            ValFlag = .ValFlag

            Basis = .Basis

            LogConnectionPath = .LogConnectionPath
        End With
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