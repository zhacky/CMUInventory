Public Class ViewTransactionType

    Private Sub ViewTransactionType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BodegaDataSet.TransactionType' table. You can move, or remove it, as needed.
        Me.TransactionTypeTableAdapter.Fill(Me.BodegaDataSet.TransactionType)

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.TransactionTypeTableAdapter.Fill(Me.BodegaDataSet.TransactionType)
        dgvTransactionTypes.Refresh()
    End Sub

    Private Sub btnAddTransactionType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTransactionType.Click
        Dim addNewTransType As New dlgAddEditTransactionType
        addNewTransType.ShowDialog()
    End Sub
End Class