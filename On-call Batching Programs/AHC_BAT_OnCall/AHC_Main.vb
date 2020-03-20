Imports AutoBatchingLibrary.Automation
Module AHC_Main

    Public args As ArgumentManager
    Public Template As Batching.Template

    Sub Main()
        Try
            args = New ArgumentManager(Environment.GetCommandLineArgs().ToArray)
            With args
                If Not args.Invalid Then
                    args.writeLog(BatchStates.Started)
                    Try

                    Catch ex As Exception
                        args.writeLog(BatchStates.ErrorFound, ex.Message)
                    End Try
                  End If
            End With
        Catch ex As Exception
        End Try
    End Sub


End Module
