Public Class Shortcuts

    Private gShortcutKeysTable As New DataTable 
    Private gShortcutKeysList As New List(Of ShortcutKey)

    Private Sub Shortcuts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        defineKeys()
        CreateTable()
        populateTable()
    End Sub

    Private Sub CreateTable()
        gShortcutKeysTable.Columns.AddRange(New DataColumn(2) _
                {New DataColumn("shortcut_key", GetType(String)),
                New DataColumn("shortcut_function", GetType(String)),
                New DataColumn("shortcut_description", GetType(String))})
    End Sub

    Class ShortcutKey
        Public mKey As String
        Public mFunction As String
        Public mDescription As String

        Public Sub New(mKey As String, mFunction As String, mDescription As String)
            Me.mKey = mKey
            Me.mFunction = mFunction
            Me.mDescription = mDescription
        End Sub
    End Class

    Private Sub defineKeys()
        gShortcutKeysList.Add(New ShortcutKey("Ctrl+N", "New", "Create a new reminder."))
        gShortcutKeysList.Add(New ShortcutKey("Ctrl+E", "Edit", "Edit the selected reminder."))
        gShortcutKeysList.Add(New ShortcutKey("Enter", "Confirm", "Confrim the changes of 'Add' or 'Edit' operations if the changes are in progress."))
        gShortcutKeysList.Add(New ShortcutKey("Esc", "Cancel", "Cancel the changes of 'Add' or 'Edit' operations if the changes are in progress. Same key is used close opened dialogs also."))
        gShortcutKeysList.Add(New ShortcutKey("Ctrl+L", "Clone", "Clone (make exact copy of) the selected reminder."))
        gShortcutKeysList.Add(New ShortcutKey("Ctrl+D", "Delete", "Delete the selected reminder."))
        gShortcutKeysList.Add(New ShortcutKey("Ctrl+C", "Clear", "Reset the screen completely."))
        gShortcutKeysList.Add(New ShortcutKey("Ctrl+R", "Start", "Start running the selected reminder."))
        gShortcutKeysList.Add(New ShortcutKey("Ctrl+Z", "Stop", "Stop the selected running reminder."))
        gShortcutKeysList.Add(New ShortcutKey("Ctrl+T", "Focus Reminders", "Set the focus to reminder table. To select reminders using UP and DOWN arrow keys."))
    End Sub

    Private Sub populateTable()
        For Each shortcutKey As ShortcutKey In gShortcutKeysList
            Dim shortcutKeyRow As DataRow = gShortcutKeysTable.NewRow
            shortcutKeyRow("shortcut_key") = shortcutKey.mKey
            shortcutKeyRow("shortcut_function") = shortcutKey.mFunction
            shortcutKeyRow("shortcut_description") = shortcutKey.mDescription
            gShortcutKeysTable.Rows.Add(shortcutKeyRow)
        Next

        setDataGrid(dgShortcutKeys, gShortcutKeysTable)
    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub


End Class