Public Class frmProducts

#Region "Initialization"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Global Variables"
    
#End Region

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BodegaDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.BodegaDataSet.Products)

    End Sub

#End Region

#Region "Form Events"

    Private Sub btnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProduct.Click
        Dim addnewproduct As New dlgAddNewProduct()
        addnewproduct.ShowDialog()
    End Sub

    Private Sub ProductsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductsDataGridView.CellContentClick
        If (e.RowIndex >= 0 And ProductsDataGridView.Columns(e.ColumnIndex).Name = "btnEditUpdate") Then
            Dim drv As DataRowView = ProductsDataGridView.Rows(e.RowIndex).DataBoundItem
            Dim editProduct As New dlgAddNewProduct(Convert.ToInt32(drv.Row("ProductID")))
            If (editProduct.ShowDialog = System.Windows.Forms.DialogResult.OK) Then
                Me.ProductsTableAdapter.FillActiveProducts(Me.BodegaDataSet.Products)
            End If
        End If
    End Sub

    Private Sub ProductsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub btnDeleteProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteProduct.Click
        Dim selectedItemRow As Integer
        selectedItemRow = ProductsDataGridView.CurrentRow.Index
        Console.WriteLine("selected row is: " & selectedItemRow.ToString)
        If selectedItemRow >= 0 Then
            If MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim drv As DataRowView = CType(ProductsDataGridView.Rows(selectedItemRow).DataBoundItem, DataRowView)
                Dim dr As DataRow = CType(drv.Row, DataRow)
                Dim tr As bodegaDataSet.ProductsRow = CType(dr, bodegaDataSet.ProductsRow)
                Me.ProductsTableAdapter.Delete(tr.ProductID)
                tr.Delete()
                ProductsDataGridView.Refresh()
            End If
        End If
    End Sub
#End Region

#Region "DataGrid View Update"
    
#End Region

   
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.ProductsTableAdapter.Fill(Me.BodegaDataSet.Products)
        Me.ProductsDataGridView.Refresh()
    End Sub
End Class