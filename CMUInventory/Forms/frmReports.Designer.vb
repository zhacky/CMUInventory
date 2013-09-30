<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.ReportViewerMain = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bodegaDataSet = New CMUInventory.bodegaDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New CMUInventory.bodegaDataSetTableAdapters.ProductsTableAdapter()
        Me.gboSelectReportType = New System.Windows.Forms.GroupBox()
        Me.cboReportTypes = New System.Windows.Forms.ComboBox()
        CType(Me.bodegaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboSelectReportType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewerMain
        '
        Me.ReportViewerMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "ProductsDataSet"
        ReportDataSource1.Value = Me.ProductsBindingSource
        Me.ReportViewerMain.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerMain.LocalReport.ReportEmbeddedResource = "CMUInventory.rptProducts.rdlc"
        Me.ReportViewerMain.Location = New System.Drawing.Point(12, 77)
        Me.ReportViewerMain.Name = "ReportViewerMain"
        Me.ReportViewerMain.Size = New System.Drawing.Size(642, 299)
        Me.ReportViewerMain.TabIndex = 0
        '
        'bodegaDataSet
        '
        Me.bodegaDataSet.DataSetName = "bodegaDataSet"
        Me.bodegaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.bodegaDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'gboSelectReportType
        '
        Me.gboSelectReportType.Controls.Add(Me.cboReportTypes)
        Me.gboSelectReportType.Location = New System.Drawing.Point(12, 12)
        Me.gboSelectReportType.Name = "gboSelectReportType"
        Me.gboSelectReportType.Size = New System.Drawing.Size(642, 59)
        Me.gboSelectReportType.TabIndex = 1
        Me.gboSelectReportType.TabStop = False
        Me.gboSelectReportType.Text = "Select Report"
        '
        'cboReportTypes
        '
        Me.cboReportTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReportTypes.FormattingEnabled = True
        Me.cboReportTypes.Items.AddRange(New Object() {"Current Inventory", "Products List"})
        Me.cboReportTypes.Location = New System.Drawing.Point(6, 19)
        Me.cboReportTypes.Name = "cboReportTypes"
        Me.cboReportTypes.Size = New System.Drawing.Size(268, 24)
        Me.cboReportTypes.TabIndex = 0
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 376)
        Me.Controls.Add(Me.gboSelectReportType)
        Me.Controls.Add(Me.ReportViewerMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReports"
        Me.Text = "Reports"
        CType(Me.bodegaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboSelectReportType.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewerMain As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bodegaDataSet As CMUInventory.bodegaDataSet
    Friend WithEvents ProductsTableAdapter As CMUInventory.bodegaDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents gboSelectReportType As System.Windows.Forms.GroupBox
    Friend WithEvents cboReportTypes As System.Windows.Forms.ComboBox
End Class
