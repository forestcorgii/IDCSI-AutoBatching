Imports System.Data.OleDb
Imports System.IO

Module MDB
    Public Provider As String = "Provider=Microsoft.JET.OLEDB.4.0;Data Source="
  
#Region "OPEN"
    Public Function mdbOpen(ByVal DatabaseFullPath As String, ByRef con As OleDbConnection) As Boolean
        Try
            con = New System.Data.OleDb.OleDbConnection(Provider & DatabaseFullPath & ";User Id=admin;Password=;")
            Return True
        Catch ex As System.Exception
            con = Nothing
            Return False
        End Try
    End Function
#End Region

#Region "Create"
    Public Sub mdbCreate(ByVal DatabaseFullPath As String)
        Try
            Dim cat As New ADOX.Catalog
            cat.Create(Provider & DatabaseFullPath & ";Jet OLEDB:Engine Type=5")
        Catch Ex As System.Exception
        End Try
    End Sub

    Public Sub mdbCreateTable(ByVal tbl As String, ByVal flds As String(), ByVal con As OleDbConnection)
        Dim qry As String = String.Format("CREATE TABLE {0}(", tbl)
        For Each fld As String In flds
            Dim tmp() As String = fld.Split(Char.Parse("-"))
            If fld = flds(0) Then
                qry &= String.Format("[{0}] {1}", tmp(0), tmp(1))
            Else
                qry &= String.Format(",[{0}] {1}", tmp(0), tmp(1))
            End If
        Next
        qry &= ")"

        executeQRY(qry, con)
    End Sub

    Public Sub mdbCreateTable(ByVal tbl As String, ByVal flds As String(), ByVal tp As String(), ByVal con As OleDbConnection)
        Dim qry As String = String.Format("CREATE TABLE {0}(", tbl)
        For i As Integer = 0 To flds.Length - 1
            If i = 0 Then
                qry &= String.Format("[{0}] {1}", flds(i), tp(i))
            Else
                qry &= String.Format(",[{0}] {1}", flds(i), tp(i))
            End If
        Next
        qry &= ")"

        executeQRY(qry, con)
    End Sub
#End Region

#Region "Convert"
    Public Sub mdbToDT(ByVal qry As String, ByRef dt As System.Data.DataTable, ByVal con As OleDbConnection)
        Try
            dt = New DataTable
            Dim da As New OleDbDataAdapter(qry, con)
            da.Fill(dt)
        Catch
        End Try
    End Sub
#End Region

#Region "Commands"
    Public Sub executeQRY(ByVal Qry As String, ByVal con As OleDbConnection)
        Try
            Dim com As New OleDbCommand(Qry, con)
            If con.State = System.Data.ConnectionState.Closed Then con.Open()
            com.ExecuteNonQuery()
            If con.State = System.Data.ConnectionState.Open Then con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mdbInsert(ByVal tbl As String, ByVal fld As String(), ByVal val As Object(), ByVal con As OleDbConnection)
        Dim qry As String = String.Format("INSERT INTO {0} (", tbl)
        Dim valtype As String = ""

        For Each f As String In fld
            If f = fld(0) Then
                qry &= String.Format("[{0}]", f)
            Else
                qry &= String.Format(",[{0}]", f)
            End If
        Next

        qry &= ") VALUES("

        For Each v As Object In val
            valtype = TypeName(v)
            If v.ToString = val(0).ToString Then
                If valtype = "String" Then
                    qry &= String.Format("'{0}'", v)
                Else
                    qry &= String.Format("{0}", v)
                End If
            Else
                If valtype = "String" Then
                    qry &= String.Format(",'{0}'", v)
                Else
                    qry &= String.Format(",{0}", v)
                End If
            End If
        Next
        qry &= ")"

        executeQRY(qry, con)
    End Sub

    Public Sub mdbUpdate(ByVal tbl As String, ByVal fld As String(), ByVal val As Object(), ByVal condition As Object(), ByVal con As OleDbConnection)
        Dim qry As String = String.Format("UPDATE {0} SET ", tbl)
        Dim valtype As String = ""

        If fld.Length = val.Length Then
            For f As Integer = 0 To fld.GetUpperBound(0)
                valtype = TypeName(val(f))
                If f = 0 Then
                    If valtype = "String" Then
                        qry &= String.Format("[{0}]='{1}'", fld(f), val(f))
                    Else
                        qry &= String.Format("[{0}]={1}", fld(f), val(f))
                    End If
                Else
                    If valtype = "String" Then
                        qry &= String.Format(",[{0}]='{1}'", fld(f), val(f))
                    Else
                        qry &= String.Format(",[{0}]={1}", fld(f), val(f))
                    End If
                End If
            Next
        End If

        If Not condition Is Nothing Then
            If TypeName(condition(1)) = "String" Then
                qry &= String.Format(" WHERE {0} = '{1}'", condition(0), condition(1))
            Else
                qry &= String.Format(" WHERE {0} = {1}", condition(0), condition(1))
            End If
        End If

        executeQRY(qry, con)
    End Sub

    Public Sub mdbUpdate(ByVal tbl As String, ByVal fld As String(), ByVal val As Object(), ByVal condition As String, ByVal con As OleDbConnection)
        Dim qry As String = String.Format("UPDATE {0} SET ", tbl)
        Dim valtype As String = ""

        If fld.Length = val.Length Then
            For f As Integer = 0 To fld.GetUpperBound(0)
                valtype = TypeName(val(f))
                If f = 0 Then
                    If valtype = "String" Then
                        qry &= String.Format("[{0}]='{1}'", fld(f), val(f))
                    Else
                        qry &= String.Format("[{0}]={1}", fld(f), val(f))
                    End If
                Else
                    If valtype = "String" Then
                        qry &= String.Format(",[{0}]='{1}'", fld(f), val(f))
                    Else
                        qry &= String.Format(",[{0}]={1}", fld(f), val(f))
                    End If
                End If
            Next
        End If

        If condition IsNot Nothing Then
            qry &= " " & condition
        End If

        executeQRY(qry, con)
    End Sub
#End Region

#Region "Reader"
    Public Function mdbRead() As OleDbDataReader
      
        Dim qry As String = String.Format("SELECT * FROM {0}", Settings_TableName)
        Dim cmd As New OleDbCommand(qry, Main_Connection)
        Dim reader As OleDbDataReader = Nothing
        Try
            If Main_Connection.State = System.Data.ConnectionState.Closed Then Main_Connection.Open()
            reader = cmd.ExecuteReader()
            '       If Main_Connection.State = System.Data.ConnectionState.Open Then Main_Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
        Return reader
    End Function

    Public Function mdbRead(qry As String) As OleDbDataReader
        Dim cmd As New OleDbCommand(qry, Main_Connection)
        Dim reader As OleDbDataReader = Nothing
        Try
            If Main_Connection.State = System.Data.ConnectionState.Closed Then Main_Connection.Open()
            reader = cmd.ExecuteReader()
            '  If Main_Connection.State = System.Data.ConnectionState.Open Then Main_Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return reader
    End Function

    Public Function mdbRead(qry As String, con As OleDbConnection) As OleDbDataReader
        Dim cmd As New OleDbCommand(qry, con)
        Dim reader As OleDbDataReader = Nothing
        Try
            If con.State = System.Data.ConnectionState.Closed Then con.Open()
            reader = cmd.ExecuteReader()
            '  If con.State = System.Data.ConnectionState.Open Then con.Close()
         Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return reader
    End Function

#End Region
End Module
