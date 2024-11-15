<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage2
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
        Me.btnreport = New System.Windows.Forms.Button()
        Me.btnfeedback = New System.Windows.Forms.Button()
        Me.btnroomlogs = New System.Windows.Forms.Button()
        Me.btnaccountlogs = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.buttonback = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnprofile, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnreport, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnfeedback, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btnroomlogs, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btnaccountlogs, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.btnlogout, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.buttonback, 2, 8)
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
        Me.btnprofile.Text = "Welcome, (Name)"
        Me.btnprofile.UseVisualStyleBackColor = False
        '
        'btnreport
        '
        Me.btnreport.AutoSize = True
        Me.btnreport.BackColor = System.Drawing.Color.Transparent
        Me.btnreport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnreport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnreport.Location = New System.Drawing.Point(53, 179)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(297, 39)
        Me.btnreport.TabIndex = 28
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'btnfeedback
        '
        Me.btnfeedback.AutoSize = True
        Me.btnfeedback.BackColor = System.Drawing.Color.Transparent
        Me.btnfeedback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnfeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfeedback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnfeedback.Location = New System.Drawing.Point(53, 224)
        Me.btnfeedback.Name = "btnfeedback"
        Me.btnfeedback.Size = New System.Drawing.Size(297, 37)
        Me.btnfeedback.TabIndex = 29
        Me.btnfeedback.Text = "Feedback"
        Me.btnfeedback.UseVisualStyleBackColor = False
        '
        'btnroomlogs
        '
        Me.btnroomlogs.AutoSize = True
        Me.btnroomlogs.BackColor = System.Drawing.Color.Transparent
        Me.btnroomlogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnroomlogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnroomlogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnroomlogs.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnroomlogs.Location = New System.Drawing.Point(53, 267)
        Me.btnroomlogs.Name = "btnroomlogs"
        Me.btnroomlogs.Size = New System.Drawing.Size(297, 43)
        Me.btnroomlogs.TabIndex = 30
        Me.btnroomlogs.Text = "Room Logs"
        Me.btnroomlogs.UseVisualStyleBackColor = False
        '
        'btnaccountlogs
        '
        Me.btnaccountlogs.AutoSize = True
        Me.btnaccountlogs.BackColor = System.Drawing.Color.Transparent
        Me.btnaccountlogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnaccountlogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaccountlogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaccountlogs.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnaccountlogs.Location = New System.Drawing.Point(53, 316)
        Me.btnaccountlogs.Name = "btnaccountlogs"
        Me.btnaccountlogs.Size = New System.Drawing.Size(297, 36)
        Me.btnaccountlogs.TabIndex = 32
        Me.btnaccountlogs.Text = "Account Logs"
        Me.btnaccountlogs.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.AutoSize = True
        Me.btnlogout.BackColor = System.Drawing.Color.Transparent
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnlogout.Location = New System.Drawing.Point(53, 358)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(297, 37)
        Me.btnlogout.TabIndex = 33
        Me.btnlogout.Text = "Log out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'buttonback
        '
        Me.buttonback.AutoSize = True
        Me.buttonback.BackColor = System.Drawing.Color.Transparent
        Me.buttonback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.buttonback.Location = New System.Drawing.Point(356, 401)
        Me.buttonback.Name = "buttonback"
        Me.buttonback.Size = New System.Drawing.Size(48, 31)
        Me.buttonback.TabIndex = 35
        Me.buttonback.Text = "<="
        Me.buttonback.UseVisualStyleBackColor = False
        '
        'AdminPage2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminPage2"
        Me.Text = "AdminPage2"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnreport As Button
    Friend WithEvents btnfeedback As Button
    Friend WithEvents btnroomlogs As Button
    Friend WithEvents btnaccountlogs As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents buttonback As Button
End Class
