Option Explicit On
Module graphics
    Public Sub Refresh_outil(newTool As Tool, ToolPreview_PictureBox As PictureBox)

        'If Main.started Then

        Try
            Dim w As Integer = ToolPreview_PictureBox.Width
            Dim StartY As Integer = ToolPreview_PictureBox.Height
            Dim myPen = New Pen(Brushes.Black, 1)
            Dim myPenRED = New Pen(Brushes.Red, 1)
            Dim toolPic As Drawing.Graphics = ToolPreview_PictureBox.CreateGraphics
            Dim BG_color As Drawing.Color = Drawing.Color.Gainsboro

            Dim CUT_color As New SolidBrush(Drawing.Color.Orange)
            Dim CUT_EXT_color As New SolidBrush(Drawing.Color.Gray)
            Dim NOCUT_color As New SolidBrush(Drawing.Color.DarkGray)

            'S = System.Drawing.Color.Silver
            toolPic.Clear(BG_color)

            Dim half_h As Integer = StartY / 2

            Dim D As Double = newTool.D1
            Dim CTS_AD As Double = If(newTool.D2 = 0, newTool.D1 - 0.2, newTool.D2)
            Dim SD As Double = newTool.D3
            Dim L As Double = newTool.L1
            Dim CTS_AL As Double = If(newTool.L2 = 0, newTool.L1, newTool.L2)
            Dim OL As Double = newTool.L3
            Dim Alpha As Double = newTool.AnglePoint
            Dim r As Double = newTool.CorRadius
            Dim A_point As Double = newTool.CorChamfer
            If (A_point <> 0) Then A_point /= 2


            Dim scale As Double = (w - 1) / OL
            Dim drawFont As New Font("Arial", 8)
            Dim drawBrush As New SolidBrush(Drawing.Color.Black)
            Dim drawFormat As New StringFormat With {
                    .Alignment = StringAlignment.Center
                }

            Dim D_tmp As Decimal = StartY - ((D / 2) * scale)
            Dim SD_tmp As Decimal = StartY - ((SD / 2) * scale)
            Dim CTS_AD_tmp As Decimal = StartY - ((CTS_AD / 2) * scale)
            Dim OL_tmp As Decimal = OL * scale
            Dim L_tmp As Decimal = L * scale
            Dim CTS_AL_tmp As Decimal = CTS_AL * scale

            Dim R_tmp As Decimal = StartY - (r * scale)
            Dim A_tmp As Decimal
            Try
                A_tmp = ((D / 2) / (Math.Tan((A_point * Math.PI) / 180)) * scale)
            Catch ex As Exception
                A_tmp = 0
            End Try

            Dim CTS_ED_tmp As Decimal
            If CTS_AD > 0 Then
                CTS_ED_tmp = CTS_AD_tmp
            Else
                CTS_ED_tmp = SD_tmp
            End If

            Dim CTS_EL_tmp As Decimal
            If Alpha = 0 Then
                CTS_EL_tmp = CTS_AL_tmp
            ElseIf Alpha = 0 And CTS_AL_tmp = 0 Then
                CTS_EL_tmp = OL_tmp
            Else
                CTS_EL_tmp = (SD - D) / 2
                CTS_EL_tmp /= Math.Tan((Alpha * Math.PI) / 180)
                'Main.CTS_AL_textbox.Text = Math.Round(CTS_AL_tmp)
                CTS_EL_tmp *= scale
                CTS_ED_tmp = SD_tmp

            End If

            'half revolved preview tool 
            'CUT
            'FR 2T et Alesoir *************************
            '
            If newTool.Type = "FR2T" Or newTool.Type = "ALFI" Or newTool.Type = "endMill" Or newTool.Type = "" Or newTool.Type = "reamer" Then
                toolPic.FillRectangle(Brushes.Orange, 0, D_tmp, L_tmp, StartY - D_tmp)
                'contour
                toolPic.DrawLine(myPen, 0, StartY, 0, D_tmp)
                toolPic.DrawLine(myPen, 0, D_tmp, L_tmp, D_tmp)
            ElseIf newTool.Type = "FRHE" Then
                'FR Spherique ***********************
                toolPic.FillEllipse(Brushes.Black, 0, D_tmp, (StartY - D_tmp) * 2, (StartY - D_tmp) * 2)
                toolPic.FillEllipse(Brushes.Orange, 1, D_tmp + 1, ((StartY - D_tmp) * 2), (StartY - D_tmp) * 2)
                toolPic.FillRectangle(Brushes.Orange, (StartY - D_tmp), D_tmp, L_tmp - (StartY - D_tmp), StartY - D_tmp)
                toolPic.DrawLine(myPen, (StartY - D_tmp), D_tmp, L_tmp, D_tmp)
            ElseIf newTool.Type = "FRTO" Then
                'FR Torique ***********************
                toolPic.FillEllipse(Brushes.Black, 0, D_tmp, (StartY - R_tmp) * 2, (StartY - R_tmp) * 2)
                toolPic.FillEllipse(Brushes.Orange, 1, D_tmp + 1, ((StartY - R_tmp) * 2), (StartY - R_tmp) * 2)
                toolPic.FillRectangle(Brushes.Orange, 0, D_tmp + ((StartY - R_tmp)), L_tmp, StartY - D_tmp)
                toolPic.FillRectangle(Brushes.Orange, StartY - R_tmp, D_tmp, L_tmp - (StartY - R_tmp), StartY - D_tmp)
                toolPic.DrawLine(myPen, 0, StartY, 0, D_tmp + ((StartY - R_tmp)))
                toolPic.DrawLine(myPen, (StartY - R_tmp), D_tmp, L_tmp, D_tmp)
            End If



            If newTool.Type = "FOCA" Or newTool.Type = "FOP9" Or newTool.Type = "FOCE" Then
                'Forets et Forets a pointer ***********************
                'CUT
                Dim pnts() As Point = {
                        New Point(0, StartY),
                        New Point(A_tmp, D_tmp),
                        New Point(L_tmp, D_tmp),
                        New Point(L_tmp, StartY),
                        New Point(0, StartY)
                        }
                toolPic.FillPolygon(Brushes.Orange, pnts)
                'CUT outline
                toolPic.DrawLine(myPen, 0, StartY, A_tmp, D_tmp)
                toolPic.DrawLine(myPen, A_tmp, D_tmp, L_tmp, D_tmp)
                toolPic.DrawLine(myPen, L_tmp, D_tmp, L_tmp, StartY)

                'NOCUT 
                toolPic.FillRectangle(Brushes.DarkGray, L_tmp, SD_tmp, OL_tmp - L_tmp, StartY - SD_tmp)
                'NOCUT outline 
                toolPic.DrawLine(myPen, L_tmp, StartY, L_tmp, SD_tmp)
                toolPic.DrawLine(myPen, L_tmp, SD_tmp, OL_tmp, SD_tmp)
                toolPic.DrawLine(myPen, OL_tmp, SD_tmp, OL_tmp, StartY)
            Else
                'NOCUT
                'partie util ( degage ) outil
                If CTS_AD_tmp <> 0 And CTS_AL_tmp <> 0 Then
                    toolPic.FillRectangle(Brushes.LightGray, L_tmp, CTS_AD_tmp, (CTS_AL_tmp - L_tmp), StartY - CTS_AD_tmp)
                    toolPic.DrawLine(myPen, L_tmp, D_tmp, L_tmp, CTS_AD_tmp)
                    toolPic.DrawLine(myPen, L_tmp, CTS_AD_tmp, CTS_AL_tmp, CTS_AD_tmp)
                    If CTS_EL_tmp > CTS_AL_tmp Then
                        toolPic.DrawLine(myPen, CTS_AL_tmp, CTS_AD_tmp, CTS_EL_tmp, SD_tmp)
                        toolPic.FillRectangle(Brushes.DarkGray, CTS_EL_tmp, SD_tmp, OL_tmp - CTS_EL_tmp, StartY - SD_tmp)
                    Else
                        toolPic.DrawLine(myPen, CTS_AL_tmp, CTS_AD_tmp, CTS_AL_tmp, SD_tmp)
                        toolPic.FillRectangle(Brushes.DarkGray, CTS_AL_tmp, SD_tmp, OL_tmp - CTS_AL_tmp, StartY - SD_tmp)
                    End If
                Else

                    If CTS_EL_tmp = 0 Then
                        CTS_EL_tmp = OL_tmp
                    End If
                    toolPic.DrawLine(myPen, L_tmp, D_tmp, CTS_EL_tmp, CTS_ED_tmp) ''TODO 

                End If

                'contour corps outil
                toolPic.DrawLine(myPen, CTS_EL_tmp, SD_tmp, OL_tmp, SD_tmp)
                toolPic.DrawLine(myPen, OL_tmp, SD_tmp, OL_tmp, StartY)
            End If


            'Red axe at tool center
            Dim axe_big As Integer = w / 20
            Dim axe_petite As Integer = axe_big / 8
            Dim space As Integer = 0

            For x As Integer = 1 To 10
                toolPic.DrawLine(myPenRED, space, StartY - 1, axe_petite + space, StartY - 1)
                space = space + axe_petite + 10
                toolPic.DrawLine(myPenRED, space, StartY - 1, axe_big + space, StartY - 1)
                space = space + axe_big + 10
            Next

            'Set_Name_auto(newTool)


        Catch ex As Exception
            '      MsgBox("GRAPHICS - design - " + ex.ToString)
        End Try

        ' End If

    End Sub

End Module
