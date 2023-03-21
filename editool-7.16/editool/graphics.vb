Option Explicit On
Module graphics


    Public Sub Refresh_outil(newTool As NewTool)

        If Main.started Then

            Try

                Dim w As Integer = Main.PictureBox1.Width
                Dim StartY As Integer = Main.PictureBox1.Height
                Dim myPen = New Pen(Brushes.Black, 1)
                Dim myPenRED = New Pen(Brushes.Red, 1)
                Dim myOutil As Drawing.Graphics = Main.PictureBox1.CreateGraphics
                Dim BG_color As Drawing.Color = Drawing.Color.Gainsboro

                Dim CUT_color As New SolidBrush(Drawing.Color.Orange)
                Dim CUT_EXT_color As New SolidBrush(Drawing.Color.Gray)
                Dim NOCUT_color As New SolidBrush(Drawing.Color.DarkGray)

                'S = System.Drawing.Color.Silver
                myOutil.Clear(BG_color)

                Dim half_h As Integer = StartY / 2

                Dim D As Decimal = newTool.D1 'Replace(Main.D_textbox.Text, ".", ",")
                Dim CTS_AD As Double = newTool.D2 'Replace(Main.CTS_AD_textbox.Text, ".", ",")
                Dim SD As Double = newTool.D3 'Replace(Main.SD_textbox.Text, ".", ",")
                Dim L As Double = newTool.L1 'Replace(Main.L_textbox.Text, ".", ",")
                Dim CTS_AL As Double = newTool.L2 'Replace(Main.CTS_AL_textbox.Text, ".", ",")
                Dim OL As Double = newTool.L3 'Replace(Main.OL_textbox.Text, ".", ",")
                Dim Alpha As Double = newTool.AngleDeg 'Replace(Main.alpha.Text, ".", ",")
                Dim r As Double = newTool.RayonBout 'Replace(Main.Chf_textbox.Text, ".", ",")
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
                'Dim x As Decimal = i * scale
                'myOutil.DrawLine(myPenRED, 0, h - x, w, h - x)
                'Next
                'For i = 1 To OL Step 1
                'Dim x As Decimal = i * scale
                'myOutil.DrawString(i, drawFont, drawBrush, x + dif_w, 10)
                'myOutil.DrawLine(myPenRED, dif_w + x, 0, dif_w + x, h)
                'Next


                Dim D_tmp As Decimal = StartY - ((D / 2) * scale)
                Dim SD_tmp As Decimal = StartY - ((SD / 2) * scale)
                Dim CTS_AD_tmp As Decimal = StartY - ((CTS_AD / 2) * scale)
                Dim OL_tmp As Decimal = OL * scale
                Dim L_tmp As Decimal = L * scale
                Dim CTS_AL_tmp As Decimal = CTS_AL * scale

                Dim R_tmp As Decimal = StartY - (r * scale)


                Dim A_tmp As Decimal = ((D / 2) / (Math.Tan((A_point * Math.PI) / 180)) * scale)

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
                If My.Settings.ToolType = "FR2T" Or My.Settings.ToolType = "ALFI" Then
                    myOutil.FillRectangle(Brushes.Orange, 0, D_tmp, L_tmp, StartY - D_tmp)
                    'contour
                    myOutil.DrawLine(myPen, 0, StartY, 0, D_tmp)
                    myOutil.DrawLine(myPen, 0, D_tmp, L_tmp, D_tmp)
                ElseIf My.Settings.ToolType = "FRHE" Then
                    'FR Spherique ***********************
                    myOutil.FillEllipse(Brushes.Black, 0, D_tmp, (StartY - D_tmp) * 2, (StartY - D_tmp) * 2)
                    myOutil.FillEllipse(Brushes.Orange, 1, D_tmp + 1, ((StartY - D_tmp) * 2), (StartY - D_tmp) * 2)
                    myOutil.FillRectangle(Brushes.Orange, (StartY - D_tmp), D_tmp, L_tmp - (StartY - D_tmp), StartY - D_tmp)
                    myOutil.DrawLine(myPen, (StartY - D_tmp), D_tmp, L_tmp, D_tmp)
                ElseIf My.Settings.ToolType = "FRTO" Then
                    'FR Torique ***********************
                    myOutil.FillEllipse(Brushes.Black, 0, D_tmp, (StartY - R_tmp) * 2, (StartY - R_tmp) * 2)
                    myOutil.FillEllipse(Brushes.Orange, 1, D_tmp + 1, ((StartY - R_tmp) * 2), (StartY - R_tmp) * 2)
                    myOutil.FillRectangle(Brushes.Orange, 0, D_tmp + ((StartY - R_tmp)), L_tmp, StartY - D_tmp)
                    myOutil.FillRectangle(Brushes.Orange, StartY - R_tmp, D_tmp, L_tmp - (StartY - R_tmp), StartY - D_tmp)
                    myOutil.DrawLine(myPen, 0, StartY, 0, D_tmp + ((StartY - R_tmp)))
                    myOutil.DrawLine(myPen, (StartY - R_tmp), D_tmp, L_tmp, D_tmp)
                End If



                If My.Settings.ToolType = "FOCA" Or My.Settings.ToolType = "FOP9" Then
                    'Forets et Forets a pointer ***********************
                    'CUT
                    Dim pnts() As Point = {
                        New Point(0, StartY),
                        New Point(A_tmp, D_tmp),
                        New Point(L_tmp, D_tmp),
                        New Point(L_tmp, StartY),
                        New Point(0, StartY)
                        }
                    myOutil.FillPolygon(Brushes.Orange, pnts)
                    'CUT outline
                    myOutil.DrawLine(myPen, 0, StartY, A_tmp, D_tmp)
                    myOutil.DrawLine(myPen, A_tmp, D_tmp, L_tmp, D_tmp)
                    myOutil.DrawLine(myPen, L_tmp, D_tmp, L_tmp, StartY)

                    'NOCUT 
                    myOutil.FillRectangle(Brushes.DarkGray, L_tmp, SD_tmp, OL_tmp - L_tmp, StartY - SD_tmp)
                    'NOCUT outline 
                    myOutil.DrawLine(myPen, L_tmp, StartY, L_tmp, SD_tmp)
                    myOutil.DrawLine(myPen, L_tmp, SD_tmp, OL_tmp, SD_tmp)
                    myOutil.DrawLine(myPen, OL_tmp, SD_tmp, OL_tmp, StartY)
                Else
                    'NOCUT
                    'partie util ( degage ) outil
                    If CTS_AD_tmp <> 0 And CTS_AL_tmp <> 0 Then
                        myOutil.FillRectangle(Brushes.LightGray, L_tmp, CTS_AD_tmp, (CTS_AL_tmp - L_tmp), StartY - CTS_AD_tmp)
                        myOutil.DrawLine(myPen, L_tmp, D_tmp, L_tmp, CTS_AD_tmp)
                        myOutil.DrawLine(myPen, L_tmp, CTS_AD_tmp, CTS_AL_tmp, CTS_AD_tmp)
                        If CTS_EL_tmp > CTS_AL_tmp Then
                            myOutil.DrawLine(myPen, CTS_AL_tmp, CTS_AD_tmp, CTS_EL_tmp, SD_tmp)
                            myOutil.FillRectangle(Brushes.DarkGray, CTS_EL_tmp, SD_tmp, OL_tmp - CTS_EL_tmp, StartY - SD_tmp)
                        Else
                            myOutil.DrawLine(myPen, CTS_AL_tmp, CTS_AD_tmp, CTS_AL_tmp, SD_tmp)
                            myOutil.FillRectangle(Brushes.DarkGray, CTS_AL_tmp, SD_tmp, OL_tmp - CTS_AL_tmp, StartY - SD_tmp)
                        End If
                    Else

                        If CTS_EL_tmp = 0 Then
                            CTS_EL_tmp = OL_tmp
                        End If
                        myOutil.DrawLine(myPen, L_tmp, D_tmp, CTS_EL_tmp, CTS_ED_tmp) ''TODO 

                    End If

                    'contour corps outil
                    myOutil.DrawLine(myPen, CTS_EL_tmp, SD_tmp, OL_tmp, SD_tmp)
                    myOutil.DrawLine(myPen, OL_tmp, SD_tmp, OL_tmp, StartY)
                End If
                Dim axe_big As Integer = w / 20
                Dim axe_petite As Integer = axe_big / 8
                Dim space As Integer = 0

                Dim x As Short

                For x = 1 To 10
                    myOutil.DrawLine(myPenRED, space, StartY - 1, axe_petite + space, StartY - 1)
                    space = space + axe_petite + 10
                    myOutil.DrawLine(myPenRED, space, StartY - 1, axe_big + space, StartY - 1)
                    space = space + axe_big + 10
                Next

                Set_Name_auto()


            Catch ex As Exception
                '      MsgBox("GRAPHICS - design - " + ex.ToString)
            End Try

        End If

    End Sub

End Module
