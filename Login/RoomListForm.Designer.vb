<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoomListForm))
        Me.dgvRoomList = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnUpdateRoomStatus = New System.Windows.Forms.Button()
        Me.cmbRoomStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.txtNumChairs = New System.Windows.Forms.TextBox()
        Me.txtNumComputers = New System.Windows.Forms.TextBox()
        Me.txtNumLaptops = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdateRoomDetails = New System.Windows.Forms.Button()
        CType(Me.dgvRoomList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRoomList
        '
        Me.dgvRoomList.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomList.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvRoomList.Location = New System.Drawing.Point(6, 48)
        Me.dgvRoomList.Name = "dgvRoomList"
        Me.dgvRoomList.RowHeadersWidth = 62
        Me.dgvRoomList.Size = New System.Drawing.Size(1009, 368)
        Me.dgvRoomList.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(12, 456)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(74, 22)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBack.Location = New System.Drawing.Point(941, 490)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(74, 22)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnUpdateRoomStatus
        '
        Me.btnUpdateRoomStatus.Location = New System.Drawing.Point(12, 427)
        Me.btnUpdateRoomStatus.Name = "btnUpdateRoomStatus"
        Me.btnUpdateRoomStatus.Size = New System.Drawing.Size(84, 22)
        Me.btnUpdateRoomStatus.TabIndex = 4
        Me.btnUpdateRoomStatus.Text = "Update Status"
        Me.btnUpdateRoomStatus.UseVisualStyleBackColor = True
        '
        'cmbRoomStatus
        '
        Me.cmbRoomStatus.FormattingEnabled = True
        Me.cmbRoomStatus.Items.AddRange(New Object() {"Occupied", "Not Occupied", "Closed"})
        Me.cmbRoomStatus.Location = New System.Drawing.Point(109, 422)
        Me.cmbRoomStatus.Name = "cmbRoomStatus"
        Me.cmbRoomStatus.Size = New System.Drawing.Size(120, 21)
        Me.cmbRoomStatus.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1040, 43)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ROOM LIST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(244, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "BUILDING NAME :"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cboType.Location = New System.Drawing.Point(379, 15)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(136, 21)
        Me.cboType.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(516, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ROOM :"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(593, 14)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(177, 20)
        Me.txtsearch.TabIndex = 10
        '
        'txtNumChairs
        '
        Me.txtNumChairs.Location = New System.Drawing.Point(513, 420)
        Me.txtNumChairs.Name = "txtNumChairs"
        Me.txtNumChairs.Size = New System.Drawing.Size(99, 20)
        Me.txtNumChairs.TabIndex = 11
        '
        'txtNumComputers
        '
        Me.txtNumComputers.Location = New System.Drawing.Point(513, 451)
        Me.txtNumComputers.Name = "txtNumComputers"
        Me.txtNumComputers.Size = New System.Drawing.Size(99, 20)
        Me.txtNumComputers.TabIndex = 12
        '
        'txtNumLaptops
        '
        Me.txtNumLaptops.Location = New System.Drawing.Point(513, 487)
        Me.txtNumLaptops.Name = "txtNumLaptops"
        Me.txtNumLaptops.Size = New System.Drawing.Size(99, 20)
        Me.txtNumLaptops.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 420)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Enter Number of Chairs : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(327, 456)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Enter Number of Computers : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(328, 487)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Enter Number of Laptops : "
        '
        'btnUpdateRoomDetails
        '
        Me.btnUpdateRoomDetails.Location = New System.Drawing.Point(635, 487)
        Me.btnUpdateRoomDetails.Name = "btnUpdateRoomDetails"
        Me.btnUpdateRoomDetails.Size = New System.Drawing.Size(116, 22)
        Me.btnUpdateRoomDetails.TabIndex = 17
        Me.btnUpdateRoomDetails.Text = "Update Room Details"
        Me.btnUpdateRoomDetails.UseVisualStyleBackColor = True
        '
        'RoomListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1040, 516)
        Me.Controls.Add(Me.btnUpdateRoomDetails)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNumLaptops)
        Me.Controls.Add(Me.txtNumComputers)
        Me.Controls.Add(Me.txtNumChairs)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRoomStatus)
        Me.Controls.Add(Me.btnUpdateRoomStatus)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvRoomList)
        Me.Name = "RoomListForm"
        Me.Text = "RoomListForm"
        CType(Me.dgvRoomList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRoomList As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnUpdateRoomStatus As Button
    Friend WithEvents cmbRoomStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents txtNumChairs As TextBox
    Friend WithEvents txtNumComputers As TextBox
    Friend WithEvents txtNumLaptops As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUpdateRoomDetails As Button
End Class
