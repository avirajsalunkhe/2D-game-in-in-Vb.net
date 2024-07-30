Public Class Car_game
    Dim speed As Integer
    Dim road(5) As PictureBox
    Dim score As Integer = 0


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles roadmover.Tick
        For x As Integer = 0 To 5
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height


            End If
        Next
        If score > 10 And score < 20 Then
            speed = 4
        End If
        If score > 20 And score < 30 Then
            speed = 5
        End If
        If score > 30 And score < 40 Then
            speed = 6
        End If
        If score > 40 And score < 50 Then
            speed = 7
        End If
        If score > 50 And score < 60 Then
            speed = 8
        End If
        If score > 60 And score < 70 Then
            speed = 9
        End If
        If score > 70 And score < 80 Then
            speed = 10
        End If
        If score > 80 And score < 90 Then
            speed = 11
        End If
        If score > 90 And score < 100 Then
            speed = 12
        End If
        If score > 100 And score < 110 Then
            speed = 13
        End If


        speed_text.Text = "speed" & speed

        If (car.Bounds.IntersectsWith(enemy1.Bounds)) Then
            gameover()
        End If
        If (car.Bounds.IntersectsWith(enemy2.Bounds)) Then
            gameover()
        End If
        If (car.Bounds.IntersectsWith(enemy3.Bounds)) Then
            gameover()
        End If

    End Sub
    Private Sub gameover()
        back.Visible = True
        endtext.Visible = True
        roadmover.Stop()
        enemy1mover.Stop()
        enemy2mover.Stop()
        enemy3mover.Stop()
        rightmover.Stop()
        leftmover.Stop()
        replay.Visible = True
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles enemy1.Click

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles enemy3.Click

    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            rightmover.Start()


        End If
        If e.KeyCode = Keys.Left Then
            leftmover.Start()

        End If
    End Sub

    Private Sub rightmover_Tick(sender As Object, e As EventArgs) Handles rightmover.Tick
        If (car.Location.X < 436) Then
            car.Left += 5
        End If
    End Sub

    Private Sub leftmover_Tick(sender As Object, e As EventArgs) Handles leftmover.Tick
        If (car.Location.X > 1) Then
            car.Left -= 5
        End If
    End Sub

    Private Sub Form3_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        rightmover.Stop()
        leftmover.Stop()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles enemy3mover.Tick

        enemy3.Top += speed / 2
        If enemy3.Top >= Me.Height Then
            score += 1
            score_text.Text = "score" & score
            enemy3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + enemy3.Height)
            enemy3.Left = CInt(Math.Ceiling(Rnd() * 300)) + 140
        End If
    End Sub

    Private Sub enemy2mover_Tick(sender As Object, e As EventArgs) Handles enemy2mover.Tick

        enemy2.Top += speed * 1.5
        If enemy2.Top >= Me.Height Then
            score += 1
            score_text.Text = "score" & score
            enemy2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + enemy2.Height)
            enemy2.Left = CInt(Math.Ceiling(Rnd() * 100)) + 240

        End If
    End Sub

    Private Sub enemy1mover_Tick(sender As Object, e As EventArgs) Handles enemy1mover.Tick

        enemy1.Top += speed * 2

        If enemy1.Top >= Me.Height Then
            score += 1
            score_text.Text = "score" & score
            enemy1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + enemy1.Height)
            enemy1.Left = CInt(Math.Ceiling(Rnd() * 100)) + 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles replay.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form3_Load(e, e)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles back.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class