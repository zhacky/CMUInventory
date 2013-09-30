Public Class frmReports

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bodegaDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.bodegaDataSet.Products)
        Me.ReportViewerMain.RefreshReport()
    End Sub

    Private Sub cboReportTypes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReportTypes.SelectedIndexChanged

        Select Case cboReportTypes.SelectedIndex + 1
            Case 1
                ReportViewerMain.LocalReport.ReportPath = "Reports\rptInventory.rdlc"
                ReportViewerMain.RefreshReport()
            Case 2
                ReportViewerMain.LocalReport.ReportPath = "Reports\rptProducts.rdlc"
                ReportViewerMain.RefreshReport()
            Case Else

        End Select

    End Sub
End Class