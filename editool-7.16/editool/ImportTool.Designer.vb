﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImportTool
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
        Me.RefTextBox = New System.Windows.Forms.TextBox()
        Me.ToolPreview_PictureBox = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.find_Bt = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.ToolPreview_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RefTextBox
        '
        Me.RefTextBox.Location = New System.Drawing.Point(12, 24)
        Me.RefTextBox.Name = "RefTextBox"
        Me.RefTextBox.Size = New System.Drawing.Size(199, 20)
        Me.RefTextBox.TabIndex = 0
        Me.RefTextBox.Text = "15520260"
        '
        'ToolPreview_PictureBox
        '
        Me.ToolPreview_PictureBox.Location = New System.Drawing.Point(12, 251)
        Me.ToolPreview_PictureBox.Name = "ToolPreview_PictureBox"
        Me.ToolPreview_PictureBox.Size = New System.Drawing.Size(682, 132)
        Me.ToolPreview_PictureBox.TabIndex = 1
        Me.ToolPreview_PictureBox.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(682, 138)
        Me.DataGridView1.TabIndex = 2
        '
        'outputLabel
        '
        Me.outputLabel.AutoSize = True
        Me.outputLabel.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputLabel.Location = New System.Drawing.Point(12, 58)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(56, 18)
        Me.outputLabel.TabIndex = 3
        Me.outputLabel.Text = "Label1"
        Me.outputLabel.Visible = False
        '
        'find_Bt
        '
        Me.find_Bt.Location = New System.Drawing.Point(225, 24)
        Me.find_Bt.Name = "find_Bt"
        Me.find_Bt.Size = New System.Drawing.Size(75, 23)
        Me.find_Bt.TabIndex = 4
        Me.find_Bt.Text = "Find"
        Me.find_Bt.UseVisualStyleBackColor = True
        '
        'ImportTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 395)
        Me.Controls.Add(Me.find_Bt)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolPreview_PictureBox)
        Me.Controls.Add(Me.RefTextBox)
        Me.Name = "ImportTool"
        Me.Text = "Import tool from..."
        CType(Me.ToolPreview_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RefTextBox As TextBox
    Friend WithEvents ToolPreview_PictureBox As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents outputLabel As Label
    Friend WithEvents find_Bt As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
