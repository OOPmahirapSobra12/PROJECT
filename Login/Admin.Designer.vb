<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.btnapproval = New System.Windows.Forms.Button()
        Me.btnmanagement = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnlist = New System.Windows.Forms.Button()
        Me.btnschedule = New System.Windows.Forms.Button()
        Me.btnloggin = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.375!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.625!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnprofile, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnapproval, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btnmanagement, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.btnlogout, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.btnnext, 2, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btnloggin, 1, 3)
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
        Me.btnprofile.Location = New System.Drawing.Point(53, 119)
        Me.btnprofile.Name = "btnprofile"
        Me.btnprofile.Size = New System.Drawing.Size(297, 54)
        Me.btnprofile.TabIndex = 27
        Me.btnprofile.Text = "User (View Account)"
        Me.btnprofile.UseVisualStyleBackColor = False
        '
        'btnapproval
        '
        Me.btnapproval.AutoSize = True
        Me.btnapproval.BackColor = System.Drawing.Color.Transparent
        Me.btnapproval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnapproval.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnapproval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnapproval.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnapproval.Location = New System.Drawing.Point(53, 267)
        Me.btnapproval.Name = "btnapproval"
        Me.btnapproval.Size = New System.Drawing.Size(297, 43)
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
        Me.btnmanagement.Location = New System.Drawing.Point(53, 316)
        Me.btnmanagement.Name = "btnmanagement"
        Me.btnmanagement.Size = New System.Drawing.Size(297, 36)
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
        Me.btnlogout.Location = New System.Drawing.Point(53, 358)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(297, 35)
        Me.btnlogout.TabIndex = 33
        Me.btnlogout.Text = "Log out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.AutoSize = True
        Me.btnnext.BackColor = System.Drawing.Color.Transparent
        Me.btnnext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnnext.Location = New System.Drawing.Point(356, 401)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(48, 31)
        Me.btnnext.TabIndex = 35
        Me.btnnext.Text = "=>"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnschedule, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnlist, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(53, 224)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(297, 37)
        Me.TableLayoutPanel3.TabIndex = 36
        '
        'btnlist
        '
        Me.btnlist.AutoSize = True
        Me.btnlist.BackColor = System.Drawing.Color.Transparent
        Me.btnlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlist.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnlist.Location = New System.Drawing.Point(3, 3)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(142, 31)
        Me.btnlist.TabIndex = 31
        Me.btnlist.Text = "Room List"
        Me.btnlist.UseVisualStyleBackColor = False
        '
        'btnschedule
        '
        Me.btnschedule.AutoSize = True
        Me.btnschedule.BackColor = System.Drawing.Color.Transparent
        Me.btnschedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnschedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnschedule.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnschedule.Location = New System.Drawing.Point(151, 3)
        Me.btnschedule.Name = "btnschedule"
        Me.btnschedule.Size = New System.Drawing.Size(143, 31)
        Me.btnschedule.TabIndex = 32
        Me.btnschedule.Text = "Schedule"
        Me.btnschedule.UseVisualStyleBackColor = False
        '
        'btnloggin
        '
        Me.btnloggin.AutoSize = True
        Me.btnloggin.BackColor = System.Drawing.Color.Transparent
        Me.btnloggin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnloggin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnloggin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloggin.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnloggin.Location = New System.Drawing.Point(53, 179)
        Me.btnloggin.Name = "btnloggin"
        Me.btnloggin.Size = New System.Drawing.Size(297, 39)
        Me.btnloggin.TabIndex = 37
        Me.btnloggin.Text = "Room Log-In"
        Me.btnloggin.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnapproval As Button
    Friend WithEvents btnmanagement As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnschedule As Button
    Friend WithEvents btnlist As Button
    Friend WithEvents btnloggin As Button
End Class
