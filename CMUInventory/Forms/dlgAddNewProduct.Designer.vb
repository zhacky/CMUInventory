<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAddNewProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim BarcodeLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim AttributesLabel As System.Windows.Forms.Label
        Dim SalePriceLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.btnSaveNewProductAndClose = New System.Windows.Forms.Button()
        Me.BodegaDataSet = New CMUInventory.bodegaDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New CMUInventory.bodegaDataSetTableAdapters.ProductsTableAdapter()
        Me.TableAdapterManager = New CMUInventory.bodegaDataSetTableAdapters.TableAdapterManager()
        Me.BarcodeTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.AttributesTextBox = New System.Windows.Forms.TextBox()
        Me.SalePriceTextBox = New System.Windows.Forms.TextBox()
        Me.btnSaveNewProduct = New System.Windows.Forms.Button()
        Me.erpAddNewProduct = New System.Windows.Forms.ErrorProvider(Me.components)
        BarcodeLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        AttributesLabel = New System.Windows.Forms.Label()
        SalePriceLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpAddNewProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarcodeLabel
        '
        BarcodeLabel.AutoSize = True
        BarcodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarcodeLabel.Location = New System.Drawing.Point(31, 72)
        BarcodeLabel.Name = "BarcodeLabel"
        BarcodeLabel.Size = New System.Drawing.Size(63, 16)
        BarcodeLabel.TabIndex = 2
        BarcodeLabel.Text = "Barcode:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductNameLabel.Location = New System.Drawing.Point(3, 98)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(97, 16)
        ProductNameLabel.TabIndex = 4
        ProductNameLabel.Text = "Product Name:"
        '
        'AttributesLabel
        '
        AttributesLabel.AutoSize = True
        AttributesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AttributesLabel.Location = New System.Drawing.Point(27, 148)
        AttributesLabel.Name = "AttributesLabel"
        AttributesLabel.Size = New System.Drawing.Size(66, 16)
        AttributesLabel.TabIndex = 6
        AttributesLabel.Text = "Attributes:"
        '
        'SalePriceLabel
        '
        SalePriceLabel.AutoSize = True
        SalePriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalePriceLabel.Location = New System.Drawing.Point(23, 207)
        SalePriceLabel.Name = "SalePriceLabel"
        SalePriceLabel.Size = New System.Drawing.Size(73, 16)
        SalePriceLabel.TabIndex = 8
        SalePriceLabel.Text = "Sale Price:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.62882!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.37118!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSaveNewProductAndClose, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(226, 306)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(229, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(155, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 8
        Me.Cancel_Button.Text = "Cancel"
        '
        'btnSaveNewProductAndClose
        '
        Me.btnSaveNewProductAndClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaveNewProductAndClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNewProductAndClose.Location = New System.Drawing.Point(7, 3)
        Me.btnSaveNewProductAndClose.Name = "btnSaveNewProductAndClose"
        Me.btnSaveNewProductAndClose.Size = New System.Drawing.Size(133, 23)
        Me.btnSaveNewProductAndClose.TabIndex = 6
        Me.btnSaveNewProductAndClose.Text = "Save And Close"
        Me.btnSaveNewProductAndClose.UseVisualStyleBackColor = True
        '
        'BodegaDataSet
        '
        Me.BodegaDataSet.DataSetName = "bodegaDataSet"
        Me.BodegaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.BodegaDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.UpdateOrder = CMUInventory.bodegaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WareHouseTableAdapter = Nothing
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeTextBox.Location = New System.Drawing.Point(100, 69)
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.Size = New System.Drawing.Size(292, 22)
        Me.BarcodeTextBox.TabIndex = 1
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(100, 95)
        Me.ProductNameTextBox.Multiline = True
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(292, 44)
        Me.ProductNameTextBox.TabIndex = 2
        '
        'AttributesTextBox
        '
        Me.AttributesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttributesTextBox.Location = New System.Drawing.Point(100, 145)
        Me.AttributesTextBox.Multiline = True
        Me.AttributesTextBox.Name = "AttributesTextBox"
        Me.AttributesTextBox.Size = New System.Drawing.Size(292, 53)
        Me.AttributesTextBox.TabIndex = 3
        '
        'SalePriceTextBox
        '
        Me.SalePriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalePriceTextBox.Location = New System.Drawing.Point(100, 204)
        Me.SalePriceTextBox.Name = "SalePriceTextBox"
        Me.SalePriceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SalePriceTextBox.TabIndex = 4
        Me.SalePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSaveNewProduct
        '
        Me.btnSaveNewProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNewProduct.Location = New System.Drawing.Point(12, 309)
        Me.btnSaveNewProduct.Name = "btnSaveNewProduct"
        Me.btnSaveNewProduct.Size = New System.Drawing.Size(124, 23)
        Me.btnSaveNewProduct.TabIndex = 5
        Me.btnSaveNewProduct.Text = "Save And New"
        Me.btnSaveNewProduct.UseVisualStyleBackColor = True
        '
        'erpAddNewProduct
        '
        Me.erpAddNewProduct.ContainerControl = Me
        '
        'dlgAddNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(467, 347)
        Me.Controls.Add(Me.btnSaveNewProduct)
        Me.Controls.Add(SalePriceLabel)
        Me.Controls.Add(Me.SalePriceTextBox)
        Me.Controls.Add(AttributesLabel)
        Me.Controls.Add(Me.AttributesTextBox)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(BarcodeLabel)
        Me.Controls.Add(Me.BarcodeTextBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAddNewProduct"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Product"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpAddNewProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents BodegaDataSet As CMUInventory.bodegaDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As CMUInventory.bodegaDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TableAdapterManager As CMUInventory.bodegaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BarcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AttributesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveNewProduct As System.Windows.Forms.Button
    Friend WithEvents btnSaveNewProductAndClose As System.Windows.Forms.Button
    Friend WithEvents erpAddNewProduct As System.Windows.Forms.ErrorProvider

End Class
