Public Class Settings
    Dim b As Byte
    Dim ch1, ch2, ch3, ch4, ch5, b1 As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        b1 = True
        Me.Close()
        ModelFrm.lineWidth = NumericUpDown1.Value
        ModelFrm.GlControl1.Invalidate()
    End Sub

    Private Sub Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If b1 = False Then
            CheckBox1.Checked = ch1
            CheckBox2.Checked = ch2
            CheckBox3.Checked = ch3
            CheckBox4.Checked = ch4
            CheckBox5.Checked = ch5
            NumericUpDown1.Value = b
        End If
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ch1 = CheckBox1.CheckState
        ch2 = CheckBox2.CheckState
        ch3 = CheckBox3.CheckState
        ch4 = CheckBox4.CheckState
        ch5 = CheckBox5.CheckState
        b = NumericUpDown1.Value
        b1 = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class