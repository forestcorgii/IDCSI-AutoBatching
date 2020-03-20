Imports AutoBatchingLibrary.BatchState
Imports System.IO

Public Class TemplateArgumentManager
    Public RawArgument As String
    Public BatchFile As String
    Public StatusFilepath As String
    Public TemplatePath As String
    Public Invalid As Boolean

    Sub New()

    End Sub

    Sub New(args As String())
        If args.Length > 1 Then
            Dim info As String() = args(1).Replace(Automation.spaceEncryptor, " ").Split("|")
            RawArgument = args(1)

            BatchFile = info(0)
            TemplatePath = info(1)
            StatusFilepath = info(2)
            Invalid = False
        Else : Invalid = True
        End If
    End Sub

    Public Sub writeLog(st As BatchStates, Optional errMsg As String = "")
        Try
            If Not StatusFilepath = "" Then
                Dim state As String = BatchState.getState(st)
                Dim writer As New StreamWriter(StatusFilepath, False)
                writer.WriteLine(String.Format("{0},,,,{1}", state, errMsg))
                writer.Close()
                Console.WriteLine(state)
            End If
        Catch ex As IOException
            Console.WriteLine(ex.Message)
            '  MsgBox(ex.Message)
        End Try
    End Sub

End Class
