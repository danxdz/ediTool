<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.d1 = New System.Windows.Forms.TextBox()
        Me.d2 = New System.Windows.Forms.TextBox()
        Me.d3 = New System.Windows.Forms.TextBox()
        Me.L1 = New System.Windows.Forms.TextBox()
        Me.L2 = New System.Windows.Forms.TextBox()
        Me.L3 = New System.Windows.Forms.TextBox()
        Me.alpha = New System.Windows.Forms.TextBox()
        Me.NoTT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.menu_5 = New System.Windows.Forms.Label()
        Me.menu_6 = New System.Windows.Forms.Label()
        Me.menu_7 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.menu_11 = New System.Windows.Forms.Label()
        Me.menu_12 = New System.Windows.Forms.Label()
        Me.create = New System.Windows.Forms.Button()
        Me.Name_textbox = New System.Windows.Forms.TextBox()
        Me.chf = New System.Windows.Forms.TextBox()
        Me.menu_2 = New System.Windows.Forms.Label()
        Me.menu_8 = New System.Windows.Forms.Label()
        Me.menu_9 = New System.Windows.Forms.Label()
        Me.menu_10 = New System.Windows.Forms.Label()
        Me.menu_3 = New System.Windows.Forms.Label()
        Me.menu_4 = New System.Windows.Forms.Label()
        Me.menu_1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lang_en = New System.Windows.Forms.Button()
        Me.lang_fr = New System.Windows.Forms.Button()
        Me.sel_lang = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(5, 334)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(421, 111)
        Me.DataGridView1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'd1
        '
        Me.d1.AccessibleDescription = "diamètre de coupe"
        Me.d1.AccessibleName = "tthth"
        Me.d1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.d1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.d1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.d1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Location = New System.Drawing.Point(57, 100)
        Me.d1.Name = "d1"
        Me.d1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.d1.Size = New System.Drawing.Size(40, 22)
        Me.d1.TabIndex = 1
        Me.d1.Text = "6"
        Me.d1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'd2
        '
        Me.d2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.d2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.d2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d2.Location = New System.Drawing.Point(379, 100)
        Me.d2.Name = "d2"
        Me.d2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.d2.Size = New System.Drawing.Size(40, 22)
        Me.d2.TabIndex = 2
        Me.d2.Text = "6"
        Me.d2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'd3
        '
        Me.d3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.d3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.d3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d3.Location = New System.Drawing.Point(168, 100)
        Me.d3.Name = "d3"
        Me.d3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.d3.Size = New System.Drawing.Size(40, 22)
        Me.d3.TabIndex = 3
        Me.d3.Text = "5.8"
        Me.d3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.L1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(379, 213)
        Me.L1.Name = "L1"
        Me.L1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.L1.Size = New System.Drawing.Size(40, 22)
        Me.L1.TabIndex = 6
        Me.L1.Text = "53"
        Me.L1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L2
        '
        Me.L2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.L2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.Location = New System.Drawing.Point(57, 213)
        Me.L2.Name = "L2"
        Me.L2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.L2.Size = New System.Drawing.Size(40, 22)
        Me.L2.TabIndex = 5
        Me.L2.Text = "8"
        Me.L2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L3
        '
        Me.L3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.L3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L3.Location = New System.Drawing.Point(168, 213)
        Me.L3.Name = "L3"
        Me.L3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.L3.Size = New System.Drawing.Size(40, 22)
        Me.L3.TabIndex = 4
        Me.L3.Text = "12"
        Me.L3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'alpha
        '
        Me.alpha.BackColor = System.Drawing.Color.LightGray
        Me.alpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alpha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alpha.Location = New System.Drawing.Point(379, 45)
        Me.alpha.Margin = New System.Windows.Forms.Padding(10)
        Me.alpha.Name = "alpha"
        Me.alpha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.alpha.Size = New System.Drawing.Size(32, 26)
        Me.alpha.TabIndex = 8
        Me.alpha.Text = "0"
        Me.alpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NoTT
        '
        Me.NoTT.BackColor = System.Drawing.Color.LightGray
        Me.NoTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoTT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoTT.Location = New System.Drawing.Point(311, 45)
        Me.NoTT.Margin = New System.Windows.Forms.Padding(10)
        Me.NoTT.Name = "NoTT"
        Me.NoTT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NoTT.Size = New System.Drawing.Size(32, 26)
        Me.NoTT.TabIndex = 7
        Me.NoTT.Text = "2"
        Me.NoTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "d1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Location = New System.Drawing.Point(5, 125)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(427, 68)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "d2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "d3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "L1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "L2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(147, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "L3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "a"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(345, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "z"
        '
        'menu_5
        '
        Me.menu_5.AutoSize = True
        Me.menu_5.Location = New System.Drawing.Point(38, 84)
        Me.menu_5.Name = "menu_5"
        Me.menu_5.Size = New System.Drawing.Size(35, 13)
        Me.menu_5.TabIndex = 19
        Me.menu_5.Text = "empty"
        '
        'menu_6
        '
        Me.menu_6.AutoSize = True
        Me.menu_6.Location = New System.Drawing.Point(147, 84)
        Me.menu_6.Name = "menu_6"
        Me.menu_6.Size = New System.Drawing.Size(35, 13)
        Me.menu_6.TabIndex = 20
        Me.menu_6.Text = "empty"
        '
        'menu_7
        '
        Me.menu_7.AutoSize = True
        Me.menu_7.Location = New System.Drawing.Point(360, 84)
        Me.menu_7.Name = "menu_7"
        Me.menu_7.Size = New System.Drawing.Size(35, 13)
        Me.menu_7.TabIndex = 21
        Me.menu_7.Text = "empty"
        '
        'TextBox9
        '
        Me.TextBox9.AccessibleDescription = "diamètre de coupe"
        Me.TextBox9.AccessibleName = "tthth"
        Me.TextBox9.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.TextBox9.Location = New System.Drawing.Point(11, 273)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox9.Size = New System.Drawing.Size(77, 20)
        Me.TextBox9.TabIndex = 22
        '
        'TextBox10
        '
        Me.TextBox10.AccessibleDescription = "diamètre de coupe"
        Me.TextBox10.AccessibleName = "tthth"
        Me.TextBox10.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.TextBox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox10.Location = New System.Drawing.Point(94, 273)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox10.Size = New System.Drawing.Size(31, 20)
        Me.TextBox10.TabIndex = 23
        '
        'menu_11
        '
        Me.menu_11.AutoSize = True
        Me.menu_11.Location = New System.Drawing.Point(11, 257)
        Me.menu_11.Name = "menu_11"
        Me.menu_11.Size = New System.Drawing.Size(35, 13)
        Me.menu_11.TabIndex = 24
        Me.menu_11.Text = "empty"
        '
        'menu_12
        '
        Me.menu_12.AutoSize = True
        Me.menu_12.Location = New System.Drawing.Point(91, 257)
        Me.menu_12.Name = "menu_12"
        Me.menu_12.Size = New System.Drawing.Size(35, 13)
        Me.menu_12.TabIndex = 25
        Me.menu_12.Text = "empty"
        '
        'create
        '
        Me.create.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create.Location = New System.Drawing.Point(335, 268)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(97, 26)
        Me.create.TabIndex = 26
        Me.create.Text = "creer outil"
        Me.create.UseVisualStyleBackColor = True
        '
        'Name_textbox
        '
        Me.Name_textbox.AccessibleDescription = "diamètre de coupe"
        Me.Name_textbox.AccessibleName = "tthth"
        Me.Name_textbox.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.Name_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_textbox.Location = New System.Drawing.Point(5, 45)
        Me.Name_textbox.Name = "Name_textbox"
        Me.Name_textbox.Size = New System.Drawing.Size(246, 26)
        Me.Name_textbox.TabIndex = 27
        Me.Name_textbox.Text = "123"
        '
        'chf
        '
        Me.chf.BackColor = System.Drawing.Color.LightGray
        Me.chf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chf.Location = New System.Drawing.Point(270, 45)
        Me.chf.Margin = New System.Windows.Forms.Padding(10)
        Me.chf.Name = "chf"
        Me.chf.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chf.Size = New System.Drawing.Size(32, 26)
        Me.chf.TabIndex = 28
        Me.chf.Text = "0"
        Me.chf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'menu_2
        '
        Me.menu_2.AutoSize = True
        Me.menu_2.Location = New System.Drawing.Point(267, 30)
        Me.menu_2.Name = "menu_2"
        Me.menu_2.Size = New System.Drawing.Size(35, 13)
        Me.menu_2.TabIndex = 29
        Me.menu_2.Text = "empty"
        '
        'menu_8
        '
        Me.menu_8.AutoSize = True
        Me.menu_8.Location = New System.Drawing.Point(38, 197)
        Me.menu_8.Name = "menu_8"
        Me.menu_8.Size = New System.Drawing.Size(35, 13)
        Me.menu_8.TabIndex = 30
        Me.menu_8.Text = "empty"
        '
        'menu_9
        '
        Me.menu_9.AutoSize = True
        Me.menu_9.Location = New System.Drawing.Point(147, 197)
        Me.menu_9.Name = "menu_9"
        Me.menu_9.Size = New System.Drawing.Size(35, 13)
        Me.menu_9.TabIndex = 31
        Me.menu_9.Text = "empty"
        '
        'menu_10
        '
        Me.menu_10.AutoSize = True
        Me.menu_10.Location = New System.Drawing.Point(360, 197)
        Me.menu_10.Name = "menu_10"
        Me.menu_10.Size = New System.Drawing.Size(35, 13)
        Me.menu_10.TabIndex = 32
        Me.menu_10.Text = "empty"
        '
        'menu_3
        '
        Me.menu_3.AutoSize = True
        Me.menu_3.Location = New System.Drawing.Point(376, 30)
        Me.menu_3.Name = "menu_3"
        Me.menu_3.Size = New System.Drawing.Size(35, 13)
        Me.menu_3.TabIndex = 33
        Me.menu_3.Text = "empty"
        '
        'menu_4
        '
        Me.menu_4.AutoSize = True
        Me.menu_4.Location = New System.Drawing.Point(308, 30)
        Me.menu_4.Name = "menu_4"
        Me.menu_4.Size = New System.Drawing.Size(35, 13)
        Me.menu_4.TabIndex = 34
        Me.menu_4.Text = "empty"
        '
        'menu_1
        '
        Me.menu_1.AutoSize = True
        Me.menu_1.Location = New System.Drawing.Point(2, 30)
        Me.menu_1.Name = "menu_1"
        Me.menu_1.Size = New System.Drawing.Size(35, 13)
        Me.menu_1.TabIndex = 35
        Me.menu_1.Text = "empty"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(168, 273)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 36
        '
        'lang_en
        '
        Me.lang_en.Location = New System.Drawing.Point(400, 452)
        Me.lang_en.Name = "lang_en"
        Me.lang_en.Size = New System.Drawing.Size(31, 23)
        Me.lang_en.TabIndex = 37
        Me.lang_en.Text = "en"
        Me.lang_en.UseVisualStyleBackColor = True
        '
        'lang_fr
        '
        Me.lang_fr.Location = New System.Drawing.Point(363, 451)
        Me.lang_fr.Name = "lang_fr"
        Me.lang_fr.Size = New System.Drawing.Size(31, 23)
        Me.lang_fr.TabIndex = 38
        Me.lang_fr.Text = "fr"
        Me.lang_fr.UseVisualStyleBackColor = True
        '
        'sel_lang
        '
        Me.sel_lang.Location = New System.Drawing.Point(257, 454)
        Me.sel_lang.Name = "sel_lang"
        Me.sel_lang.Size = New System.Drawing.Size(100, 20)
        Me.sel_lang.TabIndex = 40
        Me.sel_lang.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(438, 479)
        Me.Controls.Add(Me.sel_lang)
        Me.Controls.Add(Me.lang_fr)
        Me.Controls.Add(Me.lang_en)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.menu_1)
        Me.Controls.Add(Me.menu_4)
        Me.Controls.Add(Me.menu_3)
        Me.Controls.Add(Me.menu_10)
        Me.Controls.Add(Me.menu_9)
        Me.Controls.Add(Me.menu_8)
        Me.Controls.Add(Me.menu_2)
        Me.Controls.Add(Me.chf)
        Me.Controls.Add(Me.Name_textbox)
        Me.Controls.Add(Me.create)
        Me.Controls.Add(Me.menu_12)
        Me.Controls.Add(Me.menu_11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.menu_7)
        Me.Controls.Add(Me.menu_6)
        Me.Controls.Add(Me.menu_5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.alpha)
        Me.Controls.Add(Me.NoTT)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.d3)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "ediTool"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents d1 As TextBox
    Friend WithEvents d2 As TextBox
    Friend WithEvents d3 As TextBox
    Friend WithEvents L1 As TextBox
    Friend WithEvents L2 As TextBox
    Friend WithEvents L3 As TextBox
    Friend WithEvents alpha As TextBox
    Friend WithEvents NoTT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents menu_5 As Label
    Friend WithEvents menu_6 As Label
    Friend WithEvents menu_7 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents menu_11 As Label
    Friend WithEvents menu_12 As Label
    Friend WithEvents create As Button
    Friend WithEvents Name_textbox As TextBox
    Friend WithEvents chf As TextBox
    Friend WithEvents menu_2 As Label
    Friend WithEvents menu_8 As Label
    Friend WithEvents menu_9 As Label
    Friend WithEvents menu_10 As Label
    Friend WithEvents menu_3 As Label
    Friend WithEvents menu_4 As Label
    Friend WithEvents menu_1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lang_en As Button
    Friend WithEvents lang_fr As Button
    Friend WithEvents sel_lang As TextBox
End Class
