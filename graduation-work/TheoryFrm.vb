Public Class TheoryFrm
    Dim s As Byte
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\11.mht")
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\12.mht")
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\13.mht")
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\14.mht")
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\15.mht")
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\16.mht")
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\20.mht")
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\21.mht")
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\22.mht")
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\23.mht")
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\24.mht")
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\10.mht")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MenuFrm.Show()
        Me.Close()
        If MenuFrm.window <> MenuFrm.WindowState Then
            MenuFrm.Button4.PerformClick()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If s = 16 Then

            s = s + 4
        ElseIf s = 24 Then
            s = s + 6
        ElseIf s = 32 Then
            s = s + 8
        Else
            s = s + 1
        End If
        If s = 40 Then
            Button3.Enabled = False
        End If
        Button1.Enabled = True
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\" & Trim(Str(s)) & ".mht")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If s = 20 Then
            s = s - 4
        ElseIf s = 30 Then
            s = s - 6
        ElseIf s = 40 Then
            s = s - 8
        Else
            s = s - 1
        End If

        If s = 10 Then
            Button1.Enabled = False
        End If
        Button3.Enabled = True
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\" & Trim(Str(s)) & ".mht")
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        If Mid(e.Url.AbsolutePath, InStrRev(e.Url.AbsolutePath, "/") + 1, 2) = "10" Then
            Button1.Enabled = False
            Button3.Enabled = True
        ElseIf Mid(e.Url.AbsolutePath, InStrRev(e.Url.AbsolutePath, "/") + 1, 2) = "40" Then
            Button3.Enabled = False
            Button1.Enabled = True
        Else
            Button1.Enabled = True
            Button3.Enabled = True
        End If
        s = Val(Mid(e.Url.AbsolutePath, InStrRev(e.Url.AbsolutePath, "/") + 1, 2))
    End Sub

    Private Sub WebBrowser1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles WebBrowser1.PreviewKeyDown
        If e.KeyValue = 8 Then
            WebBrowser1.Navigate(Application.StartupPath & "\Theory\" & Trim(Str(s)) & ".mht")
        ElseIf e.KeyValue = Keys.Right Then
            Button3.PerformClick()
        ElseIf e.KeyValue = Keys.Left Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.WindowState = 0 Then
            Me.WindowState = FormWindowState.Maximized
            Button4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\restore_window.png")
            MenuFrm.window = 2
            WebBrowser1.Height = Me.Height - 53 - WebBrowser1.Top
            WebBrowser1.Width = Me.Width - 12 - WebBrowser1.Left
        Else
            Me.WindowState = FormWindowState.Normal
            MenuFrm.window = 0
            Button4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\maximize_window.png")
            WebBrowser1.Height = Me.Height - 53 - WebBrowser1.Top
            WebBrowser1.Width = Me.Width - 12 - WebBrowser1.Left
        End If
        Button2.Left = Me.Size.Width - 47
        Button4.Left = Me.Size.Width - 47 - 8 - 35
        Button5.Left = Me.Size.Width - 47 - 8 - 35 - 8 - 35
        Button6.Left = Me.Size.Width - 47 - 8 - 35 - 8 - 35 - 8 - 57
        Button1.Top = Me.Height - 12 - 35
        Button3.Top = Me.Height - 12 - 35
        Button3.Left = Me.Width - 12 - 57
        Label13.Left = WebBrowser1.Left + WebBrowser1.Width / 2 - Label13.Width / 2
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Button7.Tag = 0 Then
            Panel1.Visible = False
            Button7.Tag = 1
            Label8.Top -= 205
            Button8.Top -= 205
            Panel2.Top -= 205
            Button7.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\plus.png")
            Label17.Top -= 205
            Panel3.Top -= 205
            Label14.Top -= 205
            Button9.Top -= 205
        Else
            Panel1.Visible = True
            Button7.Tag = 0
            Label8.Top += 205
            Button8.Top += 205
            Panel2.Top += 205
            Button7.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\minus.png")
            Label17.Top += 205
            Panel3.Top += 205
            Label14.Top += 205
            Button9.Top += 205
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Button8.Tag = 0 Then
            Button8.Tag = 1
            Panel2.Visible = False
            Button8.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\plus.png")
            Panel3.Top -= 150
            Label17.Top -= 150
            Button9.Top -= 150
            Label14.Top -= 150

        Else
            Button8.Tag = 0
            Panel2.Visible = True
            Button8.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\minus.png")
            Panel3.Top += 150
            Label17.Top += 150
            Button9.Top += 150
            Label14.Top += 150
        End If
    End Sub

    Private Sub TheoryFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If MenuFrm.Visible = False Then
            Application.Exit()
        End If
    End Sub

    Private Sub TheoryFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\BackGround.jpg")
        s = 10
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\10.mht")
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If Button9.Tag = 0 Then
            Panel3.Visible = False
            Label17.Top -= 70
            Button9.Tag = 1
            Button9.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\plus.png")
        ElseIf Button9.Tag = 1 Then
            Panel3.Visible = True
            Label17.Top += 70
            Button9.Tag = 0
            Button9.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\minus.png")
        End If
    End Sub

    Private Sub Label14_Click(sender As System.Object, e As System.EventArgs) Handles Label14.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\30.mht")
    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs) Handles Label15.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\31.mht")
    End Sub

    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs) Handles Label16.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\32.mht")
    End Sub

    Private Sub Label17_Click(sender As System.Object, e As System.EventArgs) Handles Label17.Click
        WebBrowser1.Navigate(Application.StartupPath & "\Theory\40.mht")
    End Sub
End Class