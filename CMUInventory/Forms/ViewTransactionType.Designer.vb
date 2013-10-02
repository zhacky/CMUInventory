<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTransactionType
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvTransactionTypes = New System.Windows.Forms.DataGridView()
        Me.TransactionTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEditUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TransactionTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BodegaDataSet = New CMUInventory.bodegaDataSet()
        Me.TransactionTypeTableAdapter = New CMUInventory.bodegaDataSetTableAdapters.TransactionTypeTableAdapter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAddTransactionType = New System.Windows.Forms.Button()
        CType(Me.dgvTransactionTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTransactionTypes
        '
        Me.dgvTransactionTypes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransactionTypes.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactionTypes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransactionTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactionTypes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionTypeIDDataGridViewTextBoxColumn, Me.TransactionTypeDataGridViewTextBoxColumn, Me.ActionTypeDataGridViewTextBoxColumn, Me.btnEditUpdate})
        Me.dgvTransactionTypes.DataSource = Me.TransactionTypeBindingSource
        Me.dgvTransactionTypes.Location = New System.Drawing.Point(12, 59)
        Me.dgvTransactionTypes.Name = "dgvTransactionTypes"
        Me.dgvTransactionTypes.RowHeadersVisible = False
        Me.dgvTransactionTypes.Size = New System.Drawing.Size(690, 247)
        Me.dgvTransactionTypes.TabIndex = 0
        '
        'TransactionTypeIDDataGridViewTextBoxColumn
        '
        Me.TransactionTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeID"
        Me.TransactionTypeIDDataGridViewTextBoxColumn.HeaderText = "TransactionTypeID"
        Me.TransactionTypeIDDataGridViewTextBoxColumn.Name = "TransactionTypeIDDataGridViewTextBoxColumn"
        Me.TransactionTypeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransactionTypeIDDataGridViewTextBoxColumn.Visible = False
        '
        'TransactionTypeDataGridViewTextBoxColumn
        '
        Me.TransactionTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType"
        Me.TransactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType"
        Me.TransactionTypeDataGridViewTextBoxColumn.Name = "TransactionTypeDataGridViewTextBoxColumn"
        '
        'ActionTypeDataGridViewTextBoxColumn
        '
        Me.ActionTypeDataGridViewTextBoxColumn.DataPropertyName = "ActionType"
        Me.ActionTypeDataGridViewTextBoxColumn.HeaderText = "ActionType"
        Me.ActionTypeDataGridViewTextBoxColumn.Name = "ActionTypeDataGridViewTextBoxColumn"
        '
        'btnEditUpdate
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUpdate.DefaultCellStyle = DataGridViewCellStyle4
        Me.btnEditUpdate.HeaderText = "Edit/Modify"
        Me.btnEditUpdate.Name = "btnEditUpdate"
        Me.btnEditUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnEditUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnEditUpdate.Text = "Edit"
        Me.btnEditUpdate.UseColumnTextForButtonValue = True
        '
        'TransactionTypeBindingSource
        '
        Me.TransactionTypeBindingSource.DataMember = "TransactionType"
        Me.TransactionTypeBindingSource.DataSource = Me.BodegaDataSet
        '
        'BodegaDataSet
        '
        Me.BodegaDataSet.DataSetName = "bodegaDataSet"
        Me.BodegaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionTypeTableAdapter
        '
        Me.TransactionTypeTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnRefresh, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddTransactionType, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(446, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(256, 41)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(26, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnAddTransactionType
        '
        Me.btnAddTransactionType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTransactionType.Location = New System.Drawing.Point(154, 9)
        Me.btnAddTransactionType.Name = "btnAddTransactionType"
        Me.btnAddTransactionType.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTransactionType.TabIndex = 3
        Me.btnAddTransactionType.Text = "Add New"
        Me.btnAddTransactionType.UseVisualStyleBackColor = True
        '
        'ViewTransactionType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 318)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dgvTransactionTypes)
        Me.Name = "ViewTransactionType"
        Me.Text = "View Transaction Types"
        CType(Me.dgvTransactionTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvTransactionTypes As System.Windows.Forms.DataGridView
    Friend WithEvents BodegaDataSet As CMUInventory.bodegaDataSet
    Friend WithEvents TransactionTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionTypeTableAdapter As CMUInventory.bodegaDataSetTableAdapters.TransactionTypeTableAdapter
    Friend WithEvents TransactionTypeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActionTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEditUpdate As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnAddTransactionType As System.Windows.Forms.Button
End Class
