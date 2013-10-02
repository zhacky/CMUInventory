<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewTransaction
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
        Me.gboTransactionInformation = New System.Windows.Forms.GroupBox()
        Me.gboOrderInfo = New System.Windows.Forms.GroupBox()
        Me.lblTransactQuantity = New System.Windows.Forms.Label()
        Me.cboToWareHouse = New System.Windows.Forms.ComboBox()
        Me.lblTransactCost = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFromWareHouse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTransactCost = New System.Windows.Forms.TextBox()
        Me.txtTransactQuantity = New System.Windows.Forms.TextBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.cboProductTemplate = New System.Windows.Forms.ComboBox()
        Me.cboProduct = New System.Windows.Forms.ComboBox()
        Me.chkUseTemplate = New System.Windows.Forms.CheckBox()
        Me.txtTransactionRemarks = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.lblOrderNo = New System.Windows.Forms.Label()
        Me.lblTransactionDate = New System.Windows.Forms.Label()
        Me.lblTransactionType = New System.Windows.Forms.Label()
        Me.cboTransactionType = New System.Windows.Forms.ComboBox()
        Me.dtpTransactionDate = New System.Windows.Forms.DateTimePicker()
        Me.lblTransactionDetails = New System.Windows.Forms.Label()
        Me.txtTransactionDetails = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAddTransaction = New System.Windows.Forms.Button()
        Me.btnCancelNewTransaction = New System.Windows.Forms.Button()
        Me.dgvTransactionDetails = New System.Windows.Forms.DataGridView()
        Me.BodegaDataSet = New CMUInventory.bodegaDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New CMUInventory.bodegaDataSetTableAdapters.ProductsTableAdapter()
        Me.TransactionTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionTypeTableAdapter = New CMUInventory.bodegaDataSetTableAdapters.TransactionTypeTableAdapter()
        Me.WareHouseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WareHouseTableAdapter = New CMUInventory.bodegaDataSetTableAdapters.WareHouseTableAdapter()
        Me.gboTransactionInformation.SuspendLayout()
        Me.gboOrderInfo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvTransactionDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WareHouseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboTransactionInformation
        '
        Me.gboTransactionInformation.Controls.Add(Me.gboOrderInfo)
        Me.gboTransactionInformation.Controls.Add(Me.lblTransactionDate)
        Me.gboTransactionInformation.Controls.Add(Me.lblTransactionType)
        Me.gboTransactionInformation.Controls.Add(Me.cboTransactionType)
        Me.gboTransactionInformation.Controls.Add(Me.dtpTransactionDate)
        Me.gboTransactionInformation.Controls.Add(Me.lblTransactionDetails)
        Me.gboTransactionInformation.Controls.Add(Me.txtTransactionDetails)
        Me.gboTransactionInformation.Location = New System.Drawing.Point(16, 4)
        Me.gboTransactionInformation.Margin = New System.Windows.Forms.Padding(4)
        Me.gboTransactionInformation.Name = "gboTransactionInformation"
        Me.gboTransactionInformation.Padding = New System.Windows.Forms.Padding(4)
        Me.gboTransactionInformation.Size = New System.Drawing.Size(1040, 339)
        Me.gboTransactionInformation.TabIndex = 0
        Me.gboTransactionInformation.TabStop = False
        Me.gboTransactionInformation.Text = "Transaction Information"
        '
        'gboOrderInfo
        '
        Me.gboOrderInfo.Controls.Add(Me.lblTransactQuantity)
        Me.gboOrderInfo.Controls.Add(Me.cboToWareHouse)
        Me.gboOrderInfo.Controls.Add(Me.lblTransactCost)
        Me.gboOrderInfo.Controls.Add(Me.Label2)
        Me.gboOrderInfo.Controls.Add(Me.cboFromWareHouse)
        Me.gboOrderInfo.Controls.Add(Me.Label1)
        Me.gboOrderInfo.Controls.Add(Me.txtTransactCost)
        Me.gboOrderInfo.Controls.Add(Me.txtTransactQuantity)
        Me.gboOrderInfo.Controls.Add(Me.lblProductName)
        Me.gboOrderInfo.Controls.Add(Me.cboProductTemplate)
        Me.gboOrderInfo.Controls.Add(Me.cboProduct)
        Me.gboOrderInfo.Controls.Add(Me.chkUseTemplate)
        Me.gboOrderInfo.Controls.Add(Me.txtTransactionRemarks)
        Me.gboOrderInfo.Controls.Add(Me.lblRemarks)
        Me.gboOrderInfo.Controls.Add(Me.txtOrderNo)
        Me.gboOrderInfo.Controls.Add(Me.lblOrderNo)
        Me.gboOrderInfo.Location = New System.Drawing.Point(12, 100)
        Me.gboOrderInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.gboOrderInfo.Name = "gboOrderInfo"
        Me.gboOrderInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.gboOrderInfo.Size = New System.Drawing.Size(1020, 225)
        Me.gboOrderInfo.TabIndex = 6
        Me.gboOrderInfo.TabStop = False
        Me.gboOrderInfo.Text = "Product And Order Information"
        '
        'lblTransactQuantity
        '
        Me.lblTransactQuantity.AutoSize = True
        Me.lblTransactQuantity.Location = New System.Drawing.Point(802, 123)
        Me.lblTransactQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransactQuantity.Name = "lblTransactQuantity"
        Me.lblTransactQuantity.Size = New System.Drawing.Size(56, 16)
        Me.lblTransactQuantity.TabIndex = 16
        Me.lblTransactQuantity.Text = "Quantity"
        '
        'cboToWareHouse
        '
        Me.cboToWareHouse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WareHouseBindingSource, "WareHouseName", True))
        Me.cboToWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboToWareHouse.FormattingEnabled = True
        Me.cboToWareHouse.Location = New System.Drawing.Point(140, 156)
        Me.cboToWareHouse.Margin = New System.Windows.Forms.Padding(4)
        Me.cboToWareHouse.Name = "cboToWareHouse"
        Me.cboToWareHouse.Size = New System.Drawing.Size(265, 24)
        Me.cboToWareHouse.TabIndex = 15
        Me.cboToWareHouse.ValueMember = "WareHouseID"
        '
        'lblTransactCost
        '
        Me.lblTransactCost.AutoSize = True
        Me.lblTransactCost.Location = New System.Drawing.Point(485, 123)
        Me.lblTransactCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransactCost.Name = "lblTransactCost"
        Me.lblTransactCost.Size = New System.Drawing.Size(91, 16)
        Me.lblTransactCost.TabIndex = 14
        Me.lblTransactCost.Text = "Transact Cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "To WareHouse:"
        '
        'cboFromWareHouse
        '
        Me.cboFromWareHouse.DataSource = Me.WareHouseBindingSource
        Me.cboFromWareHouse.DisplayMember = "WareHouseName"
        Me.cboFromWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFromWareHouse.FormattingEnabled = True
        Me.cboFromWareHouse.Location = New System.Drawing.Point(140, 120)
        Me.cboFromWareHouse.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFromWareHouse.Name = "cboFromWareHouse"
        Me.cboFromWareHouse.Size = New System.Drawing.Size(265, 24)
        Me.cboFromWareHouse.TabIndex = 11
        Me.cboFromWareHouse.ValueMember = "WareHouseID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "From WareHouse:"
        '
        'txtTransactCost
        '
        Me.txtTransactCost.Location = New System.Drawing.Point(599, 120)
        Me.txtTransactCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactCost.Name = "txtTransactCost"
        Me.txtTransactCost.Size = New System.Drawing.Size(132, 22)
        Me.txtTransactCost.TabIndex = 9
        Me.txtTransactCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTransactQuantity
        '
        Me.txtTransactQuantity.Location = New System.Drawing.Point(878, 120)
        Me.txtTransactQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactQuantity.Name = "txtTransactQuantity"
        Me.txtTransactQuantity.Size = New System.Drawing.Size(132, 22)
        Me.txtTransactQuantity.TabIndex = 8
        Me.txtTransactQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(481, 65)
        Me.lblProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(57, 16)
        Me.lblProductName.TabIndex = 7
        Me.lblProductName.Text = "Product:"
        '
        'cboProductTemplate
        '
        Me.cboProductTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductTemplate.FormattingEnabled = True
        Me.cboProductTemplate.Location = New System.Drawing.Point(613, 26)
        Me.cboProductTemplate.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProductTemplate.Name = "cboProductTemplate"
        Me.cboProductTemplate.Size = New System.Drawing.Size(397, 24)
        Me.cboProductTemplate.TabIndex = 6
        Me.cboProductTemplate.Visible = False
        '
        'cboProduct
        '
        Me.cboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ProductName", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.cboProduct.DataSource = Me.ProductsBindingSource
        Me.cboProduct.DisplayMember = "ProductName"
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Location = New System.Drawing.Point(485, 90)
        Me.cboProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(525, 24)
        Me.cboProduct.TabIndex = 5
        Me.cboProduct.ValueMember = "ProductID"
        '
        'chkUseTemplate
        '
        Me.chkUseTemplate.AutoSize = True
        Me.chkUseTemplate.Location = New System.Drawing.Point(455, 30)
        Me.chkUseTemplate.Margin = New System.Windows.Forms.Padding(4)
        Me.chkUseTemplate.Name = "chkUseTemplate"
        Me.chkUseTemplate.Size = New System.Drawing.Size(113, 20)
        Me.chkUseTemplate.TabIndex = 4
        Me.chkUseTemplate.Text = "Use Template"
        Me.chkUseTemplate.UseVisualStyleBackColor = True
        '
        'txtTransactionRemarks
        '
        Me.txtTransactionRemarks.Location = New System.Drawing.Point(140, 59)
        Me.txtTransactionRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionRemarks.Multiline = True
        Me.txtTransactionRemarks.Name = "txtTransactionRemarks"
        Me.txtTransactionRemarks.Size = New System.Drawing.Size(265, 53)
        Me.txtTransactionRemarks.TabIndex = 3
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(8, 65)
        Me.lblRemarks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(66, 16)
        Me.lblRemarks.TabIndex = 2
        Me.lblRemarks.Text = "Remarks:"
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(140, 26)
        Me.txtOrderNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(265, 22)
        Me.txtOrderNo.TabIndex = 1
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Location = New System.Drawing.Point(8, 31)
        Me.lblOrderNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(66, 16)
        Me.lblOrderNo.TabIndex = 0
        Me.lblOrderNo.Text = "Order No."
        '
        'lblTransactionDate
        '
        Me.lblTransactionDate.AutoSize = True
        Me.lblTransactionDate.Location = New System.Drawing.Point(8, 71)
        Me.lblTransactionDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransactionDate.Name = "lblTransactionDate"
        Me.lblTransactionDate.Size = New System.Drawing.Size(114, 16)
        Me.lblTransactionDate.TabIndex = 5
        Me.lblTransactionDate.Text = "Transaction Date:"
        '
        'lblTransactionType
        '
        Me.lblTransactionType.AutoSize = True
        Me.lblTransactionType.Location = New System.Drawing.Point(493, 71)
        Me.lblTransactionType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransactionType.Name = "lblTransactionType"
        Me.lblTransactionType.Size = New System.Drawing.Size(117, 16)
        Me.lblTransactionType.TabIndex = 4
        Me.lblTransactionType.Text = "Transaction Type:"
        '
        'cboTransactionType
        '
        Me.cboTransactionType.DataSource = Me.TransactionTypeBindingSource
        Me.cboTransactionType.DisplayMember = "TransactionType"
        Me.cboTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionType.FormattingEnabled = True
        Me.cboTransactionType.Location = New System.Drawing.Point(625, 68)
        Me.cboTransactionType.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTransactionType.Name = "cboTransactionType"
        Me.cboTransactionType.Size = New System.Drawing.Size(405, 24)
        Me.cboTransactionType.TabIndex = 3
        Me.cboTransactionType.ValueMember = "TransactionTypeID"
        '
        'dtpTransactionDate
        '
        Me.dtpTransactionDate.Location = New System.Drawing.Point(152, 68)
        Me.dtpTransactionDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTransactionDate.Name = "dtpTransactionDate"
        Me.dtpTransactionDate.Size = New System.Drawing.Size(265, 22)
        Me.dtpTransactionDate.TabIndex = 2
        '
        'lblTransactionDetails
        '
        Me.lblTransactionDetails.AutoSize = True
        Me.lblTransactionDetails.Location = New System.Drawing.Point(8, 19)
        Me.lblTransactionDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransactionDetails.Name = "lblTransactionDetails"
        Me.lblTransactionDetails.Size = New System.Drawing.Size(124, 16)
        Me.lblTransactionDetails.TabIndex = 1
        Me.lblTransactionDetails.Text = "Transaction Details"
        '
        'txtTransactionDetails
        '
        Me.txtTransactionDetails.Location = New System.Drawing.Point(11, 39)
        Me.txtTransactionDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionDetails.Name = "txtTransactionDetails"
        Me.txtTransactionDetails.Size = New System.Drawing.Size(1019, 22)
        Me.txtTransactionDetails.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddTransaction, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancelNewTransaction, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(796, 565)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(250, 45)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnAddTransaction
        '
        Me.btnAddTransaction.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddTransaction.Location = New System.Drawing.Point(12, 8)
        Me.btnAddTransaction.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddTransaction.Name = "btnAddTransaction"
        Me.btnAddTransaction.Size = New System.Drawing.Size(100, 28)
        Me.btnAddTransaction.TabIndex = 0
        Me.btnAddTransaction.Text = "Add"
        Me.btnAddTransaction.UseVisualStyleBackColor = True
        '
        'btnCancelNewTransaction
        '
        Me.btnCancelNewTransaction.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelNewTransaction.Location = New System.Drawing.Point(137, 8)
        Me.btnCancelNewTransaction.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelNewTransaction.Name = "btnCancelNewTransaction"
        Me.btnCancelNewTransaction.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelNewTransaction.TabIndex = 1
        Me.btnCancelNewTransaction.Text = "New"
        Me.btnCancelNewTransaction.UseVisualStyleBackColor = True
        '
        'dgvTransactionDetails
        '
        Me.dgvTransactionDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactionDetails.Location = New System.Drawing.Point(16, 350)
        Me.dgvTransactionDetails.Name = "dgvTransactionDetails"
        Me.dgvTransactionDetails.Size = New System.Drawing.Size(1040, 208)
        Me.dgvTransactionDetails.TabIndex = 2
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
        'TransactionTypeBindingSource
        '
        Me.TransactionTypeBindingSource.DataMember = "TransactionType"
        Me.TransactionTypeBindingSource.DataSource = Me.BodegaDataSet
        '
        'TransactionTypeTableAdapter
        '
        Me.TransactionTypeTableAdapter.ClearBeforeFill = True
        '
        'WareHouseBindingSource
        '
        Me.WareHouseBindingSource.DataMember = "WareHouse"
        Me.WareHouseBindingSource.DataSource = Me.BodegaDataSet
        '
        'WareHouseTableAdapter
        '
        Me.WareHouseTableAdapter.ClearBeforeFill = True
        '
        'frmAddNewTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 625)
        Me.Controls.Add(Me.dgvTransactionDetails)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.gboTransactionInformation)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddNewTransaction"
        Me.Text = "New Transaction"
        Me.gboTransactionInformation.ResumeLayout(False)
        Me.gboTransactionInformation.PerformLayout()
        Me.gboOrderInfo.ResumeLayout(False)
        Me.gboOrderInfo.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvTransactionDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WareHouseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboTransactionInformation As System.Windows.Forms.GroupBox
    Friend WithEvents txtTransactionDetails As System.Windows.Forms.TextBox
    Friend WithEvents lblTransactionDetails As System.Windows.Forms.Label
    Friend WithEvents gboOrderInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtTransactionRemarks As System.Windows.Forms.TextBox
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents txtOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents lblOrderNo As System.Windows.Forms.Label
    Friend WithEvents lblTransactionDate As System.Windows.Forms.Label
    Friend WithEvents lblTransactionType As System.Windows.Forms.Label
    Friend WithEvents cboTransactionType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTransactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkUseTemplate As System.Windows.Forms.CheckBox
    Friend WithEvents lblTransactQuantity As System.Windows.Forms.Label
    Friend WithEvents cboToWareHouse As System.Windows.Forms.ComboBox
    Friend WithEvents lblTransactCost As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboFromWareHouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTransactCost As System.Windows.Forms.TextBox
    Friend WithEvents txtTransactQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents cboProductTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents cboProduct As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAddTransaction As System.Windows.Forms.Button
    Friend WithEvents btnCancelNewTransaction As System.Windows.Forms.Button
    Friend WithEvents dgvTransactionDetails As System.Windows.Forms.DataGridView
    Friend WithEvents BodegaDataSet As CMUInventory.bodegaDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As CMUInventory.bodegaDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TransactionTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionTypeTableAdapter As CMUInventory.bodegaDataSetTableAdapters.TransactionTypeTableAdapter
    Friend WithEvents WareHouseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WareHouseTableAdapter As CMUInventory.bodegaDataSetTableAdapters.WareHouseTableAdapter
End Class
