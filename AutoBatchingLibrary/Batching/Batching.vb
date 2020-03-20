Imports System.IO
Imports System.Xml.Serialization
Imports System.Windows.Forms

Public Class Batching
    Public Shared Function GenerateTable(tableName As String, dgv As DataGridView, excluded As Boolean) As Table
        If Not tableName = "" AndAlso dgv.Rows.Count > 1 Then
            Dim p_table As New Table(tableName)
            p_table.Excluded = excluded
            For i As Integer = 0 To dgv.Rows.Count - 1
                If Not dgv.Rows(i).Cells(0).Value = "" Then
                    p_table.Fields.Add(New Field(dgv.Rows(i).Cells(0).Value, dgv.Rows(i).Cells(1).Value, dgv.Rows(i).Cells(2).Value, dgv.Rows(i).Cells(3).Value))
                End If
            Next

            Return p_table
        Else : Return Nothing
        End If
    End Function

    Public Shared Function CollectTemplate(templateFolder As String) As List(Of Template)
        Dim p_templates As New List(Of Template)
        If Not templateFolder = "" Then
            If Not Directory.GetFiles(templateFolder, "*" & Template.Extension).Length = 0 Then
                Dim templatePaths As List(Of String) = Directory.GetFiles(templateFolder, "*" & Template.Extension).ToList
                templatePaths.Sort()
                For Each templatePath As String In templatePaths
                    Dim p_template As Template = Template.ReadFromFile(templatePath)
                    p_template.TemplateLocation = templatePath
                    p_templates.Add(p_template)
                Next
            End If
        End If
        Return p_templates
    End Function

#Region "Classes"



    <XmlRoot("Template")> _
    Public Class Template
        <XmlIgnore> Public Const Extension As String = ".template.xml"

        <XmlAttribute("Client")> Public Client As String
        <XmlAttribute("Job")> Public Job As String
        <XmlAttribute("Type")> Public Type As String
        <XmlAttribute("Valid")> Public Property Valid As Boolean
            Get
                Return CBatch.Valid And Data.Valid And Log.Valid
            End Get
            Set(value As Boolean)

            End Set
        End Property
        Public Use As Boolean

        Public TargetLocation As String
        Public SourceLocation As String
        Public DownloadDateFormat As String
        Public ExeLocation As String

        <XmlIgnore> Public TemplateLocation As String

        Public Basis As New Basis

        Public SourceImageType As String
        Public TargetImageType As String
        Public ImageFileName As String
        Public DBName As String
        Public BatchesFolderName As String
        Public Entry1FolderName As String
        Public Entry2FolderName As String
        Public CompareFolderName As String
        Public ImageFolderName As String
        Public BatchDateFolderName As String
        Public CustomDataDirectory As String

        Public BatchSize As Integer
        Public ImagesPerRecord As Integer
        Public RecordsPerImage As Integer

        Public EntryOnly As Boolean
        Public CreateCSV As Boolean
        Public AllIn As Boolean
        Public HasHeader As Boolean
        Public ContinousRecordCounting As Boolean

        Public CBatch As New Database
        Public Data As New Database
        Public Log As New Database

        Public DataDirectoryFormat As DataDirectoryFormatType
        Public Enum DataDirectoryFormatType
            ClientOnly
            Client_Job
            Client_Job_Type
            Custom
        End Enum

        Public Enum BatchNameBasisType
            Index_based
            Regex_based
            None
        End Enum

        '<--------Put Methods after this------->
        Public Sub ExportTemplateData(ByRef _bt As BatchingProcessor)
            With _bt
                .Client = Client
                .Job = Job
                .Type = Type

                .Basis = Basis
                .BatchSize = BatchSize

                .SourceImageType = SourceImageType
                .TargetImageType = TargetImageType
                .ImageFileName = ImageFileName
                .DBName = DBName

                .BatchesFolderName = BatchesFolderName
                .Entry1FolderName = Entry1FolderName
                .Entry2FolderName = Entry2FolderName
                .CompareFolderName = CompareFolderName
                .ImageFolderName = ImageFolderName
                .BatchDateFolderName = BatchDateFolderName
                .AllIn = AllIn
                .TemplateLocation = TemplateLocation
                .TargetLocation = TargetLocation
                .SourceLocation = SourceLocation
                .ExeLocation = ExeLocation
                .CustomDataDirectory = CustomDataDirectory

                .HasHeader = HasHeader
                .ImagesPerRecord = ImagesPerRecord
                .RecordsPerImage = RecordsPerImage

                .CreateCSV = CreateCSV
                .EntryOnly = EntryOnly
                .Use = Use
                .DataDirectoryFormat = DataDirectoryFormat
                .ContinousRecordCounting = ContinousRecordCounting

                .CBatch = CBatch
                .Data = Data
                .Log = Log
            End With
        End Sub
        Public Sub WriteToFile()
            Dim w As TextWriter = Nothing
            Try
                If Not TemplateLocation = "" Then
                    Dim s As New XmlSerializer(GetType(Template))
                    w = New StreamWriter(TemplateLocation)
                    s.Serialize(w, Me)
                    w.Close()
                End If
            Catch ex As Exception
                Throw ex
            Finally
                If w IsNot Nothing Then
                    w.Close()
                    w = Nothing
                End If
            End Try
        End Sub

        Public Shared Function ReadFromFile(ByVal filename As String) As Template
            Dim newTemplate As Template = Nothing
            Dim r As TextReader = Nothing
            Try
                Dim s As New XmlSerializer(GetType(Template))
                r = New StreamReader(filename)
                newTemplate = DirectCast(s.Deserialize(r), Template)
            Catch ex As Exception
                Throw ex
            Finally
                r.Close()
            End Try
            Return newTemplate
        End Function

        Public Overrides Function ToString() As String
            If Not Type = "" And Not Job = "" Then
                Return String.Format("{0}-{1}-{2}", Client, Job, Type)
            ElseIf Not Job = "" And Type = "" Then
                Return String.Format("{0}-{1}", Client, Job)
            ElseIf Job = "" And Not Type = "" Then
                Return String.Format("{0}-{1}", Client, Type)
            ElseIf Client = "" Then
                Return ""
            Else : Return Client : End If
        End Function
    End Class

    Public Class Database
        Implements IDisposable
        <XmlAttribute("Valid")> Public ReadOnly Property Valid As Boolean
            Get
                Return Not Tables.Count = 0
            End Get
        End Property
        Public Tables As New List(Of Table)

        <XmlIgnore> Private p_Fullpath As String
        <XmlIgnore> Private p_fi As IO.FileInfo
        <XmlIgnore> Private p_con As OleDb.OleDbConnection

