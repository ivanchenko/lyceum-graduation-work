Public Class AnimationFrm
    Dim pt As New Point
    Dim k As Byte
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        AxShockwaveFlash1.Movie = Application.StartupPath & "\Documents\2.swf"
        Label1.Text = "Рух частинок у радіаційних поясах"
        pt = PictureBox1.Location
        k = 1
        AxShockwaveFlash1.BackgroundColor = 0
        AxShockwaveFlash1.Play()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        AxShockwaveFlash1.Movie = Application.StartupPath & "\Documents\1.swf"
        Label1.Text = "Сонячний вітер та магнітне поле"
        pt = PictureBox2.Location
        k = 2
        AxShockwaveFlash1.BackgroundColor = 0
        AxShockwaveFlash1.Play()
    End Sub

    Private Sub AnimationFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If MenuFrm.Visible = True Then
            Application.Exit()
        End If
    End Sub

    Private Sub AnimationFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\an11.png")
        PictureBox2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\an21.png")
        Me.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\BackGround.jpg")
        PictureBox1.Top = Me.Height / 2 - 45 - 145
        PictureBox2.Top = Me.Height / 2 + 45
        pt = PictureBox1.Location
        PictureBox3.Top = PictureBox1.Top - 3
        PictureBox3.Left = PictureBox1.Left - 3
        k = 1
        AxShockwaveFlash1.Movie = Application.StartupPath & "\Documents\2.swf"
        AxShockwaveFlash1.StopPlay()
        AxShockwaveFlash1.BackgroundColor = 0

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\an1.png")
        PictureBox3.Top = PictureBox1.Top - 3
        PictureBox3.Left = PictureBox1.Left - 3
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\an2.png")
        PictureBox3.Top = PictureBox2.Top - 3
        PictureBox3.Left = PictureBox2.Left - 3
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\an11.png")
        PictureBox3.Top = pt.Y - 3
        PictureBox3.Left = pt.X - 3
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\an21.png")
        PictureBox3.Top = pt.Y - 3
        PictureBox3.Left = pt.X - 3
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
        MenuFrm.Show()
        If MenuFrm.window <> MenuFrm.WindowState Then
            MenuFrm.Button4.PerformClick()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.WindowState = 0 Then
            Me.WindowState = FormWindowState.Maximized
            Button4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\restore_window.png")
            MenuFrm.window = 2

        Else
            Me.WindowState = FormWindowState.Normal
            MenuFrm.window = 0
            Button4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\maximize_window.png")        
        End If
        Button2.Left = Me.Size.Width - 47
        Button4.Left = Me.Size.Width - 47 - 8 - 35
        Button5.Left = Me.Size.Width - 47 - 8 - 35 - 8 - 35
        Button6.Left = Me.Size.Width - 47 - 8 - 35 - 8 - 35 - 8 - 57
        AxShockwaveFlash1.Width = Me.Width - AxShockwaveFlash1.Left - 12
        AxShockwaveFlash1.Height = Me.Height - AxShockwaveFlash1.Top - 12
        PictureBox1.Top = Me.Height / 2 - 45 - 145
        PictureBox2.Top = Me.Height / 2 + 45

        If k = 1 Then
            PictureBox3.Top = PictureBox1.Top - 3
            PictureBox3.Left = PictureBox1.Left - 3
            pt = PictureBox1.Location
        ElseIf k = 2 Then
            PictureBox3.Top = PictureBox2.Top - 3
            PictureBox3.Left = PictureBox2.Left - 3
            pt = PictureBox2.Location
        End If
        Label1.Left = AxShockwaveFlash1.Width / 2 + AxShockwaveFlash1.Left - Label1.Width / 2
        Button1.Top = PictureBox2.Top + PictureBox2.Height + 6
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If k = 1 Then
            AxShockwaveFlash1.Movie = Application.StartupPath & "\Documents\1.swf"
            AxShockwaveFlash1.Movie = Application.StartupPath & "\Documents\2.swf"
            AxShockwaveFlash1.Play()

        ElseIf k = 2 Then
            AxShockwaveFlash1.Movie = Application.StartupPath & "\Documents\2.swf"
            AxShockwaveFlash1.Movie = Application.StartupPath & "\Documents\1.swf"
            AxShockwaveFlash1.Play()
        End If
    End Sub
End Class