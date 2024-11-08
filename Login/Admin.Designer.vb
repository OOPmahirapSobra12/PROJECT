<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.btnlist = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnapproval = New System.Windows.Forms.Button()
        Me.btnmanagement = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.btnfeedback = New System.Windows.Forms.Button()
        Me.DGVreport = New System.Windows.Forms.DataGridView()
        Me.DGVfeedback = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DGVreport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVfeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.375!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.625!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnprofile, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnlist, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btnapproval, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btnmanagement, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.btnlogout, 1, 7)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(390, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.71412!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.1791!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69652!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.19901!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69154!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.950249!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.19901!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(407, 435)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnprofile
        '
        Me.btnprofile.AutoSize = True
        Me.btnprofile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnprofile.BackColor = System.Drawing.Color.Transparent
        Me.btnprofile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnprofile.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprofile.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnprofile.Location = New System.Drawing.Point(23, 119)
        Me.btnprofile.Name = "btnprofile"
        Me.btnprofile.Size = New System.Drawing.Size(361, 54)
        Me.btnprofile.TabIndex = 27
        Me.btnprofile.Text = "Welcome, (Name)"
        Me.btnprofile.UseVisualStyleBackColor = False
        '
        'btnlist
        '
        Me.btnlist.AutoSize = True
        Me.btnlist.BackColor = System.Drawing.Color.Transparent
        Me.btnlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlist.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnlist.Location = New System.Drawing.Point(23, 179)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(361, 39)
        Me.btnlist.TabIndex = 28
        Me.btnlist.Text = "Room List"
        Me.btnlist.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Button2.Location = New System.Drawing.Point(23, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(361, 37)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Schedule"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnapproval
        '
        Me.btnapproval.AutoSize = True
        Me.btnapproval.BackColor = System.Drawing.Color.Transparent
        Me.btnapproval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnapproval.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnapproval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnapproval.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnapproval.Location = New System.Drawing.Point(23, 267)
        Me.btnapproval.Name = "btnapproval"
        Me.btnapproval.Size = New System.Drawing.Size(361, 43)
        Me.btnapproval.TabIndex = 30
        Me.btnapproval.Text = "Request Approval"
        Me.btnapproval.UseVisualStyleBackColor = False
        '
        'btnmanagement
        '
        Me.btnmanagement.AutoSize = True
        Me.btnmanagement.BackColor = System.Drawing.Color.Transparent
        Me.btnmanagement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmanagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmanagement.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnmanagement.Location = New System.Drawing.Point(23, 316)
        Me.btnmanagement.Name = "btnmanagement"
        Me.btnmanagement.Size = New System.Drawing.Size(361, 36)
        Me.btnmanagement.TabIndex = 32
        Me.btnmanagement.Text = "Account Management"
        Me.btnmanagement.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.AutoSize = True
        Me.btnlogout.BackColor = System.Drawing.Color.Transparent
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnlogout.Location = New System.Drawing.Point(23, 358)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(361, 35)
        Me.btnlogout.TabIndex = 33
        Me.btnlogout.Text = "Log out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnreport, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnfeedback, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.DGVreport, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.DGVfeedback, 1, 5)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 12)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(381, 435)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'btnreport
        '
        Me.btnreport.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnreport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnreport.Location = New System.Drawing.Point(23, 149)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(335, 23)
        Me.btnreport.TabIndex = 0
        Me.btnreport.Text = "Reports:"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'btnfeedback
        '
        Me.btnfeedback.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnfeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfeedback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnfeedback.Location = New System.Drawing.Point(23, 268)
        Me.btnfeedback.Name = "btnfeedback"
        Me.btnfeedback.Size = New System.Drawing.Size(335, 23)
        Me.btnfeedback.TabIndex = 1
        Me.btnfeedback.Text = "Feedback:"
        Me.btnfeedback.UseVisualStyleBackColor = True
        '
        'DGVreport
        '
        Me.DGVreport.AllowUserToAddRows = False
        Me.DGVreport.AllowUserToDeleteRows = False
        Me.DGVreport.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVreport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVreport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVreport.GridColor = System.Drawing.Color.NavajoWhite
        Me.DGVreport.Location = New System.Drawing.Point(23, 178)
        Me.DGVreport.Name = "DGVreport"
        Me.DGVreport.ReadOnly = True
        Me.DGVreport.Size = New System.Drawing.Size(335, 79)
        Me.DGVreport.TabIndex = 2
        '
        'DGVfeedback
        '
        Me.DGVfeedback.AllowUserToAddRows = False
        Me.DGVfeedback.AllowUserToDeleteRows = False
        Me.DGVfeedback.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVfeedback.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVfeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVfeedback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVfeedback.GridColor = System.Drawing.Color.NavajoWhite
        Me.DGVfeedback.Location = New System.Drawing.Point(23, 297)
        Me.DGVfeedback.Name = "DGVfeedback"
        Me.DGVfeedback.ReadOnly = True
        Me.DGVfeedback.Size = New System.Drawing.Size(335, 79)
        Me.DGVfeedback.TabIndex = 3
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.Text = "ADMIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DGVreport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVfeedback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnlist As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnapproval As Button
    Friend WithEvents btnmanagement As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnreport As Button
    Friend WithEvents btnfeedback As Button
    Friend WithEvents DGVreport As DataGridView
    Friend WithEvents DGVfeedback As DataGridView
End Class
