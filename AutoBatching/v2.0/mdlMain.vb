Imports System.IO

Module mdlMain

    'Public Function CollectItems(ByRef items As List(Of BatcherInfo)) As Boolean
    '    items = New List(Of BatcherInfo)
    '    Try
    '        Dim reader As OleDb.OleDbDataReader = mdbRead()
    '        While reader.Read
    '            Dim item As New BatcherInfo
    '            With reader
    '                item.Client = .Item("client")
    '                item.Job = .Item("job")
    '                item.Type = .Item("type")
    '                item.TargetLocation = .Item("target_path")
    '                item.SourceLocation = .Item("root_path")
    '                item.ExeLocation = .Item("exe_name")
    '            End With

    '            'Dim basisReader As OleDb.OleDbDataReader = mdbRead(String.Format("SELECT * FROM {0} WHERE client='{1}' AND job='{2}'", _
    '            '                                                                 Settings_Basis_TableName, item.Client, item.Job))
    '            'While basisReader.Read
    '            '    With basisReader
    '            '        Dim basis As New BatchItemBasis1
    '            '        basis.Type = .Item("type")
    '            '        basis.Keystring = .Item("keystring")
    '            '        basis.Substring = .Item("substring")
    '            '        item.Basis.Add(basis)
    '            '    End With
    '            'End While
    '            'basisReader.Close()
    '            items.Add(item)
    '        End While
    '        reader.Close()

    '        If items.Count = 0 Then
    '            MessageBox.Show("Batch Items not Found.")
    '            Return False
    '        End If
    '        Return True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        Return False
    '    Finally
    '        '      If Main_Connection.State = System.Data.ConnectionState.Closed Then Main_Connection.Close()
    '    End Try
    'End Function

    Public Sub DebugMsgbox(msg As String, Optional title As String = "Debugger")
        If My.Settings.computername = My.Computer.Name Then
            MsgBox(msg, MsgBoxStyle.OkOnly, title)
        End If
    End Sub
End Module
