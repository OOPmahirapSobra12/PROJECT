<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVcomment = New System.Windows.Forms.DataGridView()
        Me.btnrequest = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.btnroomlist = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnschedule = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnaccount = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.DGVcomment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label2.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label2.Location = New System.Drawing.Point(23, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 41)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Room Status:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DGVcomment
        '
        Me.DGVcomment.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVcomment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcomment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVcomment.GridColor = System.Drawing.Color.NavajoWhite
        Me.DGVcomment.Location = New System.Drawing.Point(23, 126)
        Me.DGVcomment.Name = "DGVcomment"
        Me.DGVcomment.RowHeadersWidth = 51
        Me.DGVcomment.Size = New System.Drawing.Size(368, 294)
        Me.DGVcomment.TabIndex = 53
        '
        'btnrequest
        '
        Me.btnrequest.AutoSize = True
        Me.btnrequest.BackColor = System.Drawing.Color.Transparent
        Me.btnrequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnrequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrequest.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnrequest.Location = New System.Drawing.Point(3, 324)
        Me.btnrequest.Name = "btnrequest"
        Me.btnrequest.Size = New System.Drawing.Size(368, 44)
        Me.btnrequest.TabIndex = 52
        Me.btnrequest.Text = "Request"
        Me.btnrequest.UseVisualStyleBackColor = False
        '
        'btnreport
        '
        Me.btnreport.AutoSize = True
        Me.btnreport.BackColor = System.Drawing.Color.Transparent
        Me.btnreport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnreport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnreport.Location = New System.Drawing.Point(3, 274)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(368, 44)
        Me.btnreport.TabIndex = 51
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'btnroomlist
        '
        Me.btnroomlist.AutoSize = True
        Me.btnroomlist.BackColor = System.Drawing.Color.Transparent
        Me.btnroomlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnroomlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnroomlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnroomlist.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnroomlist.Location = New System.Drawing.Point(3, 174)
        Me.btnroomlist.Name = "btnroomlist"
        Me.btnroomlist.Size = New System.Drawing.Size(368, 44)
        Me.btnroomlist.TabIndex = 50
        Me.btnroomlist.Text = "Room List"
        Me.btnroomlist.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.AutoSize = True
        Me.btnlogout.BackColor = System.Drawing.Color.Transparent
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnlogout.Location = New System.Drawing.Point(3, 374)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(368, 44)
        Me.btnlogout.TabIndex = 49
        Me.btnlogout.Text = "Sign-Out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnschedule
        '
        Me.btnschedule.AutoSize = True
        Me.btnschedule.BackColor = System.Drawing.Color.Transparent
        Me.btnschedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnschedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnschedule.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnschedule.Location = New System.Drawing.Point(3, 224)
        Me.btnschedule.Name = "btnschedule"
        Me.btnschedule.Size = New System.Drawing.Size(368, 44)
        Me.btnschedule.TabIndex = 48
        Me.btnschedule.Text = " Schedule"
        Me.btnschedule.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 55
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnroomlist, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.btnreport, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.btnschedule, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.btnrequest, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.btnlogout, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.btnaccount, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(403, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 9
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.18703!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.46883!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(394, 444)
        Me.TableLayoutPanel3.TabIndex = 57
        '
        'btnaccount
        '
        Me.btnaccount.AutoSize = True
        Me.btnaccount.BackColor = System.Drawing.Color.Transparent
        Me.btnaccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaccount.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnaccount.Location = New System.Drawing.Point(3, 124)
        Me.btnaccount.Name = "btnaccount"
        Me.btnaccount.Size = New System.Drawing.Size(368, 44)
        Me.btnaccount.TabIndex = 53
        Me.btnaccount.Text = "Name (View Account)"
        Me.btnaccount.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DGVcomment, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.83133!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.879519!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.28915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(394, 444)
        Me.TableLayoutPanel2.TabIndex = 56
        '
        'Staff
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
        Me.Name = "Staff"
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVcomment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents DGVcomment As DataGridView
    Friend WithEvents btnrequest As Button
    Friend WithEvents btnreport As Button
    Friend WithEvents btnroomlist As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnschedule As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnaccount As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
