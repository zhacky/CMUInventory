Public Class frmDbSettings



    Private Sub btnDbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDbCancel.Click
        Me.Close()
    End Sub

    Private Sub cboDbServer_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDbServer.DropDown
        cboDbServer.Items.Clear()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim svrTable As DataTable = Sql.SqlDataSourceEnumerator.Instance.GetDataSources

        Try
            For Each dtrow As DataRow In svrTable.Rows
                Console.WriteLine(dtrow(0).ToString & " - " & dtrow(1).ToString)
                If Not cboDbServer.Items.Contains(dtrow(0).ToString) Then
                    cboDbServer.Items.Add(dtrow(0).ToString)
                End If
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub cboDatabase_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDatabase.DropDown
        'SetAndTestDb(cboDbServer.Text, txtDbUsername.Text, txtDbPassword.Text, cboDatabase.Text)
        AppInit.Default.DbServer = cboDbServer.Text
        AppInit.Default.DbUsername = txtDbUsername.Text
        AppInit.Default.DbPassword = txtDbPassword.Text
        AppInit.Default.Save()

        cboDatabase.Items.Clear()
        Dim DatabaseList() As String = Nothing

        Try
            Dim DbLongList As String = DatabaseModule.GetDatabaseList()
            DatabaseList = Split(DbLongList, "/")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
        If DatabaseList Is Nothing Then
            DatabaseList = {""}
        End If



        cboDatabase.Items.AddRange(DatabaseList)
    End Sub

    Private Sub btnTestConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestConnection.Click

        DatabaseModule.SetAndTestDb(cboDbServer.Text, txtDbUsername.Text, txtDbPassword.Text, cboDatabase.Text)

    End Sub

    Private Sub btnDbOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDbOk.Click
        AppInit.Default.DbServer = cboDbServer.Text
        AppInit.Default.DbUsername = txtDbUsername.Text
        AppInit.Default.DbPassword = txtDbPassword.Text
        AppInit.Default.DbDatabase = cboDatabase.Text
        AppInit.Default.Save()

        MainFormMDI.Show()
        Me.Close()
    End Sub

    Private Sub frmDbSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboDbServer.Text = AppInit.Default.DbServer
        txtDbUsername.Text = AppInit.Default.DbUsername
        txtDbPassword.Text = AppInit.Default.DbPassword
        cboDatabase.Text = AppInit.Default.DbDatabase
        If DatabaseModule.SetAndTestDb() Then
            MainFormMDI.Show()
            Me.Close()

        End If

    End Sub

    Private Sub btnDbApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDbApply.Click
        AppInit.Default.DbServer = cboDbServer.Text
        AppInit.Default.DbUsername = txtDbUsername.Text
        AppInit.Default.DbPassword = txtDbPassword.Text
        AppInit.Default.DbDatabase = cboDatabase.Text
        AppInit.Default.Save()

    End Sub
End Class
