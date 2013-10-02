Imports System.Windows.Forms

Public Class dlgAddWareHouse


#Region "Variables"
    Private WarehouseID As Integer = 0
    Private IsUpdateMode As Boolean = False
    Dim taWarehouse As New bodegaDataSetTableAdapters.WareHouseTableAdapter
    Dim trWarehouseRow As bodegaDataSet.WareHouseRow
#End Region

#Region "Initialization"

    Sub New()

        InitializeComponent()
        WarehouseID = 0
        IsUpdateMode = False

    End Sub

    Sub New(ByVal iWarehouseID As Integer)
        InitializeComponent()
        WarehouseID = iWarehouseID
        IsUpdateMode = True

        Dim dt As bodegaDataSet.WareHouseDataTable = taWarehouse.GetRowByWareHouseID(WarehouseID)

        If dt.Rows.Count > 0 Then
            trWarehouseRow = CType(dt.Rows(0), bodegaDataSet.WareHouseRow)

        End If
        Me.WareHouseNameTextBox.Focus()
    End Sub
#End Region

#Region "Loading..."

    Private Sub dlgAddWareHouse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BodegaDataSet.WareHouse' table. You can move, or remove it, as needed.
        Me.WareHouseTableAdapter.Fill(Me.BodegaDataSet.WareHouse)
        If IsUpdateMode Then
            Me.Text = "Update WareHouse"
            btnSaveAndNew.Visible = False
            btnSaveAndClose.Text = "&Update"
            WareHouseNameTextBox.DataBindings.Add("Text", trWarehouseRow, "WareHouseName")
            DescriptionTextBox.DataBindings.Add("Text", trWarehouseRow, "Description")

        Else
            Me.Text = "Add New WareHouse"
        End If

    End Sub

#End Region

#Region "Button clicks"

    Private Sub btnSaveNewWarehouseAndClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAndClose.Click

        If SaveWareHouse() Then
            Me.Close()

        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub WareHouseBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.WareHouseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub WareHouseBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.WareHouseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub WareHouseBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.WareHouseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub btnSaveAndNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAndNew.Click
        If SaveWareHouse() Then
            ResetForm()
        End If
    End Sub

#End Region

#Region "Helper Methods"
    '--  saving function tests whether it is for updating or
    '--  adding a new warehouse

    Private Function SaveWareHouse() As Boolean
        Try
            TrimTextBoxes()
            If IsEntryValid() Then
                If IsUpdateMode Then
                    If taWarehouse.Update(trWarehouseRow) > 0 Then
                        MessageBox.Show("WareHouse updated successfully", "WareHouse Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return True
                    Else
                        MessageBox.Show("Warehouse update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                Else
                    If taWarehouse.Insert(WareHouseNameTextBox.Text, DescriptionTextBox.Text) > 0 Then
                        MessageBox.Show("WareHouse added successfully", "WareHouse Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return True
                    Else
                        MessageBox.Show("Warehouse addition failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("WareHouse insertion failed due to the following error: " & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Private Sub ResetForm()
        WareHouseNameTextBox.Text = ""
        DescriptionTextBox.Text = ""
    End Sub


    Private Sub TrimTextBoxes()
        WareHouseNameTextBox.Text = WareHouseNameTextBox.Text.Trim
        DescriptionTextBox.Text = DescriptionTextBox.Text.Trim
    End Sub

    Private Function IsEntryValid() As Boolean
        If WareHouseNameTextBox.Text = String.Empty Then
            erpWarehouse.SetError(WareHouseNameTextBox, "Cannot be empty")
            Return False
        Else
            Return True
        End If

    End Function

#End Region

   

End Class
