<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_request_modify
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.cborcode = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboday = New System.Windows.Forms.ComboBox()
        Me.DTPdate = New System.Windows.Forms.DateTimePicker()
        Me.DTPtimein = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTPtimeout = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdetail = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtschedID = New System.Windows.Forms.TextBox()
        Me.DGVroomlist = New System.Windows.Forms.DataGridView()
        Me.room_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.room_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.building = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_chairs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_computers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_laptops = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        CType(Me.DGVroomlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel7, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.DGVroomlist, 1, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.50973!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.41245!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.07782!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1056, 555)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.76238!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.23763!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel9, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(23, 23)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1010, 84)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(234, 78)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Schedule"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 5
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.73142!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.25033!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.64667!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.59713!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.77445!))
        Me.TableLayoutPanel9.Controls.Add(Me.cboType, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.btnsearch, 4, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.txtsearch, 3, 1)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(243, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(764, 78)
        Me.TableLayoutPanel9.TabIndex = 1
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cboType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Choose", "Room Code", "Room Name", "Building", "Availability", "Chair #", "Computer #", "Laptop #"})
        Me.cboType.Location = New System.Drawing.Point(138, 40)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(179, 33)
        Me.cboType.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 41)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Search for :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(323, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 41)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "SEARCH :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnsearch.Location = New System.Drawing.Point(622, 40)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(139, 35)
        Me.btnsearch.TabIndex = 12
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtsearch.Location = New System.Drawing.Point(419, 40)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(197, 31)
        Me.txtsearch.TabIndex = 14
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.80198!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.19802!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel11, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel10, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(23, 331)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1010, 200)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.Controls.Add(Me.btnback, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.btnupdate, 0, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(707, 3)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 2
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(300, 194)
        Me.TableLayoutPanel11.TabIndex = 1
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnback.Location = New System.Drawing.Point(153, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(144, 40)
        Me.btnback.TabIndex = 14
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnupdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnupdate.Location = New System.Drawing.Point(3, 3)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(144, 40)
        Me.btnupdate.TabIndex = 13
        Me.btnupdate.Text = "Modify"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 4
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.05444!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.96848!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.85185!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.07407!))
        Me.TableLayoutPanel10.Controls.Add(Me.cborcode, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label6, 2, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.Label5, 2, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label10, 2, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.cboday, 3, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.DTPdate, 3, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.DTPtimein, 3, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.Label7, 2, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.DTPtimeout, 3, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.txtdetail, 1, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.txtname, 1, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.txtschedID, 1, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 5
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(698, 194)
        Me.TableLayoutPanel10.TabIndex = 0
        '
        'cborcode
        '
        Me.cborcode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cborcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cborcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborcode.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cborcode.FormattingEnabled = True
        Me.cborcode.Items.AddRange(New Object() {"...", "Temporary", "Monday", "Tuesday", "Wednessday", "Thurday", "Friday", "Saturday"})
        Me.cborcode.Location = New System.Drawing.Point(136, 39)
        Me.cborcode.Name = "cborcode"
        Me.cborcode.Size = New System.Drawing.Size(266, 33)
        Me.cborcode.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(408, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 36)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Time In:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(408, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 35)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(408, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 36)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Day:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboday
        '
        Me.cboday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cboday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboday.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboday.FormattingEnabled = True
        Me.cboday.Items.AddRange(New Object() {"...", "Temporary", "Monday", "Tuesday", "Wednessday", "Thurday", "Friday", "Saturday"})
        Me.cboday.Location = New System.Drawing.Point(490, 3)
        Me.cboday.Name = "cboday"
        Me.cboday.Size = New System.Drawing.Size(205, 33)
        Me.cboday.TabIndex = 22
        '
        'DTPdate
        '
        Me.DTPdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DTPdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTPdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdate.Location = New System.Drawing.Point(490, 39)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(205, 30)
        Me.DTPdate.TabIndex = 25
        '
        'DTPtimein
        '
        Me.DTPtimein.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DTPtimein.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTPtimein.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.DTPtimein.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPtimein.Location = New System.Drawing.Point(490, 74)
        Me.DTPtimein.Name = "DTPtimein"
        Me.DTPtimein.Size = New System.Drawing.Size(205, 30)
        Me.DTPtimein.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(408, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 35)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Time Out:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DTPtimeout
        '
        Me.DTPtimeout.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DTPtimeout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTPtimeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.DTPtimeout.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPtimeout.Location = New System.Drawing.Point(490, 110)
        Me.DTPtimeout.Name = "DTPtimeout"
        Me.DTPtimeout.Size = New System.Drawing.Size(205, 30)
        Me.DTPtimeout.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(3, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 35)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Detail:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtdetail
        '
        Me.txtdetail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtdetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetail.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtdetail.Location = New System.Drawing.Point(136, 110)
        Me.txtdetail.Name = "txtdetail"
        Me.txtdetail.Size = New System.Drawing.Size(266, 31)
        Me.txtdetail.TabIndex = 19
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtname.Location = New System.Drawing.Point(136, 74)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(266, 31)
        Me.txtname.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(3, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 36)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Room Name:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(3, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 35)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Room Code:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 36)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Schedule Code:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtschedID
        '
        Me.txtschedID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtschedID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtschedID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtschedID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtschedID.Location = New System.Drawing.Point(136, 3)
        Me.txtschedID.Name = "txtschedID"
        Me.txtschedID.Size = New System.Drawing.Size(266, 31)
        Me.txtschedID.TabIndex = 30
        '
        'DGVroomlist
        '
        Me.DGVroomlist.AllowUserToAddRows = False
        Me.DGVroomlist.AllowUserToDeleteRows = False
        Me.DGVroomlist.AllowUserToResizeColumns = False
        Me.DGVroomlist.AllowUserToResizeRows = False
        Me.DGVroomlist.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVroomlist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVroomlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVroomlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.room_code, Me.room_name, Me.building, Me.status, Me.num_chairs, Me.num_computers, Me.num_laptops})
        Me.DGVroomlist.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVroomlist.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVroomlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVroomlist.GridColor = System.Drawing.SystemColors.HotTrack
        Me.DGVroomlist.Location = New System.Drawing.Point(23, 113)
        Me.DGVroomlist.Name = "DGVroomlist"
        Me.DGVroomlist.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVroomlist.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVroomlist.RowHeadersWidth = 62
        Me.DGVroomlist.Size = New System.Drawing.Size(1010, 212)
        Me.DGVroomlist.TabIndex = 4
        '
        'room_code
        '
        Me.room_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.room_code.HeaderText = "Room Code"
        Me.room_code.Name = "room_code"
        Me.room_code.ReadOnly = True
        '
        'room_name
        '
        Me.room_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.room_name.HeaderText = "Room Name"
        Me.room_name.Name = "room_name"
        Me.room_name.ReadOnly = True
        '
        'building
        '
        Me.building.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.building.HeaderText = "Building"
        Me.building.Name = "building"
        Me.building.ReadOnly = True
        '
        'status
        '
        Me.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.status.HeaderText = "Availability"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'num_chairs
        '
        Me.num_chairs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.num_chairs.HeaderText = "Chair #"
        Me.num_chairs.Name = "num_chairs"
        Me.num_chairs.ReadOnly = True
        '
        'num_computers
        '
        Me.num_computers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.num_computers.HeaderText = "Computer #"
        Me.num_computers.Name = "num_computers"
        Me.num_computers.ReadOnly = True
        '
        'num_laptops
        '
        Me.num_laptops.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.num_laptops.HeaderText = "Laptop #"
        Me.num_laptops.Name = "num_laptops"
        Me.num_laptops.ReadOnly = True
        '
        'staff_request_modify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources._467460386_1064088022134846_6079649981189841706_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1056, 555)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staff_request_modify"
        Me.Text = "staff_request_modify"
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        CType(Me.DGVroomlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnback As Button
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents cborcode As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboday As ComboBox
    Friend WithEvents DTPdate As DateTimePicker
    Friend WithEvents DTPtimein As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents DTPtimeout As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txtdetail As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtschedID As TextBox
    Friend WithEvents DGVroomlist As DataGridView
    Friend WithEvents room_code As DataGridViewTextBoxColumn
    Friend WithEvents room_name As DataGridViewTextBoxColumn
    Friend WithEvents building As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents num_chairs As DataGridViewTextBoxColumn
    Friend WithEvents num_computers As DataGridViewTextBoxColumn
    Friend WithEvents num_laptops As DataGridViewTextBoxColumn
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtsearch As TextBox
End Class
