Public Class frmAddNewTransaction


#Region "Class Variables"
    Private UseTemplate As Boolean = False
#End Region

    '--                         --

#Region "Initialization"

#End Region

    '--                         --

#Region "Form Events"

    Private Sub chkUseTemplate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseTemplate.CheckedChanged
        If chkUseTemplate.Checked Then
            UseTemplate = True
            cboProductTemplate.Visible = True
            '-
            cboProduct.Visible = False
            lblProductName.Visible = False
            lblTransactCost.Visible = False
            lblTransactQuantity.Visible = False
            txtTransactCost.Visible = False
            txtTransactQuantity.Visible = False

        Else
            UseTemplate = False
            cboProductTemplate.Visible = False
            '-
            cboProduct.Visible = True
            lblProductName.Visible = True
            lblTransactCost.Visible = True
            lblTransactQuantity.Visible = True
            txtTransactCost.Visible = True
            txtTransactQuantity.Visible = True
        End If

    End Sub

#End Region

    '--                         --

#Region "Class Methods"

#End Region

    '--                         --

#Region "Other Codes"

#End Region

    Private Sub frmAddNewTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BodegaDataSet.WareHouse' table. You can move, or remove it, as needed.
        Me.WareHouseTableAdapter.Fill(Me.BodegaDataSet.WareHouse)
        'TODO: This line of code loads data into the 'BodegaDataSet.TransactionType' table. You can move, or remove it, as needed.
        Me.TransactionTypeTableAdapter.Fill(Me.BodegaDataSet.TransactionType)
        'TODO: This line of code loads data into the 'BodegaDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.BodegaDataSet.Products)


    End Sub
End Class