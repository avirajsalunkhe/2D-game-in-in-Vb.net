Public Class Tank_game
    Dim speed As Integer
    Dim score As Integer = 0

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 1

        If score > 10 And score < 50 Then
            speed = speed * 5
        End If
        If score > 50 And score < 100 Then
            speed = speed * 10
        End If
        If score > 100 And score < 150 Then
            speed = speed * 15
        End If
        If score > 150 And score < 200 Then
            speed = speed * 20
        End If
        If score > 200 And score < 250 Then
            speed = speed * 25
        End If

    End Sub
    Private Sub gameover()
        endtext.Visible = True
        Retrytext.Visible = True
        leftmover.Stop()
        rightmover.Stop()
        bombmover.Stop()
        leftmoverbomb.Stop()
        rightmoverbomb.Stop()
        bomb.Visible = False
        backbutton.Visible = True
        enemytankmover.Stop()
        enemy1mover.Stop()
        enemy2mover.Stop()
        enemy3mover.Stop()
        enemy4mover.Stop()


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles enemytankmover.Tick

        enemytank1.Top += speed
        enemytank2.Top += speed
        enemytank3.Top += speed
        enemytank4.Top += speed


        If enemytank1.Visible = True And (endline.Bounds.IntersectsWith(enemytank1.Bounds)) Then
            gameover()
        End If
        If enemytank2.Visible = True And (endline.Bounds.IntersectsWith(enemytank2.Bounds)) Then
            gameover()
        End If
        If enemytank3.Visible = True And (endline.Bounds.IntersectsWith(enemytank3.Bounds)) Then
            gameover()
        End If
        If enemytank4.Visible = True And (endline.Bounds.IntersectsWith(enemytank4.Bounds)) Then
            gameover()
        End If

        If (lastline.Bounds.IntersectsWith(enemytank1.Bounds)) Then
            enemytank1.Visible = True


        End If
        If (lastline.Bounds.IntersectsWith(enemytank2.Bounds)) Then
            enemytank2.Visible = True

        End If
        If (lastline.Bounds.IntersectsWith(enemytank3.Bounds)) Then
            enemytank3.Visible = True

        End If
        If (lastline.Bounds.IntersectsWith(enemytank4.Bounds)) Then
            enemytank4.Visible = True

        End If

    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            rightmover.Start()
            rightmoverbomb.Start()

        End If
        If e.KeyCode = Keys.Left Then
            leftmover.Start()
            leftmoverbomb.Start()


        End If
        If e.KeyCode = Keys.Space Then
            bombmover.Start()
            bomb.Visible = True
        End If
    End Sub

    Private Sub leftmover_Tick(sender As Object, e As EventArgs) Handles leftmover.Tick
        If (india.Location.X > 3) Then
            india.Left -= 8
        End If
    End Sub

    Private Sub rightmover_Tick(sender As Object, e As EventArgs) Handles rightmover.Tick
        If (india.Location.X < 280) Then
            india.Left += 8
        End If
    End Sub

    Private Sub Form4_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        leftmover.Stop()
        rightmover.Stop()
        bombmover.Stop()
        leftmoverbomb.Stop()
        rightmoverbomb.Stop()
        bomb.Visible = False

    End Sub

    Private Sub leftmoverbomb_Tick(sender As Object, e As EventArgs) Handles leftmoverbomb.Tick
        If (bomb.Location.X > 31) Then
            bomb.Left -= 8
        End If
    End Sub

    Private Sub rightmoverbomb_Tick(sender As Object, e As EventArgs) Handles rightmoverbomb.Tick
        If (bomb.Location.X < 308) Then
            bomb.Left += 8
        End If
    End Sub

    Private Sub bombmover_Tick(sender As Object, e As EventArgs) Handles bombmover.Tick

        bomb.Top += 100
        If bomb.Top >= Me.Height Then
            bomb.Top = -bomb.Height
        End If
        If bomb.Visible = True And (bomb.Bounds.IntersectsWith(enemytank1.Bounds)) Then
            scoretext.Text += 0.5
            enemytank1.Visible = False
        End If
        If bomb.Visible = True And (bomb.Bounds.IntersectsWith(enemytank2.Bounds)) Then
            scoretext.Text += 0.5
            enemytank2.Visible = False


        End If
        If bomb.Visible = True And (bomb.Bounds.IntersectsWith(enemytank3.Bounds)) Then
            scoretext.Text += 0.5
            enemytank3.Visible = False
        End If
        If bomb.Visible = True And (bomb.Bounds.IntersectsWith(enemytank4.Bounds)) Then
            scoretext.Text += 0.5
            enemytank4.Visible = False
        End If
        If (bomb.Bounds.IntersectsWith(firstline.Bounds)) Then
            bomb.Visible = True

        End If
        If (bomb.Bounds.IntersectsWith(secondline.Bounds)) Then
            bomb.Visible = False


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Retrytext_Click(sender As Object, e As EventArgs) Handles Retrytext.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form4_Load(e, e)

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles enemy1mover.Tick
        enemytank1.Top += speed * 4

        If enemytank1.Top >= Me.Height Then

            enemytank1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + enemytank1.Height)
            enemytank1.Left = CInt(Math.Ceiling(Rnd() * 100)) + 0
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles enemy2mover.Tick
        enemytank2.Top += speed * 4

        If enemytank2.Top >= Me.Height Then

            enemytank2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + enemytank2.Height)
            enemytank2.Left = CInt(Math.Ceiling(Rnd() * 70)) + 140
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles enemy3mover.Tick
        enemytank3.Top += speed * 3

        If enemytank3.Top >= Me.Height Then

            enemytank3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + enemytank3.Height)
            enemytank3.Left = CInt(Math.Ceiling(Rnd() * 250)) + 100
        End If
    End Sub

    Private Sub enemy4mover_Tick(sender As Object, e As EventArgs) Handles enemy4mover.Tick
        enemytank4.Top += speed * 1.5

        If enemytank4.Top >= Me.Height Then

            enemytank4.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + enemytank4.Height)
            enemytank4.Left = CInt(Math.Ceiling(Rnd() * 100)) + 0
        End If
    End Sub
End Class