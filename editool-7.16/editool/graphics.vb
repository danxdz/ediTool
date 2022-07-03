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

            Dim d1 As Double = Replace(Main.d1.Text, ".", ",")
            Dim d2 As Double = Replace(Main.d2.Text, ".", ",")
            Dim d3 As Double = Replace(Main.d3.Text, ".", ",")
            Dim l1 As Double = Replace(Main.L1.Text, ".", ",")
            Dim l2 As Double = Replace(Main.L2.Text, ".", ",")
            Dim l3 As Double = Replace(Main.L3.Text, ".", ",")

            Dim scale As Double = (w - 1) / l1
            Dim drawFont As New Font("Arial", 8)
            Dim drawBrush As New SolidBrush(Drawing.Color.Black)
            Dim drawFormat As New StringFormat With {
                .Alignment = StringAlignment.Center
            }

            '-------   grid

            'For i = 1 To d2 / 2 Step 1
            'Dim x As Single = i * scale
            'myOutil.DrawLine(myPenRED, 0, h - x, w, h - x)
            'Next
            'For i = 1 To l1 Step 1
            'Dim x As Single = i * scale
            'myOutil.DrawString(i, drawFont, drawBrush, x + dif_w, 10)
            'myOutil.DrawLine(myPenRED, dif_w + x, 0, dif_w + x, h)
            'Next

            Dim d1_tmp As Single = h - ((d1 / 2) * scale)
            Dim d2_tmp As Single = h - ((d2 / 2) * scale)
            Dim d3_tmp As Single
            If d3 <> 0 Then
                d3_tmp = h - ((d3 / 2) * scale)
            Else
                d3_tmp = 0
            End If

            Dim l1_tmp As Single = l1 * scale
            Dim l2_tmp As Single = l2 * scale

            Dim l3_tmp As Single = l3 * scale


            myOutil.FillRectangle(Brushes.Orange, 0, d1_tmp, l2_tmp, h - d1_tmp)

            myOutil.DrawLine(myPen, 0, h, 0, d1_tmp)
            myOutil.DrawLine(myPen, 0, d1_tmp, l2_tmp, d1_tmp)

            If d3_tmp <> 0 And l3_tmp <> 0 Then
                myOutil.FillRectangle(Brushes.LightGray, l2_tmp, d3_tmp, (l3_tmp - l2_tmp), h - d3_tmp)
            End If

            If d3_tmp = 0 Then
                d3_tmp = d1_tmp
            End If
            If l3_tmp = 0 Then
                l3_tmp = l2_tmp
            End If

            myOutil.FillRectangle(Brushes.DarkGray, l3_tmp, d2_tmp, (l1_tmp - l3_tmp), h - d2_tmp)

            myOutil.DrawLine(myPen, l2_tmp, d1_tmp, l2_tmp, d3_tmp)
            myOutil.DrawLine(myPen, l2_tmp, d3_tmp, l3_tmp, d3_tmp)
            myOutil.DrawLine(myPen, l3_tmp, d3_tmp, l3_tmp, d2_tmp)
            myOutil.DrawLine(myPen, l3_tmp, d2_tmp, l1_tmp, d2_tmp)
            myOutil.DrawLine(myPen, l1_tmp, d2_tmp, l1_tmp, h)


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
