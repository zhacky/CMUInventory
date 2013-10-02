<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAddEditTransactionType
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAddUpdateTransaction = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.gboAddTransactionType = New System.Windows.Forms.GroupBox()
        Me.txtTransactionType = New System.Windows.Forms.TextBox()
        Me.lblTransactionTypeName = New System.Windows.Forms.Label()
        Me.cboActionType = New System.Windows.Forms.ComboBox()
        Me.lblActionType = New System.Windows.Forms.Label()
        Me.erpTransactionType = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gboAddTransactionType.SuspendLayout()
        CType(Me.erpTransactionType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddUpdateTransaction, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Close_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(372, 223)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnAddUpdateTransaction
        '
        Me.btnAddUpdateTransaction.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddUpdateTransaction.Location = New System.Drawing.Point(4, 4)
        Me.btnAddUpdateTransaction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddUpdateTransaction.Name = "btnAddUpdateTransaction"
        Me.btnAddUpdateTransaction.Size = New System.Drawing.Size(89, 28)
        Me.btnAddUpdateTransaction.TabIndex = 0
        Me.btnAddUpdateTransaction.Text = "Add"
        '
        'Close_Button
        '
        Me.Close_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Close_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close_Button.Location = New System.Drawing.Point(101, 4)
        Me.Close_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(89, 28)
        Me.Close_Button.TabIndex = 1
        Me.Close_Button.Text = "Close"
        '
        'gboAddTransactionType
        '
        Me.gboAddTransactionType.Controls.Add(Me.lblActionType)
        Me.gboAddTransactionType.Controls.Add(Me.cboActionType)
        Me.gboAddTransactionType.Controls.Add(Me.lblTransactionTypeName)
        Me.gboAddTransactionType.Controls.Add(Me.txtTransactionType)
        Me.gboAddTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboAddTransactionType.Location = New System.Drawing.Point(14, 29)
        Me.gboAddTransactionType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboAddTransactionType.Name = "gboAddTransactionType"
        Me.gboAddTransactionType.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboAddTransactionType.Size = New System.Drawing.Size(548, 183)
        Me.gboAddTransactionType.TabIndex = 1
        Me.gboAddTransactionType.TabStop = False
        Me.gboAddTransactionType.Text = "Add Transaction Type"
        '
        'txtTransactionType
        '
        Me.txtTransactionType.Location = New System.Drawing.Point(133, 55)
        Me.txtTransactionType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTransactionType.Name = "txtTransactionType"
        Me.txtTransactionType.Size = New System.Drawing.Size(317, 22)
        Me.txtTransactionType.TabIndex = 0
        '
        'lblTransactionTypeName
        '
        Me.lblTransactionTypeName.AutoSize = True
        Me.lblTransactionTypeName.Location = New System.Drawing.Point(8, 55)
        Me.lblTransactionTypeName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransactionTypeName.Name = "lblTransactionTypeName"
        Me.lblTransactionTypeName.Size = New System.Drawing.Size(117, 16)
        Me.lblTransactionTypeName.TabIndex = 1
        Me.lblTransactionTypeName.Text = "Transaction Type:"
        '
        'cboActionType
        '
        Me.cboActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActionType.FormattingEnabled = True
        Me.cboActionType.Items.AddRange(New Object() {"Addition", "Subtraction", "Transfer"})
        Me.cboActionType.Location = New System.Drawing.Point(133, 101)
        Me.cboActionType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboActionType.Name = "cboActionType"
        Me.cboActionType.Size = New System.Drawing.Size(317, 24)
        Me.cboActionType.TabIndex = 2
        '
        'lblActionType
        '
        Me.lblActionType.AutoSize = True
        Me.lblActionType.Location = New System.Drawing.Point(42, 104)
        Me.lblActionType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActionType.Name = "lblActionType"
        Me.lblActionType.Size = New System.Drawing.Size(83, 16)
        Me.lblActionType.TabIndex = 3
        Me.lblActionType.Text = "Action Type:"
        '
        'erpTransactionType
        '
        Me.erpTransactionType.ContainerControl = Me
        '
        'dlgAddEditTransactionType
        '
        Me.AcceptButton = Me.btnAddUpdateTransaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Close_Button
        Me.ClientSize = New System.Drawing.Size(580, 272)
        Me.Controls.Add(Me.gboAddTransactionType)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAddEditTransactionType"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transaction Type"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gboAddTransactionType.ResumeLayout(False)
        Me.gboAddTransactionType.PerformLayout()
        CType(Me.erpTransactionType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAddUpdateTransaction As System.Windows.Forms.Button
    Friend WithEvents Close_Button As System.Windows.Forms.Button
    Friend WithEvents gboAddTransactionType As System.Windows.Forms.GroupBox
    Friend WithEvents lblActionType As System.Windows.Forms.Label
    Friend WithEvents cboActionType As System.Windows.Forms.ComboBox
    Friend WithEvents lblTransactionTypeName As System.Windows.Forms.Label
    Friend WithEvents txtTransactionType As System.Windows.Forms.TextBox
    Friend WithEvents erpTransactionType As System.Windows.Forms.ErrorProvider

End Class
