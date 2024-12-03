<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPage2
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
        Me.btnback = New System.Windows.Forms.Button()
        Me.btncourse = New System.Windows.Forms.Button()
        Me.btnsection = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnsubject = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnback, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.btncourse, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btnsection, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btnlogout, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.btnprofile, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnnext, 2, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.btnsubject, 1, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(390, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.71412!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.1791!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69652!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69154!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.950249!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.19901!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(407, 435)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnback
        '
        Me.btnback.AutoSize = True
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnback.Location = New System.Drawing.Point(3, 401)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(44, 31)
        Me.btnback.TabIndex = 40
        Me.btnback.Text = "<="
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btncourse
        '
        Me.btncourse.AutoSize = True
        Me.btncourse.BackColor = System.Drawing.Color.Transparent
        Me.btncourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btncourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncourse.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btncourse.Location = New System.Drawing.Point(53, 250)
        Me.btncourse.Name = "btncourse"
        Me.btncourse.Size = New System.Drawing.Size(297, 50)
        Me.btncourse.TabIndex = 30
        Me.btncourse.Text = "Courses"
        Me.btncourse.UseVisualStyleBackColor = False
        '
        'btnsection
        '
        Me.btnsection.AutoSize = True
        Me.btnsection.BackColor = System.Drawing.Color.Transparent
        Me.btnsection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsection.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsection.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsection.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnsection.Location = New System.Drawing.Point(53, 306)
        Me.btnsection.Name = "btnsection"
        Me.btnsection.Size = New System.Drawing.Size(297, 41)
        Me.btnsection.TabIndex = 32
        Me.btnsection.Text = "Sections"
        Me.btnsection.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.AutoSize = True
        Me.btnlogout.BackColor = System.Drawing.Color.Transparent
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnlogout.Location = New System.Drawing.Point(53, 353)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(297, 35)
        Me.btnlogout.TabIndex = 33
        Me.btnlogout.Text = "Log out"
        Me.btnlogout.UseVisualStyleBackColor = False
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
        Me.btnprofile.Location = New System.Drawing.Point(53, 131)
        Me.btnprofile.Name = "btnprofile"
        Me.btnprofile.Size = New System.Drawing.Size(297, 62)
        Me.btnprofile.TabIndex = 36
        Me.btnprofile.Text = "User (View Account)"
        Me.btnprofile.UseVisualStyleBackColor = False
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
        Me.btnnext.TabIndex = 38
        Me.btnnext.Text = "=>"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnsubject
        '
        Me.btnsubject.AutoSize = True
        Me.btnsubject.BackColor = System.Drawing.Color.Transparent
        Me.btnsubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubject.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnsubject.Location = New System.Drawing.Point(53, 199)
        Me.btnsubject.Name = "btnsubject"
        Me.btnsubject.Size = New System.Drawing.Size(297, 45)
        Me.btnsubject.TabIndex = 41
        Me.btnsubject.Text = "Subjects"
        Me.btnsubject.UseVisualStyleBackColor = False
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
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnback As Button
    Friend WithEvents btncourse As Button
    Friend WithEvents btnsection As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnsubject As Button
End Class
