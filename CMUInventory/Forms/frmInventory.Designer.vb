<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Me.gboInventory = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'gboInventory
        '
        Me.gboInventory.Location = New System.Drawing.Point(12, 12)
        Me.gboInventory.Name = "gboInventory"
        Me.gboInventory.Size = New System.Drawing.Size(735, 267)
        Me.gboInventory.TabIndex = 0
        Me.gboInventory.TabStop = False
        Me.gboInventory.Text = "Inventory Information"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 291)
        Me.Controls.Add(Me.gboInventory)
        Me.Name = "frmInventory"
        Me.Text = "Inventory"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboInventory As System.Windows.Forms.GroupBox
End Class
