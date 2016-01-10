Public Class MenuFrm
    Public window As Byte
    Dim tick1 As Integer
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.WindowState = 0 Then
            Me.WindowState = FormWindowState.Maximized
            Button4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\restore_window.png")
            window = 2
            Dim pt As New Point
            pt.X = Me.Width / 2 - Label1.Width / 2
            pt.Y = Me.Height / 2 - 28 - 27 - 56 - 27 - 56
            Label1.Location = pt
            pt.X = Me.Width / 2 - Label2.Width / 2
            pt.Y = Me.Height / 2 - 28 - 27 - 56
            Label2.Location = pt
            pt.X = Me.Width / 2 - Label3.Width / 2
            pt.Y = Me.Height / 2 - 28
            Label3.Location = pt
            pt.X = Me.Width / 2 - Label4.Width / 2
            pt.Y = Me.Height / 2 + 28 + 27
            Label4.Location = pt
            pt.X = Me.Width / 2 - Label10.Width / 2
            pt.Y = Me.Height / 2 + 28 + 27 + 56 + 27
            Label10.Location = pt
        Else
            Me.WindowState = FormWindowState.Normal
            window = 0
            Button4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\maximize_window.png")
            Dim pt As New Point
            pt.X = 521
            pt.Y = 156
            Label1.Location = pt
            pt.X = 434
            pt.Y = 239
            Label2.Location = pt
            pt.X = 499
            pt.Y = 322
            Label3.Location = pt
            pt.X = 534
            pt.Y = 405
            Label4.Location = pt
            pt.X = 467
            pt.Y = 488
            Label10.Location = pt
        End If
        Button2.Left = Me.Size.Width - 47
        Button4.Left = Me.Size.Width - 47 - 8 - 35
        Button5.Left = Me.Size.Width - 47 - 8 - 35 - 8 - 35
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Dim t As Boolean
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tick1 += 1
        If tick1 > 100 And t = False Then
            Me.Opacity -= 1 / 100
        End If
        If Me.Opacity = 0 Then
            t = True
            Me.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\BackGround.jpg")
        End If
        If t = True Then

            Me.Opacity += 1 / 100
            Button5.Visible = True
            Button2.Visible = True
            Button4.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label10.Visible = True
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            If Me.Opacity = 1 Then
                Timer1.Stop()
            End If
        End If
        Dim c As Integer
        c = Me.WindowState
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        VideoFrm.Show()
        Me.Hide()
        If VideoFrm.WindowState <> window Then
            VideoFrm.Button4.PerformClick()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        TheoryFrm.Show()
        If TheoryFrm.WindowState <> window Then
            TheoryFrm.Button4.PerformClick()
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Hide()
        ModelFrm.Show()
        If ModelFrm.WindowState <> window Then
            ModelFrm.MaximizedBtn.PerformClick()
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        AnimationFrm.Show()
        Me.Hide()
        If AnimationFrm.WindowState <> window Then
            AnimationFrm.Button4.PerformClick()
        End If
    End Sub
    Dim zr As Boolean
    Private Sub MenuFrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Space And t = False Then
            If zr = True Then
                Timer1.Stop()
                zr = False
            ElseIf zr = False Then
                Timer1.Start()
                zr = True
            End If
        End If
    End Sub

    Private Sub MenuFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        window = 0
        t = False
        zr = True
    End Sub

   
    Private Sub Label1_MouseEnter(sender As Object, e As System.EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As System.EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As System.EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As System.EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.Black
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As System.EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Black
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        TestsFrm.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As EventArgs) Handles Label10.MouseEnter
        Label10.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles Label10.MouseLeave
        Label10.ForeColor = Color.Black
    End Sub
End Class
