<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Kayıt = New System.Windows.Forms.Timer(Me.components)
        Me.Oynat = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(30, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kayıt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(93, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Duraklat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(24, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Durdur"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 194)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 6
        Me.ListBox1.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(138, 194)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 7
        Me.ListBox2.Visible = False
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(264, 194)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.TabIndex = 8
        Me.ListBox3.Visible = False
        '
        'Kayıt
        '
        Me.Kayıt.Interval = 10
        '
        'Oynat
        '
        Me.Oynat.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(139, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Durum"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(12, 171)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(121, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Kayıt Sırasında Gizle"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(173, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Oynat"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = Global.Makro.My.Resources.Resources.play
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button4.Location = New System.Drawing.Point(162, 83)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 61)
        Me.Button4.TabIndex = 11
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = Global.Makro.My.Resources.Resources.durdur
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button3.Location = New System.Drawing.Point(12, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 61)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.Makro.My.Resources.Resources.Duraklat
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.Location = New System.Drawing.Point(87, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 61)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.Makro.My.Resources.Resources.e2c76caef0769df1d24ee920e7a5f31e
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(12, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 61)
        Me.Button1.TabIndex = 0
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(238, 167)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "Durdur"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(399, 194)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(120, 95)
        Me.ListBox4.TabIndex = 14
        Me.ListBox4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(174, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(302, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Label8"
        Me.Label8.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 95
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 201)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Fare Kayıt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Kayıt As Timer
    Friend WithEvents Oynat As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
End Class
