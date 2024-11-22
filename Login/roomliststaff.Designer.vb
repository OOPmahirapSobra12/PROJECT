<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomliststaff
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
        Me.DGVroomlist = New System.Windows.Forms.DataGridView()
        Me.RoomCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Building = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Availability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Computer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Laptop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtsearch1 = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnSearch1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DGVroomlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVroomlist
        '
        Me.DGVroomlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVroomlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomCode, Me.RoomName, Me.Building, Me.Availability, Me.Chair, Me.Computer, Me.Laptop})
        Me.DGVroomlist.Location = New System.Drawing.Point(75, 55)
        Me.DGVroomlist.Name = "DGVroomlist"
        Me.DGVroomlist.RowHeadersWidth = 51
        Me.DGVroomlist.RowTemplate.Height = 24
        Me.DGVroomlist.Size = New System.Drawing.Size(1219, 438)
        Me.DGVroomlist.TabIndex = 7
        '
        'RoomCode
        '
        Me.RoomCode.HeaderText = "Room Code"
        Me.RoomCode.MinimumWidth = 6
        Me.RoomCode.Name = "RoomCode"
        Me.RoomCode.Width = 125
        '
        'RoomName
        '
        Me.RoomName.HeaderText = "Room Name"
        Me.RoomName.MinimumWidth = 6
        Me.RoomName.Name = "RoomName"
        Me.RoomName.Width = 125
        '
        'Building
        '
        Me.Building.HeaderText = "Building"
        Me.Building.MinimumWidth = 6
        Me.Building.Name = "Building"
        Me.Building.Width = 125
        '
        'Availability
        '
        Me.Availability.HeaderText = "Availability"
        Me.Availability.MinimumWidth = 6
        Me.Availability.Name = "Availability"
        Me.Availability.Width = 125
        '
        'Chair
        '
        Me.Chair.HeaderText = "Chair"
        Me.Chair.MinimumWidth = 6
        Me.Chair.Name = "Chair"
        Me.Chair.Width = 125
        '
        'Computer
        '
        Me.Computer.HeaderText = "Computer"
        Me.Computer.MinimumWidth = 6
        Me.Computer.Name = "Computer"
        Me.Computer.Width = 125
        '
        'Laptop
        '
        Me.Laptop.HeaderText = "Laptop"
        Me.Laptop.MinimumWidth = 6
        Me.Laptop.Name = "Laptop"
        Me.Laptop.Width = 125
        '
        'txtsearch1
        '
        Me.txtsearch1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch1.Location = New System.Drawing.Point(826, 13)
        Me.txtsearch1.Name = "txtsearch1"
        Me.txtsearch1.Size = New System.Drawing.Size(252, 30)
        Me.txtsearch1.TabIndex = 13
        '
        'cboType
        '
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(385, 10)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(216, 33)
        Me.cboType.TabIndex = 12
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(1103, 502)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(109, 32)
        Me.btnback.TabIndex = 11
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnSearch1
        '
        Me.btnSearch1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch1.Location = New System.Drawing.Point(1103, 12)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(109, 32)
        Me.btnSearch1.TabIndex = 10
        Me.btnSearch1.Text = "Search"
        Me.btnSearch1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextBox2.Location = New System.Drawing.Point(668, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(136, 30)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "Search :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.Location = New System.Drawing.Point(207, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 30)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "Search For:"
        '
        'roomliststaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 545)
        Me.Controls.Add(Me.DGVroomlist)
        Me.Controls.Add(Me.txtsearch1)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnSearch1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "roomliststaff"
        Me.Text = "roomliststaff"
        CType(Me.DGVroomlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVroomlist As DataGridView
    Friend WithEvents RoomCode As DataGridViewTextBoxColumn
    Friend WithEvents RoomName As DataGridViewTextBoxColumn
    Friend WithEvents Building As DataGridViewTextBoxColumn
    Friend WithEvents Availability As DataGridViewTextBoxColumn
    Friend WithEvents Chair As DataGridViewTextBoxColumn
    Friend WithEvents Computer As DataGridViewTextBoxColumn
    Friend WithEvents Laptop As DataGridViewTextBoxColumn
    Friend WithEvents txtsearch1 As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents btnback As Button
    Friend WithEvents btnSearch1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
