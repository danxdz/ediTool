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
        Me.D1textBox = New System.Windows.Forms.TextBox()
        Me.D3textBox = New System.Windows.Forms.TextBox()
        Me.L3textBox = New System.Windows.Forms.TextBox()
        Me.L1textBox = New System.Windows.Forms.TextBox()
        Me.L2textBox = New System.Windows.Forms.TextBox()
        Me.alpha = New System.Windows.Forms.TextBox()
        Me.NoTT = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolPreview_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Name_textbox = New System.Windows.Forms.TextBox()
        Me.Chf_textbox = New System.Windows.Forms.TextBox()
        Me.toolName = New System.Windows.Forms.Label()
        Me.manref_TextBox = New System.Windows.Forms.ComboBox()
        Me.manuf_comboBox = New System.Windows.Forms.ComboBox()
        Me.forceName = New System.Windows.Forms.CheckBox()
        Me.config = New System.Windows.Forms.Button()
        Me.createBt = New System.Windows.Forms.Button()
        Me.autoOpen = New System.Windows.Forms.CheckBox()
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
        Me.filterD1_Combobox = New System.Windows.Forms.ComboBox()
        Me.newToolMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.filterL1_ComboBox = New System.Windows.Forms.ComboBox()
        Me.filterMat_ComboBox = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.LocalTabPage = New System.Windows.Forms.TabPage()
        Me.NewToolDataGridView = New System.Windows.Forms.DataGridView()
        Me.CloudTabPage = New System.Windows.Forms.TabPage()
        Me.ImportTabPage = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.teethNum = New System.Windows.Forms.GroupBox()
        Me.angleDeg = New System.Windows.Forms.GroupBox()
        Me.anglePoint = New System.Windows.Forms.GroupBox()
        Me.rayon = New System.Windows.Forms.GroupBox()
        Me.D2textBox = New System.Windows.Forms.TextBox()
        Me.toolPreviewBox = New System.Windows.Forms.GroupBox()
        Me.filters = New System.Windows.Forms.GroupBox()
        Me.readToolProgress_Label = New System.Windows.Forms.Label()
        Me.autoCheckIn = New System.Windows.Forms.CheckBox()
        CType(Me.ToolPreview_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.newToolMenu.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.LocalTabPage.SuspendLayout()
        CType(Me.NewToolDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImportTabPage.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.teethNum.SuspendLayout()
        Me.angleDeg.SuspendLayout()
        Me.anglePoint.SuspendLayout()
        Me.rayon.SuspendLayout()
        Me.toolPreviewBox.SuspendLayout()
        Me.filters.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'D1textBox
        '
        Me.D1textBox.AccessibleDescription = "diamètre de coupe"
        Me.D1textBox.AccessibleName = "tthth"
        Me.D1textBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.D1textBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.D1textBox.BackColor = System.Drawing.Color.LightGray
        Me.D1textBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D1textBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D1textBox.Location = New System.Drawing.Point(10, 19)
        Me.D1textBox.Name = "D1textBox"
        Me.D1textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.D1textBox.Size = New System.Drawing.Size(71, 22)
        Me.D1textBox.TabIndex = 1
        Me.D1textBox.Text = "6"
        Me.D1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3textBox
        '
        Me.D3textBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.D3textBox.BackColor = System.Drawing.Color.LightGray
        Me.D3textBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D3textBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D3textBox.Location = New System.Drawing.Point(570, 19)
        Me.D3textBox.Name = "D3textBox"
        Me.D3textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.D3textBox.Size = New System.Drawing.Size(71, 22)
        Me.D3textBox.TabIndex = 3
        Me.D3textBox.Text = "6"
        Me.D3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L3textBox
        '
        Me.L3textBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L3textBox.BackColor = System.Drawing.Color.LightGray
        Me.L3textBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L3textBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L3textBox.Location = New System.Drawing.Point(570, 148)
        Me.L3textBox.Name = "L3textBox"
        Me.L3textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.L3textBox.Size = New System.Drawing.Size(71, 22)
        Me.L3textBox.TabIndex = 6
        Me.L3textBox.Text = "53"
        Me.L3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L1textBox
        '
        Me.L1textBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L1textBox.BackColor = System.Drawing.Color.LightGray
        Me.L1textBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L1textBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1textBox.Location = New System.Drawing.Point(10, 148)
        Me.L1textBox.Name = "L1textBox"
        Me.L1textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.L1textBox.Size = New System.Drawing.Size(71, 22)
        Me.L1textBox.TabIndex = 4
        Me.L1textBox.Text = "8"
        Me.L1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L2textBox
        '
        Me.L2textBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L2textBox.BackColor = System.Drawing.Color.LightGray
        Me.L2textBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L2textBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2textBox.Location = New System.Drawing.Point(173, 148)
        Me.L2textBox.Name = "L2textBox"
        Me.L2textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.L2textBox.Size = New System.Drawing.Size(71, 22)
        Me.L2textBox.TabIndex = 5
        Me.L2textBox.Text = "12"
        Me.L2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'alpha
        '
        Me.alpha.BackColor = System.Drawing.Color.LightGray
        Me.alpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alpha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alpha.Location = New System.Drawing.Point(6, 19)
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
        Me.NoTT.Location = New System.Drawing.Point(13, 19)
        Me.NoTT.Margin = New System.Windows.Forms.Padding(10)
        Me.NoTT.Name = "NoTT"
        Me.NoTT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NoTT.Size = New System.Drawing.Size(32, 26)
        Me.NoTT.TabIndex = 7
        Me.NoTT.Text = "2"
        Me.NoTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolPreview_PictureBox
        '
        Me.ToolPreview_PictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolPreview_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.ToolPreview_PictureBox.Location = New System.Drawing.Point(10, 44)
        Me.ToolPreview_PictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolPreview_PictureBox.Name = "ToolPreview_PictureBox"
        Me.ToolPreview_PictureBox.Size = New System.Drawing.Size(634, 101)
        Me.ToolPreview_PictureBox.TabIndex = 11
        Me.ToolPreview_PictureBox.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "a"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "z"
        '
        'Name_textbox
        '
        Me.Name_textbox.AccessibleDescription = "diamètre de coupe"
        Me.Name_textbox.AccessibleName = "tthth"
        Me.Name_textbox.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.Name_textbox.Enabled = False
        Me.Name_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_textbox.Location = New System.Drawing.Point(11, 68)
        Me.Name_textbox.Name = "Name_textbox"
        Me.Name_textbox.Size = New System.Drawing.Size(311, 31)
        Me.Name_textbox.TabIndex = 27
        '
        'Chf_textbox
        '
        Me.Chf_textbox.BackColor = System.Drawing.Color.LightGray
        Me.Chf_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Chf_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chf_textbox.Location = New System.Drawing.Point(13, 19)
        Me.Chf_textbox.Margin = New System.Windows.Forms.Padding(10)
        Me.Chf_textbox.Name = "Chf_textbox"
        Me.Chf_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Chf_textbox.Size = New System.Drawing.Size(32, 26)
        Me.Chf_textbox.TabIndex = 28
        Me.Chf_textbox.Text = "0"
        Me.Chf_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'toolName
        '
        Me.toolName.AutoSize = True
        Me.toolName.Location = New System.Drawing.Point(11, 42)
        Me.toolName.Name = "toolName"
        Me.toolName.Size = New System.Drawing.Size(35, 13)
        Me.toolName.TabIndex = 35
        Me.toolName.Text = "empty"
        '
        'manref_TextBox
        '
        Me.manref_TextBox.FormattingEnabled = True
        Me.manref_TextBox.Location = New System.Drawing.Point(387, 18)
        Me.manref_TextBox.Name = "manref_TextBox"
        Me.manref_TextBox.Size = New System.Drawing.Size(121, 21)
        Me.manref_TextBox.TabIndex = 36
        '
        'manuf_comboBox
        '
        Me.manuf_comboBox.FormattingEnabled = True
        Me.manuf_comboBox.Items.AddRange(New Object() {"FRAISA", "SECO", "HOFFMAN"})
        Me.manuf_comboBox.Location = New System.Drawing.Point(514, 18)
        Me.manuf_comboBox.Name = "manuf_comboBox"
        Me.manuf_comboBox.Size = New System.Drawing.Size(121, 21)
        Me.manuf_comboBox.TabIndex = 41
        Me.manuf_comboBox.Text = "FRAISA"
        '
        'forceName
        '
        Me.forceName.AutoSize = True
        Me.forceName.Location = New System.Drawing.Point(116, 109)
        Me.forceName.Name = "forceName"
        Me.forceName.Size = New System.Drawing.Size(54, 17)
        Me.forceName.TabIndex = 42
        Me.forceName.Text = "empty"
        '
        'config
        '
        Me.config.Location = New System.Drawing.Point(11, 105)
        Me.config.Name = "config"
        Me.config.Size = New System.Drawing.Size(99, 23)
        Me.config.TabIndex = 45
        Me.config.Text = "empty"
        Me.config.UseVisualStyleBackColor = True
        '
        'createBt
        '
        Me.createBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.createBt.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createBt.Location = New System.Drawing.Point(535, 653)
        Me.createBt.Name = "createBt"
        Me.createBt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.createBt.Size = New System.Drawing.Size(130, 37)
        Me.createBt.TabIndex = 50
        Me.createBt.Text = "creer outil"
        Me.createBt.UseVisualStyleBackColor = True
        '
        'autoOpen
        '
        Me.autoOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.autoOpen.AutoSize = True
        Me.autoOpen.Checked = True
        Me.autoOpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autoOpen.Location = New System.Drawing.Point(458, 665)
        Me.autoOpen.Name = "autoOpen"
        Me.autoOpen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.autoOpen.Size = New System.Drawing.Size(54, 17)
        Me.autoOpen.TabIndex = 51
        Me.autoOpen.Text = "empty"
        Me.autoOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.autoOpen.UseVisualStyleBackColor = True
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
        Me.A_TextBox.Location = New System.Drawing.Point(13, 19)
        Me.A_TextBox.Margin = New System.Windows.Forms.Padding(10)
        Me.A_TextBox.Name = "A_TextBox"
        Me.A_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.A_TextBox.Size = New System.Drawing.Size(32, 26)
        Me.A_TextBox.TabIndex = 55
        Me.A_TextBox.Text = "90"
        Me.A_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'filterD1_Combobox
        '
        Me.filterD1_Combobox.FormattingEnabled = True
        Me.filterD1_Combobox.Location = New System.Drawing.Point(135, 18)
        Me.filterD1_Combobox.Name = "filterD1_Combobox"
        Me.filterD1_Combobox.Size = New System.Drawing.Size(120, 21)
        Me.filterD1_Combobox.TabIndex = 59
        Me.filterD1_Combobox.Text = " "
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
        'filterL1_ComboBox
        '
        Me.filterL1_ComboBox.FormattingEnabled = True
        Me.filterL1_ComboBox.Location = New System.Drawing.Point(261, 18)
        Me.filterL1_ComboBox.Name = "filterL1_ComboBox"
        Me.filterL1_ComboBox.Size = New System.Drawing.Size(120, 21)
        Me.filterL1_ComboBox.TabIndex = 65
        Me.filterL1_ComboBox.Text = " "
        '
        'filterMat_ComboBox
        '
        Me.filterMat_ComboBox.FormattingEnabled = True
        Me.filterMat_ComboBox.Location = New System.Drawing.Point(9, 18)
        Me.filterMat_ComboBox.Name = "filterMat_ComboBox"
        Me.filterMat_ComboBox.Size = New System.Drawing.Size(120, 21)
        Me.filterMat_ComboBox.TabIndex = 66
        Me.filterMat_ComboBox.Text = " "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(663, 24)
        Me.MenuStrip1.TabIndex = 70
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.LocalTabPage)
        Me.TabControl1.Controls.Add(Me.CloudTabPage)
        Me.TabControl1.Controls.Add(Me.ImportTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(11, 404)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(651, 243)
        Me.TabControl1.TabIndex = 79
        '
        'LocalTabPage
        '
        Me.LocalTabPage.Controls.Add(Me.NewToolDataGridView)
        Me.LocalTabPage.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalTabPage.Location = New System.Drawing.Point(4, 22)
        Me.LocalTabPage.Name = "LocalTabPage"
        Me.LocalTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.LocalTabPage.Size = New System.Drawing.Size(643, 217)
        Me.LocalTabPage.TabIndex = 0
        Me.LocalTabPage.Text = "local"
        Me.LocalTabPage.UseVisualStyleBackColor = True
        '
        'NewToolDataGridView
        '
        Me.NewToolDataGridView.AllowUserToOrderColumns = True
        Me.NewToolDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.NewToolDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NewToolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewToolDataGridView.Location = New System.Drawing.Point(8, 6)
        Me.NewToolDataGridView.Name = "NewToolDataGridView"
        Me.NewToolDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.NewToolDataGridView.Size = New System.Drawing.Size(626, 204)
        Me.NewToolDataGridView.TabIndex = 79
        '
        'CloudTabPage
        '
        Me.CloudTabPage.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CloudTabPage.Name = "CloudTabPage"
        Me.CloudTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CloudTabPage.Size = New System.Drawing.Size(643, 217)
        Me.CloudTabPage.TabIndex = 1
        Me.CloudTabPage.Text = "cloud"
        Me.CloudTabPage.UseVisualStyleBackColor = True
        '
        'ImportTabPage
        '
        Me.ImportTabPage.Controls.Add(Me.DataGridView1)
        Me.ImportTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ImportTabPage.Name = "ImportTabPage"
        Me.ImportTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ImportTabPage.Size = New System.Drawing.Size(643, 217)
        Me.ImportTabPage.TabIndex = 2
        Me.ImportTabPage.Text = "import"
        Me.ImportTabPage.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(637, 211)
        Me.DataGridView1.TabIndex = 0
        '
        'teethNum
        '
        Me.teethNum.BackColor = System.Drawing.Color.LightGray
        Me.teethNum.Controls.Add(Me.NoTT)
        Me.teethNum.Controls.Add(Me.Label8)
        Me.teethNum.Location = New System.Drawing.Point(350, 77)
        Me.teethNum.Name = "teethNum"
        Me.teethNum.Size = New System.Drawing.Size(83, 51)
        Me.teethNum.TabIndex = 80
        Me.teethNum.TabStop = False
        Me.teethNum.Text = "NoTT"
        '
        'angleDeg
        '
        Me.angleDeg.BackColor = System.Drawing.Color.LightGray
        Me.angleDeg.Controls.Add(Me.Label7)
        Me.angleDeg.Controls.Add(Me.alpha)
        Me.angleDeg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.angleDeg.Location = New System.Drawing.Point(579, 77)
        Me.angleDeg.Name = "angleDeg"
        Me.angleDeg.Size = New System.Drawing.Size(83, 51)
        Me.angleDeg.TabIndex = 81
        Me.angleDeg.TabStop = False
        Me.angleDeg.Text = "a"
        '
        'anglePoint
        '
        Me.anglePoint.BackColor = System.Drawing.Color.LightGray
        Me.anglePoint.Controls.Add(Me.A_TextBox)
        Me.anglePoint.Location = New System.Drawing.Point(512, 77)
        Me.anglePoint.Name = "anglePoint"
        Me.anglePoint.Size = New System.Drawing.Size(60, 51)
        Me.anglePoint.TabIndex = 82
        Me.anglePoint.TabStop = False
        Me.anglePoint.Text = "a"
        '
        'rayon
        '
        Me.rayon.BackColor = System.Drawing.Color.LightGray
        Me.rayon.Controls.Add(Me.Chf_textbox)
        Me.rayon.Location = New System.Drawing.Point(445, 77)
        Me.rayon.Name = "rayon"
        Me.rayon.Size = New System.Drawing.Size(61, 51)
        Me.rayon.TabIndex = 81
        Me.rayon.TabStop = False
        Me.rayon.Text = "r"
        '
        'D2textBox
        '
        Me.D2textBox.AccessibleDescription = "diamètre de coupe"
        Me.D2textBox.AccessibleName = "tthth"
        Me.D2textBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.D2textBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.D2textBox.BackColor = System.Drawing.Color.LightGray
        Me.D2textBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D2textBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D2textBox.Location = New System.Drawing.Point(173, 19)
        Me.D2textBox.Name = "D2textBox"
        Me.D2textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.D2textBox.Size = New System.Drawing.Size(71, 22)
        Me.D2textBox.TabIndex = 83
        Me.D2textBox.Text = "6"
        Me.D2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'toolPreviewBox
        '
        Me.toolPreviewBox.BackColor = System.Drawing.Color.LightGray
        Me.toolPreviewBox.Controls.Add(Me.D1textBox)
        Me.toolPreviewBox.Controls.Add(Me.D2textBox)
        Me.toolPreviewBox.Controls.Add(Me.D3textBox)
        Me.toolPreviewBox.Controls.Add(Me.ToolPreview_PictureBox)
        Me.toolPreviewBox.Controls.Add(Me.L3textBox)
        Me.toolPreviewBox.Controls.Add(Me.L2textBox)
        Me.toolPreviewBox.Controls.Add(Me.L1textBox)
        Me.toolPreviewBox.Location = New System.Drawing.Point(11, 143)
        Me.toolPreviewBox.Name = "toolPreviewBox"
        Me.toolPreviewBox.Size = New System.Drawing.Size(650, 176)
        Me.toolPreviewBox.TabIndex = 84
        Me.toolPreviewBox.TabStop = False
        Me.toolPreviewBox.Text = "tool preview"
        '
        'filters
        '
        Me.filters.BackColor = System.Drawing.Color.LightGray
        Me.filters.Controls.Add(Me.manuf_comboBox)
        Me.filters.Controls.Add(Me.manref_TextBox)
        Me.filters.Controls.Add(Me.filterL1_ComboBox)
        Me.filters.Controls.Add(Me.filterD1_Combobox)
        Me.filters.Controls.Add(Me.filterMat_ComboBox)
        Me.filters.Location = New System.Drawing.Point(11, 337)
        Me.filters.Name = "filters"
        Me.filters.Size = New System.Drawing.Size(650, 49)
        Me.filters.TabIndex = 86
        Me.filters.TabStop = False
        Me.filters.Text = "filters"
        '
        'readToolProgress_Label
        '
        Me.readToolProgress_Label.AutoSize = True
        Me.readToolProgress_Label.Location = New System.Drawing.Point(652, 42)
        Me.readToolProgress_Label.Name = "readToolProgress_Label"
        Me.readToolProgress_Label.Size = New System.Drawing.Size(13, 13)
        Me.readToolProgress_Label.TabIndex = 87
        Me.readToolProgress_Label.Text = "0"
        '
        'autoCheckIn
        '
        Me.autoCheckIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.autoCheckIn.AutoSize = True
        Me.autoCheckIn.Checked = True
        Me.autoCheckIn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autoCheckIn.Location = New System.Drawing.Point(363, 665)
        Me.autoCheckIn.Name = "autoCheckIn"
        Me.autoCheckIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.autoCheckIn.Size = New System.Drawing.Size(54, 17)
        Me.autoCheckIn.TabIndex = 88
        Me.autoCheckIn.Text = "empty"
        Me.autoCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.autoCheckIn.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(673, 701)
        Me.Controls.Add(Me.autoCheckIn)
        Me.Controls.Add(Me.readToolProgress_Label)
        Me.Controls.Add(Me.filters)
        Me.Controls.Add(Me.toolPreviewBox)
        Me.Controls.Add(Me.rayon)
        Me.Controls.Add(Me.anglePoint)
        Me.Controls.Add(Me.angleDeg)
        Me.Controls.Add(Me.teethNum)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.createBt)
        Me.Controls.Add(Me.autoOpen)
        Me.Controls.Add(Me.config)
        Me.Controls.Add(Me.forceName)
        Me.Controls.Add(Me.toolName)
        Me.Controls.Add(Me.Name_textbox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ediTool"
        CType(Me.ToolPreview_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.newToolMenu.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.LocalTabPage.ResumeLayout(False)
        CType(Me.NewToolDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImportTabPage.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.teethNum.ResumeLayout(False)
        Me.teethNum.PerformLayout()
        Me.angleDeg.ResumeLayout(False)
        Me.angleDeg.PerformLayout()
        Me.anglePoint.ResumeLayout(False)
        Me.anglePoint.PerformLayout()
        Me.rayon.ResumeLayout(False)
        Me.rayon.PerformLayout()
        Me.toolPreviewBox.ResumeLayout(False)
        Me.toolPreviewBox.PerformLayout()
        Me.filters.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents D1textBox As TextBox
    Friend WithEvents D3textBox As TextBox
    Friend WithEvents L3textBox As TextBox
    Friend WithEvents L1textBox As TextBox
    Friend WithEvents L2textBox As TextBox
    Friend WithEvents alpha As TextBox
    Friend WithEvents NoTT As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolPreview_PictureBox As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Name_textbox As TextBox
    Friend WithEvents Chf_textbox As TextBox
    Friend WithEvents toolName As Label
    Friend WithEvents manref_TextBox As ComboBox
    Friend WithEvents manuf_comboBox As ComboBox
    Friend WithEvents forceName As CheckBox
    Friend WithEvents config As Button
    Friend WithEvents createBt As Button
    Friend WithEvents autoOpen As CheckBox
    Friend WithEvents FR2T As ToolStripButton
    Friend WithEvents FRTO As ToolStripButton
    Friend WithEvents FRBO As ToolStripButton
    Friend WithEvents FAP As ToolStripButton
    Friend WithEvents FO As ToolStripButton
    Friend WithEvents AL As ToolStripButton
    Friend WithEvents A_TextBox As TextBox
    Friend WithEvents XML_ToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents filterD1_Combobox As ComboBox
    Friend WithEvents Top6_ToolStripButton As ToolStripButton
    Friend WithEvents OrderTools_ToolStripButton As ToolStripButton
    Friend WithEvents newToolMenu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents filterL1_ComboBox As ComboBox
    Friend WithEvents filterMat_ComboBox As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents LocalTabPage As TabPage
    Friend WithEvents CloudTabPage As TabPage
    Friend WithEvents NewToolDataGridView As DataGridView
    Friend WithEvents ImportTabPage As TabPage
    Friend WithEvents teethNum As GroupBox
    Friend WithEvents angleDeg As GroupBox
    Friend WithEvents anglePoint As GroupBox
    Friend WithEvents rayon As GroupBox
    Friend WithEvents D2textBox As TextBox
    Friend WithEvents toolPreviewBox As GroupBox
    Friend WithEvents filters As GroupBox
    Friend WithEvents readToolProgress_Label As Label
    Friend WithEvents autoCheckIn As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
