<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addscheduleadmin
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbosearch = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbominuteout = New System.Windows.Forms.ComboBox()
        Me.cboampmout = New System.Windows.Forms.ComboBox()
        Me.cbohourout = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtrname = New System.Windows.Forms.TextBox()
        Me.txtrcode = New System.Windows.Forms.TextBox()
        Me.txtrDD = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.Label()
        Me.txtroom = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboDD = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbuilding = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbominutein = New System.Windows.Forms.ComboBox()
        Me.cboampmin = New System.Windows.Forms.ComboBox()
        Me.cbohourin = New System.Windows.Forms.ComboBox()
        Me.DGVrooms = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnaddschedule = New System.Windows.Forms.Button()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.DGVrooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.53919!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.0095!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.45131!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.DGVrooms, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(23, 80)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60777!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.71533!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.86131!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(754, 314)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.41711!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.58289!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.8877!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.1123!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnsearch, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtsearchbox, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cbosearch, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(748, 46)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'btnsearch
        '
        Me.btnsearch.AutoSize = True
        Me.btnsearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnsearch.Location = New System.Drawing.Point(621, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(124, 40)
        Me.btnsearch.TabIndex = 0
        Me.btnsearch.Text = "btnsearch"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtsearchbox
        '
        Me.txtsearchbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtsearchbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtsearchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtsearchbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtsearchbox.Location = New System.Drawing.Point(376, 3)
        Me.txtsearchbox.Name = "txtsearchbox"
        Me.txtsearchbox.Size = New System.Drawing.Size(239, 31)
        Me.txtsearchbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Box:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbosearch
        '
        Me.cbosearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbosearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbosearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Location = New System.Drawing.Point(237, 3)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(133, 33)
        Me.cbosearch.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.25134!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.54011!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.7754!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.80749!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.02674!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel7, 3, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.btnadd, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtrname, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtrcode, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtrDD, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtcode, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtroom, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.cboDD, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtbuilding, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 3, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 201)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.41667!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.29167!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(748, 110)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.AutoSize = True
        Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.Controls.Add(Me.cbominuteout, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.cboampmout, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.cbohourout, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(468, 77)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(201, 30)
        Me.TableLayoutPanel7.TabIndex = 17
        '
        'cbominuteout
        '
        Me.cbominuteout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbominuteout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbominuteout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbominuteout.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbominuteout.FormattingEnabled = True
        Me.cbominuteout.Location = New System.Drawing.Point(70, 3)
        Me.cbominuteout.Name = "cbominuteout"
        Me.cbominuteout.Size = New System.Drawing.Size(61, 21)
        Me.cbominuteout.TabIndex = 1
        '
        'cboampmout
        '
        Me.cboampmout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cboampmout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboampmout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboampmout.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboampmout.FormattingEnabled = True
        Me.cboampmout.Location = New System.Drawing.Point(137, 3)
        Me.cboampmout.Name = "cboampmout"
        Me.cboampmout.Size = New System.Drawing.Size(61, 21)
        Me.cboampmout.TabIndex = 2
        '
        'cbohourout
        '
        Me.cbohourout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbohourout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbohourout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbohourout.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbohourout.FormattingEnabled = True
        Me.cbohourout.Location = New System.Drawing.Point(3, 3)
        Me.cbohourout.Name = "cbohourout"
        Me.cbohourout.Size = New System.Drawing.Size(61, 21)
        Me.cbohourout.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(359, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 36)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Time OUT:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnadd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnadd.Location = New System.Drawing.Point(675, 3)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(70, 33)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'txtrname
        '
        Me.txtrname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtrname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtrname.Location = New System.Drawing.Point(146, 3)
        Me.txtrname.Name = "txtrname"
        Me.txtrname.Size = New System.Drawing.Size(199, 29)
        Me.txtrname.TabIndex = 0
        '
        'txtrcode
        '
        Me.txtrcode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtrcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtrcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrcode.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtrcode.Location = New System.Drawing.Point(146, 42)
        Me.txtrcode.Name = "txtrcode"
        Me.txtrcode.Size = New System.Drawing.Size(199, 29)
        Me.txtrcode.TabIndex = 1
        '
        'txtrDD
        '
        Me.txtrDD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtrDD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtrDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrDD.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtrDD.Location = New System.Drawing.Point(468, 3)
        Me.txtrDD.Name = "txtrDD"
        Me.txtrDD.Size = New System.Drawing.Size(201, 29)
        Me.txtrDD.TabIndex = 4
        '
        'txtcode
        '
        Me.txtcode.AutoSize = True
        Me.txtcode.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtcode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtcode.Location = New System.Drawing.Point(18, 0)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(122, 39)
        Me.txtcode.TabIndex = 8
        Me.txtcode.Text = "Room Name:"
        Me.txtcode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtroom
        '
        Me.txtroom.AutoSize = True
        Me.txtroom.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroom.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtroom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtroom.Location = New System.Drawing.Point(23, 39)
        Me.txtroom.Name = "txtroom"
        Me.txtroom.Size = New System.Drawing.Size(117, 35)
        Me.txtroom.TabIndex = 9
        Me.txtroom.Text = "Room Code:"
        Me.txtroom.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 36)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Building Letter:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboDD
        '
        Me.cboDD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cboDD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboDD.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboDD.FormattingEnabled = True
        Me.cboDD.Location = New System.Drawing.Point(351, 3)
        Me.cboDD.Name = "cboDD"
        Me.cboDD.Size = New System.Drawing.Size(111, 21)
        Me.cboDD.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(381, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 35)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Time IN:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtbuilding
        '
        Me.txtbuilding.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtbuilding.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbuilding.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuilding.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtbuilding.Location = New System.Drawing.Point(146, 77)
        Me.txtbuilding.Name = "txtbuilding"
        Me.txtbuilding.Size = New System.Drawing.Size(199, 29)
        Me.txtbuilding.TabIndex = 2
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.AutoSize = True
        Me.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Controls.Add(Me.cbominutein, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.cboampmin, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.cbohourin, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(468, 42)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(201, 29)
        Me.TableLayoutPanel6.TabIndex = 16
        '
        'cbominutein
        '
        Me.cbominutein.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbominutein.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbominutein.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbominutein.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbominutein.FormattingEnabled = True
        Me.cbominutein.Location = New System.Drawing.Point(70, 3)
        Me.cbominutein.Name = "cbominutein"
        Me.cbominutein.Size = New System.Drawing.Size(61, 21)
        Me.cbominutein.TabIndex = 1
        '
        'cboampmin
        '
        Me.cboampmin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cboampmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboampmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboampmin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboampmin.FormattingEnabled = True
        Me.cboampmin.Location = New System.Drawing.Point(137, 3)
        Me.cboampmin.Name = "cboampmin"
        Me.cboampmin.Size = New System.Drawing.Size(61, 21)
        Me.cboampmin.TabIndex = 2
        '
        'cbohourin
        '
        Me.cbohourin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbohourin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbohourin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbohourin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbohourin.FormattingEnabled = True
        Me.cbohourin.Location = New System.Drawing.Point(3, 3)
        Me.cbohourin.Name = "cbohourin"
        Me.cbohourin.Size = New System.Drawing.Size(61, 21)
        Me.cbohourin.TabIndex = 17
        '
        'DGVrooms
        '
        Me.DGVrooms.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVrooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVrooms.GridColor = System.Drawing.Color.MidnightBlue
        Me.DGVrooms.Location = New System.Drawing.Point(3, 55)
        Me.DGVrooms.Name = "DGVrooms"
        Me.DGVrooms.Size = New System.Drawing.Size(748, 140)
        Me.DGVrooms.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnback, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnclear, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnaddschedule, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnconfirm, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(23, 400)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(754, 38)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnback.Location = New System.Drawing.Point(567, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(184, 32)
        Me.btnback.TabIndex = 0
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnclear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnclear.Location = New System.Drawing.Point(379, 3)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(182, 32)
        Me.btnclear.TabIndex = 1
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnaddschedule
        '
        Me.btnaddschedule.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnaddschedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnaddschedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaddschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddschedule.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnaddschedule.Location = New System.Drawing.Point(191, 3)
        Me.btnaddschedule.Name = "btnaddschedule"
        Me.btnaddschedule.Size = New System.Drawing.Size(182, 32)
        Me.btnaddschedule.TabIndex = 2
        Me.btnaddschedule.Text = "Add Schedule"
        Me.btnaddschedule.UseVisualStyleBackColor = False
        '
        'btnconfirm
        '
        Me.btnconfirm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnconfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnconfirm.Location = New System.Drawing.Point(3, 3)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(182, 32)
        Me.btnconfirm.TabIndex = 15
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(23, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(754, 57)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Schedule Module"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'addscheduleadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Login.My.Resources.Resources._467460386_1064088022134846_6079649981189841706_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addscheduleadmin"
        Me.Text = "addscheduleadmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.DGVrooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearchbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbosearch As ComboBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents cbominuteout As ComboBox
    Friend WithEvents cboampmout As ComboBox
    Friend WithEvents cbohourout As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents txtrname As TextBox
    Friend WithEvents txtrcode As TextBox
    Friend WithEvents txtrDD As TextBox
    Friend WithEvents txtcode As Label
    Friend WithEvents txtroom As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboDD As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbuilding As TextBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents cbominutein As ComboBox
    Friend WithEvents cboampmin As ComboBox
    Friend WithEvents cbohourin As ComboBox
    Friend WithEvents DGVrooms As DataGridView
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnback As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnaddschedule As Button
    Friend WithEvents btnconfirm As Button
    Friend WithEvents Label3 As Label
End Class
