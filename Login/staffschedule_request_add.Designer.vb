<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staffschedule_request_add
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
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboday = New System.Windows.Forms.ComboBox()
        Me.cborcode = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTPdate = New System.Windows.Forms.DateTimePicker()
        Me.DTPtimein = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTPtimeout = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtschedID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbocourse = New System.Windows.Forms.ComboBox()
        Me.cbosection = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbosubject = New System.Windows.Forms.ComboBox()
        Me.cboroomname = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel11, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel10, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.15614!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.84387!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(850, 277)
        Me.TableLayoutPanel7.TabIndex = 4
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 3
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.Controls.Add(Me.btnback, 2, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.btnAdd, 1, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 230)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(844, 44)
        Me.TableLayoutPanel11.TabIndex = 2
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnback.Location = New System.Drawing.Point(565, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(276, 38)
        Me.btnback.TabIndex = 14
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAdd.Location = New System.Drawing.Point(284, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(275, 38)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 4
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.05444!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.96848!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.85185!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.07407!))
        Me.TableLayoutPanel10.Controls.Add(Me.cboday, 3, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.cborcode, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label6, 2, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.Label5, 2, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label10, 2, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.DTPdate, 3, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.DTPtimein, 3, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.Label7, 2, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.DTPtimeout, 3, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.txtschedID, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.cbocourse, 1, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.cbosection, 1, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.Label9, 0, 5)
        Me.TableLayoutPanel10.Controls.Add(Me.cbosubject, 1, 5)
        Me.TableLayoutPanel10.Controls.Add(Me.cboroomname, 1, 2)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 6
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(844, 221)
        Me.TableLayoutPanel10.TabIndex = 0
        '
        'cboday
        '
        Me.cboday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cboday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboday.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboday.FormattingEnabled = True
        Me.cboday.Items.AddRange(New Object() {"...", "Temporary", "Monday", "Tuesday", "Wednessday", "Thurday", "Friday", "Saturday"})
        Me.cboday.Location = New System.Drawing.Point(592, 3)
        Me.cboday.Name = "cboday"
        Me.cboday.Size = New System.Drawing.Size(161, 33)
        Me.cboday.TabIndex = 36
        '
        'cborcode
        '
        Me.cborcode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cborcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cborcode.Enabled = False
        Me.cborcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborcode.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cborcode.FormattingEnabled = True
        Me.cborcode.Location = New System.Drawing.Point(163, 37)
        Me.cborcode.Name = "cborcode"
        Me.cborcode.Size = New System.Drawing.Size(323, 33)
        Me.cborcode.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(492, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 34)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Time In:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(492, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 36)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(492, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 34)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Day:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPdate
        '
        Me.DTPdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DTPdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTPdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdate.Location = New System.Drawing.Point(592, 37)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(249, 30)
        Me.DTPdate.TabIndex = 25
        '
        'DTPtimein
        '
        Me.DTPtimein.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DTPtimein.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTPtimein.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.DTPtimein.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPtimein.Location = New System.Drawing.Point(592, 73)
        Me.DTPtimein.Name = "DTPtimein"
        Me.DTPtimein.Size = New System.Drawing.Size(249, 30)
        Me.DTPtimein.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(492, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 36)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Time Out:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPtimeout
        '
        Me.DTPtimeout.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DTPtimeout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTPtimeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.DTPtimeout.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPtimeout.Location = New System.Drawing.Point(592, 107)
        Me.DTPtimeout.Name = "DTPtimeout"
        Me.DTPtimeout.Size = New System.Drawing.Size(249, 30)
        Me.DTPtimeout.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(3, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 34)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Room Name:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(3, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 36)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Room Code:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 34)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Schedule Code:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtschedID
        '
        Me.txtschedID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtschedID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtschedID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtschedID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtschedID.Location = New System.Drawing.Point(163, 3)
        Me.txtschedID.Name = "txtschedID"
        Me.txtschedID.Size = New System.Drawing.Size(323, 31)
        Me.txtschedID.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(3, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 36)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Course:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(3, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 39)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Section:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbocourse
        '
        Me.cbocourse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbocourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbocourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocourse.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbocourse.FormattingEnabled = True
        Me.cbocourse.Location = New System.Drawing.Point(163, 107)
        Me.cbocourse.Name = "cbocourse"
        Me.cbocourse.Size = New System.Drawing.Size(323, 33)
        Me.cbocourse.TabIndex = 38
        '
        'cbosection
        '
        Me.cbosection.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbosection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbosection.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosection.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbosection.FormattingEnabled = True
        Me.cbosection.Location = New System.Drawing.Point(163, 143)
        Me.cbosection.Name = "cbosection"
        Me.cbosection.Size = New System.Drawing.Size(323, 33)
        Me.cbosection.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(3, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 42)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Subject:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbosubject
        '
        Me.cbosubject.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbosubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbosubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosubject.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbosubject.FormattingEnabled = True
        Me.cbosubject.Location = New System.Drawing.Point(163, 182)
        Me.cbosubject.Name = "cbosubject"
        Me.cbosubject.Size = New System.Drawing.Size(323, 33)
        Me.cbosubject.TabIndex = 37
        '
        'cboroomname
        '
        Me.cboroomname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cboroomname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboroomname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboroomname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboroomname.FormattingEnabled = True
        Me.cboroomname.Location = New System.Drawing.Point(163, 73)
        Me.cboroomname.Name = "cboroomname"
        Me.cboroomname.Size = New System.Drawing.Size(323, 33)
        Me.cboroomname.TabIndex = 40
        '
        'staffschedule_request_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources._467460386_1064088022134846_6079649981189841706_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(850, 277)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staffschedule_request_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staff_request_add"
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents btnback As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents cboday As ComboBox
    Friend WithEvents cborcode As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DTPdate As DateTimePicker
    Friend WithEvents DTPtimein As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents DTPtimeout As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtschedID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbocourse As ComboBox
    Friend WithEvents cbosection As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbosubject As ComboBox
    Friend WithEvents cboroomname As ComboBox
End Class
