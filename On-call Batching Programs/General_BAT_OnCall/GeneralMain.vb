Imports AutoBatchingLibrary.Automation
Module GeneralMain

    Public args As TemplateArgumentManager
    Public Processor As BatchingProcessor

    Sub Main()
        Try '"E:\AutoBatching\Root\0000_29052018\tmp\F36900001K.zip|C:\Users\soft026\Desktop\Templates\Bounty-PP-PP369.template.xml|E:\Sean**SPACE**Ivan\PROGRAMS\AutoBatchingSolution\AutoBatching\v2.0\bin\Debug\DATA\PROCESSES\F36900001K_30_162938.status"
            Dim argument As New List(Of String)
            argument.AddRange(Environment.GetCommandLineArgs)
            argument.Add("E:\AutoBatching\Root\0000_29052018\tmp\F37000000A.zip|C:\Users\soft026\Desktop\Templates\Bounty-PP-PP370.template.xml|E:\Sean**SPACE**Ivan\PROGRAMS\AutoBatchingSolution\AutoBatching\v2.0\bin\Debug\DATA\PROCESSES\F37000000A_30_164251.status")
            args = New TemplateArgumentManager(argument.ToArray)
            With args
                If Not args.Invalid Then
                    args.writeLog(BatchStates.Started)
                    Try
                        If IO.File.Exists(args.TemplatePath) Then
                            Processor = New BatchingProcessor(args.BatchFile, Batching.Template.ReadFromFile(args.TemplatePath), args)
                            If Processor.Execute() Then
                                args.writeLog(BatchStates.Done)
                            End If
                        End If
                    Catch ex As Exception
                        args.writeLog(BatchStates.ErrorFound, ex.Message)
                    End Try
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub setup()

    End Sub
End Module
