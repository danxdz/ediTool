<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preload
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
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Version = New System.Windows.Forms.Label()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.version_label = New System.Windows.Forms.Label()
        Me.path_label = New System.Windows.Forms.Label()
        Me.output = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.toolCountLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MainLayoutPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.AutoSize = True
        Me.MainLayoutPanel.BackColor = System.Drawing.SystemColors.Control
        Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainLayoutPanel.ColumnCount = 3
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 635.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.MainLayoutPanel.Controls.Add(Me.Version, 2, 0)
        Me.MainLayoutPanel.Controls.Add(Me.ApplicationTitle, 1, 0)
        Me.MainLayoutPanel.Controls.Add(Me.Panel1, 0, 0)
        Me.MainLayoutPanel.Controls.Add(Me.Panel2, 0, 1)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowCount = 2
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 334.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(970, 386)
        Me.MainLayoutPanel.TabIndex = 0
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(888, 0)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(79, 334)
        Me.Version.TabIndex = 1
        Me.Version.Text = "v. {0}.{1:00}"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(638, 0)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(244, 334)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "EdiTool"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.version_label)
        Me.Panel1.Controls.Add(Me.path_label)
        Me.Panel1.Controls.Add(Me.output)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 328)
        Me.Panel1.TabIndex = 3
        '
        'version_label
        '
        Me.version_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.version_label.BackColor = System.Drawing.Color.Transparent
        Me.version_label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_label.Location = New System.Drawing.Point(9, 256)
        Me.version_label.Name = "version_label"
        Me.version_label.Size = New System.Drawing.Size(623, 41)
        Me.version_label.TabIndex = 4
        Me.version_label.Text = "version"
        Me.version_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'path_label
        '
        Me.path_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.path_label.BackColor = System.Drawing.Color.Transparent
        Me.path_label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path_label.Location = New System.Drawing.Point(9, 219)
        Me.path_label.Name = "path_label"
        Me.path_label.Size = New System.Drawing.Size(620, 37)
        Me.path_label.TabIndex = 3
        Me.path_label.Text = "path"
        Me.path_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'output
        '
        Me.output.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.output.BackColor = System.Drawing.Color.Transparent
        Me.output.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output.Location = New System.Drawing.Point(208, 130)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(163, 40)
        Me.output.TabIndex = 2
        Me.output.Text = "searching"
        Me.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.toolCountLabel)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(3, 337)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 46)
        Me.Panel2.TabIndex = 60
        '
        'toolCountLabel
        '
        Me.toolCountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toolCountLabel.AutoSize = True
        Me.toolCountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolCountLabel.Location = New System.Drawing.Point(80, 11)
        Me.toolCountLabel.Name = "toolCountLabel"
        Me.toolCountLabel.Size = New System.Drawing.Size(24, 25)
        Me.toolCountLabel.TabIndex = 60
        Me.toolCountLabel.Text = "0"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(623, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "version"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(620, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "path"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "tools"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Preload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preload"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Version As Label
    Friend WithEvents output As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents path_label As Label
    Friend WithEvents version_label As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents toolCountLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
