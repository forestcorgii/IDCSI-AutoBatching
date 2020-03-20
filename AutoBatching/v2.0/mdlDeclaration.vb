Imports System.ComponentModel
Imports System.Text.RegularExpressions

Module mdlDeclaration

    Public SystemConfig As New clsConfig

    Public Settings_Basis_Fields As String() = New String() {"client", "job", "type", "keystring", "substring", "valid"}
    Public Settings_Basis_Types As String() = New String() {"TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(50)", "TEXT(10)", "YESNO"}
    Public Settings_Basis_TableName As String = "tblSettingsBasis"

    Public Settings_Fields As String() = New String() {"client", "job", "type", "root_path", "target_path", "exe_name", "batch_count", "file_type"}
    Public Settings_Types As String() = New String() {"TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT", "TEXT", "TEXT(100)", "TEXT(100)", "TEXT(100)"}
    Public Settings_TableName As String = "tblSettings"

    'Public Main_MDBName As String = "MasterDatabase"
    'Public Main_Connection As OleDb.OleDbConnection
    Public Logs_MDBName As String = "MasterLog"
    Public Logs_Connection As OleDb.OleDbConnection

    Public Logs_Fields As String() = New String() {"batchfile", "batchfullpath", "client", "job", "type", "starttime", "endtime", "elapsetime", "errorlog"} 'COMPLETE LOGS FIELDS
    Public Logs_Types As String() = New String() {"TEXT(255)", "TEXT", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(255)"}
    Public Logs_TableName As String = "tblLogs"

    Public NextListing As Date

    Public bgBatcher As New List(Of BackgroundWorker)

    Public Cancelled As Boolean

    Public QueueList As List(Of BatchInfo)

    Public DaysToCheck As New List(Of Date)
    Public ListedBatchFiles As New List(Of String)

    Public stateSeparator As New Regex(",,,,")
    Public Const spaceEncryptor As String = "**SPACE**"

    Public StatusDirectory As String = Application.StartupPath & "\DATA\PROCESSES\"
    Public MDBDirectory As String = Application.StartupPath & "\DATA\MDB\"
    Public ExeDirectory As String = Application.StartupPath & "\DATA\EXE\"
    Public SettingDirectory As String = Application.StartupPath & "\DATA\SETTING\"
    Public TemplateDirectory As String = Application.StartupPath & "\DATA\SETTING\Templates\"
    Public Const SettingFileName As String = "Autobatching.setting.xml"
 
End Module
