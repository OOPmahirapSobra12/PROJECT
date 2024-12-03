<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGVrooms = New System.Windows.Forms.DataGridView()
        Me.subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.room_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnaccount = New System.Windows.Forms.Button()
        Me.btnroomlist = New System.Windows.Forms.Button()
        Me.btnschedule = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnfeedback = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DGVrooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(907, 499)
        Me.TableLayoutPanel1.TabIndex = 29
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DGVrooms, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.83133!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.879519!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.28915!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(447, 493)
        Me.TableLayoutPanel3.TabIndex = 57
        '
        'DGVrooms
        '
        Me.DGVrooms.AllowUserToAddRows = False
        Me.DGVrooms.AllowUserToDeleteRows = False
        Me.DGVrooms.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVrooms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subject, Me.time, Me.room, Me.room_status})
        Me.DGVrooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVrooms.GridColor = System.Drawing.Color.NavajoWhite
        Me.DGVrooms.Location = New System.Drawing.Point(23, 138)
        Me.DGVrooms.Name = "DGVrooms"
        Me.DGVrooms.ReadOnly = True
        Me.DGVrooms.RowHeadersWidth = 51
        Me.DGVrooms.Size = New System.Drawing.Size(421, 330)
        Me.DGVrooms.TabIndex = 53
        '
        'subject
        '
        Me.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.subject.HeaderText = "Subject"
        Me.subject.Name = "subject"
        Me.subject.ReadOnly = True
        '
        'time
        '
        Me.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.time.HeaderText = "Time"
        Me.time.Name = "time"
        Me.time.ReadOnly = True
        '
        'room
        '
        Me.room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.room.HeaderText = "Room"
        Me.room.Name = "room"
        Me.room.ReadOnly = True
        '
        'room_status
        '
        Me.room_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.room_status.HeaderText = "Room Status"
        Me.room_status.Name = "room_status"
        Me.room_status.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label2.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label2.Location = New System.Drawing.Point(23, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(421, 45)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Schedules:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnaccount, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnroomlist, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnschedule, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnlogout, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(456, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.87234!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.80851!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(448, 493)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnaccount
        '
        Me.btnaccount.AutoSize = True
        Me.btnaccount.BackColor = System.Drawing.Color.Transparent
        Me.btnaccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaccount.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnaccount.Location = New System.Drawing.Point(3, 144)
        Me.btnaccount.Name = "btnaccount"
        Me.btnaccount.Size = New System.Drawing.Size(442, 79)
        Me.btnaccount.TabIndex = 54
        Me.btnaccount.Text = "Name (View Account)"
        Me.btnaccount.UseVisualStyleBackColor = False
        '
        'btnroomlist
        '
        Me.btnroomlist.AutoSize = True
        Me.btnroomlist.BackColor = System.Drawing.Color.Transparent
        Me.btnroomlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnroomlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnroomlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnroomlist.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnroomlist.Location = New System.Drawing.Point(3, 229)
        Me.btnroomlist.Name = "btnroomlist"
        Me.btnroomlist.Size = New System.Drawing.Size(442, 50)
        Me.btnroomlist.TabIndex = 55
        Me.btnroomlist.Text = "Roomlist"
        Me.btnroomlist.UseVisualStyleBackColor = False
        '
        'btnschedule
        '
        Me.btnschedule.AutoSize = True
        Me.btnschedule.BackColor = System.Drawing.Color.Transparent
        Me.btnschedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnschedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnschedule.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnschedule.Location = New System.Drawing.Point(3, 285)
        Me.btnschedule.Name = "btnschedule"
        Me.btnschedule.Size = New System.Drawing.Size(442, 50)
        Me.btnschedule.TabIndex = 56
        Me.btnschedule.Text = "Schedule"
        Me.btnschedule.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.AutoSize = True
        Me.btnlogout.BackColor = System.Drawing.Color.Transparent
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnlogout.Location = New System.Drawing.Point(3, 397)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(442, 50)
        Me.btnlogout.TabIndex = 59
        Me.btnlogout.Text = "Log-Out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnreport, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnfeedback, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 341)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(442, 50)
        Me.TableLayoutPanel4.TabIndex = 60
        '
        'btnfeedback
        '
        Me.btnfeedback.AutoSize = True
        Me.btnfeedback.BackColor = System.Drawing.Color.Transparent
        Me.btnfeedback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnfeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfeedback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnfeedback.Location = New System.Drawing.Point(3, 3)
        Me.btnfeedback.Name = "btnfeedback"
        Me.btnfeedback.Size = New System.Drawing.Size(215, 44)
        Me.btnfeedback.TabIndex = 58
        Me.btnfeedback.Text = "Feedback"
        Me.btnfeedback.UseVisualStyleBackColor = False
        '
        'btnreport
        '
        Me.btnreport.AutoSize = True
        Me.btnreport.BackColor = System.Drawing.Color.Transparent
        Me.btnreport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnreport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnreport.Location = New System.Drawing.Point(224, 3)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(215, 44)
        Me.btnreport.TabIndex = 59
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 499)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "student"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.DGVrooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DGVrooms As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnaccount As Button
    Friend WithEvents btnroomlist As Button
    Friend WithEvents btnschedule As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents subject As DataGridViewTextBoxColumn
    Friend WithEvents time As DataGridViewTextBoxColumn
    Friend WithEvents room As DataGridViewTextBoxColumn
    Friend WithEvents room_status As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnreport As Button
    Friend WithEvents btnfeedback As Button
End Class
