<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAddWareHouse
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
        Dim WareHouseNameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveAndClose = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.BodegaDataSet = New CMUInventory.bodegaDataSet()
        Me.WareHouseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WareHouseTableAdapter = New CMUInventory.bodegaDataSetTableAdapters.WareHouseTableAdapter()
        Me.TableAdapterManager = New CMUInventory.bodegaDataSetTableAdapters.TableAdapterManager()
        Me.WareHouseNameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.btnSaveAndNew = New System.Windows.Forms.Button()
        Me.erpWarehouse = New System.Windows.Forms.ErrorProvider(Me.components)
        WareHouseNameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WareHouseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WareHouseNameLabel
        '
        WareHouseNameLabel.AutoSize = True
        WareHouseNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WareHouseNameLabel.Location = New System.Drawing.Point(37, 49)
        WareHouseNameLabel.Name = "WareHouseNameLabel"
        WareHouseNameLabel.Size = New System.Drawing.Size(127, 16)
        WareHouseNameLabel.TabIndex = 4
        WareHouseNameLabel.Text = "Ware House Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(37, 116)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(79, 16)
        DescriptionLabel.TabIndex = 6
        DescriptionLabel.Text = "Description:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSaveAndClose, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(181, 291)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(266, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnSaveAndClose
        '
        Me.btnSaveAndClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaveAndClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAndClose.Location = New System.Drawing.Point(6, 3)
        Me.btnSaveAndClose.Name = "btnSaveAndClose"
        Me.btnSaveAndClose.Size = New System.Drawing.Size(120, 30)
        Me.btnSaveAndClose.TabIndex = 0
        Me.btnSaveAndClose.Text = "Save And Close"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(166, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 30)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
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
        'WareHouseNameTextBox
        '
        Me.WareHouseNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WareHouseNameTextBox.Location = New System.Drawing.Point(40, 68)
        Me.WareHouseNameTextBox.Name = "WareHouseNameTextBox"
        Me.WareHouseNameTextBox.Size = New System.Drawing.Size(382, 22)
        Me.WareHouseNameTextBox.TabIndex = 5
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(40, 135)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(382, 106)
        Me.DescriptionTextBox.TabIndex = 7
        '
        'btnSaveAndNew
        '
        Me.btnSaveAndNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAndNew.Location = New System.Drawing.Point(40, 295)
        Me.btnSaveAndNew.Name = "btnSaveAndNew"
        Me.btnSaveAndNew.Size = New System.Drawing.Size(112, 29)
        Me.btnSaveAndNew.TabIndex = 8
        Me.btnSaveAndNew.Text = "Save And New"
        Me.btnSaveAndNew.UseVisualStyleBackColor = True
        '
        'erpWarehouse
        '
        Me.erpWarehouse.ContainerControl = Me
        '
        'dlgAddWareHouse
        '
        Me.AcceptButton = Me.btnSaveAndClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(459, 339)
        Me.Controls.Add(Me.btnSaveAndNew)
        Me.Controls.Add(WareHouseNameLabel)
        Me.Controls.Add(Me.WareHouseNameTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAddWareHouse"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add WareHouse"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WareHouseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSaveAndClose As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents BodegaDataSet As CMUInventory.bodegaDataSet
    Friend WithEvents WareHouseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WareHouseTableAdapter As CMUInventory.bodegaDataSetTableAdapters.WareHouseTableAdapter
    Friend WithEvents TableAdapterManager As CMUInventory.bodegaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WareHouseNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveAndNew As System.Windows.Forms.Button
    Friend WithEvents erpWarehouse As System.Windows.Forms.ErrorProvider

End Class
