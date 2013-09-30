<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDbSettings
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
        Me.panDbButtons = New System.Windows.Forms.Panel()
        Me.btnDbApply = New System.Windows.Forms.Button()
        Me.btnDbCancel = New System.Windows.Forms.Button()
        Me.btnDbOk = New System.Windows.Forms.Button()
        Me.gboDbConfiguration = New System.Windows.Forms.GroupBox()
        Me.cboDatabase = New System.Windows.Forms.ComboBox()
        Me.txtDbPassword = New System.Windows.Forms.TextBox()
        Me.txtDbUsername = New System.Windows.Forms.TextBox()
        Me.cboDbServer = New System.Windows.Forms.ComboBox()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panDbButtons.SuspendLayout()
        Me.gboDbConfiguration.SuspendLayout()
        Me.SuspendLayout()
        '
        'panDbButtons
        '
        Me.panDbButtons.Controls.Add(Me.btnDbApply)
        Me.panDbButtons.Controls.Add(Me.btnDbCancel)
        Me.panDbButtons.Controls.Add(Me.btnDbOk)
        Me.panDbButtons.Location = New System.Drawing.Point(251, 358)
        Me.panDbButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.panDbButtons.Name = "panDbButtons"
        Me.panDbButtons.Size = New System.Drawing.Size(328, 36)
        Me.panDbButtons.TabIndex = 0
        '
        'btnDbApply
        '
        Me.btnDbApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDbApply.Location = New System.Drawing.Point(220, 4)
        Me.btnDbApply.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDbApply.Name = "btnDbApply"
        Me.btnDbApply.Size = New System.Drawing.Size(100, 28)
        Me.btnDbApply.TabIndex = 1
        Me.btnDbApply.Text = "Apply"
        Me.btnDbApply.UseVisualStyleBackColor = True
        '
        'btnDbCancel
        '
        Me.btnDbCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDbCancel.Location = New System.Drawing.Point(112, 4)
        Me.btnDbCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDbCancel.Name = "btnDbCancel"
        Me.btnDbCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnDbCancel.TabIndex = 1
        Me.btnDbCancel.Text = "Cancel"
        Me.btnDbCancel.UseVisualStyleBackColor = True
        '
        'btnDbOk
        '
        Me.btnDbOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDbOk.Location = New System.Drawing.Point(4, 4)
        Me.btnDbOk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDbOk.Name = "btnDbOk"
        Me.btnDbOk.Size = New System.Drawing.Size(100, 28)
        Me.btnDbOk.TabIndex = 1
        Me.btnDbOk.Text = "OK"
        Me.btnDbOk.UseVisualStyleBackColor = True
        '
        'gboDbConfiguration
        '
        Me.gboDbConfiguration.Controls.Add(Me.cboDatabase)
        Me.gboDbConfiguration.Controls.Add(Me.txtDbPassword)
        Me.gboDbConfiguration.Controls.Add(Me.txtDbUsername)
        Me.gboDbConfiguration.Controls.Add(Me.cboDbServer)
        Me.gboDbConfiguration.Controls.Add(Me.btnTestConnection)
        Me.gboDbConfiguration.Controls.Add(Me.Label4)
        Me.gboDbConfiguration.Controls.Add(Me.Label3)
        Me.gboDbConfiguration.Controls.Add(Me.Label2)
        Me.gboDbConfiguration.Controls.Add(Me.Label1)
        Me.gboDbConfiguration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboDbConfiguration.Location = New System.Drawing.Point(16, 15)
        Me.gboDbConfiguration.Margin = New System.Windows.Forms.Padding(4)
        Me.gboDbConfiguration.Name = "gboDbConfiguration"
        Me.gboDbConfiguration.Padding = New System.Windows.Forms.Padding(4)
        Me.gboDbConfiguration.Size = New System.Drawing.Size(563, 336)
        Me.gboDbConfiguration.TabIndex = 1
        Me.gboDbConfiguration.TabStop = False
        Me.gboDbConfiguration.Text = "Server Configuration"
        '
        'cboDatabase
        '
        Me.cboDatabase.FormattingEnabled = True
        Me.cboDatabase.Location = New System.Drawing.Point(113, 194)
        Me.cboDatabase.Name = "cboDatabase"
        Me.cboDatabase.Size = New System.Drawing.Size(281, 24)
        Me.cboDatabase.TabIndex = 8
        '
        'txtDbPassword
        '
        Me.txtDbPassword.Location = New System.Drawing.Point(113, 151)
        Me.txtDbPassword.Name = "txtDbPassword"
        Me.txtDbPassword.Size = New System.Drawing.Size(281, 22)
        Me.txtDbPassword.TabIndex = 7
        Me.txtDbPassword.UseSystemPasswordChar = True
        '
        'txtDbUsername
        '
        Me.txtDbUsername.Location = New System.Drawing.Point(113, 108)
        Me.txtDbUsername.Name = "txtDbUsername"
        Me.txtDbUsername.Size = New System.Drawing.Size(281, 22)
        Me.txtDbUsername.TabIndex = 6
        '
        'cboDbServer
        '
        Me.cboDbServer.FormattingEnabled = True
        Me.cboDbServer.Location = New System.Drawing.Point(113, 65)
        Me.cboDbServer.Name = "cboDbServer"
        Me.cboDbServer.Size = New System.Drawing.Size(281, 24)
        Me.cboDbServer.TabIndex = 5
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestConnection.Location = New System.Drawing.Point(320, 300)
        Me.btnTestConnection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(235, 28)
        Me.btnTestConnection.TabIndex = 4
        Me.btnTestConnection.Text = "Test Connection"
        Me.btnTestConnection.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Database:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DB Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DB Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server:"
        '
        'frmDbSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 409)
        Me.Controls.Add(Me.gboDbConfiguration)
        Me.Controls.Add(Me.panDbButtons)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDbSettings"
        Me.Text = "Database Settings"
        Me.panDbButtons.ResumeLayout(False)
        Me.gboDbConfiguration.ResumeLayout(False)
        Me.gboDbConfiguration.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panDbButtons As System.Windows.Forms.Panel
    Friend WithEvents btnDbApply As System.Windows.Forms.Button
    Friend WithEvents btnDbCancel As System.Windows.Forms.Button
    Friend WithEvents btnDbOk As System.Windows.Forms.Button
    Friend WithEvents gboDbConfiguration As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDatabase As System.Windows.Forms.ComboBox
    Friend WithEvents txtDbPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtDbUsername As System.Windows.Forms.TextBox
    Friend WithEvents cboDbServer As System.Windows.Forms.ComboBox
    Friend WithEvents btnTestConnection As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
