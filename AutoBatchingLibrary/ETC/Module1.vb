Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace _Batching
    Module Module1
        Public StatusDirectory As String = Application.StartupPath & "\DATA\PROCESSES\"
        Public MDBDirectory As String = Application.StartupPath & "\DATA\MDB\"
        Public ExeDirectory As String = Application.StartupPath & "\DATA\EXE\"
        Public SettingDirectory As String = Application.StartupPath & "\DATA\SETTING\"
        Public TemplateDirectory As String = Application.StartupPath & "\DATA\SETTING\Templates\"
        Public Const SettingFileName As String = "Autobatching.setting.xml"
    End Module
End Namespace
