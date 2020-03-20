Namespace _Batching

    Public Class BatchState
        Public Shared Done As String = "DONE"
        Public Shared Started As String = "PROCESSING"
        Public Shared ErrorFound As String = "ERROR"
        Public Shared Extracting As String = "EXTRACTING"
        Public Shared Rebatch As String = "ALREADY BATCHED"
        Public Shared Batching As String = "BATCHING"

        Public Shared Function getState(st As BatchStates) As String
            Select Case st
                Case BatchStates.Batching
                    Return "BATCHING"
                Case BatchStates.Done
                    Return "DONE"
                Case BatchStates.ErrorFound
                    Return "ERROR"
                Case BatchStates.Extracting
                    Return "EXTRACTING"
                Case BatchStates.Rebatch
                    Return "ALREADY BATCHED"
                Case BatchStates.Started
                    Return "PROCESSING"
            End Select
            Return Nothing
        End Function

        Public Enum BatchStates
            Done
            Started
            ErrorFound
            Extracting
            Rebatch
            Batching
        End Enum
    End Class
End Namespace