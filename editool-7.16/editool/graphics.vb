Module graphics

    Public Sub design()
        Try
            Dim w As Integer = Main.PictureBox1.Width
            Dim h As Integer = Main.PictureBox1.Height
            Dim myPen = New Pen(Brushes.Black, 1)
            Dim myPenRED = New Pen(Brushes.Red, 1)
            Dim myOutil As Drawing.Graphics = Main.PictureBox1.CreateGraphics
            Dim s As New System.Drawing.Color

            s = System.Drawing.Color.Gainsboro

            'S = System.Drawing.Color.Silver
            myOutil.Clear(s)

            Dim half_h As Integer = h / 2

            Dim D As Double = Replace(Main.D_textbox.Text, ".", ",")
            Dim SD As Double = Replace(Main.SD_textbox.Text, ".", ",")
            Dim CTS_AD As Double = Replace(Main.CTS_AD_textbox.Text, ".", ",")
            Dim OL As Double = Replace(Main.OL_textbox.Text, ".", ",")
            Dim L As Double = Replace(Main.L_textbox.Text, ".", ",")
            Dim CTS_AL As Double = Replace(Main.CTS_AL_textbox.Text, ".", ",")
            Dim Alpha As Double = Replace(Main.alpha.Text, ".", ",")
            Dim r As Double = Replace(Main.chf.Text, ".", ",")
            Dim A_point = Replace(Main.A_TextBox.Text, ".", ",")
            A_point /= 2

            Dim scale As Double = (w - 1) / OL
            Dim drawFont As New Font("Arial", 8)
            Dim drawBrush As New SolidBrush(Drawing.Color.Black)
            Dim drawFormat As New StringFormat With {
                .Alignment = StringAlignment.Center
            }

            '-------   grid

            'For i = 1 To SD / 2 Step 1
            'Dim x As Single = i * scale
            'myOutil.DrawLine(myPenRED, 0, h - x, w, h - x)
            'Next
            'For i = 1 To OL Step 1
            'Dim x As Single = i * scale
            'myOutil.DrawString(i, drawFont, drawBrush, x + dif_w, 10)
            'myOutil.DrawLine(myPenRED, dif_w + x, 0, dif_w + x, h)
            'Next


            Dim D_tmp As Single = h - ((D / 2) * scale)
            Dim SD_tmp As Single = h - ((SD / 2) * scale)
            Dim CTS_AD_tmp As Single = h - ((CTS_AD / 2) * scale)
            Dim OL_tmp As Single = OL * scale
            Dim L_tmp As Single = L * scale
            Dim CTS_AL_tmp As Single = CTS_AL * scale

            Dim R_tmp As Single = h - (r * scale)


            Dim A_tmp As Single = ((D / 2) / (Math.Tan((A_point * Math.PI) / 180)) * scale)

            Dim CTS_ED_tmp As Single
            If CTS_AD > 0 Then
                CTS_ED_tmp = CTS_AD_tmp
            Else
                CTS_ED_tmp = SD_tmp
            End If

            Dim CTS_EL_tmp As Single
            If (Alpha = 0) Then
                CTS_EL_tmp = CTS_AL_tmp
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
            If My.Settings.ToolType = "FR" Or My.Settings.ToolType = "AL" Then
                myOutil.FillRectangle(Brushes.Orange, 0, D_tmp, L_tmp, h - D_tmp)
                'contour
                myOutil.DrawLine(myPen, 0, h, 0, D_tmp)
                myOutil.DrawLine(myPen, 0, D_tmp, L_tmp, D_tmp)
            ElseIf My.Settings.ToolType = "FB" Then
                'FR Spherique ***********************
                myOutil.FillEllipse(Brushes.Black, 0, D_tmp, (h - D_tmp) * 2, (h - D_tmp) * 2)
                myOutil.FillEllipse(Brushes.Orange, 1, D_tmp + 1, ((h - D_tmp) * 2), (h - D_tmp) * 2)
                myOutil.FillRectangle(Brushes.Orange, (h - D_tmp), D_tmp, L_tmp - (h - D_tmp), h - D_tmp)
                myOutil.DrawLine(myPen, (h - D_tmp), D_tmp, L_tmp, D_tmp)
            ElseIf My.Settings.ToolType = "FT" Then
                'FR Torique ***********************
                myOutil.FillEllipse(Brushes.Black, 0, D_tmp, (h - R_tmp) * 2, (h - R_tmp) * 2)
                myOutil.FillEllipse(Brushes.Orange, 1, D_tmp + 1, ((h - R_tmp) * 2), (h - R_tmp) * 2)
                myOutil.FillRectangle(Brushes.Orange, 0, D_tmp + ((h - R_tmp)), L_tmp, h - D_tmp)
                myOutil.FillRectangle(Brushes.Orange, h - R_tmp, D_tmp, L_tmp - (h - R_tmp), h - D_tmp)
                myOutil.DrawLine(myPen, 0, h, 0, D_tmp + ((h - R_tmp)))
                myOutil.DrawLine(myPen, (h - R_tmp), D_tmp, L_tmp, D_tmp)
            ElseIf My.Settings.ToolType = "FO" Or My.Settings.ToolType = "FP" Then
                'Forets et Forets a pointer ***********************


                Dim pnts() As Point = {
                    New Point(0, h),
                    New Point(A_tmp, D_tmp),
                    New Point(L_tmp, D_tmp),
                    New Point(L_tmp, h),
                    New Point(0, h)
                    }
                myOutil.FillPolygon(Brushes.Orange, pnts)

                myOutil.DrawLine(myPen, 0, h, A_tmp, D_tmp)
                myOutil.DrawLine(myPen, A_tmp, D_tmp, L_tmp, D_tmp)

                ' myOutil.FillRectangle(Brushes.Orange, A_tmp, D_tmp + 1, L_tmp - A_tmp, h - D_tmp + 1)


            End If
            'NOCUT
            'partie util ( degage ) outil
            If CTS_AD_tmp <> 0 And CTS_AL_tmp <> 0 Then
                myOutil.FillRectangle(Brushes.LightGray, L_tmp, CTS_AD_tmp, (CTS_AL_tmp - L_tmp), h - CTS_AD_tmp)
                myOutil.DrawLine(myPen, L_tmp, D_tmp, L_tmp, CTS_AD_tmp)
                myOutil.DrawLine(myPen, L_tmp, CTS_AD_tmp, CTS_AL_tmp, CTS_AD_tmp)
                If CTS_EL_tmp > CTS_AL_tmp Then
                    myOutil.DrawLine(myPen, CTS_AL_tmp, CTS_AD_tmp, CTS_EL_tmp, SD_tmp)
                    myOutil.FillRectangle(Brushes.DarkGray, CTS_EL_tmp, SD_tmp, OL_tmp - CTS_EL_tmp, h - SD_tmp)
                Else
                    myOutil.DrawLine(myPen, CTS_AL_tmp, CTS_AD_tmp, CTS_AL_tmp, SD_tmp)
                    myOutil.FillRectangle(Brushes.DarkGray, CTS_AL_tmp, SD_tmp, OL_tmp - CTS_AL_tmp, h - SD_tmp)
                End If
            Else
                If My.Settings.ToolType = "FR" Then
                    myOutil.DrawLine(myPen, L_tmp, D_tmp, CTS_EL_tmp, CTS_ED_tmp) ''TODO 
                End If
            End If

            'contour corps outil
            myOutil.DrawLine(myPen, CTS_EL_tmp, SD_tmp, OL_tmp, SD_tmp)
            myOutil.DrawLine(myPen, OL_tmp, SD_tmp, OL_tmp, h)


            Dim axe_big As Integer = w / 20
            Dim axe_petite As Integer = axe_big / 8
            Dim space As Integer = 0

            Dim x As Short


            For x = 1 To 10
                myOutil.DrawLine(myPenRED, space, h - 1, axe_petite + space, h - 1)
                space = space + axe_petite + 10
                myOutil.DrawLine(myPenRED, space, h - 1, axe_big + space, h - 1)
                space = space + axe_big + 10
            Next
        Catch ex As Exception
            '      MsgBox("GRAPHICS - design - " + ex.ToString)
        End Try
    End Sub
End Module
