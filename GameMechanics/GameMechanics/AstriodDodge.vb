Public Class scorelbl


    Public Sub New()



        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Move(ast1wall, 1, 16)
        Move(expl1, 1, 16)
        Move(ast2wall, 1, 16)
        Move(expl2, 1, 16)
        Move(ast3wall, 1, 17)
        Move(expl3, 1, 17)
        Move(ast4wall, 1, 18)
        Move(expl4, 1, 18)
        Move(WIN, 0, 11)
        Move(blaze1, 1, 16)
        Move(blaze2, 1, 16)
        Move(blaze3, 1, 17)
        Move(blaze4, 1, 18)
        Move(blaze5, 1, 13)
        Move(ast5wall, 1, 13)
        Move(expl5, 1, 13)
        Move(expl6, 1, 10)
        Move(ast6wall, 1, 10)
        Move(blaze6, 1, 10)



    End Sub

    Sub Move(P As PictureBox, X As Integer, Y As Integer)
        P.Location = New Point(P.Location.X + X, P.Location.Y + Y)
    End Sub

    'Keyboard Area 
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.R
                rocketship.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                Me.Refresh()
            Case Keys.Right, Keys.D
                MoveTo(rocketship, 15, 0)
                MoveTo(expl, 15, 0)
                MoveTo(bullet, 15, 0)

            Case Keys.Left, Keys.A
                MoveTo(rocketship, -15, 0)
                MoveTo(expl, -15, 0)
                MoveTo(bullet, -15, 0)
            Case Keys.Space

                bullet.Visible = True
                Timer3.Enabled = True
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub


    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If
        Dim other As Object = Nothing

        If p.Name = "rocketship" And Collision(p, "WIN") Then
            Label2.Text = "1"
            rocketship.Visible = False
            gfreeze()
            winbox.Visible = True
            Timer6.Enabled = True

            Return
        ElseIf p.Name = "rocketship" And Collision(p, "ast4WALL") Then
            ast4wall.Visible = False
            blaze1.Visible = False
            blaze2.Visible = False
            blaze3.Visible = False
            blaze4.Visible = False
            blaze5.Visible = False
            blaze6.Visible = False
            rocketship.Visible = False
            expl.Visible = True
            gfreeze()
            loosebox.Visible = True
        ElseIf p.Name = "rocketship" And Collision(p, "ast1WALL") Then
            ast1wall.Visible = False
            blaze1.Visible = False
            blaze2.Visible = False
            blaze3.Visible = False
            blaze4.Visible = False
            blaze5.Visible = False
            blaze6.Visible = False
            rocketship.Visible = False
            expl.Visible = True
            gfreeze()
            loosebox.Visible = True
        ElseIf p.Name = "rocketship" And Collision(p, "ast2WALL") Then
            ast2wall.Visible = False
            blaze1.Visible = False
            blaze2.Visible = False
            blaze3.Visible = False
            blaze4.Visible = False
            blaze5.Visible = False
            blaze6.Visible = False
            rocketship.Visible = False
            expl.Visible = True
            gfreeze()
            loosebox.Visible = True
        ElseIf p.Name = "rocketship" And Collision(p, "ast3WALL") Then
            ast3wall.Visible = False
            blaze1.Visible = False
            blaze2.Visible = False
            blaze3.Visible = False
            blaze4.Visible = False
            blaze5.Visible = False
            blaze6.Visible = False
            rocketship.Visible = False
            expl.Visible = True
            gfreeze()
            loosebox.Visible = True
        ElseIf p.Name = "rocketship" And Collision(p, "ast5WALL") Then
            ast5wall.Visible = False
            blaze1.Visible = False
            blaze2.Visible = False
            blaze3.Visible = False
            blaze4.Visible = False
            blaze5.Visible = False
            blaze6.Visible = False
            rocketship.Visible = False
            expl.Visible = True
            gfreeze()
            loosebox.Visible = True
        ElseIf p.Name = "rocketship" And Collision(p, "ast6WALL") Then
            ast6wall.Visible = False
            blaze1.Visible = False
            blaze2.Visible = False
            blaze3.Visible = False
            blaze4.Visible = False
            blaze5.Visible = False
            blaze6.Visible = False
            rocketship.Visible = False
            expl.Visible = True
            gfreeze()
            loosebox.Visible = True
        ElseIf p.Name = "bullet" And Collision(p, "ast1WALL", other) Then
            other.Visible = False
            blaze2.Visible = False
            expl1.Visible = True
            Timer4.Enabled = True
            bullet.Visible = False
            p.Visible = False

        ElseIf p.Name = "bullet" And Collision(p, "ast2WALL") Then
            ast2wall.Visible = False
            blaze1.Visible = False
            expl2.Visible = True
            Timer4.Enabled = True
            bullet.Visible = False


        ElseIf p.Name = "bullet" And Collision(p, "ast3WALL") Then
            ast3wall.Visible = False
            blaze3.Visible = False
            expl3.Visible = True
            Timer4.Enabled = True
            bullet.Visible = False


        ElseIf p.Name = "bullet" And Collision(p, "ast4WALL") Then
            ast4wall.Visible = False
            blaze4.Visible = False
            expl4.Visible = True
            Timer4.Enabled = True
            bullet.Visible = False

        ElseIf p.Name = "bullet" And Collision(p, "ast5WALL") Then
            ast5wall.Visible = False
            blaze5.Visible = False
            expl5.Visible = True
            Timer4.Enabled = True
            bullet.Visible = False

        ElseIf p.Name = "bullet" And Collision(p, "ast6WALL") Then
            ast6wall.Visible = False
            blaze6.Visible = False
            expl6.Visible = True
            Timer4.Enabled = True
            bullet.Visible = False


        End If
    End Sub

    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function

    Sub MoveTo(p As String, distx As Integer, disty As Integer)
        For Each c In Controls
            If c.name.toupper.ToString.Contains(p.ToUpper) Then
                MoveTo(c, distx, disty)
            End If
        Next
    End Sub

    Sub CreateNew(name As String, pic As PictureBox, location As Point)
        Dim p As New PictureBox
        p.Location = location
        p.Image = pic.Image
        p.BackColor = pic.BackColor
        p.Name = name
        p.Width = pic.Width
        p.Height = pic.Height
        p.SizeMode = PictureBoxSizeMode.StretchImage
        Controls.Add(p)

    End Sub



    Private Sub gfreeze()
        Me.Timer1.Stop()
    End Sub

    Private Sub gstart()
        Me.Timer1.Start()

    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        MoveTo(bullet, 0, -50)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        expl3.Visible = False
        expl1.Visible = False
        expl4.Visible = False
        expl2.Visible = False
        expl5.Visible = False
        expl6.Visible = False

    End Sub

    Private Sub _Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        Label3.Visible = False

    End Sub

End Class
