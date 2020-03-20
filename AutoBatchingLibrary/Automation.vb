Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Globalization
Imports System.Text.RegularExpressions


Public Class Automation
    'Public Shared SystemConfig As New clsConfig

    'Public Shared Logs_MDBName As String = "MasterLog"
    'Public Shared Logs_Connection As OleDb.OleDbConnection

    'Public Shared Logs_Fields As String() = New String() {"batchfile", "batchfullpath", "client", "job", "type", "starttime", "endtime", "elapsetime", "errorlog"} 'COMPLETE LOGS FIELDS
    'Public Shared Logs_Types As String() = New String() {"TEXT(255)", "TEXT", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(255)"}
    'Public Shared Logs_TableName As String = "tblLogs"

    'Public Shared NextListing As Date

    'Public Shared bgBatcher As New List(Of BackgroundWorker)

    'Public Shared Cancelled As Boolean

    'Public Shared QueueList As List(Of BatchInfo)

    'Public Shared DaysToCheck As New List(Of Date)
    'Public Shared ListedBatchFiles As New List(Of String)

    Public Shared StatusDirectory As String = Application.StartupPath & "\DATA\PROCESSES\"
    Public Shared MDBDirectory As String = Application.StartupPath & "\DATA\MDB\"
    Public Shared ExeDirectory As String = Application.StartupPath & "\DATA\EXE\"
    Public Shared SettingDirectory As String = Application.StartupPath & "\DATA\SETTING\"
    Public Shared TemplateDirectory As String = Application.StartupPath & "\DATA\SETTING\Templates\"
    Public Const SettingFileName As String = "Autobatching.setting.xml"

    Public Shared stateSeparator As New Regex(",,,,")
    Public Const spaceEncryptor As String = "**SPACE**"


    '#Region "Database"
    '    Public Class MDB

    '#Region "OPEN"
    '        Public Shared Function Open(ByVal DatabaseFullPath As String, Optional ByRef con As OleDbConnection = Nothing)
    '            Try
    '                con = New System.Data.OleDb.OleDbConnection(String.Format("Provider=Microsoft.JET.OLEDB.4.0;Data Source={0};User Id=admin;Password=;", DatabaseFullPath))
    '            Catch ex As System.Exception
    '                MsgBox(ex.Message)
    '            End Try
    '            Return con
    '        End Function
    '#End Region

    '#Region "Delete"
    '        Public Shared Sub Drop(ByVal tbls As String(), ByVal con As OleDbConnection)
    '            For Each i As String In tbls
    '                executeQuery(String.Format("DROP TABLE {0}", i), con)
    '            Next
    '        End Sub

    '        Public Shared Sub Drop(ByVal tbls As String, ByVal con As OleDbConnection)
    '            For Each i As String In tbls
    '                executeQuery(String.Format("DROP TABLE {0}", i), con)
    '            Next
    '        End Sub
    '#End Region

    '#Region "Create"
    '        Public Shared Sub Create(ByVal DatabaseFullPath As String)
    '            Try
    '                Dim cat As New ADOX.Catalog
    '                cat.Create(String.Format("Provider=Microsoft.JET.OLEDB.4.0;Data Source={0};Jet OLEDB:Engine Type=5", DatabaseFullPath))
    '            Catch Ex As System.Exception
    '            End Try
    '        End Sub

    '        Public Shared Sub CreateTable(ByVal tbl As String, ByVal flds As String(), ByVal con As OleDbConnection)
    '            Dim qry As String = String.Format("CREATE TABLE {0}(", tbl)
    '            For Each fld As String In flds
    '                Dim tmp() As String = fld.Split(Char.Parse("-"))
    '                If fld = flds(0) Then
    '                    qry &= String.Format("[{0}] {1} NULL", tmp(0), tmp(1))
    '                Else
    '                    qry &= String.Format(",[{0}] {1} NULL", tmp(0), tmp(1))
    '                End If
    '            Next
    '            qry &= ")"

    '            executeQuery(qry, con)
    '        End Sub

    '        Public Shared Sub CreateTable(ByVal tbl As String, ByVal flds As DataTable, ByVal DDTT As String, ByVal con As OleDbConnection)
    '            Dim qry As String = String.Format("CREATE TABLE {0}(", tbl)
    '            For Each fld As DataRow In flds.Rows
    '                If fld.Item(0).ToString = flds.Rows(0).Item(0).ToString Then
    '                    qry &= String.Format("[{0}] {1} NULL", fld.Item(0).ToString, DDTT)
    '                Else
    '                    qry &= String.Format(",[{0}] {1} NULL", fld.Item(0).ToString, DDTT)
    '                End If
    '            Next
    '            qry &= ")"

    '            executeQuery(qry, con)
    '        End Sub

    '        Public Shared Sub CreateTable(ByVal tbl As String, ByVal flds As DataGridView, ByVal DDTT As String, ByVal con As OleDbConnection)
    '            Dim qry As String = String.Format("CREATE TABLE {0}(", tbl)
    '            For Each fld As DataGridViewRow In flds.Rows
    '                If fld.Cells(0).Value = flds.Rows(0).Cells(0).Value Then
    '                    qry &= String.Format("[{0}] {1} NULL", fld.Cells(0).Value, DDTT)
    '                Else
    '                    qry &= String.Format(",[{0}] {1} NULL", fld.Cells(0).Value, DDTT)
    '                End If
    '            Next
    '            qry &= ")"

    '            executeQuery(qry, con)
    '        End Sub
    '#End Region

    '#Region "Convert"
    '        Public Shared Function ConvertToDT(ByVal qry As String, ByVal con As OleDbConnection, Optional ByRef dt As System.Data.DataTable = Nothing) As DataTable
    '            Try
    '                dt = New DataTable
    '                Dim da As New OleDbDataAdapter(qry, con)
    '                da.MissingSchemaAction = MissingSchemaAction.AddWithKey
    '                da.Fill(dt)
    '            Catch
    '            End Try
    '            Return dt
    '        End Function
    '#End Region

    '#Region "Commands"
    '        Public Shared Sub executeQuery(ByVal Qry As String, ByVal con As OleDbConnection)
    '            Try
    '                Dim com As New OleDbCommand(Qry, con)
    '                com.ExecuteNonQuery()
    '            Catch ex As Exception
    '                MsgBox(String.Format("Error:{0}\nConnectionString:{1}\n\nQuery:{2}", ex.Message, con.ConnectionString, Qry))
    '            End Try
    '        End Sub

    '        Public Shared Sub Insert(ByVal tbl As String, ByVal fld As String(), ByVal val As Object(), ByVal con As OleDbConnection)
    '            Dim qry As String = String.Format("INSERT INTO {0} (", tbl)
    '            Dim valtype As String = ""
    '            Dim counter As Integer = 0

    '            For Each f As String In fld
    '                If f = fld(0) And counter = 0 Then
    '                    qry &= String.Format("[{0}]", f)
    '                Else
    '                    qry &= String.Format(",[{0}]", f)
    '                End If
    '                counter += 1
    '            Next

    '            qry &= ") VALUES("

    '            counter = 0
    '            For Each v As Object In val
    '                v &= ""
    '                valtype = TypeName(v)
    '                If v.ToString = val(0).ToString And counter = 0 Then
    '                    If valtype = "String" Then
    '                        qry &= String.Format("'{0}'", v)
    '                    Else
    '                        qry &= String.Format("{0}", v)
    '                    End If
    '                Else
    '                    If valtype = "String" Then
    '                        qry &= String.Format(",'{0}'", v)
    '                    Else
    '                        qry &= String.Format(",{0}", v)
    '                    End If
    '                End If
    '                counter += 1
    '            Next
    '            qry &= ")"

    '            executeQuery(qry, con)
    '        End Sub

    '        Public Shared Sub Update(ByVal tbl As String, ByVal fld As String(), ByVal val As Object(), ByVal condition As Object(), ByVal con As OleDbConnection)
    '            Dim qry As String = String.Format("UPDATE {0} SET ", tbl)
    '            Dim valtype As String = ""
    '            Dim counter As Integer = 0

    '            If fld.Length = val.Length Then
    '                For f As Integer = 0 To fld.GetUpperBound(0)
    '                    val(f) &= ""
    '                    valtype = TypeName(val(f))
    '                    If f = 0 Then
    '                        If valtype = "String" Then
    '                            qry &= String.Format("[{0}]='{1}'", fld(f), val(f))
    '                        Else
    '                            qry &= String.Format("[{0}]={1}", fld(f), val(f))
    '                        End If
    '                    Else
    '                        If valtype = "String" Then
    '                            qry &= String.Format(",[{0}]='{1}'", fld(f), val(f))
    '                        Else
    '                            qry &= String.Format(",[{0}]={1}", fld(f), val(f))
    '                        End If
    '                    End If
    '                Next
    '            End If

    '            If Not condition Is Nothing Then
    '                If TypeName(condition(1)) = "String" Then
    '                    qry &= String.Format(" WHERE {0} = '{1}'", condition(0), condition(1))
    '                Else
    '                    qry &= String.Format(" WHERE {0} = {1}", condition(0), condition(1))
    '                End If
    '            End If

    '            executeQuery(qry, con)
    '        End Sub
    '#End Region


    '#Region "Reader"
    '        Public Shared Function Read(qry As String, con As OleDbConnection) As OleDbDataReader
    '            If con.State = System.Data.ConnectionState.Closed Then con.Open()
    '            Dim cmd As New OleDbCommand(qry, con)
    '            If con.State = System.Data.ConnectionState.Closed Then con.Close()
    '            Dim reader As OleDbDataReader
    '            reader = cmd.ExecuteReader()
    '            Return reader
    '        End Function
    '#End Region

    '        Public Shared Function Tables(ByVal con As OleDb.OleDbConnection) As List(Of String)
    '            Dim restrictions As String() = New String() {Nothing, Nothing, Nothing, "Table"}
    '            Dim dt As New DataTable

    '            Tables = New List(Of String)
    '            dt = con.GetSchema("Tables", restrictions)
    '            For i As Integer = 0 To dt.Rows.Count - 1
    '                Tables.Add(dt.Rows(i)(2).ToString)
    '            Next

    '            Return Tables
    '        End Function

    '        Public Shared Sub CreateCBatchCSV(job As String, mdbpath As String, csvPath As String, conn As OleDb.OleDbConnection)
    '            Dim dbCommand As OleDb.OleDbCommand
    '            Dim dbAdapter As OleDb.OleDbDataAdapter
    '            Open(mdbpath, conn)
    '            conn.Open()
    '            dbCommand = New OleDb.OleDbCommand("SELECT * FROM [" & job & "]", conn)
    '            dbAdapter = New OleDb.OleDbDataAdapter
    '            dbAdapter.SelectCommand = dbCommand
    '            Dim dbTable As New DataTable
    '            dbAdapter.Fill(dbTable)

    '            Dim sw As New System.IO.StreamWriter(csvPath)
    '            Dim columnHeaders As New System.Text.StringBuilder
    '            For Each col As DataColumn In dbTable.Columns
    '                If columnHeaders.ToString.Length > 0 Then columnHeaders.Append(",")
    '                columnHeaders.Append("""" & col.ColumnName & """")
    '            Next
    '            sw.WriteLine(columnHeaders.ToString)
    '            Dim dataValues As New System.Text.StringBuilder
    '            For Each row As DataRow In dbTable.Rows
    '                For Each col As DataColumn In dbTable.Columns
    '                    If dataValues.ToString.Length > 0 Then dataValues.Append(",")
    '                    dataValues.Append("""" & row(col.ColumnName).ToString & """")
    '                Next
    '                sw.WriteLine(dataValues.ToString)
    '                dataValues = New System.Text.StringBuilder
    '            Next
    '            sw.Close()
    '            conn.Close()
    '        End Sub
    '    End Class
    '#End Region
 



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
#Region "Batching Template"


#End Region

End Class
