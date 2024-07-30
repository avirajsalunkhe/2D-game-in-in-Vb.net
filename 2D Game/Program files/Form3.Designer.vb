<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Car_game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Car_game))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.roadmover = New System.Windows.Forms.Timer(Me.components)
        Me.car = New System.Windows.Forms.PictureBox()
        Me.enemy1 = New System.Windows.Forms.PictureBox()
        Me.enemy2 = New System.Windows.Forms.PictureBox()
        Me.enemy3 = New System.Windows.Forms.PictureBox()
        Me.leftmover = New System.Windows.Forms.Timer(Me.components)
        Me.rightmover = New System.Windows.Forms.Timer(Me.components)
        Me.enemy1mover = New System.Windows.Forms.Timer(Me.components)
        Me.enemy2mover = New System.Windows.Forms.Timer(Me.components)
        Me.enemy3mover = New System.Windows.Forms.Timer(Me.components)
        Me.endtext = New System.Windows.Forms.Label()
        Me.replay = New System.Windows.Forms.Button()
        Me.score_text = New System.Windows.Forms.Label()
        Me.speed_text = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(150, -51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 126)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.Location = New System.Drawing.Point(320, -51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 126)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox3.Location = New System.Drawing.Point(150, 150)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 126)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox4.Location = New System.Drawing.Point(320, 150)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(15, 126)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox5.Location = New System.Drawing.Point(150, 349)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(15, 126)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox6.Location = New System.Drawing.Point(320, 349)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(15, 126)
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'roadmover
        '
        Me.roadmover.Enabled = True
        Me.roadmover.Interval = 10
        '
        'car
        '
        Me.car.Image = CType(resources.GetObject("car.Image"), System.Drawing.Image)
        Me.car.Location = New System.Drawing.Point(341, 326)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(51, 119)
        Me.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car.TabIndex = 1
        Me.car.TabStop = False
        '
        'enemy1
        '
        Me.enemy1.Image = CType(resources.GetObject("enemy1.Image"), System.Drawing.Image)
        Me.enemy1.Location = New System.Drawing.Point(49, 233)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New System.Drawing.Size(51, 119)
        Me.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.enemy1.TabIndex = 1
        Me.enemy1.TabStop = False
        '
        'enemy2
        '
        Me.enemy2.Image = CType(resources.GetObject("enemy2.Image"), System.Drawing.Image)
        Me.enemy2.Location = New System.Drawing.Point(219, -44)
        Me.enemy2.Name = "enemy2"
        Me.enemy2.Size = New System.Drawing.Size(51, 119)
        Me.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.enemy2.TabIndex = 1
        Me.enemy2.TabStop = False
        '
        'enemy3
        '
        Me.enemy3.Image = CType(resources.GetObject("enemy3.Image"), System.Drawing.Image)
        Me.enemy3.Location = New System.Drawing.Point(397, 89)
        Me.enemy3.Name = "enemy3"
        Me.enemy3.Size = New System.Drawing.Size(50, 119)
        Me.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.enemy3.TabIndex = 1
        Me.enemy3.TabStop = False
        '
        'leftmover
        '
        Me.leftmover.Interval = 10
        '
        'rightmover
        '
        Me.rightmover.Interval = 10
        '
        'enemy1mover
        '
        Me.enemy1mover.Enabled = True
        Me.enemy1mover.Interval = 10
        '
        'enemy2mover
        '
        Me.enemy2mover.Enabled = True
        Me.enemy2mover.Interval = 10
        '
        'enemy3mover
        '
        Me.enemy3mover.Enabled = True
        Me.enemy3mover.Interval = 10
        '
        'endtext
        '
        Me.endtext.AutoSize = True
        Me.endtext.BackColor = System.Drawing.Color.Black
        Me.endtext.Font = New System.Drawing.Font("Sitka Small", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.endtext.ForeColor = System.Drawing.Color.Red
        Me.endtext.Location = New System.Drawing.Point(49, 78)
        Me.endtext.Name = "endtext"
        Me.endtext.Size = New System.Drawing.Size(401, 94)
        Me.endtext.TabIndex = 2
        Me.endtext.Text = "Game over"
        Me.endtext.Visible = False
        '
        'replay
        '
        Me.replay.BackColor = System.Drawing.Color.Transparent
        Me.replay.Font = New System.Drawing.Font("Sitka Display", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.replay.ForeColor = System.Drawing.Color.Green
        Me.replay.Location = New System.Drawing.Point(299, 278)
        Me.replay.Name = "replay"
        Me.replay.Size = New System.Drawing.Size(130, 65)
        Me.replay.TabIndex = 3
        Me.replay.Text = "Retry"
        Me.replay.UseVisualStyleBackColor = False
        Me.replay.Visible = False
        '
        'score_text
        '
        Me.score_text.AutoSize = True
        Me.score_text.BackColor = System.Drawing.Color.White
        Me.score_text.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.score_text.Location = New System.Drawing.Point(12, 9)
        Me.score_text.Name = "score_text"
        Me.score_text.Size = New System.Drawing.Size(94, 24)
        Me.score_text.TabIndex = 4
        Me.score_text.Text = "score__00"
        '
        'speed_text
        '
        Me.speed_text.AutoSize = True
        Me.speed_text.BackColor = System.Drawing.Color.White
        Me.speed_text.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.speed_text.Location = New System.Drawing.Point(385, 9)
        Me.speed_text.Name = "speed_text"
        Me.speed_text.Size = New System.Drawing.Size(99, 24)
        Me.speed_text.TabIndex = 4
        Me.speed_text.Text = "speed__00"
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.Font = New System.Drawing.Font("Sitka Display", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.back.ForeColor = System.Drawing.Color.Maroon
        Me.back.Location = New System.Drawing.Point(106, 278)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(130, 65)
        Me.back.TabIndex = 3
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        Me.back.Visible = False
        '
        'Car_game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(491, 445)
        Me.Controls.Add(Me.speed_text)
        Me.Controls.Add(Me.score_text)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.replay)
        Me.Controls.Add(Me.endtext)
        Me.Controls.Add(Me.enemy3)
        Me.Controls.Add(Me.enemy2)
        Me.Controls.Add(Me.enemy1)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Car_game"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents roadmover As Timer
    Friend WithEvents car As PictureBox
    Friend WithEvents enemy1 As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents enemy3 As PictureBox
    Friend WithEvents leftmover As Timer
    Friend WithEvents rightmover As Timer
    Friend WithEvents enemy1mover As Timer
    Friend WithEvents enemy2mover As Timer
    Friend WithEvents enemy3mover As Timer
    Friend WithEvents endtext As Label
    Friend WithEvents replay As Button
    Friend WithEvents speed_text As Label
    Friend WithEvents score_text As Label
    Friend WithEvents back As Button
End Class