#Region "Properties"
        <XmlIgnore> Public Property Fullpath As String
            Get
                Return p_Fullpath
            End Get
            Set(value As String)
                p_Fullpath = value
                p_fi = New IO.FileInfo(p_Fullpath)
                If p_fi.Directory.Exists Then
                    'If p_fi.Exists Then
                    '    p_con.Dispose()
                    '    p_con = New OleDb.OleDbConnection(String.Format("Provider=Microsoft.JET.OLEDB.4.0;Data Source={0};User Id=admin;Password=;", Location))
                    '    p_con.Open()
                    'End If
                Else
                    Throw New Exception("Directory does not exist.")
                End If
            End Set
        End Property

        <XmlIgnore> Public ReadOnly Property Name As String
            Get
                Return p_fi.Name
            End Get
        End Property

        <XmlIgnore> Public ReadOnly Property Location As String
            Get
                Return p_fi.Directory.FullName
            End Get
        End Property

        <XmlIgnore> Public ReadOnly Property ValidFile As Boolean
            Get
                Return p_fi.Exists
            End Get
        End Property

        <XmlIgnore> Public ReadOnly Property Connection As OleDb.OleDbConnection
            Get
                Return p_con
            End Get
        End Property

#End Region

#Region "Inits"
        Sub New()
        End Sub

        Sub New(_fullPath As String)
            Fullpath = _fullPath
        End Sub

        Sub New(_db As Database)
            With _db
                Tables = .Tables
            End With
        End Sub
#End Region

#Region "Methods"
        Public Sub Create(Optional overwrite As Boolean = True)
            Dim cat As New ADOX.Catalog
            For i As Integer = 1 To 10
                Try
                    If ValidFile And overwrite Then
                        File.Delete(p_Fullpath)
                        cat.Create(String.Format("Provider=Microsoft.JET.OLEDB.4.0;Data Source={0};Jet OLEDB:Engine Type=5", p_Fullpath))
                    ElseIf Not ValidFile Then
                        cat.Create(String.Format("Provider=Microsoft.JET.OLEDB.4.0;Data Source={0};Jet OLEDB:Engine Type=5", p_Fullpath))
                    End If
                    Exit For
                Catch : Threading.Thread.Sleep(500)
                End Try
            Next

            p_con = New OleDb.OleDbConnection(String.Format("Provider=Microsoft.JET.OLEDB.4.0;Data Source={0};User Id=admin;Password=;", p_Fullpath))
            If Not p_con.State = ConnectionState.Open Then p_con.Open()

            For i As Integer = 0 To Tables.Count - 1
                Tables(i).Create(p_con)
            Next
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
#End Region


