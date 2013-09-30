Imports System.Windows.Forms

Public Class dlgAddNewProduct
#Region "Fields"
    Private ProductID As Integer = 0
    Private IsUpdateMode As Boolean = False
    Dim taProducts As New bodegaDataSetTableAdapters.ProductsTableAdapter
    Dim trProductRow As bodegaDataSet.ProductsRow

#End Region

#Region "Initialization"


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ProductID = 0
        IsUpdateMode = False

    End Sub
    Sub New(ByVal iProductID As Integer)
        InitializeComponent()
        ProductID = iProductID
        IsUpdateMode = True

        Dim dt As bodegaDataSet.ProductsDataTable = taProducts.GetProductByID(ProductID)
        If (dt.Rows.Count > 0) Then
            trProductRow = CType(dt.Rows(0), bodegaDataSet.ProductsRow)
        End If

    End Sub
    Private Sub dlgAddNewProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (IsUpdateMode) Then
            Me.Text = "Update Product"
            btnSaveNewProduct.Visible = False
            btnSaveNewProductAndClose.Text = "&Update"

            BarcodeTextBox.DataBindings.Add("Text", trProductRow, "Barcode")
            ProductNameTextBox.DataBindings.Add("Text", trProductRow, "ProductName")
            AttributesTextBox.DataBindings.Add("Text", trProductRow, "Attributes")
            SalePriceTextBox.DataBindings.Add("Text", trProductRow, "SalePrice")
        Else
            Me.Text = "Add New Product"


        End If
        ProductNameTextBox.Focus()
    End Sub
#End Region

#Region "Button Clicks"
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub ProductsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)
    End Sub
    Private Sub btnSaveNewProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNewProduct.Click

        If (SaveProduct()) Then
            ResetForm()
        End If

    End Sub

    Private Sub btnSaveNewProductAndClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNewProductAndClose.Click
        If (SaveProduct()) Then
           
            Me.Close()
        End If
    End Sub
#End Region

#Region "Helper Methods"

    Private Function SaveProduct() As Boolean

        Try
            TrimTextBoxes()
            If IsProductValid() Then
                Dim dSalePrice As Decimal = 0
                If Not SalePriceTextBox.Text = String.Empty Then
                    dSalePrice = Decimal.Parse(SalePriceTextBox.Text)
                End If
                If IsUpdateMode Then
                    If taProducts.Update(trProductRow) > 0 Then
                        MessageBox.Show("Product updated successfully", "Product Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return True
                    Else
                        MessageBox.Show("Product update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                Else
                    If (taProducts.Insert(BarcodeTextBox.Text, ProductNameTextBox.Text, AttributesTextBox.Text, dSalePrice)) > 0 Then
                        MessageBox.Show("Product inserted successfully", "Product Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return True
                    Else
                        MessageBox.Show("Product insertion failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Product insertion failed due to the following error: " & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try



    End Function

    Private Sub ClearTextBoxes()
        BarcodeTextBox.Text = String.Empty
        ProductNameTextBox.Text = String.Empty
        AttributesTextBox.Text = String.Empty
        SalePriceTextBox.Text = String.Empty
    End Sub

    Private Sub TrimTextBoxes()
        ProductNameTextBox.Text = ProductNameTextBox.Text.Trim
        BarcodeTextBox.Text = BarcodeTextBox.Text.Trim
        AttributesTextBox.Text = AttributesTextBox.Text.Trim
        SalePriceTextBox.Text = SalePriceTextBox.Text.Trim
    End Sub

    Private Sub ResetForm()
        BarcodeTextBox.Text = ""
        ProductNameTextBox.Text = ""
        AttributesTextBox.Text = ""
        SalePriceTextBox.Text = ""
    End Sub

    Private Function IsProductValid() As Boolean

     
        If BarcodeTextBox.Text = String.Empty Or IsDBNull(BarcodeTextBox.Text) Then
            erpAddNewProduct.SetError(BarcodeTextBox, "Required")
            Return False
        ElseIf (BarcodeTextBox.Text.Length > 20) Then
            erpAddNewProduct.SetError(BarcodeTextBox, "Cannot be more than 20 characters")
            Return False
        ElseIf BarcodeTextBox.Text.Length < 4 Then
            erpAddNewProduct.SetError(BarcodeTextBox, "At least 4 Characters is required")
        ElseIf ProductNameTextBox.Text = String.Empty Or IsDBNull(ProductNameTextBox.Text) Then
            erpAddNewProduct.SetError(ProductNameTextBox, "Required")
            Return False
        ElseIf (ProductNameTextBox.Text.Length > 150) Then
            erpAddNewProduct.SetError(ProductNameTextBox, "Cannot be more than 100 characters")
            Return False
        ElseIf (AttributesTextBox.Text.Length > 50) Then
            erpAddNewProduct.SetError(AttributesTextBox, "Cannot be more than 50 characters")
            Return False
        End If

        '--  handle the sale price textbox   --
        Dim testDecimal As Decimal
        If Not (SalePriceTextBox.Text = String.Empty) Then
            If (Decimal.TryParse(SalePriceTextBox.Text, testDecimal)) Then
                If testDecimal <= 0 Then
                    erpAddNewProduct.SetError(SalePriceTextBox, "Sale Price cannot be zero or negative")
                    Return False
                End If
            Else
                erpAddNewProduct.SetError(SalePriceTextBox, "Please enter a valid sale price")
                Return False
            End If
        End If

        Return True
    End Function

#End Region
End Class
