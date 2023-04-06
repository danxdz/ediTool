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
        Me.Lang_fr = New System.Windows.Forms.Button()
        Me.Lang_pt = New System.Windows.Forms.Button()
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
        Me.Name_textbox = New System.Windows.Forms.TextBox()
        Me.Chf_textbox = New System.Windows.Forms.TextBox()
        Me.menu_2 = New System.Windows.Forms.Label()
        Me.menu_8 = New System.Windows.Forms.Label()
        Me.menu_9 = New System.Windows.Forms.Label()
        Me.menu_10 = New System.Windows.Forms.Label()
        Me.menu_3 = New System.Windows.Forms.Label()
        Me.menu_4 = New System.Windows.Forms.Label()
        Me.menu_1 = New System.Windows.Forms.Label()
        Me.manref_TextBox = New System.Windows.Forms.ComboBox()
        Me.manuf_comboBox = New System.Windows.Forms.ComboBox()
        Me.ForceName_checkBox = New System.Windows.Forms.CheckBox()
        Me.DefineName_Bt = New System.Windows.Forms.Button()
        Me.Lang_en = New System.Windows.Forms.Button()
        Me.ValidateBt = New System.Windows.Forms.Button()
        Me.AutoOpen_checkBox = New System.Windows.Forms.CheckBox()
        Me.FR2T = New System.Windows.Forms.ToolStripButton()
        Me.FRTO = New System.Windows.Forms.ToolStripButton()
        Me.FRBO = New System.Windows.Forms.ToolStripButton()
        Me.FAP = New System.Windows.Forms.ToolStripButton()
        Me.FO = New System.Windows.Forms.ToolStripButton()
        Me.AL = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.XML_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Top6_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OrderTools_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.A_TextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.filterD1_Combobox = New System.Windows.Forms.ComboBox()
        Me.NewToolDataGridView = New System.Windows.Forms.DataGridView()
        Me.newToolMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer_label = New System.Windows.Forms.Label()
        Me.filterL1_ComboBox = New System.Windows.Forms.ComboBox()
        Me.filterMat_ComboBox = New System.Windows.Forms.ComboBox()
        Me.readToolProgress_Label = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.AutoCheckIn_checkBox = New System.Windows.Forms.CheckBox()
        Me.toolRef_checkBox = New System.Windows.Forms.CheckBox()
        Me.toolDiam_checkBox = New System.Windows.Forms.CheckBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewToolDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.newToolMenu.SuspendLayout()
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
        Me.D_textbox.BackColor = System.Drawing.Color.LightGray
        Me.D_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_textbox.Location = New System.Drawing.Point(494, 80)
        Me.D_textbox.Name = "D_textbox"
        Me.D_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.D_textbox.Size = New System.Drawing.Size(71, 22)
        Me.D_textbox.TabIndex = 1
        Me.D_textbox.Text = "6"
        Me.D_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SD_textbox
        '
        Me.SD_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SD_textbox.BackColor = System.Drawing.Color.LightGray
        Me.SD_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SD_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SD_textbox.Location = New System.Drawing.Point(924, 80)
        Me.SD_textbox.Name = "SD_textbox"
        Me.SD_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SD_textbox.Size = New System.Drawing.Size(71, 22)
        Me.SD_textbox.TabIndex = 3
        Me.SD_textbox.Text = "6"
        Me.SD_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CTS_AD_textbox
        '
        Me.CTS_AD_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTS_AD_textbox.BackColor = System.Drawing.Color.LightGray
        Me.CTS_AD_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTS_AD_textbox.Location = New System.Drawing.Point(694, 80)
        Me.CTS_AD_textbox.Name = "CTS_AD_textbox"
        Me.CTS_AD_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CTS_AD_textbox.Size = New System.Drawing.Size(71, 29)
        Me.CTS_AD_textbox.TabIndex = 2
        Me.CTS_AD_textbox.Text = "5.8"
        Me.CTS_AD_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OL_textbox
        '
        Me.OL_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OL_textbox.BackColor = System.Drawing.Color.LightGray
        Me.OL_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OL_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OL_textbox.Location = New System.Drawing.Point(924, 208)
        Me.OL_textbox.Name = "OL_textbox"
        Me.OL_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OL_textbox.Size = New System.Drawing.Size(71, 22)
        Me.OL_textbox.TabIndex = 6
        Me.OL_textbox.Text = "53"
        Me.OL_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_textbox
        '
        Me.L_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_textbox.BackColor = System.Drawing.Color.LightGray
        Me.L_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_textbox.Location = New System.Drawing.Point(494, 208)
        Me.L_textbox.Name = "L_textbox"
        Me.L_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.L_textbox.Size = New System.Drawing.Size(71, 22)
        Me.L_textbox.TabIndex = 4
        Me.L_textbox.Text = "8"
        Me.L_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CTS_AL_textbox
        '
        Me.CTS_AL_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTS_AL_textbox.BackColor = System.Drawing.Color.LightGray
        Me.CTS_AL_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CTS_AL_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTS_AL_textbox.Location = New System.Drawing.Point(694, 208)
        Me.CTS_AL_textbox.Name = "CTS_AL_textbox"
        Me.CTS_AL_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CTS_AL_textbox.Size = New System.Drawing.Size(71, 22)
        Me.CTS_AL_textbox.TabIndex = 5
        Me.CTS_AL_textbox.Text = "12"
        Me.CTS_AL_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'alpha
        '
        Me.alpha.BackColor = System.Drawing.Color.LightGray
        Me.alpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alpha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alpha.Location = New System.Drawing.Point(348, 92)
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
        Me.NoTT.Location = New System.Drawing.Point(348, 63)
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
        Me.Label1.Location = New System.Drawing.Point(479, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "D"
        '
        'Lang_fr
        '
        Me.Lang_fr.Location = New System.Drawing.Point(932, 5)
        Me.Lang_fr.Name = "Lang_fr"
        Me.Lang_fr.Size = New System.Drawing.Size(31, 29)
        Me.Lang_fr.TabIndex = 73
        Me.Lang_fr.Text = "fr"
        Me.ToolTip1.SetToolTip(Me.Lang_fr, "francais")
        Me.Lang_fr.UseVisualStyleBackColor = True
        '
        'Lang_pt
        '
        Me.Lang_pt.Location = New System.Drawing.Point(969, 5)
        Me.Lang_pt.Name = "Lang_pt"
        Me.Lang_pt.Size = New System.Drawing.Size(31, 29)
        Me.Lang_pt.TabIndex = 76
        Me.Lang_pt.Text = "pt"
        Me.ToolTip1.SetToolTip(Me.Lang_pt, "portuguese")
        Me.Lang_pt.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Location = New System.Drawing.Point(478, 110)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(517, 80)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(901, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "SD"
        '
        'CTS_AD_label
        '
        Me.CTS_AD_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTS_AD_label.AutoSize = True
        Me.CTS_AD_label.Location = New System.Drawing.Point(639, 85)
        Me.CTS_AD_label.Name = "CTS_AD_label"
        Me.CTS_AD_label.Size = New System.Drawing.Size(49, 13)
        Me.CTS_AD_label.TabIndex = 13
        Me.CTS_AD_label.Text = "CTS_AD"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(901, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "OL"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(479, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "L"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(641, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "CTS_AL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(393, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "a"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(393, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "z"
        '
        'menu_5
        '
        Me.menu_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_5.AutoSize = True
        Me.menu_5.Location = New System.Drawing.Point(499, 66)
        Me.menu_5.Name = "menu_5"
        Me.menu_5.Size = New System.Drawing.Size(35, 13)
        Me.menu_5.TabIndex = 19
        Me.menu_5.Text = "empty"
        '
        'menu_6
        '
        Me.menu_6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_6.AutoSize = True
        Me.menu_6.Location = New System.Drawing.Point(694, 66)
        Me.menu_6.Name = "menu_6"
        Me.menu_6.Size = New System.Drawing.Size(35, 13)
        Me.menu_6.TabIndex = 20
        Me.menu_6.Text = "empty"
        '
        'menu_7
        '
        Me.menu_7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_7.AutoSize = True
        Me.menu_7.Location = New System.Drawing.Point(924, 66)
        Me.menu_7.Name = "menu_7"
        Me.menu_7.Size = New System.Drawing.Size(35, 13)
        Me.menu_7.TabIndex = 21
        Me.menu_7.Text = "empty"
        '
        'Name_textbox
        '
        Me.Name_textbox.AccessibleDescription = "diamètre de coupe"
        Me.Name_textbox.AccessibleName = "tthth"
        Me.Name_textbox.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.Name_textbox.Enabled = False
        Me.Name_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_textbox.Location = New System.Drawing.Point(11, 97)
        Me.Name_textbox.Name = "Name_textbox"
        Me.Name_textbox.Size = New System.Drawing.Size(311, 31)
        Me.Name_textbox.TabIndex = 27
        '
        'Chf_textbox
        '
        Me.Chf_textbox.BackColor = System.Drawing.Color.LightGray
        Me.Chf_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Chf_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chf_textbox.Location = New System.Drawing.Point(348, 121)
        Me.Chf_textbox.Margin = New System.Windows.Forms.Padding(10)
        Me.Chf_textbox.Name = "Chf_textbox"
        Me.Chf_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Chf_textbox.Size = New System.Drawing.Size(32, 26)
        Me.Chf_textbox.TabIndex = 28
        Me.Chf_textbox.Text = "0"
        Me.Chf_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'menu_2
        '
        Me.menu_2.AutoSize = True
        Me.menu_2.Location = New System.Drawing.Point(393, 128)
        Me.menu_2.Name = "menu_2"
        Me.menu_2.Size = New System.Drawing.Size(35, 13)
        Me.menu_2.TabIndex = 29
        Me.menu_2.Text = "empty"
        '
        'menu_8
        '
        Me.menu_8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_8.AutoSize = True
        Me.menu_8.Location = New System.Drawing.Point(494, 193)
        Me.menu_8.Name = "menu_8"
        Me.menu_8.Size = New System.Drawing.Size(35, 13)
        Me.menu_8.TabIndex = 30
        Me.menu_8.Text = "empty"
        '
        'menu_9
        '
        Me.menu_9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_9.AutoSize = True
        Me.menu_9.Location = New System.Drawing.Point(694, 193)
        Me.menu_9.Name = "menu_9"
        Me.menu_9.Size = New System.Drawing.Size(35, 13)
        Me.menu_9.TabIndex = 31
        Me.menu_9.Text = "empty"
        '
        'menu_10
        '
        Me.menu_10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_10.AutoSize = True
        Me.menu_10.Location = New System.Drawing.Point(924, 193)
        Me.menu_10.Name = "menu_10"
        Me.menu_10.Size = New System.Drawing.Size(35, 13)
        Me.menu_10.TabIndex = 32
        Me.menu_10.Text = "empty"
        '
        'menu_3
        '
        Me.menu_3.AutoSize = True
        Me.menu_3.Location = New System.Drawing.Point(393, 96)
        Me.menu_3.Name = "menu_3"
        Me.menu_3.Size = New System.Drawing.Size(35, 13)
        Me.menu_3.TabIndex = 33
        Me.menu_3.Text = "empty"
        '
        'menu_4
        '
        Me.menu_4.AutoSize = True
        Me.menu_4.Location = New System.Drawing.Point(393, 63)
        Me.menu_4.Name = "menu_4"
        Me.menu_4.Size = New System.Drawing.Size(35, 13)
        Me.menu_4.TabIndex = 34
        Me.menu_4.Text = "empty"
        '
        'menu_1
        '
        Me.menu_1.AutoSize = True
        Me.menu_1.Location = New System.Drawing.Point(8, 72)
        Me.menu_1.Name = "menu_1"
        Me.menu_1.Size = New System.Drawing.Size(35, 13)
        Me.menu_1.TabIndex = 35
        Me.menu_1.Text = "empty"
        '
        'manref_TextBox
        '
        Me.manref_TextBox.FormattingEnabled = True
        Me.manref_TextBox.Location = New System.Drawing.Point(278, 566)
        Me.manref_TextBox.Name = "manref_TextBox"
        Me.manref_TextBox.Size = New System.Drawing.Size(181, 21)
        Me.manref_TextBox.TabIndex = 36
        '
        'manuf_comboBox
        '
        Me.manuf_comboBox.FormattingEnabled = True
        Me.manuf_comboBox.Items.AddRange(New Object() {"FRAISA", "SECO", "HOFFMAN"})
        Me.manuf_comboBox.Location = New System.Drawing.Point(9, 566)
        Me.manuf_comboBox.Name = "manuf_comboBox"
        Me.manuf_comboBox.Size = New System.Drawing.Size(181, 21)
        Me.manuf_comboBox.TabIndex = 41
        Me.manuf_comboBox.Text = "FRAISA"
        '
        'ForceName_checkBox
        '
        Me.ForceName_checkBox.AutoSize = True
        Me.ForceName_checkBox.Location = New System.Drawing.Point(92, 152)
        Me.ForceName_checkBox.Name = "ForceName_checkBox"
        Me.ForceName_checkBox.Size = New System.Drawing.Size(54, 17)
        Me.ForceName_checkBox.TabIndex = 42
        Me.ForceName_checkBox.Text = "empty"
        '
        'DefineName_Bt
        '
        Me.DefineName_Bt.Location = New System.Drawing.Point(11, 148)
        Me.DefineName_Bt.Name = "DefineName_Bt"
        Me.DefineName_Bt.Size = New System.Drawing.Size(75, 23)
        Me.DefineName_Bt.TabIndex = 45
        Me.DefineName_Bt.Text = "empty"
        Me.DefineName_Bt.UseVisualStyleBackColor = True
        '
        'Lang_en
        '
        Me.Lang_en.Location = New System.Drawing.Point(895, 5)
        Me.Lang_en.Name = "Lang_en"
        Me.Lang_en.Size = New System.Drawing.Size(31, 29)
        Me.Lang_en.TabIndex = 47
        Me.Lang_en.Tag = "english"
        Me.Lang_en.Text = "en"
        Me.Lang_en.UseVisualStyleBackColor = True
        '
        'ValidateBt
        '
        Me.ValidateBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValidateBt.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidateBt.Location = New System.Drawing.Point(873, 550)
        Me.ValidateBt.Name = "ValidateBt"
        Me.ValidateBt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ValidateBt.Size = New System.Drawing.Size(130, 46)
        Me.ValidateBt.TabIndex = 50
        Me.ValidateBt.Text = "creer outil"
        Me.ValidateBt.UseVisualStyleBackColor = True
        '
        'AutoOpen_checkBox
        '
        Me.AutoOpen_checkBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutoOpen_checkBox.AutoSize = True
        Me.AutoOpen_checkBox.Checked = True
        Me.AutoOpen_checkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoOpen_checkBox.Location = New System.Drawing.Point(801, 550)
        Me.AutoOpen_checkBox.Name = "AutoOpen_checkBox"
        Me.AutoOpen_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AutoOpen_checkBox.Size = New System.Drawing.Size(54, 17)
        Me.AutoOpen_checkBox.TabIndex = 51
        Me.AutoOpen_checkBox.Text = "empty"
        Me.AutoOpen_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AutoOpen_checkBox.UseVisualStyleBackColor = True
        '
        'FR2T
        '
        Me.FR2T.AutoSize = False
        Me.FR2T.BackColor = System.Drawing.Color.Lime
        Me.FR2T.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FR2T.Image = CType(resources.GetObject("FR2T.Image"), System.Drawing.Image)
        Me.FR2T.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FR2T.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FR2T.Name = "FR2T"
        Me.FR2T.Size = New System.Drawing.Size(40, 60)
        Me.FR2T.Text = "FR2T"
        Me.FR2T.ToolTipText = "Fraise 2 tailles"
        '
        'FRTO
        '
        Me.FRTO.AutoSize = False
        Me.FRTO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FRTO.Image = CType(resources.GetObject("FRTO.Image"), System.Drawing.Image)
        Me.FRTO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FRTO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FRTO.Name = "FRTO"
        Me.FRTO.Size = New System.Drawing.Size(40, 60)
        Me.FRTO.Text = "FRTO"
        '
        'FRBO
        '
        Me.FRBO.AutoSize = False
        Me.FRBO.BackColor = System.Drawing.Color.Transparent
        Me.FRBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FRBO.Image = CType(resources.GetObject("FRBO.Image"), System.Drawing.Image)
        Me.FRBO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FRBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FRBO.Name = "FRBO"
        Me.FRBO.Size = New System.Drawing.Size(40, 60)
        Me.FRBO.Text = "FRHE"
        Me.FRBO.ToolTipText = "Fraise hemesferique"
        '
        'FAP
        '
        Me.FAP.AutoSize = False
        Me.FAP.BackColor = System.Drawing.Color.Transparent
        Me.FAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FAP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FAP.Image = CType(resources.GetObject("FAP.Image"), System.Drawing.Image)
        Me.FAP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FAP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FAP.Name = "FAP"
        Me.FAP.Size = New System.Drawing.Size(40, 60)
        Me.FAP.Text = "FRCH"
        '
        'FO
        '
        Me.FO.AutoSize = False
        Me.FO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FO.Image = CType(resources.GetObject("FO.Image"), System.Drawing.Image)
        Me.FO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FO.Name = "FO"
        Me.FO.Size = New System.Drawing.Size(40, 60)
        Me.FO.Text = "Forets"
        '
        'AL
        '
        Me.AL.AutoSize = False
        Me.AL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AL.Image = CType(resources.GetObject("AL.Image"), System.Drawing.Image)
        Me.AL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AL.Name = "AL"
        Me.AL.Size = New System.Drawing.Size(40, 60)
        Me.AL.Text = "AL"
        Me.AL.ToolTipText = "Alesoirs fixe"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.IndianRed
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.IndianRed
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(40, 60)
        '
        'XML_ToolStripButton
        '
        Me.XML_ToolStripButton.AutoSize = False
        Me.XML_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.XML_ToolStripButton.Font = New System.Drawing.Font("3ds", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XML_ToolStripButton.Image = CType(resources.GetObject("XML_ToolStripButton.Image"), System.Drawing.Image)
        Me.XML_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.XML_ToolStripButton.Name = "XML_ToolStripButton"
        Me.XML_ToolStripButton.Size = New System.Drawing.Size(60, 60)
        Me.XML_ToolStripButton.Text = "XML"
        '
        'Top6_ToolStripButton
        '
        Me.Top6_ToolStripButton.AutoSize = False
        Me.Top6_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Top6_ToolStripButton.Font = New System.Drawing.Font("3ds", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Top6_ToolStripButton.Image = CType(resources.GetObject("Top6_ToolStripButton.Image"), System.Drawing.Image)
        Me.Top6_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Top6_ToolStripButton.Name = "Top6_ToolStripButton"
        Me.Top6_ToolStripButton.Size = New System.Drawing.Size(60, 60)
        Me.Top6_ToolStripButton.Text = "Top6"
        '
        'OrderTools_ToolStripButton
        '
        Me.OrderTools_ToolStripButton.AutoSize = False
        Me.OrderTools_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OrderTools_ToolStripButton.Font = New System.Drawing.Font("3ds", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderTools_ToolStripButton.Image = CType(resources.GetObject("OrderTools_ToolStripButton.Image"), System.Drawing.Image)
        Me.OrderTools_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OrderTools_ToolStripButton.Name = "OrderTools_ToolStripButton"
        Me.OrderTools_ToolStripButton.Size = New System.Drawing.Size(100, 60)
        Me.OrderTools_ToolStripButton.Text = "OrderTools"
        '
        'A_TextBox
        '
        Me.A_TextBox.BackColor = System.Drawing.Color.LightGray
        Me.A_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.A_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_TextBox.Location = New System.Drawing.Point(348, 152)
        Me.A_TextBox.Margin = New System.Windows.Forms.Padding(10)
        Me.A_TextBox.Name = "A_TextBox"
        Me.A_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.A_TextBox.Size = New System.Drawing.Size(32, 26)
        Me.A_TextBox.TabIndex = 55
        Me.A_TextBox.Text = "90"
        Me.A_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(260, 185)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox1.TabIndex = 56
        Me.CheckBox1.Text = "empty"
        Me.CheckBox1.Visible = False
        '
        'filterD1_Combobox
        '
        Me.filterD1_Combobox.FormattingEnabled = True
        Me.filterD1_Combobox.Location = New System.Drawing.Point(134, 208)
        Me.filterD1_Combobox.Name = "filterD1_Combobox"
        Me.filterD1_Combobox.Size = New System.Drawing.Size(120, 21)
        Me.filterD1_Combobox.TabIndex = 59
        Me.filterD1_Combobox.Text = " "
        '
        'NewToolDataGridView
        '
        Me.NewToolDataGridView.AllowUserToOrderColumns = True
        Me.NewToolDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.NewToolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewToolDataGridView.Location = New System.Drawing.Point(8, 245)
        Me.NewToolDataGridView.MultiSelect = False
        Me.NewToolDataGridView.Name = "NewToolDataGridView"
        Me.NewToolDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.NewToolDataGridView.Size = New System.Drawing.Size(608, 299)
        Me.NewToolDataGridView.TabIndex = 61
        '
        'newToolMenu
        '
        Me.newToolMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.newToolMenu.Name = "ContextMenuStrip1"
        Me.newToolMenu.Size = New System.Drawing.Size(111, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem1.Text = "créer"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem2.Text = "info"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem3.Text = "effacer"
        '
        'Timer1
        '
        '
        'timer_label
        '
        Me.timer_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timer_label.AutoSize = True
        Me.timer_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer_label.Location = New System.Drawing.Point(510, 559)
        Me.timer_label.Name = "timer_label"
        Me.timer_label.Size = New System.Drawing.Size(24, 25)
        Me.timer_label.TabIndex = 63
        Me.timer_label.Text = "0"
        '
        'filterL1_ComboBox
        '
        Me.filterL1_ComboBox.FormattingEnabled = True
        Me.filterL1_ComboBox.Location = New System.Drawing.Point(260, 208)
        Me.filterL1_ComboBox.Name = "filterL1_ComboBox"
        Me.filterL1_ComboBox.Size = New System.Drawing.Size(120, 21)
        Me.filterL1_ComboBox.TabIndex = 65
        Me.filterL1_ComboBox.Text = " "
        '
        'filterMat_ComboBox
        '
        Me.filterMat_ComboBox.FormattingEnabled = True
        Me.filterMat_ComboBox.Location = New System.Drawing.Point(8, 208)
        Me.filterMat_ComboBox.Name = "filterMat_ComboBox"
        Me.filterMat_ComboBox.Size = New System.Drawing.Size(120, 21)
        Me.filterMat_ComboBox.TabIndex = 66
        Me.filterMat_ComboBox.Text = " "
        '
        'readToolProgress_Label
        '
        Me.readToolProgress_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.readToolProgress_Label.AutoSize = True
        Me.readToolProgress_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readToolProgress_Label.Location = New System.Drawing.Point(582, 559)
        Me.readToolProgress_Label.Name = "readToolProgress_Label"
        Me.readToolProgress_Label.Size = New System.Drawing.Size(24, 25)
        Me.readToolProgress_Label.TabIndex = 69
        Me.readToolProgress_Label.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(998, 24)
        Me.MenuStrip1.TabIndex = 70
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Location = New System.Drawing.Point(5, 33)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(111, 25)
        Me.ToolStrip1.TabIndex = 71
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'AutoCheckIn_checkBox
        '
        Me.AutoCheckIn_checkBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutoCheckIn_checkBox.AutoSize = True
        Me.AutoCheckIn_checkBox.Checked = True
        Me.AutoCheckIn_checkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoCheckIn_checkBox.Location = New System.Drawing.Point(801, 577)
        Me.AutoCheckIn_checkBox.Name = "AutoCheckIn_checkBox"
        Me.AutoCheckIn_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AutoCheckIn_checkBox.Size = New System.Drawing.Size(54, 17)
        Me.AutoCheckIn_checkBox.TabIndex = 72
        Me.AutoCheckIn_checkBox.Text = "empty"
        Me.AutoCheckIn_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AutoCheckIn_checkBox.UseVisualStyleBackColor = True
        '
        'toolRef_checkBox
        '
        Me.toolRef_checkBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toolRef_checkBox.AutoSize = True
        Me.toolRef_checkBox.Location = New System.Drawing.Point(218, 569)
        Me.toolRef_checkBox.Name = "toolRef_checkBox"
        Me.toolRef_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.toolRef_checkBox.Size = New System.Drawing.Size(54, 17)
        Me.toolRef_checkBox.TabIndex = 74
        Me.toolRef_checkBox.Text = "empty"
        Me.toolRef_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolRef_checkBox.UseVisualStyleBackColor = True
        '
        'toolDiam_checkBox
        '
        Me.toolDiam_checkBox.AutoSize = True
        Me.toolDiam_checkBox.Location = New System.Drawing.Point(134, 185)
        Me.toolDiam_checkBox.Name = "toolDiam_checkBox"
        Me.toolDiam_checkBox.Size = New System.Drawing.Size(54, 17)
        Me.toolDiam_checkBox.TabIndex = 75
        Me.toolDiam_checkBox.Text = "empty"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Location = New System.Drawing.Point(5, 29)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(998, 25)
        Me.ToolStrip2.TabIndex = 77
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Lang_pt)
        Me.Controls.Add(Me.toolDiam_checkBox)
        Me.Controls.Add(Me.toolRef_checkBox)
        Me.Controls.Add(Me.Lang_fr)
        Me.Controls.Add(Me.AutoCheckIn_checkBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.readToolProgress_Label)
        Me.Controls.Add(Me.filterMat_ComboBox)
        Me.Controls.Add(Me.filterL1_ComboBox)
        Me.Controls.Add(Me.timer_label)
        Me.Controls.Add(Me.Lang_en)
        Me.Controls.Add(Me.menu_10)
        Me.Controls.Add(Me.menu_9)
        Me.Controls.Add(Me.menu_8)
        Me.Controls.Add(Me.menu_7)
        Me.Controls.Add(Me.menu_6)
        Me.Controls.Add(Me.menu_5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CTS_AD_label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OL_textbox)
        Me.Controls.Add(Me.L_textbox)
        Me.Controls.Add(Me.CTS_AL_textbox)
        Me.Controls.Add(Me.CTS_AD_textbox)
        Me.Controls.Add(Me.SD_textbox)
        Me.Controls.Add(Me.D_textbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NewToolDataGridView)
        Me.Controls.Add(Me.filterD1_Combobox)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.A_TextBox)
        Me.Controls.Add(Me.ValidateBt)
        Me.Controls.Add(Me.AutoOpen_checkBox)
        Me.Controls.Add(Me.DefineName_Bt)
        Me.Controls.Add(Me.ForceName_checkBox)
        Me.Controls.Add(Me.manuf_comboBox)
        Me.Controls.Add(Me.manref_TextBox)
        Me.Controls.Add(Me.menu_1)
        Me.Controls.Add(Me.menu_4)
        Me.Controls.Add(Me.menu_3)
        Me.Controls.Add(Me.menu_2)
        Me.Controls.Add(Me.Chf_textbox)
        Me.Controls.Add(Me.Name_textbox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.alpha)
        Me.Controls.Add(Me.NoTT)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ediTool"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewToolDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.newToolMenu.ResumeLayout(False)
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
    Friend WithEvents Name_textbox As TextBox
    Friend WithEvents Chf_textbox As TextBox
    Friend WithEvents menu_2 As Label
    Friend WithEvents menu_8 As Label
    Friend WithEvents menu_9 As Label
    Friend WithEvents menu_10 As Label
    Friend WithEvents menu_3 As Label
    Friend WithEvents menu_4 As Label
    Friend WithEvents menu_1 As Label
    Friend WithEvents manref_TextBox As ComboBox
    Friend WithEvents manuf_comboBox As ComboBox
    Friend WithEvents ForceName_checkBox As CheckBox
    Friend WithEvents DefineName_Bt As Button
    Friend WithEvents Lang_en As Button
    Friend WithEvents ValidateBt As Button
    Friend WithEvents AutoOpen_checkBox As CheckBox
    Friend WithEvents FR2T As ToolStripButton
    Friend WithEvents FRTO As ToolStripButton
    Friend WithEvents FRBO As ToolStripButton
    Friend WithEvents FAP As ToolStripButton
    Friend WithEvents FO As ToolStripButton
    Friend WithEvents AL As ToolStripButton
    Friend WithEvents A_TextBox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents XML_ToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents filterD1_Combobox As ComboBox
    Friend WithEvents NewToolDataGridView As DataGridView
    Friend WithEvents Top6_ToolStripButton As ToolStripButton
    Friend WithEvents OrderTools_ToolStripButton As ToolStripButton
    Friend WithEvents newToolMenu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timer_label As Label
    Friend WithEvents filterL1_ComboBox As ComboBox
    Friend WithEvents filterMat_ComboBox As ComboBox
    Friend WithEvents readToolProgress_Label As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents AutoCheckIn_checkBox As CheckBox
    Friend WithEvents Lang_fr As Button
    Friend WithEvents toolRef_checkBox As CheckBox
    Friend WithEvents toolDiam_checkBox As CheckBox
    Friend WithEvents Lang_pt As Button
    Friend WithEvents ToolStrip2 As ToolStrip
End Class