#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            Me.disposedValue = True
        End Sub

        ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.

            If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
                Connection.Close()
                Connection.Dispose()
            End If

            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region
    End Class

    Public Class Table
        <XmlAttribute("Name")> Public Name As String
        <XmlAttribute("Excluded")> Public Excluded As Boolean
        <XmlAttribute("Valid")> Public ReadOnly Property Valid As Boolean
            Get
                Return Not Fields.Count = 0
            End Get
        End Property

        Public Fields As New List(Of Field)

        Sub New()
            Fields = New List(Of Field)
        End Sub

        Sub New(_name As String)
            Name = _name
            Fields = New List(Of Field)
        End Sub

        Sub New(_name As String, _fields As List(Of Field))
            Name = _name
            Fields = _fields
            Fields = New List(Of Field)
        End Sub

        Public Function Create(con As OleDb.OleDbConnection) As Exception
            Try
                If Not Fields.Count = 0 Then
                    'Generate Query
                    Dim flds As String = Fields(0).ToString
                    For i As Integer = 1 To Fields.Count - 1
                        flds &= "," & Fields(i).ToString
                    Next
                    Dim qry As String = String.Format("CREATE TABLE `{0}`({1})", Name, flds)

                    'Creation Process
                    Dim cmd As New OleDb.OleDbCommand(qry, con)
                    cmd.ExecuteNonQuery()
                Else
                    Return New Exception("There is no Fields inside the class.")
                End If
            Catch ex As Exception
                Return ex
            End Try

            Return Nothing
        End Function

        Public Function Insert(cells As List(Of Cell), con As OleDb.OleDbConnection) As Exception
            Try
                'Generate Query
                Dim flds As String = cells(0).Name
                Dim vals As String = editValue(cells(0).Value)
                For i As Integer = 1 To cells.Count - 1
                    flds &= "," & cells(i).Name
                    vals &= "," & editValue(cells(i).Value)
                Next
                Dim qry As String = String.Format("INSERT INTO `{0}`({1})VALUES({2})", Name, flds, vals)

                'Creation Process
                Dim cmd As New OleDb.OleDbCommand(qry, con)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Return ex
            End Try

            Return Nothing
        End Function

        Public Function Update(cells As List(Of Cell), conditionString As String, con As OleDb.OleDbConnection) As Exception
            Try
                'Generate Query
                Dim vals As String = cells(0).Name & "=" & editValue(cells(0).Value)
                For i As Integer = 1 To cells.Count - 1
                    vals &= "," & cells(i).Name & "=" & editValue(cells(i).Value)
                Next
                Dim qry As String = String.Format("UPDATE `{0}` SET {1} WHERE {2}", Name, vals, conditionString)
                'Creation Process
                Dim cmd As New OleDb.OleDbCommand(qry, con)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Return ex
            End Try

            Return Nothing
        End Function



        Private Function editValue(val As Object) As String
            If TypeName(val) = "String" Then
                Return "'" & val & "'"
            Else
                Return val
            End If
        End Function

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Public Class Field
        <XmlAttribute("Name")> Public Name As String
        <XmlAttribute("Type")> Public Type As String
        <XmlAttribute("Length")> Public Length As String
        <XmlAttribute("DefaultValue")> Public DefaultValue As String

        Sub New()

        End Sub

        Sub New(_name As String)
            Name = _name
        End Sub

        Sub New(_name As String, _type As String)
            Name = _name
            Type = _type
        End Sub

        Sub New(_name As String, _type As String, _len As String, _defVal As String)
            Name = _name
            Type = _type
            Length = _len
            DefaultValue = _defVal
        End Sub

        Public Function ToDatagridviewRow(dgv As System.Windows.Forms.DataGridView) As System.Windows.Forms.DataGridViewRow
            Dim dgvr As New System.Windows.Forms.DataGridViewRow()
            dgvr.CreateCells(dgv)
            dgvr.Cells(0).Value = Name
            dgvr.Cells(1).Value = convertType(Type)
            dgvr.Cells(2).Value = Length
            dgvr.Cells(3).Value = DefaultValue
            Return dgvr
        End Function

        Private Function convertType(_type As String) As String
            Dim p_type As String = ""
            Select Case _type.ToUpper
                Case "INT32"
                    p_type = "NUMBER"
                Case "STRING"
                    p_type = "TEXT"


                Case "DATE", "DATETIME", "BYTE", "NUMBER", "TEXT"
                    p_type = _type.ToUpper
                Case Else
                    p_type = "*" & _type
            End Select
            Return p_type
        End Function

        Public Overrides Function ToString() As String
            Dim str As String = ""
            If Length > 0 Then
                str = String.Format("[{0}] {1}({2})", Name, Type, Length)
            Else : str = String.Format("[{0}] {1}", Name, Type)
            End If
            Return str
        End Function
    End Class

    Public Class Cell
        Public Name As String
        Public Value As Object

        Sub New()
        End Sub

        Sub New(_name As String)
            Name = _name
        End Sub

        Sub New(_name As String, _value As String)
            Name = _name
            Value = _value
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Public Class Basis
        Public BasisType As Template.BatchNameBasisType
        Public RegexValue As String
        Sub New()

        End Sub

        Sub New(_regexValue As String)
            RegexValue = _regexValue
        End Sub

        Public Overrides Function ToString() As String
            Return BasisType.ToString
        End Function
    End Class

    Public Class Log
        Public BatchDate As Date
        Public BatchName As String
        Public JobName As String
        Public ID As String
        Public Entry1Folder As String
        Public Entry2Folder As String
        Public CompareFolder As String
        Public DataFolder As String
        Public DBLogs As New List(Of String)

        Public ReadOnly Property StartingRecord As Integer
            Get
                Return (FinalRecord + 1) - RecordCount
            End Get
        End Property
        Public FinalRecord As Integer
        Public RecordCount As Integer
        Public BatchNo As String

        Public Sub Log(ByRef _hasHeader As Boolean, _ImagesPerRecord As Integer)
            FinalRecord += RecordCount
            If _hasHeader Then
                If CInt(BatchNo) = 1 Then
                    DBLogs.Add(String.Format("│{0,-20}│{1,-15}│{2,-15}│{3,-15}│", BatchNo & ".mdb", StartingRecord, FinalRecord - _ImagesPerRecord, RecordCount - _ImagesPerRecord))
                Else : DBLogs.Add(String.Format("│{0,-20}│{1,-15}│{2,-15}│{3,-15}│", BatchNo & ".mdb", StartingRecord - _ImagesPerRecord, FinalRecord - _ImagesPerRecord, RecordCount))
                End If
            Else : DBLogs.Add(String.Format("│{0,-20}│{1,-15}│{2,-15}│{3,-15}│", BatchNo & ".mdb", StartingRecord, FinalRecord, RecordCount))
            End If
            RecordCount = 0
        End Sub

        Public Sub Print(file As String, Optional entryOnly As Boolean = False)
            Using writer As New StreamWriter(file, False)
                With writer
                    .WriteLine("{0,-20}: {1}", "Date", BatchDate.ToString("G"))
                    .WriteLine("{0,-20}: {1}", "Job", JobName)
                    .WriteLine("{0,-20}: {1}", "Shipment/ZipFile", BatchName)
                    .WriteLine("{0,-20}: {1}", "Batch By (OperId)", ID)

                    If Not DataFolder = "" Then .WriteLine("{0,-20}: {1}", "Directory Data", DataFolder)
                    If Not Entry1Folder = "" Then .WriteLine("{0,-20}: {1}", "Directory Entry1", Entry1Folder)
                    If Not Entry2Folder = "" Then .WriteLine("{0,-20}: {1}", "Directory Entry2", Entry2Folder)
                    If Not CompareFolder = "" Then .WriteLine("{0,-20}: {1}", "Directory Compare", CompareFolder)

                    .WriteLine("{0,-20}: {1}", "Date Received", "__________________________________________")
                    .WriteLine("{0,-20}: {1}", "Output Date", "__________________________________________")
                    .WriteLine("{0,-20}: {1}", "DE Target Date", "__________________________________________")
                    .WriteLine("{0,-20}: {1}", "QC Target Date", "__________________________________________")
                    .WriteLine("{0,-20}: {1}", "Val Target Date", "__________________________________________")
                    .WriteLine(vbNewLine & vbNewLine)
                    .WriteLine("┌────────────────────┬───────────────┬───────────────┬───────────────┐")
                    .WriteLine("│{0,-20}│{1,-15}│{2,-15}│{3,-15}│", "MDB Name", "Start Rec", "End Rec", "Rec Count")
                    .WriteLine("├────────────────────┼───────────────┼───────────────┼───────────────┤")
                    For i As Integer = 0 To DBLogs.Count - 1
                        .WriteLine(DBLogs(i))
                    Next
                    .WriteLine("└────────────────────┴───────────────┴───────────────┴───────────────┘")
                End With
            End Using
        End Sub
    End Class
#End Region
End Class
