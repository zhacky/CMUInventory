Public Class frmWareHouseList
#Region "Loading..."

    Private Sub frmWareHouseList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BodegaDataSet.WareHouse' table. You can move, or remove it, as needed.
        Me.WareHouseTableAdapter.Fill(Me.BodegaDataSet.WareHouse)

    End Sub

#End Region

#Region "Form Events"

    Private Sub WareHouseBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.WareHouseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub btnAddNewWarehouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewWarehouse.Click
        Dim addwarehouse As New dlgAddWareHouse
        addwarehouse.ShowDialog()
    End Sub

    Private Sub WareHouseDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles WareHouseDataGridView.CellContentClick
        If WareHouseDataGridView.Rows(e.RowIndex).IsNewRow Then
            Exit Sub
        End If
        If (e.RowIndex >= 0 And WareHouseDataGridView.Columns(e.ColumnIndex).Name = "btnEditUpdateWarehouse") Then
            Dim drv As DataRowView = WareHouseDataGridView.Rows(e.RowIndex).DataBoundItem
            Dim editWareHouse As New dlgAddWareHouse(Convert.ToInt32(drv.Row("WareHouseID")))
            If (editWareHouse.ShowDialog = System.Windows.Forms.DialogResult.OK) Then
                Me.WareHouseTableAdapter.Fill(Me.BodegaDataSet.WareHouse)
            End If
        End If

    End Sub

    Private Sub btnRefreshWareHouseList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshWareHouseList.Click
        Me.WareHouseTableAdapter.Fill(Me.BodegaDataSet.WareHouse)
        WareHouseDataGridView.Refresh()
    End Sub

#End Region

End Class