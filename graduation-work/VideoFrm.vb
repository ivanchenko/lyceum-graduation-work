Public Class VideoFrm
    Dim pt As New Point
    Dim k As Byte

    Private Sub VideoFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If MenuFrm.Visible = False Then
            Application.Exit()
        End If
    End Sub

    Private Sub VideoFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MenuFrm.window <> Me.WindowState Then
            Button4.PerformClick()
        End If
        pt = PictureBox4.Location
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "\Video\4.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        k = 4
        Me.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\BackGround.jpg")
        PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\1.bmp")
        PictureBox2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\2.bmp")
        PictureBox3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\3.png")
        PictureBox4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\4.png")
        PictureBox5.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\5.png")
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\11.bmp")
        PictureBox6.Top = PictureBox1.Top - 3
        PictureBox6.Left = PictureBox1.Left - 3
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\1.bmp")
        PictureBox6.Left = pt.X - 3
        PictureBox6.Top = pt.Y - 3
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\21.bmp")
        PictureBox6.Top = PictureBox2.Top - 3
        PictureBox6.Left = PictureBox2.Left - 3
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\2.bmp")
        PictureBox6.Left = pt.X - 3
        PictureBox6.Top = pt.Y - 3
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\31.png")
        PictureBox6.Top = PictureBox3.Top - 3
        PictureBox6.Left = PictureBox3.Left - 3
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\3.png")
        PictureBox6.Left = pt.X - 3
        PictureBox6.Top = pt.Y - 3
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\41.png")
        PictureBox6.Top = PictureBox4.Top - 3
        PictureBox6.Left = PictureBox4.Left - 3
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\4.png")
        PictureBox6.Left = pt.X - 3
        PictureBox6.Top = pt.Y - 3
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\51.png")
        PictureBox6.Top = PictureBox5.Top - 3
        PictureBox6.Left = PictureBox5.Left - 3
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\5.png")
        PictureBox6.Left = pt.X - 3
        PictureBox6.Top = pt.Y - 3
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "\Video\5.mp4"
        Label1.Text = "Північне сяйво"
        Label1.Left = AxWindowsMediaPlayer1.Left + AxWindowsMediaPlayer1.Width / 2 - Label1.Width / 2
        pt = PictureBox5.Location
        k = 5
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "\Video\2.mp4"
        Label1.Text = "Магнітне поле землі під загрозою"
        Label1.Left = AxWindowsMediaPlayer1.Left + AxWindowsMediaPlayer1.Width / 2 - Label1.Width / 2
        pt = PictureBox2.Location
        k = 2
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "\Video\3.mp4"
        Label1.Text = "Магнітне поле Землі слабшає"
        Label1.Left = AxWindowsMediaPlayer1.Left + AxWindowsMediaPlayer1.Width / 2 - Label1.Width / 2
        pt = PictureBox3.Location
        k = 3
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "\Video\4.mp4"
        Label1.Text = "Невидимий світ - магнітне поле Землі"
        Label1.Left = AxWindowsMediaPlayer1.Left + AxWindowsMediaPlayer1.Width / 2 - Label1.Width / 2
        pt = PictureBox4.Location
        k = 4
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "\Video\1.mp4"
        Label1.Text = "Геомагнітне поле та магнітосфера"
        Label1.Left = AxWindowsMediaPlayer1.Left + AxWindowsMediaPlayer1.Width / 2 - Label1.Width / 2
        pt = PictureBox1.Location
        k = 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MenuFrm.Show()
        Me.Close()
        If MenuFrm.window <> MenuFrm.WindowState Then
            MenuFrm.Button4.PerformClick()
        End If
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
        AxWindowsMediaPlayer1.Width = Me.Width - 12 - AxWindowsMediaPlayer1.Left
        AxWindowsMediaPlayer1.Height = Me.Height - 12 - AxWindowsMediaPlayer1.Top
        Label1.Left = AxWindowsMediaPlayer1.Left + AxWindowsMediaPlayer1.Width / 2 - Label1.Width / 2

        PictureBox4.Top = (Me.Height - 108 * 5 - 14 * 4) / 2
        PictureBox2.Top = PictureBox4.Top + 108 + 14
        PictureBox3.Top = PictureBox2.Top + 108 + 14
        PictureBox1.Top = PictureBox3.Top + 108 + 14
        PictureBox5.Top = PictureBox1.Top + 108 + 14
        If k = 1 Then
            pt = PictureBox1.Location
        ElseIf k = 2 Then
            pt = PictureBox2.Location
        ElseIf k = 3 Then
            pt = PictureBox3.Location
        ElseIf k = 4 Then
            pt = PictureBox4.Location
        ElseIf k = 5 Then
            pt = PictureBox5.Location
        End If
        PictureBox6.Top = pt.Y - 3
        PictureBox6.Left = pt.X - 3
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class