<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomlistStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoomlistStaff))
        Me.txtroomnumber = New System.Windows.Forms.TextBox()
        Me.txtroomname = New System.Windows.Forms.TextBox()
        Me.txtcapacity = New System.Windows.Forms.TextBox()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBoxRoomNumber = New System.Windows.Forms.ComboBox()
        Me.ComboBoxRoomName = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCapacity = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtroomnumber
        '
        Me.txtroomnumber.BackColor = System.Drawing.SystemColors.Info
        Me.txtroomnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroomnumber.Location = New System.Drawing.Point(622, 293)
        Me.txtroomnumber.Name = "txtroomnumber"
        Me.txtroomnumber.Size = New System.Drawing.Size(148, 30)
        Me.txtroomnumber.TabIndex = 4
        Me.txtroomnumber.Text = "Room Number"
        '
        'txtroomname
        '
        Me.txtroomname.BackColor = System.Drawing.SystemColors.Info
        Me.txtroomname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroomname.Location = New System.Drawing.Point(622, 355)
        Me.txtroomname.Name = "txtroomname"
        Me.txtroomname.Size = New System.Drawing.Size(148, 30)
        Me.txtroomname.TabIndex = 5
        Me.txtroomname.Text = "  Room Name"
        '
        'txtcapacity
        '
        Me.txtcapacity.BackColor = System.Drawing.SystemColors.Info
        Me.txtcapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcapacity.Location = New System.Drawing.Point(622, 422)
        Me.txtcapacity.Name = "txtcapacity"
        Me.txtcapacity.Size = New System.Drawing.Size(148, 30)
        Me.txtcapacity.TabIndex = 6
        Me.txtcapacity.Text = "    Capacity"
        '
        'btnconfirm
        '
        Me.btnconfirm.Location = New System.Drawing.Point(1023, 574)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(133, 35)
        Me.btnconfirm.TabIndex = 8
        Me.btnconfirm.Text = "Confirm Selection"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(813, 574)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(133, 35)
        Me.btnback.TabIndex = 9
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1252, 677)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ComboBoxRoomNumber
        '
        Me.ComboBoxRoomNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxRoomNumber.FormattingEnabled = True
        Me.ComboBoxRoomNumber.Location = New System.Drawing.Point(813, 293)
        Me.ComboBoxRoomNumber.Name = "ComboBoxRoomNumber"
        Me.ComboBoxRoomNumber.Size = New System.Drawing.Size(308, 33)
        Me.ComboBoxRoomNumber.TabIndex = 12
        '
        'ComboBoxRoomName
        '
        Me.ComboBoxRoomName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxRoomName.FormattingEnabled = True
        Me.ComboBoxRoomName.Location = New System.Drawing.Point(813, 355)
        Me.ComboBoxRoomName.Name = "ComboBoxRoomName"
        Me.ComboBoxRoomName.Size = New System.Drawing.Size(308, 33)
        Me.ComboBoxRoomName.TabIndex = 13
        '
        'ComboBoxCapacity
        '
        Me.ComboBoxCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCapacity.FormattingEnabled = True
        Me.ComboBoxCapacity.Location = New System.Drawing.Point(813, 422)
        Me.ComboBoxCapacity.Name = "ComboBoxCapacity"
        Me.ComboBoxCapacity.Size = New System.Drawing.Size(308, 33)
        Me.ComboBoxCapacity.TabIndex = 14
        '
        'RoomlistStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 673)
        Me.Controls.Add(Me.ComboBoxCapacity)
        Me.Controls.Add(Me.ComboBoxRoomName)
        Me.Controls.Add(Me.ComboBoxRoomNumber)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.txtcapacity)
        Me.Controls.Add(Me.txtroomname)
        Me.Controls.Add(Me.txtroomnumber)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "RoomlistStaff"
        Me.Text = "Roomlist Staff"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtroomnumber As TextBox
    Friend WithEvents txtroomname As TextBox
    Friend WithEvents txtcapacity As TextBox
    Friend WithEvents btnconfirm As Button
    Friend WithEvents btnback As Button
    Friend WithEvents ComboBoxRoomNumber As ComboBox
    Friend WithEvents ComboBoxRoomName As ComboBox
    Friend WithEvents ComboBoxCapacity As ComboBox
End Class
