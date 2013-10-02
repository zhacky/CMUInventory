Imports System.Windows.Forms

Public Class dlgAddEditTransactionType

#Region "Variables"
    Private IsUpdateMode As Boolean = False
    Dim tta As New bodegaDataSetTableAdapters.TransactionTypeTableAdapter
    Dim tdr As bodegaDataSet.TransactionTypeRow
#End Region

#Region "Initialization"

#End Region

#Region "Form Events"

    Private Sub btnAddUpdateTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUpdateTransaction.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If SaveTransactionType() Then
            Me.Close()
        End If

    End Sub

    Private Sub Close_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region

#Region "Helper Methods"

    Private Function SaveTransactionType() As Boolean
        Try

        
        If IsDataValid() Then
            If IsUpdateMode Then
                tdr.TransactionType = txtTransactionType.Text.Trim
                tdr.ActionType = cboActionType.SelectedItem.ToString
                If tta.Update(tdr) > 0 Then
                    MessageBox.Show("Transaction Type updated successfully", "Transaction Type Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    MessageBox.Show("Transaction Type update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Else
                If tta.Insert(txtTransactionType.Text.Trim, cboActionType.SelectedItem.ToString) > 0 Then
                    MessageBox.Show("Transaction Type added successfully", "Transaction Type Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    MessageBox.Show("Transaction Type addition failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

            End If

        Else
            Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to make changes due to the following error: " & vbCrLf & ex.Message)
            Return False

        End Try
    End Function

    Private Function IsDataValid() As Boolean
        If txtTransactionType.Text = String.Empty Or IsDBNull(txtTransactionType.Text) Then
            erpTransactionType.SetError(txtTransactionType, "Cannot be empty")
            Return False
        Else
            Return True
        End If
    End Function

#End Region
End Class
