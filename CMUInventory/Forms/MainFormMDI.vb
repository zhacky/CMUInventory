Imports System.Windows.Forms
Imports System.Windows.Forms.Keys

Public Class MainFormMDI
#Region "Old/Default Codes"
    'ToolStripMenuItem1.ShortcutKeys = F6 
    '    tsbProducts.ShortcutKeys = F2

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        'If Form.ActiveForm.ActiveControl.GetType Is GetType(TextBox) Then
        '    My.Computer.Clipboard.SetText(Form.ActiveForm.ActiveControl.Text)
        'End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        If TypeOf (Form.ActiveForm.ActiveControl) Is TextBox Then
            If Form.ActiveForm.ActiveControl.Focused Then
                My.Computer.Clipboard.SetText(Form.ActiveForm.ActiveControl.Text.ToString)
            End If

        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.EasyToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click

    End Sub
#End Region


#Region "Menu Item Clicks"

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        dlgOptions.ShowDialog()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        ShowReportsForm()
    End Sub

    Private Sub tsbProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbProducts.Click
        ShowProductsForm()
    End Sub

    Private Sub ViewWareHousesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewWareHousesToolStripMenuItem.Click
        ShowWareHouseForm()
    End Sub

    Private Sub AddWareHouseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddWareHouseToolStripMenuItem.Click
        Dim addwarehouse As New dlgAddWareHouse
        addwarehouse.ShowDialog()
    End Sub

    Private Sub ProductsF2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsF2ToolStripMenuItem.Click
        ShowProductsForm()
    End Sub

    Private Sub tsbReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbReports.Click
        ShowReportsForm()
    End Sub

    Private Sub ViewTransactionTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTransactionTypesToolStripMenuItem.Click
        ShowTransactionTypeForm()
    End Sub

    Private Sub AddNewTransactionTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewTransactionTypeToolStripMenuItem.Click
        Dim dlgTransType As New dlgAddEditTransactionType
        dlgTransType.ShowDialog()
    End Sub

#End Region

    '-----   MY METHODS     -----
#Region "Methods"


    Private Sub ShowProductsForm()
        If Not ChildrenReachedLimit() Then

                Dim ChildForm As New frmProducts

                ChildForm.MdiParent = Me
                ChildForm.Show()
                ' Make it a child of this MDI form before showing it.
            End If

    End Sub

    Private Sub ShowReportsForm()
        If Not ChildrenReachedLimit() Then

            Dim ChildForm As New frmReports

            ChildForm.MdiParent = Me


            ChildForm.Text = "Reports "

            ChildForm.Show()

        End If
    End Sub

    Private Sub ShowWareHouseForm()
        If Not ChildrenReachedLimit() Then

            Dim ChildForm As New frmWareHouseList

            ChildForm.MdiParent = Me


            ChildForm.Text = "WareHouses "

            ChildForm.Show()

        End If
    End Sub

    Private Function ChildrenReachedLimit() As Boolean
        If Me.HasChildren() Then

            If Me.MdiChildren.Count() > 8 Then

                Return True

            End If
        Else
            Return False
        End If
        Return False
    End Function

    Private Sub ShowTransactionTypeForm()
        If Not ChildrenReachedLimit() Then

            Dim ChildForm As New ViewTransactionType

            ChildForm.MdiParent = Me


            ChildForm.Text = "Transaction Types "

            ChildForm.Show()

        End If
    End Sub

#End Region

    Private Sub AddNewTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewTransactionToolStripMenuItem.Click
        Dim addTransaction As New frmAddNewTransaction
        addTransaction.MdiParent = Me
        addTransaction.Show()
    End Sub
End Class
