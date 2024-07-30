<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tank_game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tank_game))
        Me.enemytankmover = New System.Windows.Forms.Timer(Me.components)
        Me.india = New System.Windows.Forms.PictureBox()
        Me.enemytank3 = New System.Windows.Forms.PictureBox()
        Me.enemytank4 = New System.Windows.Forms.PictureBox()
        Me.enemytank1 = New System.Windows.Forms.PictureBox()
        Me.enemytank2 = New System.Windows.Forms.PictureBox()
        Me.bombmover = New System.Windows.Forms.Timer(Me.components)
        Me.leftmover = New System.Windows.Forms.Timer(Me.components)
        Me.rightmover = New System.Windows.Forms.Timer(Me.components)
        Me.leftmoverbomb = New System.Windows.Forms.Timer(Me.components)
        Me.rightmoverbomb = New System.Windows.Forms.Timer(Me.components)
        Me.enemy1mover = New System.Windows.Forms.Timer(Me.components)
        Me.bomb = New System.Windows.Forms.PictureBox()
        Me.endtext = New System.Windows.Forms.Label()
        Me.backbutton = New System.Windows.Forms.Button()
        Me.Retrytext = New System.Windows.Forms.Button()
        Me.endline = New System.Windows.Forms.PictureBox()
        Me.scoretext = New System.Windows.Forms.Label()
        Me.enemy4mover = New System.Windows.Forms.Timer(Me.components)
        Me.enemy2mover = New System.Windows.Forms.Timer(Me.components)
        Me.enemy3mover = New System.Windows.Forms.Timer(Me.components)
        Me.lastline = New System.Windows.Forms.PictureBox()
        Me.firstline = New System.Windows.Forms.PictureBox()
        Me.secondline = New System.Windows.Forms.PictureBox()
        CType(Me.india, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemytank3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemytank4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemytank1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemytank2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bomb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.endline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lastline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.firstline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.secondline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'enemytankmover
        '
        Me.enemytankmover.Enabled = True
        Me.enemytankmover.Interval = 10
        '
        'india
        '
        Me.india.BackColor = System.Drawing.Color.White
        Me.india.Image = CType(resources.GetObject("india.Image"), System.Drawing.Image)
        Me.india.Location = New System.Drawing.Point(131, 335)
        Me.india.Name = "india"
        Me.india.Size = New System.Drawing.Size(75, 112)
        Me.india.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.india.TabIndex = 0
        Me.india.TabStop = False
        '
        'enemytank3
        '
        Me.enemytank3.BackColor = System.Drawing.Color.White
        Me.enemytank3.Image = CType(resources.GetObject("enemytank3.Image"), System.Drawing.Image)
        Me.enemytank3.Location = New System.Drawing.Point(190, -38)
        Me.enemytank3.Name = "enemytank3"
        Me.enemytank3.Size = New System.Drawing.Size(36, 59)
        Me.enemytank3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemytank3.TabIndex = 0
        Me.enemytank3.TabStop = False
        '
        'enemytank4
        '
        Me.enemytank4.BackColor = System.Drawing.Color.White
        Me.enemytank4.Image = CType(resources.GetObject("enemytank4.Image"), System.Drawing.Image)
        Me.enemytank4.Location = New System.Drawing.Point(310, 60)
        Me.enemytank4.Name = "enemytank4"
        Me.enemytank4.Size = New System.Drawing.Size(42, 59)
        Me.enemytank4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemytank4.TabIndex = 0
        Me.enemytank4.TabStop = False
        '
        'enemytank1
        '
        Me.enemytank1.BackColor = System.Drawing.Color.White
        Me.enemytank1.Image = CType(resources.GetObject("enemytank1.Image"), System.Drawing.Image)
        Me.enemytank1.Location = New System.Drawing.Point(12, -38)
        Me.enemytank1.Name = "enemytank1"
        Me.enemytank1.Size = New System.Drawing.Size(41, 57)
        Me.enemytank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemytank1.TabIndex = 0
        Me.enemytank1.TabStop = False
        '
        'enemytank2
        '
        Me.enemytank2.BackColor = System.Drawing.Color.White
        Me.enemytank2.Image = CType(resources.GetObject("enemytank2.Image"), System.Drawing.Image)
        Me.enemytank2.Location = New System.Drawing.Point(107, 71)
        Me.enemytank2.Name = "enemytank2"
        Me.enemytank2.Size = New System.Drawing.Size(37, 59)
        Me.enemytank2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemytank2.TabIndex = 0
        Me.enemytank2.TabStop = False
        '
        'bombmover
        '
        Me.bombmover.Interval = 10
        '
        'leftmover
        '
        Me.leftmover.Interval = 10
        '
        'rightmover
        '
        Me.rightmover.Interval = 10
        '
        'leftmoverbomb
        '
        Me.leftmoverbomb.Interval = 10
        '
        'rightmoverbomb
        '
        Me.rightmoverbomb.Interval = 10
        '
        'enemy1mover
        '
        Me.enemy1mover.Enabled = True
        Me.enemy1mover.Interval = 10
        '
        'bomb
        '
        Me.bomb.BackColor = System.Drawing.Color.Gray
        Me.bomb.Location = New System.Drawing.Point(158, 427)
        Me.bomb.Name = "bomb"
        Me.bomb.Size = New System.Drawing.Size(16, 20)
        Me.bomb.TabIndex = 1
        Me.bomb.TabStop = False
        Me.bomb.Visible = False
        '
        'endtext
        '
        Me.endtext.AutoSize = True
        Me.endtext.BackColor = System.Drawing.Color.Silver
        Me.endtext.Font = New System.Drawing.Font("Sitka Small", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.endtext.ForeColor = System.Drawing.Color.Red
        Me.endtext.Location = New System.Drawing.Point(27, 97)
        Me.endtext.Name = "endtext"
        Me.endtext.Size = New System.Drawing.Size(302, 71)
        Me.endtext.TabIndex = 2
        Me.endtext.Text = "Game over"
        Me.endtext.Visible = False
        '
        'backbutton
        '
        Me.backbutton.Font = New System.Drawing.Font("Sitka Display", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.backbutton.Location = New System.Drawing.Point(52, 226)
        Me.backbutton.Name = "backbutton"
        Me.backbutton.Size = New System.Drawing.Size(76, 43)
        Me.backbutton.TabIndex = 3
        Me.backbutton.Text = "Back"
        Me.backbutton.UseVisualStyleBackColor = True
        Me.backbutton.Visible = False
        '
        'Retrytext
        '
        Me.Retrytext.Font = New System.Drawing.Font("Sitka Display", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Retrytext.Location = New System.Drawing.Point(211, 226)
        Me.Retrytext.Name = "Retrytext"
        Me.Retrytext.Size = New System.Drawing.Size(76, 43)
        Me.Retrytext.TabIndex = 3
        Me.Retrytext.Text = "Retry"
        Me.Retrytext.UseVisualStyleBackColor = True
        Me.Retrytext.Visible = False
        '
        'endline
        '
        Me.endline.Location = New System.Drawing.Point(36, 456)
        Me.endline.Name = "endline"
        Me.endline.Size = New System.Drawing.Size(281, 10)
        Me.endline.TabIndex = 4
        Me.endline.TabStop = False
        '
        'scoretext
        '
        Me.scoretext.AutoSize = True
        Me.scoretext.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.scoretext.Font = New System.Drawing.Font("Showcard Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.scoretext.Location = New System.Drawing.Point(286, -4)
        Me.scoretext.Name = "scoretext"
        Me.scoretext.Size = New System.Drawing.Size(66, 46)
        Me.scoretext.TabIndex = 5
        Me.scoretext.Text = "00"
        '
        'enemy4mover
        '
        Me.enemy4mover.Enabled = True
        Me.enemy4mover.Interval = 10
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
        'lastline
        '
        Me.lastline.Location = New System.Drawing.Point(-124, 543)
        Me.lastline.Name = "lastline"
        Me.lastline.Size = New System.Drawing.Size(645, 8)
        Me.lastline.TabIndex = 6
        Me.lastline.TabStop = False
        '
        'firstline
        '
        Me.firstline.Location = New System.Drawing.Point(1, -4)
        Me.firstline.Name = "firstline"
        Me.firstline.Size = New System.Drawing.Size(351, 10)
        Me.firstline.TabIndex = 7
        Me.firstline.TabStop = False
        '
        'secondline
        '
        Me.secondline.Location = New System.Drawing.Point(15, 413)
        Me.secondline.Name = "secondline"
        Me.secondline.Size = New System.Drawing.Size(314, 8)
        Me.secondline.TabIndex = 7
        Me.secondline.TabStop = False
        '
        'Tank_game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(351, 450)
        Me.Controls.Add(Me.lastline)
        Me.Controls.Add(Me.enemytank1)
        Me.Controls.Add(Me.enemytank2)
        Me.Controls.Add(Me.enemytank3)
        Me.Controls.Add(Me.enemytank4)
        Me.Controls.Add(Me.scoretext)
        Me.Controls.Add(Me.Retrytext)
        Me.Controls.Add(Me.backbutton)
        Me.Controls.Add(Me.endtext)
        Me.Controls.Add(Me.india)
        Me.Controls.Add(Me.endline)
        Me.Controls.Add(Me.secondline)
        Me.Controls.Add(Me.firstline)
        Me.Controls.Add(Me.bomb)
        Me.Name = "Tank_game"
        Me.Text = "Form4"
        CType(Me.india, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemytank3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemytank4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemytank1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemytank2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bomb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.endline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lastline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.firstline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.secondline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents enemytankmover As Timer
    Friend WithEvents india As PictureBox
    Friend WithEvents enemytank3 As PictureBox
    Friend WithEvents enemytank4 As PictureBox
    Friend WithEvents enemytank1 As PictureBox
    Friend WithEvents enemytank2 As PictureBox
    Friend WithEvents bombmover As Timer
    Friend WithEvents leftmover As Timer
    Friend WithEvents rightmover As Timer
    Friend WithEvents leftmoverbomb As Timer
    Friend WithEvents rightmoverbomb As Timer
    Friend WithEvents enemy1mover As Timer
    Friend WithEvents bomb As PictureBox
    Friend WithEvents endtext As Label
    Friend WithEvents backbutton As Button
    Friend WithEvents Retrytext As Button
    Friend WithEvents endline As PictureBox
    Friend WithEvents scoretext As Label
    Friend WithEvents enemy4mover As Timer
    Friend WithEvents enemy2mover As Timer
    Friend WithEvents enemy3mover As Timer
    Friend WithEvents lastline As PictureBox
    Friend WithEvents firstline As PictureBox
    Friend WithEvents secondline As PictureBox
End Class
