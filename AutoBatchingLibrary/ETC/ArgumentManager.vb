Imports AutoBatchingLibrary.BatchState
Imports System.IO

Public Class ArgumentManager
    Public RawArgument As String
    Public BatchFile As String
    Public TargetDirectory As String
    Public BatchSize As String
    Public Rebatch As Boolean
    Public StatusFilepath As String
    Public TemplatePath As String
    Public Invalid As Boolean

    Sub New(args As String())
        If args.Length > 1 Then
            Dim info As String() = args(1).Replace(Automation.spaceEncryptor, " ").Split("|")
            RawArgument = args(1)

            BatchFile = info(0)
            TargetDirectory = info(1)
            BatchSize = info(2)
            Rebatch = info(3)
            StatusFilepath = info(4)
            TemplatePath = info(5)
            Invalid = False
        Else : Invalid = True
        End If
    End Sub

    Public Sub writeLog(st As BatchStates, Optional errMsg As String = "")
        Try
            Dim state As String = BatchState.getState(st)
            Dim writer As New StreamWriter(StatusFilepath, False)
            writer.WriteLine(String.Format("{0},,,,{1}", state, errMsg))
            writer.Close()
            Console.WriteLine(state)
        Catch ex As IOException
            Console.WriteLine(ex.Message)
            '  MsgBox(ex.Message)
        End Try
    End Sub
End Class
