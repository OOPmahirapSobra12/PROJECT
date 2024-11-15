<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomoccupancy
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
        Me.cboChoose = New System.Windows.Forms.ComboBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.txtroom = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cboChoose
        '
        Me.cboChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cboChoose.FormattingEnabled = True
        Me.cboChoose.Items.AddRange(New Object() {"Choose:", "Room Code", "Room Name"})
        Me.cboChoose.Location = New System.Drawing.Point(50, 174)
        Me.cboChoose.Name = "cboChoose"
        Me.cboChoose.Size = New System.Drawing.Size(121, 32)
        Me.cboChoose.TabIndex = 106
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnback.Location = New System.Drawing.Point(244, 246)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(70, 32)
        Me.btnback.TabIndex = 105
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnClear.Location = New System.Drawing.Point(382, 117)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 32)
        Me.btnClear.TabIndex = 104
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.Transparent
        Me.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnregister.Location = New System.Drawing.Point(210, 208)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(123, 32)
        Me.btnregister.TabIndex = 103
        Me.btnregister.Text = "Register"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(177, 138)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(199, 29)
        Me.txtpassword.TabIndex = 102
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(177, 103)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(199, 29)
        Me.txtID.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(69, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 24)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Account ID:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(74, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnconfirm
        '
        Me.btnconfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnconfirm.Location = New System.Drawing.Point(382, 173)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(123, 32)
        Me.btnconfirm.TabIndex = 98
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = False
        '
        'txtroom
        '
        Me.txtroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroom.Location = New System.Drawing.Point(177, 173)
        Me.txtroom.Name = "txtroom"
        Me.txtroom.Size = New System.Drawing.Size(199, 29)
        Me.txtroom.TabIndex = 97
        '
        'roomoccupancy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(543, 297)
        Me.Controls.Add(Me.cboChoose)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.txtroom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "roomoccupancy"
        Me.Text = "roomoccupancy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboChoose As ComboBox
    Friend WithEvents btnback As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnregister As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnconfirm As Button
    Friend WithEvents txtroom As TextBox
End Class
