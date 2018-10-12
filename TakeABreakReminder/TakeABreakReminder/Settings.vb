Imports Microsoft.Win32

Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkStartOnBoot.Checked = My.Settings.start_at_windows_boot
        chkNotifyOnMinimize.Checked = My.Settings.notify_on_minimize_to_tray
        radMinimizeOnClose.Checked = My.Settings.minimize_on_close
        radExitOnClose.Checked = Not My.Settings.minimize_on_close
        chkConfirmDeletion.Checked = My.Settings.confirm_before_delete
    End Sub

    Private Sub chkStartOnBoot_CheckedChanged(sender As Object, e As EventArgs) Handles chkStartOnBoot.CheckedChanged
        My.Settings.start_at_windows_boot = chkStartOnBoot.Checked
        Dim registryKey As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        If chkStartOnBoot.Checked = True Then
            registryKey.SetValue(Application.ProductName, Application.ExecutablePath + " arg1")
        Else
            registryKey.DeleteValue(Application.ProductName, False)
        End If
        My.Settings.Save()
    End Sub

    Private Sub chkNotifyOnMinimize_CheckedChanged(sender As Object, e As EventArgs) Handles chkNotifyOnMinimize.CheckedChanged
        My.Settings.notify_on_minimize_to_tray = chkNotifyOnMinimize.Checked
        My.Settings.Save()
    End Sub

    Private Sub radMinimizeOnClose_CheckedChanged(sender As Object, e As EventArgs) Handles radMinimizeOnClose.CheckedChanged
        If radMinimizeOnClose.Checked = True Then
            My.Settings.minimize_on_close = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub radExitOnClose_CheckedChanged(sender As Object, e As EventArgs) Handles radExitOnClose.CheckedChanged
        If radExitOnClose.Checked = True Then
            My.Settings.minimize_on_close = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkConfirmDeletion_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfirmDeletion.CheckedChanged
        My.Settings.confirm_before_delete = chkConfirmDeletion.Checked
        My.Settings.Save()
    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class