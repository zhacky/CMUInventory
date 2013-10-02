<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWareHouseList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BodegaDataSet = New CMUInventory.bodegaDataSet()
        Me.WareHouseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WareHouseTableAdapter = New CMUInventory.bodegaDataSetTableAdapters.WareHouseTableAdapter()
        Me.TableAdapterManager = New CMUInventory.bodegaDataSetTableAdapters.TableAdapterManager()
        Me.WareHouseDataGridView = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRefreshWareHouseList = New System.Windows.Forms.Button()
        Me.btnAddNewWarehouse = New System.Windows.Forms.Button()
        Me.btnDeleteWarehouse = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEditUpdateWarehouse = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WareHouseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WareHouseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BodegaDataSet
        '
        Me.BodegaDataSet.DataSetName = "bodegaDataSet"
        Me.BodegaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CMUInventory.bodegaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WareHouseTableAdapter = Me.WareHouseTableAdapter
        '
        'WareHouseDataGridView
        '
        Me.WareHouseDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WareHouseDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WareHouseDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.WareHouseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WareHouseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.btnEditUpdateWarehouse})
        Me.WareHouseDataGridView.DataSource = Me.WareHouseBindingSource
        Me.WareHouseDataGridView.Location = New System.Drawing.Point(12, 57)
        Me.WareHouseDataGridView.Name = "WareHouseDataGridView"
        Me.WareHouseDataGridView.RowHeadersVisible = False
        Me.WareHouseDataGridView.Size = New System.Drawing.Size(541, 157)
        Me.WareHouseDataGridView.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.79279!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.20721!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnRefreshWareHouseList, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddNewWarehouse, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDeleteWarehouse, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(246, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(307, 39)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btnRefreshWareHouseList
        '
        Me.btnRefreshWareHouseList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefreshWareHouseList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshWareHouseList.Location = New System.Drawing.Point(10, 8)
        Me.btnRefreshWareHouseList.Name = "btnRefreshWareHouseList"
        Me.btnRefreshWareHouseList.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshWareHouseList.TabIndex = 1
        Me.btnRefreshWareHouseList.Text = "Refresh"
        Me.btnRefreshWareHouseList.UseVisualStyleBackColor = True
        '
        'btnAddNewWarehouse
        '
        Me.btnAddNewWarehouse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddNewWarehouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewWarehouse.Location = New System.Drawing.Point(108, 8)
        Me.btnAddNewWarehouse.Name = "btnAddNewWarehouse"
        Me.btnAddNewWarehouse.Size = New System.Drawing.Size(101, 23)
        Me.btnAddNewWarehouse.TabIndex = 0
        Me.btnAddNewWarehouse.Text = "Add WareHouse"
        Me.btnAddNewWarehouse.UseVisualStyleBackColor = True
        '
        'btnDeleteWarehouse
        '
        Me.btnDeleteWarehouse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteWarehouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteWarehouse.Location = New System.Drawing.Point(227, 8)
        Me.btnDeleteWarehouse.Name = "btnDeleteWarehouse"
        Me.btnDeleteWarehouse.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteWarehouse.TabIndex = 2
        Me.btnDeleteWarehouse.Text = "Delete"
        Me.btnDeleteWarehouse.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WareHouseID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "WareHouseID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WareHouseName"
        Me.DataGridViewTextBoxColumn2.FillWeight = 175.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "WareHouse Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 175
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 175
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'btnEditUpdateWarehouse
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUpdateWarehouse.DefaultCellStyle = DataGridViewCellStyle2
        Me.btnEditUpdateWarehouse.HeaderText = "Edit/Modify"
        Me.btnEditUpdateWarehouse.Name = "btnEditUpdateWarehouse"
        Me.btnEditUpdateWarehouse.Text = "Edit"
        Me.btnEditUpdateWarehouse.UseColumnTextForButtonValue = True
        '
        'frmWareHouseList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 495)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.WareHouseDataGridView)
        Me.Name = "frmWareHouseList"
        Me.Text = "WareHouses"
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WareHouseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WareHouseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BodegaDataSet As CMUInventory.bodegaDataSet
    Friend WithEvents WareHouseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WareHouseTableAdapter As CMUInventory.bodegaDataSetTableAdapters.WareHouseTableAdapter
    Friend WithEvents TableAdapterManager As CMUInventory.bodegaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WareHouseDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnRefreshWareHouseList As System.Windows.Forms.Button
    Friend WithEvents btnAddNewWarehouse As System.Windows.Forms.Button
    Friend WithEvents btnDeleteWarehouse As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEditUpdateWarehouse As System.Windows.Forms.DataGridViewButtonColumn
End Class
