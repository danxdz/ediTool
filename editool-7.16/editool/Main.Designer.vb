<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.D_textbox = New System.Windows.Forms.TextBox()
        Me.SD_textbox = New System.Windows.Forms.TextBox()
        Me.CTS_AD_textbox = New System.Windows.Forms.TextBox()
        Me.OL_textbox = New System.Windows.Forms.TextBox()
        Me.L_textbox = New System.Windows.Forms.TextBox()
        Me.CTS_AL_textbox = New System.Windows.Forms.TextBox()
        Me.alpha = New System.Windows.Forms.TextBox()
        Me.NoTT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CTS_AD_label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.menu_5 = New System.Windows.Forms.Label()
        Me.menu_6 = New System.Windows.Forms.Label()
        Me.menu_7 = New System.Windows.Forms.Label()
        Me.Ref_filter_TextBox = New System.Windows.Forms.TextBox()
        Me.Diam_filter_TextBox = New System.Windows.Forms.TextBox()
        Me.menu_11 = New System.Windows.Forms.Label()
        Me.menu_12 = New System.Windows.Forms.Label()
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
        Me.Man = New System.Windows.Forms.ComboBox()
        Me.ForceName_checkBox = New System.Windows.Forms.CheckBox()
        Me.DefineName_Bt = New System.Windows.Forms.Button()
        Me.Lang_en = New System.Windows.Forms.Button()
        Me.Lang_fr = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ValidateBt = New System.Windows.Forms.Button()
        Me.AutoOpen_checkBox = New System.Windows.Forms.CheckBox()
        Me.ToolsBar = New System.Windows.Forms.ToolStrip()
        Me.FR2T = New System.Windows.Forms.ToolStripButton()
        Me.FRTO = New System.Windows.Forms.ToolStripButton()
        Me.FRBO = New System.Windows.Forms.ToolStripButton()
        Me.FAP = New System.Windows.Forms.ToolStripButton()
        Me.FO = New System.Windows.Forms.ToolStripButton()
        Me.AL = New System.Windows.Forms.ToolStripButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolsBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'D_textbox
        '
        Me.D_textbox.AccessibleDescription = "diamètre de coupe"
        Me.D_textbox.AccessibleName = "tthth"
        Me.D_textbox.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.D_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.D_textbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.D_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_textbox.Location = New System.Drawing.Point(420, 29)
        Me.D_textbox.Name = "D_textbox"
        Me.D_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.D_textbox.Size = New System.Drawing.Size(40, 22)
        Me.D_textbox.TabIndex = 1
        Me.D_textbox.Text = "6"
        Me.D_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SD_textbox
        '
        Me.SD_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SD_textbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SD_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SD_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SD_textbox.Location = New System.Drawing.Point(728, 29)
        Me.SD_textbox.Name = "SD_textbox"
        Me.SD_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SD_textbox.Size = New System.Drawing.Size(40, 22)
        Me.SD_textbox.TabIndex = 2
        Me.SD_textbox.Text = "6"
        Me.SD_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CTS_AD_textbox
        '
        Me.CTS_AD_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTS_AD_textbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CTS_AD_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CTS_AD_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTS_AD_textbox.Location = New System.Drawing.Point(539, 29)
        Me.CTS_AD_textbox.Name = "CTS_AD_textbox"
        Me.CTS_AD_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CTS_AD_textbox.Size = New System.Drawing.Size(40, 22)
        Me.CTS_AD_textbox.TabIndex = 3
        Me.CTS_AD_textbox.Text = "5.8"
        Me.CTS_AD_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OL_textbox
        '
        Me.OL_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OL_textbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OL_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OL_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OL_textbox.Location = New System.Drawing.Point(728, 142)
        Me.OL_textbox.Name = "OL_textbox"
        Me.OL_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OL_textbox.Size = New System.Drawing.Size(40, 22)
        Me.OL_textbox.TabIndex = 6
        Me.OL_textbox.Text = "53"
        Me.OL_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_textbox
        '
        Me.L_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_textbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.L_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_textbox.Location = New System.Drawing.Point(420, 143)
        Me.L_textbox.Name = "L_textbox"
        Me.L_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.L_textbox.Size = New System.Drawing.Size(40, 22)
        Me.L_textbox.TabIndex = 5
        Me.L_textbox.Text = "8"
        Me.L_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CTS_AL_textbox
        '
        Me.CTS_AL_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTS_AL_textbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CTS_AL_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CTS_AL_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTS_AL_textbox.Location = New System.Drawing.Point(539, 142)
        Me.CTS_AL_textbox.Name = "CTS_AL_textbox"
        Me.CTS_AL_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CTS_AL_textbox.Size = New System.Drawing.Size(40, 22)
        Me.CTS_AL_textbox.TabIndex = 4
        Me.CTS_AL_textbox.Text = "12"
        Me.CTS_AL_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'alpha
        '
        Me.alpha.BackColor = System.Drawing.Color.LightGray
        Me.alpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alpha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alpha.Location = New System.Drawing.Point(317, 97)
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
        Me.NoTT.Location = New System.Drawing.Point(317, 41)
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
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "D"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Location = New System.Drawing.Point(376, 54)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(427, 68)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(701, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "SD"
        '
        'CTS_AD_label
        '
        Me.CTS_AD_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTS_AD_label.AutoSize = True
        Me.CTS_AD_label.Location = New System.Drawing.Point(493, 33)
        Me.CTS_AD_label.Name = "CTS_AD_label"
        Me.CTS_AD_label.Size = New System.Drawing.Size(49, 13)
        Me.CTS_AD_label.TabIndex = 13
        Me.CTS_AD_label.Text = "CTS_AD"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(701, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "OL"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "L"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(493, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "CTS_AL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(356, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "a"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(356, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "z"
        '
        'menu_5
        '
        Me.menu_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_5.AutoSize = True
        Me.menu_5.Location = New System.Drawing.Point(425, 13)
        Me.menu_5.Name = "menu_5"
        Me.menu_5.Size = New System.Drawing.Size(35, 13)
        Me.menu_5.TabIndex = 19
        Me.menu_5.Text = "empty"
        '
        'menu_6
        '
        Me.menu_6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_6.AutoSize = True
        Me.menu_6.Location = New System.Drawing.Point(544, 13)
        Me.menu_6.Name = "menu_6"
        Me.menu_6.Size = New System.Drawing.Size(35, 13)
        Me.menu_6.TabIndex = 20
        Me.menu_6.Text = "empty"
        '
        'menu_7
        '
        Me.menu_7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_7.AutoSize = True
        Me.menu_7.Location = New System.Drawing.Point(733, 13)
        Me.menu_7.Name = "menu_7"
        Me.menu_7.Size = New System.Drawing.Size(35, 13)
        Me.menu_7.TabIndex = 21
        Me.menu_7.Text = "empty"
        '
        'Ref_filter_TextBox
        '
        Me.Ref_filter_TextBox.AccessibleDescription = "diamètre de coupe"
        Me.Ref_filter_TextBox.AccessibleName = "tthth"
        Me.Ref_filter_TextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.Ref_filter_TextBox.Location = New System.Drawing.Point(50, 149)
        Me.Ref_filter_TextBox.Name = "Ref_filter_TextBox"
        Me.Ref_filter_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Ref_filter_TextBox.Size = New System.Drawing.Size(77, 20)
        Me.Ref_filter_TextBox.TabIndex = 22
        '
        'Diam_filter_TextBox
        '
        Me.Diam_filter_TextBox.AccessibleDescription = "diamètre de coupe"
        Me.Diam_filter_TextBox.AccessibleName = "tthth"
        Me.Diam_filter_TextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.Diam_filter_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Diam_filter_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Diam_filter_TextBox.Location = New System.Drawing.Point(139, 149)
        Me.Diam_filter_TextBox.Name = "Diam_filter_TextBox"
        Me.Diam_filter_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Diam_filter_TextBox.Size = New System.Drawing.Size(31, 20)
        Me.Diam_filter_TextBox.TabIndex = 23
        '
        'menu_11
        '
        Me.menu_11.AutoSize = True
        Me.menu_11.Location = New System.Drawing.Point(53, 128)
        Me.menu_11.Name = "menu_11"
        Me.menu_11.Size = New System.Drawing.Size(35, 13)
        Me.menu_11.TabIndex = 24
        Me.menu_11.Text = "empty"
        '
        'menu_12
        '
        Me.menu_12.AutoSize = True
        Me.menu_12.Location = New System.Drawing.Point(136, 128)
        Me.menu_12.Name = "menu_12"
        Me.menu_12.Size = New System.Drawing.Size(35, 13)
        Me.menu_12.TabIndex = 25
        Me.menu_12.Text = "empty"
        '
        'Name_textbox
        '
        Me.Name_textbox.AccessibleDescription = "diamètre de coupe"
        Me.Name_textbox.AccessibleName = "tthth"
        Me.Name_textbox.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.Name_textbox.Enabled = False
        Me.Name_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_textbox.Location = New System.Drawing.Point(50, 37)
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
        Me.chf.Location = New System.Drawing.Point(317, 143)
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
        Me.menu_2.Location = New System.Drawing.Point(319, 133)
        Me.menu_2.Name = "menu_2"
        Me.menu_2.Size = New System.Drawing.Size(35, 13)
        Me.menu_2.TabIndex = 29
        Me.menu_2.Text = "empty"
        '
        'menu_8
        '
        Me.menu_8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_8.AutoSize = True
        Me.menu_8.Location = New System.Drawing.Point(425, 128)
        Me.menu_8.Name = "menu_8"
        Me.menu_8.Size = New System.Drawing.Size(35, 13)
        Me.menu_8.TabIndex = 30
        Me.menu_8.Text = "empty"
        '
        'menu_9
        '
        Me.menu_9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_9.AutoSize = True
        Me.menu_9.Location = New System.Drawing.Point(544, 128)
        Me.menu_9.Name = "menu_9"
        Me.menu_9.Size = New System.Drawing.Size(35, 13)
        Me.menu_9.TabIndex = 31
        Me.menu_9.Text = "empty"
        '
        'menu_10
        '
        Me.menu_10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_10.AutoSize = True
        Me.menu_10.Location = New System.Drawing.Point(733, 128)
        Me.menu_10.Name = "menu_10"
        Me.menu_10.Size = New System.Drawing.Size(35, 13)
        Me.menu_10.TabIndex = 32
        Me.menu_10.Text = "empty"
        '
        'menu_3
        '
        Me.menu_3.AutoSize = True
        Me.menu_3.Location = New System.Drawing.Point(319, 87)
        Me.menu_3.Name = "menu_3"
        Me.menu_3.Size = New System.Drawing.Size(35, 13)
        Me.menu_3.TabIndex = 33
        Me.menu_3.Text = "empty"
        '
        'menu_4
        '
        Me.menu_4.AutoSize = True
        Me.menu_4.Location = New System.Drawing.Point(319, 31)
        Me.menu_4.Name = "menu_4"
        Me.menu_4.Size = New System.Drawing.Size(35, 13)
        Me.menu_4.TabIndex = 34
        Me.menu_4.Text = "empty"
        '
        'menu_1
        '
        Me.menu_1.AutoSize = True
        Me.menu_1.Location = New System.Drawing.Point(52, 27)
        Me.menu_1.Name = "menu_1"
        Me.menu_1.Size = New System.Drawing.Size(35, 13)
        Me.menu_1.TabIndex = 35
        Me.menu_1.Text = "empty"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(176, 148)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 36
        '
        'Man
        '
        Me.Man.FormattingEnabled = True
        Me.Man.Items.AddRange(New Object() {"FRAISA", "SECO", "HOFFMAN"})
        Me.Man.Location = New System.Drawing.Point(49, 97)
        Me.Man.Name = "Man"
        Me.Man.Size = New System.Drawing.Size(247, 21)
        Me.Man.TabIndex = 41
        Me.Man.Text = "FRAISA"
        '
        'ForceName_checkBox
        '
        Me.ForceName_checkBox.AutoSize = True
        Me.ForceName_checkBox.Location = New System.Drawing.Point(50, 68)
        Me.ForceName_checkBox.Name = "ForceName_checkBox"
        Me.ForceName_checkBox.Size = New System.Drawing.Size(54, 17)
        Me.ForceName_checkBox.TabIndex = 42
        Me.ForceName_checkBox.Text = "empty"
        '
        'DefineName_Bt
        '
        Me.DefineName_Bt.Location = New System.Drawing.Point(221, 68)
        Me.DefineName_Bt.Name = "DefineName_Bt"
        Me.DefineName_Bt.Size = New System.Drawing.Size(75, 23)
        Me.DefineName_Bt.TabIndex = 45
        Me.DefineName_Bt.Text = "empty"
        Me.DefineName_Bt.UseVisualStyleBackColor = True
        '
        'Lang_en
        '
        Me.Lang_en.Location = New System.Drawing.Point(86, 357)
        Me.Lang_en.Name = "Lang_en"
        Me.Lang_en.Size = New System.Drawing.Size(31, 23)
        Me.Lang_en.TabIndex = 47
        Me.Lang_en.Text = "en"
        Me.Lang_en.UseVisualStyleBackColor = True
        '
        'Lang_fr
        '
        Me.Lang_fr.Location = New System.Drawing.Point(49, 357)
        Me.Lang_fr.Name = "Lang_fr"
        Me.Lang_fr.Size = New System.Drawing.Size(31, 23)
        Me.Lang_fr.TabIndex = 48
        Me.Lang_fr.Text = "fr"
        Me.Lang_fr.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Location = New System.Drawing.Point(50, 182)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(752, 168)
        Me.DataGridView1.TabIndex = 49
        '
        'ValidateBt
        '
        Me.ValidateBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValidateBt.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidateBt.Location = New System.Drawing.Point(581, 356)
        Me.ValidateBt.Name = "ValidateBt"
        Me.ValidateBt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ValidateBt.Size = New System.Drawing.Size(130, 26)
        Me.ValidateBt.TabIndex = 50
        Me.ValidateBt.Text = "creer outil"
        Me.ValidateBt.UseVisualStyleBackColor = True
        '
        'AutoOpen_checkBox
        '
        Me.AutoOpen_checkBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutoOpen_checkBox.AutoSize = True
        Me.AutoOpen_checkBox.Location = New System.Drawing.Point(732, 361)
        Me.AutoOpen_checkBox.Name = "AutoOpen_checkBox"
        Me.AutoOpen_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AutoOpen_checkBox.Size = New System.Drawing.Size(54, 17)
        Me.AutoOpen_checkBox.TabIndex = 51
        Me.AutoOpen_checkBox.Text = "empty"
        Me.AutoOpen_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AutoOpen_checkBox.UseVisualStyleBackColor = True
        '
        'ToolsBar
        '
        Me.ToolsBar.BackColor = System.Drawing.Color.Silver
        Me.ToolsBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolsBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolsBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolsBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FR2T, Me.FRTO, Me.FRBO, Me.FAP, Me.FO, Me.AL})
        Me.ToolsBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.ToolsBar.Location = New System.Drawing.Point(5, 5)
        Me.ToolsBar.Margin = New System.Windows.Forms.Padding(5)
        Me.ToolsBar.Name = "ToolsBar"
        Me.ToolsBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolsBar.Size = New System.Drawing.Size(32, 382)
        Me.ToolsBar.TabIndex = 54
        Me.ToolsBar.Text = "ToolsBar"
        '
        'FR2T
        '
        Me.FR2T.BackColor = System.Drawing.Color.Gainsboro
        Me.FR2T.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FR2T.Image = CType(resources.GetObject("FR2T.Image"), System.Drawing.Image)
        Me.FR2T.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FR2T.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FR2T.Name = "FR2T"
        Me.FR2T.Size = New System.Drawing.Size(24, 44)
        Me.FR2T.Text = "FR 2T"
        '
        'FRTO
        '
        Me.FRTO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FRTO.Image = CType(resources.GetObject("FRTO.Image"), System.Drawing.Image)
        Me.FRTO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FRTO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FRTO.Name = "FRTO"
        Me.FRTO.Size = New System.Drawing.Size(24, 44)
        Me.FRTO.Text = "FRTO"
        '
        'FRBO
        '
        Me.FRBO.BackColor = System.Drawing.Color.DimGray
        Me.FRBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FRBO.Image = CType(resources.GetObject("FRBO.Image"), System.Drawing.Image)
        Me.FRBO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FRBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FRBO.Name = "FRBO"
        Me.FRBO.Size = New System.Drawing.Size(24, 44)
        Me.FRBO.Text = "FRBO"
        Me.FRBO.ToolTipText = "Fraise hemesferique"
        '
        'FAP
        '
        Me.FAP.BackColor = System.Drawing.Color.SpringGreen
        Me.FAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FAP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FAP.Image = CType(resources.GetObject("FAP.Image"), System.Drawing.Image)
        Me.FAP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FAP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FAP.Name = "FAP"
        Me.FAP.Size = New System.Drawing.Size(24, 44)
        Me.FAP.Text = "FRCH"
        '
        'FO
        '
        Me.FO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FO.Image = CType(resources.GetObject("FO.Image"), System.Drawing.Image)
        Me.FO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FO.Name = "FO"
        Me.FO.Size = New System.Drawing.Size(24, 44)
        Me.FO.Text = "FO"
        '
        'AL
        '
        Me.AL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AL.Image = CType(resources.GetObject("AL.Image"), System.Drawing.Image)
        Me.AL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AL.Name = "AL"
        Me.AL.Size = New System.Drawing.Size(24, 44)
        Me.AL.Text = "AL"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(810, 392)
        Me.Controls.Add(Me.ToolsBar)
        Me.Controls.Add(Me.ValidateBt)
        Me.Controls.Add(Me.AutoOpen_checkBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Lang_en)
        Me.Controls.Add(Me.Lang_fr)
        Me.Controls.Add(Me.DefineName_Bt)
        Me.Controls.Add(Me.ForceName_checkBox)
        Me.Controls.Add(Me.Man)
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
        Me.Controls.Add(Me.menu_12)
        Me.Controls.Add(Me.menu_11)
        Me.Controls.Add(Me.Diam_filter_TextBox)
        Me.Controls.Add(Me.Ref_filter_TextBox)
        Me.Controls.Add(Me.menu_7)
        Me.Controls.Add(Me.menu_6)
        Me.Controls.Add(Me.menu_5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CTS_AD_label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.alpha)
        Me.Controls.Add(Me.NoTT)
        Me.Controls.Add(Me.OL_textbox)
        Me.Controls.Add(Me.L_textbox)
        Me.Controls.Add(Me.CTS_AL_textbox)
        Me.Controls.Add(Me.CTS_AD_textbox)
        Me.Controls.Add(Me.SD_textbox)
        Me.Controls.Add(Me.D_textbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Main"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ediTool"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolsBar.ResumeLayout(False)
        Me.ToolsBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents D_textbox As TextBox
    Friend WithEvents SD_textbox As TextBox
    Friend WithEvents CTS_AD_textbox As TextBox
    Friend WithEvents OL_textbox As TextBox
    Friend WithEvents L_textbox As TextBox
    Friend WithEvents CTS_AL_textbox As TextBox
    Friend WithEvents alpha As TextBox
    Friend WithEvents NoTT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CTS_AD_label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents menu_5 As Label
    Friend WithEvents menu_6 As Label
    Friend WithEvents menu_7 As Label
    Friend WithEvents Ref_filter_TextBox As TextBox
    Friend WithEvents Diam_filter_TextBox As TextBox
    Friend WithEvents menu_11 As Label
    Friend WithEvents menu_12 As Label
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
    Friend WithEvents Man As ComboBox
    Friend WithEvents ForceName_checkBox As CheckBox
    Friend WithEvents DefineName_Bt As Button
    Friend WithEvents Lang_en As Button
    Friend WithEvents Lang_fr As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ValidateBt As Button
    Friend WithEvents AutoOpen_checkBox As CheckBox
    Friend WithEvents FR2T As ToolStripButton
    Friend WithEvents FRTO As ToolStripButton
    Friend WithEvents FRBO As ToolStripButton
    Friend WithEvents FAP As ToolStripButton
    Private WithEvents ToolsBar As ToolStrip
    Friend WithEvents FO As ToolStripButton
    Friend WithEvents AL As ToolStripButton
End Class
