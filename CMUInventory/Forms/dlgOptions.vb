Imports System.Windows.Forms

Public Class dlgOptions

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        AppInit.Default.DbServer = txtServer.Text.Trim
        AppInit.Default.DbUsername = txtDbUsername.Text.Trim
        AppInit.Default.DbPassword = txtDbPassword.Text.Trim
        AppInit.Default.DbDatabase = txtDatabase.Text.Trim
        AppInit.Default.Save()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnDatabaseSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPgConfiguration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPgConfiguration.Click
        
    End Sub

    Private Sub btnTestConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestConnection.Click
        DatabaseModule.SetAndTestDb(txtServer.Text.Trim, txtDbUsername.Text.Trim, txtDbPassword.Text.Trim, txtDatabase.Text.Trim)
    End Sub

    Private Sub dlgOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDbConfig()
    End Sub

    Private Sub LoadDbConfig()
        txtServer.Text = AppInit.Default.DbServer
        txtDbUsername.Text = AppInit.Default.DbUsername
        txtDbPassword.Text = AppInit.Default.DbPassword
        txtDatabase.Text = AppInit.Default.DbDatabase
    End Sub

End Class
