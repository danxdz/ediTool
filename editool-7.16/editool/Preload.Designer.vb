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
        Me.toolCountLabel = New System.Windows.Forms.Label()
        Me.output = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.version_label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.path_label = New System.Windows.Forms.Label()
        Me.MainLayoutPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainLayoutPanel.AutoSize = True
        Me.MainLayoutPanel.BackColor = System.Drawing.SystemColors.Control
        Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.MainLayoutPanel.ColumnCount = 1
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 635.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.MainLayoutPanel.Controls.Add(Me.Panel1, 0, 0)
        Me.MainLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.MainLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowCount = 1
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
        Me.Version.Location = New System.Drawing.Point(882, 357)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(75, 15)
        Me.Version.TabIndex = 1
        Me.Version.Text = "v. {0}.{1:00}"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(709, 248)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(244, 61)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "EdiTool"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.version_label)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Version)
        Me.Panel1.Controls.Add(Me.toolCountLabel)
        Me.Panel1.Controls.Add(Me.ApplicationTitle)
        Me.Panel1.Controls.Add(Me.output)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.path_label)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 376)
        Me.Panel1.TabIndex = 3
        '
        'toolCountLabel
        '
        Me.toolCountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toolCountLabel.AutoSize = True
        Me.toolCountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolCountLabel.Location = New System.Drawing.Point(178, 311)
        Me.toolCountLabel.Name = "toolCountLabel"
        Me.toolCountLabel.Size = New System.Drawing.Size(24, 25)
        Me.toolCountLabel.TabIndex = 60
        Me.toolCountLabel.Text = "0"
        '
        'output
        '
        Me.output.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.output.BackColor = System.Drawing.Color.Transparent
        Me.output.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output.Location = New System.Drawing.Point(7, 318)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(94, 16)
        Me.output.TabIndex = 2
        Me.output.Text = "searching"
        Me.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "tools"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(124, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(313, 21)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "@ path :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'version_label
        '
        Me.version_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.version_label.BackColor = System.Drawing.Color.Transparent
        Me.version_label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_label.Location = New System.Drawing.Point(32, 351)
        Me.version_label.Name = "version_label"
        Me.version_label.Size = New System.Drawing.Size(323, 21)
        Me.version_label.TabIndex = 4
        Me.version_label.Text = "not found"
        Me.version_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 21)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "v. "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'path_label
        '
        Me.path_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.path_label.BackColor = System.Drawing.Color.Transparent
        Me.path_label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path_label.Location = New System.Drawing.Point(206, 351)
        Me.path_label.Name = "path_label"
        Me.path_label.Size = New System.Drawing.Size(647, 21)
        Me.path_label.TabIndex = 3
        Me.path_label.Text = "not found"
        Me.path_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Version As Label
    Friend WithEvents output As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents path_label As Label
    Friend WithEvents version_label As Label
    Friend WithEvents toolCountLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
