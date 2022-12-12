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
        Me.Chf_textbox = New System.Windows.Forms.TextBox()
        Me.menu_2 = New System.Windows.Forms.Label()
        Me.menu_8 = New System.Windows.Forms.Label()
        Me.menu_9 = New System.Windows.Forms.Label()
        Me.menu_10 = New System.Windows.Forms.Label()
        Me.menu_3 = New System.Windows.Forms.Label()
        Me.menu_4 = New System.Windows.Forms.Label()
        Me.menu_1 = New System.Windows.Forms.Label()
        Me.manref_TextBox = New System.Windows.Forms.ComboBox()
        Me.manuf_TextBox = New System.Windows.Forms.ComboBox()
        Me.ForceName_checkBox = New System.Windows.Forms.CheckBox()
        Me.DefineName_Bt = New System.Windows.Forms.Button()
        Me.Lang_en = New System.Windows.Forms.Button()
        Me.Lang_fr = New System.Windows.Forms.Button()
        Me.ValidateBt = New System.Windows.Forms.Button()
        Me.AutoOpen_checkBox = New System.Windows.Forms.CheckBox()
        Me.ToolsBar = New System.Windows.Forms.ToolStrip()
        Me.FR2T = New System.Windows.Forms.ToolStripButton()
        Me.FRTO = New System.Windows.Forms.ToolStripButton()
        Me.FRBO = New System.Windows.Forms.ToolStripButton()
        Me.FAP = New System.Windows.Forms.ToolStripButton()
        Me.FO = New System.Windows.Forms.ToolStripButton()
        Me.AL = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.OrderTools_Bt = New System.Windows.Forms.ToolStripButton()
        Me.A_TextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.readToolProgress_Label = New System.Windows.Forms.Label()
        Me.manRefSec_TextBox = New System.Windows.Forms.ComboBox()
        Me.NewToolDataGridView = New System.Windows.Forms.DataGridView()
        Me.newToolMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolsBar.SuspendLayout()
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
        Me.D_textbox.BackColor = System.Drawing.Color.White
        Me.D_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_textbox.Location = New System.Drawing.Point(485, 97)
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
        Me.SD_textbox.BackColor = System.Drawing.Color.White
        Me.SD_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SD_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SD_textbox.Location = New System.Drawing.Point(915, 97)
        Me.SD_textbox.Name = "SD_textbox"
        Me.SD_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SD_textbox.Size = New System.Drawing.Size(71, 22)
        Me.SD_textbox.TabIndex = 2
        Me.SD_textbox.Text = "6"
        Me.SD_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CTS_AD_textbox
        '
        Me.CTS_AD_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTS_AD_textbox.BackColor = System.Drawing.Color.White
        Me.CTS_AD_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CTS_AD_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTS_AD_textbox.Location = New System.Drawing.Point(685, 97)
        Me.CTS_AD_textbox.Name = "CTS_AD_textbox"
        Me.CTS_AD_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CTS_AD_textbox.Size = New System.Drawing.Size(71, 22)
        Me.CTS_AD_textbox.TabIndex = 3
        Me.CTS_AD_textbox.Text = "5.8"
        Me.CTS_AD_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OL_textbox
        '
        Me.OL_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OL_textbox.BackColor = System.Drawing.Color.White
        Me.OL_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OL_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OL_textbox.Location = New System.Drawing.Point(915, 238)
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
        Me.L_textbox.BackColor = System.Drawing.Color.White
        Me.L_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_textbox.Location = New System.Drawing.Point(485, 238)
        Me.L_textbox.Name = "L_textbox"
        Me.L_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.L_textbox.Size = New System.Drawing.Size(71, 22)
        Me.L_textbox.TabIndex = 5
        Me.L_textbox.Text = "8"
        Me.L_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CTS_AL_textbox
        '
        Me.CTS_AL_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTS_AL_textbox.BackColor = System.Drawing.Color.White
        Me.CTS_AL_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CTS_AL_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTS_AL_textbox.Location = New System.Drawing.Point(685, 238)
        Me.CTS_AL_textbox.Name = "CTS_AL_textbox"
        Me.CTS_AL_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CTS_AL_textbox.Size = New System.Drawing.Size(71, 22)
        Me.CTS_AL_textbox.TabIndex = 4
        Me.CTS_AL_textbox.Text = "12"
        Me.CTS_AL_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'alpha
        '
        Me.alpha.BackColor = System.Drawing.Color.LightGray
        Me.alpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alpha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alpha.Location = New System.Drawing.Point(96, 182)
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
        Me.NoTT.Location = New System.Drawing.Point(30, 182)
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
        Me.Label1.Location = New System.Drawing.Point(470, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "D"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Location = New System.Drawing.Point(469, 128)
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
        Me.Label2.Location = New System.Drawing.Point(896, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "SD"
        '
        'CTS_AD_label
        '
        Me.CTS_AD_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTS_AD_label.AutoSize = True
        Me.CTS_AD_label.Location = New System.Drawing.Point(630, 102)
        Me.CTS_AD_label.Name = "CTS_AD_label"
        Me.CTS_AD_label.Size = New System.Drawing.Size(49, 13)
        Me.CTS_AD_label.TabIndex = 13
        Me.CTS_AD_label.Text = "CTS_AD"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(896, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "OL"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(470, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "L"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(632, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "CTS_AL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(137, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "a"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "z"
        '
        'menu_5
        '
        Me.menu_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_5.AutoSize = True
        Me.menu_5.Location = New System.Drawing.Point(490, 83)
        Me.menu_5.Name = "menu_5"
        Me.menu_5.Size = New System.Drawing.Size(35, 13)
        Me.menu_5.TabIndex = 19
        Me.menu_5.Text = "empty"
        '
        'menu_6
        '
        Me.menu_6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_6.AutoSize = True
        Me.menu_6.Location = New System.Drawing.Point(685, 83)
        Me.menu_6.Name = "menu_6"
        Me.menu_6.Size = New System.Drawing.Size(35, 13)
        Me.menu_6.TabIndex = 20
        Me.menu_6.Text = "empty"
        '
        'menu_7
        '
        Me.menu_7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_7.AutoSize = True
        Me.menu_7.Location = New System.Drawing.Point(915, 83)
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
        Me.Ref_filter_TextBox.Location = New System.Drawing.Point(83, 462)
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
        Me.Diam_filter_TextBox.Location = New System.Drawing.Point(166, 462)
        Me.Diam_filter_TextBox.Name = "Diam_filter_TextBox"
        Me.Diam_filter_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Diam_filter_TextBox.Size = New System.Drawing.Size(31, 20)
        Me.Diam_filter_TextBox.TabIndex = 23
        '
        'menu_11
        '
        Me.menu_11.AutoSize = True
        Me.menu_11.Location = New System.Drawing.Point(83, 449)
        Me.menu_11.Name = "menu_11"
        Me.menu_11.Size = New System.Drawing.Size(35, 13)
        Me.menu_11.TabIndex = 24
        Me.menu_11.Text = "empty"
        '
        'menu_12
        '
        Me.menu_12.AutoSize = True
        Me.menu_12.Location = New System.Drawing.Point(163, 446)
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
        Me.Name_textbox.Location = New System.Drawing.Point(27, 97)
        Me.Name_textbox.Name = "Name_textbox"
        Me.Name_textbox.Size = New System.Drawing.Size(246, 26)
        Me.Name_textbox.TabIndex = 27
        Me.Name_textbox.Text = "123"
        '
        'Chf_textbox
        '
        Me.Chf_textbox.BackColor = System.Drawing.Color.LightGray
        Me.Chf_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Chf_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chf_textbox.Location = New System.Drawing.Point(163, 182)
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
        Me.menu_2.Location = New System.Drawing.Point(162, 159)
        Me.menu_2.Name = "menu_2"
        Me.menu_2.Size = New System.Drawing.Size(35, 13)
        Me.menu_2.TabIndex = 29
        Me.menu_2.Text = "empty"
        '
        'menu_8
        '
        Me.menu_8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_8.AutoSize = True
        Me.menu_8.Location = New System.Drawing.Point(485, 223)
        Me.menu_8.Name = "menu_8"
        Me.menu_8.Size = New System.Drawing.Size(35, 13)
        Me.menu_8.TabIndex = 30
        Me.menu_8.Text = "empty"
        '
        'menu_9
        '
        Me.menu_9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_9.AutoSize = True
        Me.menu_9.Location = New System.Drawing.Point(685, 223)
        Me.menu_9.Name = "menu_9"
        Me.menu_9.Size = New System.Drawing.Size(35, 13)
        Me.menu_9.TabIndex = 31
        Me.menu_9.Text = "empty"
        '
        'menu_10
        '
        Me.menu_10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_10.AutoSize = True
        Me.menu_10.Location = New System.Drawing.Point(915, 223)
        Me.menu_10.Name = "menu_10"
        Me.menu_10.Size = New System.Drawing.Size(35, 13)
        Me.menu_10.TabIndex = 32
        Me.menu_10.Text = "empty"
        '
        'menu_3
        '
        Me.menu_3.AutoSize = True
        Me.menu_3.Location = New System.Drawing.Point(95, 162)
        Me.menu_3.Name = "menu_3"
        Me.menu_3.Size = New System.Drawing.Size(35, 13)
        Me.menu_3.TabIndex = 33
        Me.menu_3.Text = "empty"
        '
        'menu_4
        '
        Me.menu_4.AutoSize = True
        Me.menu_4.Location = New System.Drawing.Point(29, 159)
        Me.menu_4.Name = "menu_4"
        Me.menu_4.Size = New System.Drawing.Size(35, 13)
        Me.menu_4.TabIndex = 34
        Me.menu_4.Text = "empty"
        '
        'menu_1
        '
        Me.menu_1.AutoSize = True
        Me.menu_1.Location = New System.Drawing.Point(29, 87)
        Me.menu_1.Name = "menu_1"
        Me.menu_1.Size = New System.Drawing.Size(35, 13)
        Me.menu_1.TabIndex = 35
        Me.menu_1.Text = "empty"
        '
        'manref_TextBox
        '
        Me.manref_TextBox.FormattingEnabled = True
        Me.manref_TextBox.Location = New System.Drawing.Point(214, 221)
        Me.manref_TextBox.Name = "manref_TextBox"
        Me.manref_TextBox.Size = New System.Drawing.Size(181, 21)
        Me.manref_TextBox.TabIndex = 36
        '
        'manuf_TextBox
        '
        Me.manuf_TextBox.FormattingEnabled = True
        Me.manuf_TextBox.Items.AddRange(New Object() {"FRAISA", "SECO", "HOFFMAN"})
        Me.manuf_TextBox.Location = New System.Drawing.Point(27, 221)
        Me.manuf_TextBox.Name = "manuf_TextBox"
        Me.manuf_TextBox.Size = New System.Drawing.Size(181, 21)
        Me.manuf_TextBox.TabIndex = 41
        Me.manuf_TextBox.Text = "FRAISA"
        '
        'ForceName_checkBox
        '
        Me.ForceName_checkBox.AutoSize = True
        Me.ForceName_checkBox.Location = New System.Drawing.Point(27, 128)
        Me.ForceName_checkBox.Name = "ForceName_checkBox"
        Me.ForceName_checkBox.Size = New System.Drawing.Size(54, 17)
        Me.ForceName_checkBox.TabIndex = 42
        Me.ForceName_checkBox.Text = "empty"
        '
        'DefineName_Bt
        '
        Me.DefineName_Bt.Location = New System.Drawing.Point(198, 128)
        Me.DefineName_Bt.Name = "DefineName_Bt"
        Me.DefineName_Bt.Size = New System.Drawing.Size(75, 23)
        Me.DefineName_Bt.TabIndex = 45
        Me.DefineName_Bt.Text = "empty"
        Me.DefineName_Bt.UseVisualStyleBackColor = True
        '
        'Lang_en
        '
        Me.Lang_en.Location = New System.Drawing.Point(969, 2)
        Me.Lang_en.Name = "Lang_en"
        Me.Lang_en.Size = New System.Drawing.Size(31, 29)
        Me.Lang_en.TabIndex = 47
        Me.Lang_en.Text = "en"
        Me.Lang_en.UseVisualStyleBackColor = True
        '
        'Lang_fr
        '
        Me.Lang_fr.Location = New System.Drawing.Point(932, 2)
        Me.Lang_fr.Name = "Lang_fr"
        Me.Lang_fr.Size = New System.Drawing.Size(31, 29)
        Me.Lang_fr.TabIndex = 48
        Me.Lang_fr.Text = "fr"
        Me.Lang_fr.UseVisualStyleBackColor = True
        '
        'ValidateBt
        '
        Me.ValidateBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValidateBt.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidateBt.Location = New System.Drawing.Point(795, 450)
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
        Me.AutoOpen_checkBox.Location = New System.Drawing.Point(946, 457)
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
        Me.ToolsBar.AutoSize = False
        Me.ToolsBar.BackColor = System.Drawing.Color.Transparent
        Me.ToolsBar.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolsBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolsBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FR2T, Me.FRTO, Me.FRBO, Me.FAP, Me.FO, Me.AL, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton2, Me.OrderTools_Bt})
        Me.ToolsBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolsBar.Location = New System.Drawing.Point(10, 2)
        Me.ToolsBar.Margin = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.ToolsBar.Name = "ToolsBar"
        Me.ToolsBar.Size = New System.Drawing.Size(522, 64)
        Me.ToolsBar.TabIndex = 54
        Me.ToolsBar.Text = "ToolsBar"
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
        Me.FR2T.Text = "FR 2T"
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
        Me.FRBO.Text = "FRBO"
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
        Me.FO.Text = "FO"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("3ds", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(60, 60)
        Me.ToolStripButton1.Text = "XML"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("3ds", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(60, 60)
        Me.ToolStripButton2.Text = "Top6"
        '
        'OrderTools_Bt
        '
        Me.OrderTools_Bt.AutoSize = False
        Me.OrderTools_Bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OrderTools_Bt.Font = New System.Drawing.Font("3ds", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderTools_Bt.Image = CType(resources.GetObject("OrderTools_Bt.Image"), System.Drawing.Image)
        Me.OrderTools_Bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OrderTools_Bt.Name = "OrderTools_Bt"
        Me.OrderTools_Bt.Size = New System.Drawing.Size(100, 60)
        Me.OrderTools_Bt.Text = "OrderTools"
        '
        'A_TextBox
        '
        Me.A_TextBox.BackColor = System.Drawing.Color.LightGray
        Me.A_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.A_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_TextBox.Location = New System.Drawing.Point(199, 182)
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
        Me.CheckBox1.Location = New System.Drawing.Point(157, 257)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox1.TabIndex = 56
        Me.CheckBox1.Text = "empty"
        Me.CheckBox1.Visible = False
        '
        'readToolProgress_Label
        '
        Me.readToolProgress_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.readToolProgress_Label.AutoSize = True
        Me.readToolProgress_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readToolProgress_Label.Location = New System.Drawing.Point(25, 457)
        Me.readToolProgress_Label.Name = "readToolProgress_Label"
        Me.readToolProgress_Label.Size = New System.Drawing.Size(24, 25)
        Me.readToolProgress_Label.TabIndex = 58
        Me.readToolProgress_Label.Text = "0"
        '
        'manRefSec_TextBox
        '
        Me.manRefSec_TextBox.FormattingEnabled = True
        Me.manRefSec_TextBox.Location = New System.Drawing.Point(31, 253)
        Me.manRefSec_TextBox.Name = "manRefSec_TextBox"
        Me.manRefSec_TextBox.Size = New System.Drawing.Size(120, 21)
        Me.manRefSec_TextBox.TabIndex = 59
        '
        'NewToolDataGridView
        '
        Me.NewToolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewToolDataGridView.Location = New System.Drawing.Point(27, 295)
        Me.NewToolDataGridView.MultiSelect = False
        Me.NewToolDataGridView.Name = "NewToolDataGridView"
        Me.NewToolDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.NewToolDataGridView.Size = New System.Drawing.Size(973, 149)
        Me.NewToolDataGridView.TabIndex = 61
        '
        'newToolMenu
        '
        Me.newToolMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.newToolMenu.Name = "ContextMenuStrip1"
        Me.newToolMenu.Size = New System.Drawing.Size(181, 92)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem1.Text = "créer"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "info"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem3.Text = "effacer"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1008, 486)
        Me.Controls.Add(Me.ToolsBar)
        Me.Controls.Add(Me.Lang_en)
        Me.Controls.Add(Me.Lang_fr)
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
        Me.Controls.Add(Me.manRefSec_TextBox)
        Me.Controls.Add(Me.readToolProgress_Label)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.A_TextBox)
        Me.Controls.Add(Me.ValidateBt)
        Me.Controls.Add(Me.AutoOpen_checkBox)
        Me.Controls.Add(Me.DefineName_Bt)
        Me.Controls.Add(Me.ForceName_checkBox)
        Me.Controls.Add(Me.manuf_TextBox)
        Me.Controls.Add(Me.manref_TextBox)
        Me.Controls.Add(Me.menu_1)
        Me.Controls.Add(Me.menu_4)
        Me.Controls.Add(Me.menu_3)
        Me.Controls.Add(Me.menu_2)
        Me.Controls.Add(Me.Chf_textbox)
        Me.Controls.Add(Me.Name_textbox)
        Me.Controls.Add(Me.menu_12)
        Me.Controls.Add(Me.menu_11)
        Me.Controls.Add(Me.Diam_filter_TextBox)
        Me.Controls.Add(Me.Ref_filter_TextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.alpha)
        Me.Controls.Add(Me.NoTT)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Main"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ediTool"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolsBar.ResumeLayout(False)
        Me.ToolsBar.PerformLayout()
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
    Friend WithEvents Ref_filter_TextBox As TextBox
    Friend WithEvents Diam_filter_TextBox As TextBox
    Friend WithEvents menu_11 As Label
    Friend WithEvents menu_12 As Label
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
    Friend WithEvents manuf_TextBox As ComboBox
    Friend WithEvents ForceName_checkBox As CheckBox
    Friend WithEvents DefineName_Bt As Button
    Friend WithEvents Lang_en As Button
    Friend WithEvents Lang_fr As Button
    Friend WithEvents ValidateBt As Button
    Friend WithEvents AutoOpen_checkBox As CheckBox
    Friend WithEvents FR2T As ToolStripButton
    Friend WithEvents FRTO As ToolStripButton
    Friend WithEvents FRBO As ToolStripButton
    Friend WithEvents FAP As ToolStripButton
    Private WithEvents ToolsBar As ToolStrip
    Friend WithEvents FO As ToolStripButton
    Friend WithEvents AL As ToolStripButton
    Friend WithEvents A_TextBox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents readToolProgress_Label As Label
    Friend WithEvents manRefSec_TextBox As ComboBox
    Friend WithEvents NewToolDataGridView As DataGridView
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents OrderTools_Bt As ToolStripButton
    Friend WithEvents newToolMenu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
End Class
