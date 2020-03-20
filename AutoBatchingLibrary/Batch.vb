Imports System.Text.RegularExpressions
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.IO
Imports AutoBatchingLibrary.Automation
Imports System.Xml.Serialization

Public Class Batch
    Public Shared SystemConfig As New clsConfig

     Public Shared Logs_MDBName As String = "MasterLog"
    Public Shared Logs_Connection As OleDb.OleDbConnection

    Public Shared Logs_Fields As String() = New String() {"batchfile", "batchfullpath", "client", "job", "type", "starttime", "endtime", "elapsetime", "errorlog"} 'COMPLETE LOGS FIELDS
    Public Shared Logs_Types As String() = New String() {"TEXT(255)", "TEXT", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(100)", "TEXT(255)"}
    Public Shared Logs_TableName As String = "tblLogs"

    Public Shared NextListing As Date

    Public Shared bgBatcher As New List(Of BackgroundWorker)

    Public Shared Cancelled As Boolean

    Public Shared QueueList As List(Of BatchInfo)

    Public Shared DaysToCheck As New List(Of Date)
    Public Shared ListedBatchFiles As New List(Of String)

  
 

End Class
