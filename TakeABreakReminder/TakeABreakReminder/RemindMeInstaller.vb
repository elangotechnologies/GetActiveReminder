Imports System.ComponentModel
Imports System.Configuration.Install
Imports Microsoft.Win32

Public Class RemindMeInstaller

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add initialization code after the call to InitializeComponent

    End Sub

    Public Overrides Sub Install(ByVal stateSaver As System.Collections.IDictionary)
        MyBase.Install(stateSaver)
        Dim installationPath As String = Context.Parameters.Item("target").ToString()
        installationPath += "RemindMe.exe"

        '' My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("RemindMe", installationPath)
    End Sub

    Public Overrides Sub Commit(ByVal savedState As System.Collections.IDictionary)
        MyBase.Commit(savedState)
    End Sub

    Public Overrides Sub Rollback(ByVal savedState As System.Collections.IDictionary)
        MyBase.Rollback(savedState)
    End Sub

    Public Overrides Sub Uninstall(ByVal savedState As System.Collections.IDictionary)
        MyBase.Uninstall(savedState)
        ''My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("RemindMe", False)
        'Dim key As Microsoft.Win32.RegistryKey
        'key = My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        'If Not (key Is Nothing) Then
        '    key.DeleteValue("RemindMe", False)
        'End If

        'Try
        '    Dim myRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        '    System.Windows.Forms.MessageBox.Show(myRegistryKey.ValueCount().ToString)
        '    If myRegistryKey.GetValue("RemindMe") Is Nothing Then
        '        System.Windows.Forms.MessageBox.Show("RemindMe not found in registry")
        '    Else
        '        System.Windows.Forms.MessageBox.Show("RemindMe found in registry, deleting")
        '        myRegistryKey.DeleteValue("RemindMe", False)
        '    End If
        'Catch ex As Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

End Class
