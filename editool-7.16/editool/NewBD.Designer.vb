<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBD
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.valider_bt = New System.Windows.Forms.Button()
        Me.ToolNameCb = New System.Windows.Forms.ComboBox()
        Me.MatCb = New System.Windows.Forms.ComboBox()
        Me.ManufRef = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.d2Cb = New System.Windows.Forms.ComboBox()
        Me.d3Cb = New System.Windows.Forms.ComboBox()
        Me.d1Cb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.L_deta_cb = New System.Windows.Forms.ComboBox()
        Me.L_total_cb = New System.Windows.Forms.ComboBox()
        Me.L_coupe_cb = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chf__cb = New System.Windows.Forms.ComboBox()
        Me.NoTT_cb = New System.Windows.Forms.ComboBox()
        Me.r_bout_cb = New System.Windows.Forms.ComboBox()
        Me.arrosage_int_cb = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.type_tar_cb = New System.Windows.Forms.ComboBox()
        Me.coupe_centre_cb = New System.Windows.Forms.ComboBox()
        Me.ref_cb = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ref_comp_cb = New System.Windows.Forms.ComboBox()
        Me.manuf__cb = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.pas_tar_cb = New System.Windows.Forms.ComboBox()
        Me.ref_int_cb = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.code_barre_cb = New System.Windows.Forms.ComboBox()
        Me.comm_cb = New System.Windows.Forms.ComboBox()
        Me.cancel_bt = New System.Windows.Forms.Button()
        Me.open_file_bt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Row_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.path_TextBox = New System.Windows.Forms.TextBox()
        Me.RC_Menu_NewDB = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.new_tool = New System.Windows.Forms.ToolStripMenuItem()
        Me.copy_tool = New System.Windows.Forms.ToolStripMenuItem()
        Me.del_tool = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeFilterComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Row_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RC_Menu_NewDB.SuspendLayout()
        Me.SuspendLayout()
        '
        'valider_bt
        '
        Me.valider_bt.Location = New System.Drawing.Point(315, 380)
        Me.valider_bt.Name = "valider_bt"
        Me.valider_bt.Size = New System.Drawing.Size(75, 23)
        Me.valider_bt.TabIndex = 0
        Me.valider_bt.Text = "validate"
        Me.valider_bt.UseVisualStyleBackColor = True
        '
        'nom_cb
        '
        Me.ToolNameCb.FormattingEnabled = True
        Me.ToolNameCb.Location = New System.Drawing.Point(15, 25)
        Me.ToolNameCb.Name = "nom_cb"
        Me.ToolNameCb.Size = New System.Drawing.Size(121, 21)
        Me.ToolNameCb.TabIndex = 1
        '
        'mat_cb
        '
        Me.MatCb.FormattingEnabled = True
        Me.MatCb.Location = New System.Drawing.Point(269, 25)
        Me.MatCb.Name = "mat_cb"
        Me.MatCb.Size = New System.Drawing.Size(121, 21)
        Me.MatCb.TabIndex = 4
        '
        'code_outil_cb
        '
        Me.ManufRef.FormattingEnabled = True
        Me.ManufRef.Location = New System.Drawing.Point(142, 25)
        Me.ManufRef.Name = "code_outil_cb"
        Me.ManufRef.Size = New System.Drawing.Size(121, 21)
        Me.ManufRef.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nom outil *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Matiere a usiner"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Code outil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Diamétre détalonée"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(269, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Diametre corps *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Diamètre de coupe *"
        '
        'diam_deta_cb
        '
        Me.d2Cb.FormattingEnabled = True
        Me.d2Cb.Location = New System.Drawing.Point(142, 72)
        Me.d2Cb.Name = "diam_deta_cb"
        Me.d2Cb.Size = New System.Drawing.Size(121, 21)
        Me.d2Cb.TabIndex = 11
        '
        'diam_corps_cb
        '
        Me.d3Cb.FormattingEnabled = True
        Me.d3Cb.Location = New System.Drawing.Point(269, 72)
        Me.d3Cb.Name = "diam_corps_cb"
        Me.d3Cb.Size = New System.Drawing.Size(121, 21)
        Me.d3Cb.TabIndex = 10
        '
        'diam_coupe_cb
        '
        Me.d1Cb.FormattingEnabled = True
        Me.d1Cb.Location = New System.Drawing.Point(15, 72)
        Me.d1Cb.Name = "diam_coupe_cb"
        Me.d1Cb.Size = New System.Drawing.Size(121, 21)
        Me.d1Cb.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(139, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Longueur détalonée"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(269, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Longueur total *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Longueur de coupe *"
        '
        'L_deta_cb
        '
        Me.L_deta_cb.FormattingEnabled = True
        Me.L_deta_cb.Location = New System.Drawing.Point(142, 112)
        Me.L_deta_cb.Name = "L_deta_cb"
        Me.L_deta_cb.Size = New System.Drawing.Size(121, 21)
        Me.L_deta_cb.TabIndex = 17
        '
        'L_total_cb
        '
        Me.L_total_cb.FormattingEnabled = True
        Me.L_total_cb.Location = New System.Drawing.Point(269, 112)
        Me.L_total_cb.Name = "L_total_cb"
        Me.L_total_cb.Size = New System.Drawing.Size(121, 21)
        Me.L_total_cb.TabIndex = 16
        '
        'L_coupe_cb
        '
        Me.L_coupe_cb.FormattingEnabled = True
        Me.L_coupe_cb.Location = New System.Drawing.Point(15, 112)
        Me.L_coupe_cb.Name = "L_coupe_cb"
        Me.L_coupe_cb.Size = New System.Drawing.Size(121, 21)
        Me.L_coupe_cb.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(139, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Rayon bout"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(269, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Chanfrein"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Nombre dents *"
        '
        'chf__cb
        '
        Me.chf__cb.FormattingEnabled = True
        Me.chf__cb.Location = New System.Drawing.Point(269, 152)
        Me.chf__cb.Name = "chf__cb"
        Me.chf__cb.Size = New System.Drawing.Size(121, 21)
        Me.chf__cb.TabIndex = 22
        '
        'NoTT_cb
        '
        Me.NoTT_cb.FormattingEnabled = True
        Me.NoTT_cb.Location = New System.Drawing.Point(15, 152)
        Me.NoTT_cb.Name = "NoTT_cb"
        Me.NoTT_cb.Size = New System.Drawing.Size(121, 21)
        Me.NoTT_cb.TabIndex = 21
        '
        'r_bout_cb
        '
        Me.r_bout_cb.FormattingEnabled = True
        Me.r_bout_cb.Location = New System.Drawing.Point(142, 152)
        Me.r_bout_cb.Name = "r_bout_cb"
        Me.r_bout_cb.Size = New System.Drawing.Size(121, 21)
        Me.r_bout_cb.TabIndex = 26
        '
        'arrosage_int_cb
        '
        Me.arrosage_int_cb.FormattingEnabled = True
        Me.arrosage_int_cb.Location = New System.Drawing.Point(142, 198)
        Me.arrosage_int_cb.Name = "arrosage_int_cb"
        Me.arrosage_int_cb.Size = New System.Drawing.Size(121, 21)
        Me.arrosage_int_cb.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(139, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Arrosage interne"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(269, 182)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Type de taraud"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 182)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Coupe au centre"
        '
        'type_tar_cb
        '
        Me.type_tar_cb.FormattingEnabled = True
        Me.type_tar_cb.Location = New System.Drawing.Point(269, 198)
        Me.type_tar_cb.Name = "type_tar_cb"
        Me.type_tar_cb.Size = New System.Drawing.Size(121, 21)
        Me.type_tar_cb.TabIndex = 28
        '
        'coupe_centre_cb
        '
        Me.coupe_centre_cb.FormattingEnabled = True
        Me.coupe_centre_cb.Location = New System.Drawing.Point(15, 198)
        Me.coupe_centre_cb.Name = "coupe_centre_cb"
        Me.coupe_centre_cb.Size = New System.Drawing.Size(121, 21)
        Me.coupe_centre_cb.TabIndex = 27
        '
        'ref_cb
        '
        Me.ref_cb.FormattingEnabled = True
        Me.ref_cb.Location = New System.Drawing.Point(142, 293)
        Me.ref_cb.Name = "ref_cb"
        Me.ref_cb.Size = New System.Drawing.Size(121, 21)
        Me.ref_cb.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(139, 277)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Référence de l'outil"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(269, 277)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Nuance"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 277)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Fournisseur"
        '
        'ref_comp_cb
        '
        Me.ref_comp_cb.FormattingEnabled = True
        Me.ref_comp_cb.Location = New System.Drawing.Point(269, 293)
        Me.ref_comp_cb.Name = "ref_comp_cb"
        Me.ref_comp_cb.Size = New System.Drawing.Size(121, 21)
        Me.ref_comp_cb.TabIndex = 34
        '
        'manuf__cb
        '
        Me.manuf__cb.FormattingEnabled = True
        Me.manuf__cb.Location = New System.Drawing.Point(15, 293)
        Me.manuf__cb.Name = "manuf__cb"
        Me.manuf__cb.Size = New System.Drawing.Size(121, 21)
        Me.manuf__cb.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(269, 222)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Pas de taraud"
        '
        'pas_tar_cb
        '
        Me.pas_tar_cb.FormattingEnabled = True
        Me.pas_tar_cb.Location = New System.Drawing.Point(269, 238)
        Me.pas_tar_cb.Name = "pas_tar_cb"
        Me.pas_tar_cb.Size = New System.Drawing.Size(121, 21)
        Me.pas_tar_cb.TabIndex = 39
        '
        'ref_int_cb
        '
        Me.ref_int_cb.FormattingEnabled = True
        Me.ref_int_cb.Location = New System.Drawing.Point(142, 344)
        Me.ref_int_cb.Name = "ref_int_cb"
        Me.ref_int_cb.Size = New System.Drawing.Size(121, 21)
        Me.ref_int_cb.TabIndex = 46
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(139, 328)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 13)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Référence interne"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(269, 328)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 13)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "Code barre"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 328)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 13)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Commentaire"
        '
        'code_barre_cb
        '
        Me.code_barre_cb.FormattingEnabled = True
        Me.code_barre_cb.Location = New System.Drawing.Point(269, 344)
        Me.code_barre_cb.Name = "code_barre_cb"
        Me.code_barre_cb.Size = New System.Drawing.Size(121, 21)
        Me.code_barre_cb.TabIndex = 42
        '
        'comm_cb
        '
        Me.comm_cb.FormattingEnabled = True
        Me.comm_cb.Location = New System.Drawing.Point(15, 344)
        Me.comm_cb.Name = "comm_cb"
        Me.comm_cb.Size = New System.Drawing.Size(121, 21)
        Me.comm_cb.TabIndex = 41
        '
        'cancel_bt
        '
        Me.cancel_bt.Location = New System.Drawing.Point(15, 380)
        Me.cancel_bt.Name = "cancel_bt"
        Me.cancel_bt.Size = New System.Drawing.Size(75, 23)
        Me.cancel_bt.TabIndex = 47
        Me.cancel_bt.Text = "anuler"
        Me.cancel_bt.UseVisualStyleBackColor = True
        '
        'open_file_bt
        '
        Me.open_file_bt.Location = New System.Drawing.Point(212, 380)
        Me.open_file_bt.Name = "open_file_bt"
        Me.open_file_bt.Size = New System.Drawing.Size(75, 23)
        Me.open_file_bt.TabIndex = 48
        Me.open_file_bt.Text = "fichier"
        Me.open_file_bt.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(428, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(680, 378)
        Me.DataGridView1.TabIndex = 49
        '
        'Row_NumericUpDown
        '
        Me.Row_NumericUpDown.Location = New System.Drawing.Point(428, 25)
        Me.Row_NumericUpDown.Name = "Row_NumericUpDown"
        Me.Row_NumericUpDown.Size = New System.Drawing.Size(61, 20)
        Me.Row_NumericUpDown.TabIndex = 50
        Me.Row_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'path_TextBox
        '
        Me.path_TextBox.Location = New System.Drawing.Point(846, 23)
        Me.path_TextBox.Name = "path_TextBox"
        Me.path_TextBox.Size = New System.Drawing.Size(262, 20)
        Me.path_TextBox.TabIndex = 51
        '
        'RC_Menu_NewDB
        '
        Me.RC_Menu_NewDB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.new_tool, Me.copy_tool, Me.del_tool})
        Me.RC_Menu_NewDB.Name = "ContextMenuStrip1"
        Me.RC_Menu_NewDB.Size = New System.Drawing.Size(107, 70)
        '
        'new_tool
        '
        Me.new_tool.Name = "new_tool"
        Me.new_tool.Size = New System.Drawing.Size(106, 22)
        Me.new_tool.Text = "new"
        '
        'copy_tool
        '
        Me.copy_tool.Name = "copy_tool"
        Me.copy_tool.Size = New System.Drawing.Size(106, 22)
        Me.copy_tool.Text = "copy"
        '
        'del_tool
        '
        Me.del_tool.Name = "del_tool"
        Me.del_tool.Size = New System.Drawing.Size(106, 22)
        Me.del_tool.Text = "delete"
        '
        'TypeFilterComboBox
        '
        Me.TypeFilterComboBox.FormattingEnabled = True
        Me.TypeFilterComboBox.Location = New System.Drawing.Point(495, 23)
        Me.TypeFilterComboBox.Name = "TypeFilterComboBox"
        Me.TypeFilterComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TypeFilterComboBox.TabIndex = 52
        Me.TypeFilterComboBox.Text = "FOCA"
        '
        'NewBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 489)
        Me.Controls.Add(Me.TypeFilterComboBox)
        Me.Controls.Add(Me.path_TextBox)
        Me.Controls.Add(Me.Row_NumericUpDown)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.open_file_bt)
        Me.Controls.Add(Me.cancel_bt)
        Me.Controls.Add(Me.ref_int_cb)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.code_barre_cb)
        Me.Controls.Add(Me.comm_cb)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.pas_tar_cb)
        Me.Controls.Add(Me.ref_cb)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ref_comp_cb)
        Me.Controls.Add(Me.manuf__cb)
        Me.Controls.Add(Me.arrosage_int_cb)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.type_tar_cb)
        Me.Controls.Add(Me.coupe_centre_cb)
        Me.Controls.Add(Me.r_bout_cb)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.chf__cb)
        Me.Controls.Add(Me.NoTT_cb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.L_deta_cb)
        Me.Controls.Add(Me.L_total_cb)
        Me.Controls.Add(Me.L_coupe_cb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.d2Cb)
        Me.Controls.Add(Me.d3Cb)
        Me.Controls.Add(Me.d1Cb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ManufRef)
        Me.Controls.Add(Me.MatCb)
        Me.Controls.Add(Me.ToolNameCb)
        Me.Controls.Add(Me.valider_bt)
        Me.Name = "NewBD"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Row_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RC_Menu_NewDB.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents valider_bt As Button
    Friend WithEvents ToolNameCb As ComboBox
    Friend WithEvents MatCb As ComboBox
    Friend WithEvents ManufRef As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents d2Cb As ComboBox
    Friend WithEvents d3Cb As ComboBox
    Friend WithEvents d1Cb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents L_deta_cb As ComboBox
    Friend WithEvents L_total_cb As ComboBox
    Friend WithEvents L_coupe_cb As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents chf__cb As ComboBox
    Friend WithEvents NoTT_cb As ComboBox
    Friend WithEvents r_bout_cb As ComboBox
    Friend WithEvents arrosage_int_cb As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents type_tar_cb As ComboBox
    Friend WithEvents coupe_centre_cb As ComboBox
    Friend WithEvents ref_cb As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ref_comp_cb As ComboBox
    Friend WithEvents manuf__cb As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents pas_tar_cb As ComboBox
    Friend WithEvents ref_int_cb As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents code_barre_cb As ComboBox
    Friend WithEvents comm_cb As ComboBox
    Friend WithEvents cancel_bt As Button
    Friend WithEvents open_file_bt As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Row_NumericUpDown As NumericUpDown
    Friend WithEvents path_TextBox As TextBox
    Friend WithEvents RC_Menu_NewDB As ContextMenuStrip
    Friend WithEvents new_tool As ToolStripMenuItem
    Friend WithEvents copy_tool As ToolStripMenuItem
    Friend WithEvents del_tool As ToolStripMenuItem
    Friend WithEvents TypeFilterComboBox As ComboBox
End Class
