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
        Me.btncreate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnsignout = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnroomlist = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btncreate
        '
        Me.btncreate.AutoSize = True
        Me.btncreate.BackColor = System.Drawing.Color.Transparent
        Me.btncreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btncreate.Location = New System.Drawing.Point(716, 309)
        Me.btncreate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(424, 54)
        Me.btncreate.TabIndex = 21
        Me.btncreate.Text = " Schedule"
        Me.btncreate.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Button2.Location = New System.Drawing.Point(717, 392)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(424, 54)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Feedbacks"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnsignout
        '
        Me.btnsignout.AutoSize = True
        Me.btnsignout.BackColor = System.Drawing.Color.Transparent
        Me.btnsignout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsignout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignout.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnsignout.Location = New System.Drawing.Point(849, 474)
        Me.btnsignout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsignout.Name = "btnsignout"
        Me.btnsignout.Size = New System.Drawing.Size(171, 54)
        Me.btnsignout.TabIndex = 24
        Me.btnsignout.Text = "Sign-Out"
        Me.btnsignout.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Button4.Location = New System.Drawing.Point(21, 18)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 52)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = ":"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnroomlist
        '
        Me.btnroomlist.AutoSize = True
        Me.btnroomlist.BackColor = System.Drawing.Color.Transparent
        Me.btnroomlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnroomlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnroomlist.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnroomlist.Location = New System.Drawing.Point(716, 228)
        Me.btnroomlist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnroomlist.Name = "btnroomlist"
        Me.btnroomlist.Size = New System.Drawing.Size(424, 54)
        Me.btnroomlist.TabIndex = 26
        Me.btnroomlist.Text = "Room List"
        Me.btnroomlist.UseVisualStyleBackColor = False
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btnroomlist)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnsignout)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btncreate)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Student"
        Me.Text = "student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncreate As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnsignout As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnroomlist As Button
End Class
