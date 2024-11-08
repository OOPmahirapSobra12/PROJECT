<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.welcome = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.31605!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.76807!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.51519!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.02691!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.373768!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtuname, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.username, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.password, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnlogin, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.welcome, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtpassword, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btncreate, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnclose, 3, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.30055!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.397731!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.408496!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.150422!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13966!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.60314!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtuname
        '
        Me.txtuname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtuname.Location = New System.Drawing.Point(535, 210)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(242, 31)
        Me.txtuname.TabIndex = 15
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.BackColor = System.Drawing.Color.Transparent
        Me.username.Dock = System.Windows.Forms.DockStyle.Fill
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.NavajoWhite
        Me.username.Location = New System.Drawing.Point(395, 207)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(134, 34)
        Me.username.TabIndex = 17
        Me.username.Text = "Username:"
        Me.username.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.BackColor = System.Drawing.Color.Transparent
        Me.password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.NavajoWhite
        Me.password.Location = New System.Drawing.Point(395, 241)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(134, 37)
        Me.password.TabIndex = 19
        Me.password.Text = "Password:"
        Me.password.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnlogin
        '
        Me.btnlogin.AutoSize = True
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnlogin.Location = New System.Drawing.Point(535, 281)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(242, 35)
        Me.btnlogin.TabIndex = 20
        Me.btnlogin.Text = "LogIn"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.BackColor = System.Drawing.Color.Transparent
        Me.welcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.ForeColor = System.Drawing.Color.NavajoWhite
        Me.welcome.Location = New System.Drawing.Point(535, 169)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(242, 38)
        Me.welcome.TabIndex = 16
        Me.welcome.Text = "Welcome"
        Me.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpassword
        '
        Me.txtpassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtpassword.Location = New System.Drawing.Point(535, 244)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(242, 32)
        Me.txtpassword.TabIndex = 18
        '
        'btncreate
        '
        Me.btncreate.AutoSize = True
        Me.btncreate.BackColor = System.Drawing.Color.Transparent
        Me.btncreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncreate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btncreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btncreate.Location = New System.Drawing.Point(443, 281)
        Me.btncreate.MaximumSize = New System.Drawing.Size(0, 35)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(86, 35)
        Me.btncreate.TabIndex = 22
        Me.btncreate.Text = "Create"
        Me.btncreate.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.AutoSize = True
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnclose.Location = New System.Drawing.Point(535, 412)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(242, 35)
        Me.btnclose.TabIndex = 23
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Navy
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log-In"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtuname As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents username As Label
    Friend WithEvents welcome As Label
    Friend WithEvents password As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents btncreate As Button
    Friend WithEvents btnclose As Button
End Class
