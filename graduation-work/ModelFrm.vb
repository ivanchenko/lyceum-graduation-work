Imports OpenTK.GLControl
Imports OpenTK.Graphics.OpenGL
Imports OpenTK.Graphics
Public Class ModelFrm
    Dim PoleType As Byte
    Public lineWidth As Byte
    Dim Tick1, tick2 As Integer
    Dim c As Integer = -1 '  массив сфера
    Dim o As Integer ' массив однородное поле
    Dim xSphere(230), ySphere(230), zSphere(230) As Single ' массив для сферы
    Dim x(), y(), z() As Double ' массив для координат движения в однородном поле
    Dim m, q, B, V, alpha, alphaN, Bn, Vn As Double
    Dim o1 As Integer ' массив неоднородное поле
    Dim xN(), yN(), zN() As Double
    Dim xMause0, yMause0, xEye, yEye, zEye, leftOnSphere, upOnSphere, Rcamera As Double ' переменные для камеры 
    Dim lPole As Single
    Dim BPol(), TPol(), RPol() As Double
    Dim xEye2, yEye2, zEye2, xTarget, yTarget, zTarget As Double

    Sub TraektoryOd()

        If Electron.Checked = True Then
            m = 9.10938291 * 10 ^ -31
            q = -1.60217657 * 10 ^ -19
        ElseIf Proton.Checked = True Then
            m = 1.67262178 * 10 ^ -27
            q = 1.60217657 * 10 ^ -19
        End If
        B = Val(NumericUpDown1.Value) * 10 ^ -5
        V = Val(NumericUpDown2.Value) * 10 ^ 5
        alpha = Val(NumericUpDown3.Value)
        alpha = (Math.PI * alpha) / 180

        Dim T, R, h As Double

        R = m * V * Math.Sin(alpha) / (q * B)
        T = 2 * Math.PI * m / (q * B)
        h = V * (1 - Math.Sin(alpha) ^ 2) * T

        Label1.Text = "T =" & StepFunc(T, 1) & "с"
        Label2.Text = "R =" & StepFunc(R, 2) & "м"
        Label3.Text = "h =" & StepFunc(h, 3) & "м"
        ' массив для траектории в однородном поле
        o = -1

        Dim a As Integer = 36  ' разбиение круга спирали на градусы 
        If Electron.Checked = True Then
            a = 216
        Else
            a = 36
        End If
        For i = 0 To 200
            o += 1
            ReDim Preserve x(o), y(o), z(o)
            y(o) = h / 50 * i
            a += 360 / 50
            x(o) = Math.Sin(Math.PI * a / 180) * R
            z(o) = Math.Cos(Math.PI * a / 180) * R
            If a = 360 Then a = -9
        Next
        ' конец
        GlControl1.Invalidate()
    End Sub

    Sub TraektoryNe()
        If Electron.Checked = True Then
            m = 9.10938291 * 10 ^ -31
            q = -1.60217657 * 10 ^ -19
        ElseIf Proton.Checked = True Then
            m = 1.67262178 * 10 ^ -27
            q = 1.60217657 * 10 ^ -19
        End If

        Bn = Val(NumericUpDown1.Value) * 10 ^ -5
        Vn = Val(NumericUpDown2.Value) * 10 ^ 5
        alphaN = Val(NumericUpDown3.Value)
        alphaN = Math.PI * alphaN / 180
        lPole = Val(NumericUpDown4.Value)
        Dim w, p, w0, time1, T, R, B1 As Double

        time1 = lPole / (Vn * Math.Cos(alphaN) * 1000)
        p = -Math.PI / 2 - Math.PI / 500
        o1 = -1
        For i = 0 To 2000

            p += Math.PI / 500
            w0 += w * time1
            B1 = Bn / (Math.Sin(p) + 2)
            T = 2 * Math.PI * m / (q * B1)
            w = 2 * Math.PI / T
            R = m * Vn * Math.Sin(alphaN) / (q * B1)
            o1 = o1 + 1
            ReDim Preserve xN(o1), yN(o1), zN(o1), BPol(o1), TPol(o1), RPol(o1)
            If i > 1000 Then
                xN(o1) = -Vn * Math.Cos(alphaN) * time1 * i + lPole * 3 / 2
            Else
                xN(o1) = Vn * Math.Cos(alphaN) * time1 * i - lPole / 2
            End If

            yN(o1) = R * Math.Cos(w0)
            zN(o1) = R * Math.Sin(w0)
            BPol(o1) = B1
            TPol(o1) = T
            RPol(o1) = R
        Next

        GlControl1.Invalidate()
    End Sub

    Sub Pole()
        If PoleType = 0 Then
            Dim xMax, zMax, xMin, zMin As Double

            For i = 0 To o
                If xMax < x(i) Then xMax = x(i)
                If zMax < z(i) Then zMax = z(i)
                If xMin > x(i) Then xMin = x(i)
                If zMin > z(i) Then zMin = z(i)
            Next
            Dim d As Single ' переменная для стрелок  
            d = Math.Abs(xMin * 1.5 + Math.Abs(xMin) * -1 - xMin * 1.5 + Math.Abs(xMin) * 0.25) / 5
            GL.Enable(EnableCap.LineStipple)
            GL.LineStipple(2, 127)
            GL.Begin(BeginMode.Lines)

            For k = -1 To 4 Step 1.25
                For i = -1 To 4 Step 1.25
                    GL.Vertex3(xMin * 1.5 + Math.Abs(xMin) * i, y(0), zMin * 1.5 + Math.Abs(zMin) * k)
                    GL.Vertex3(xMin * 1.5 + Math.Abs(xMin) * i, y(o), zMin * 1.5 + Math.Abs(zMin) * k)

                    GL.Vertex3(xMin * 1.5 + Math.Abs(xMin) * i, y(o) * 7 / 25, zMin * 1.5 + Math.Abs(zMin) * k)
                    GL.Vertex3(xMin * 1.5 + Math.Abs(xMin) * i, y(o) * 7 / 25 - d, zMin * 1.5 + Math.Abs(zMin) * k - d)

                    GL.Vertex3(xMin * 1.5 + Math.Abs(xMin) * i, y(o) * 16 / 25, zMin * 1.5 + Math.Abs(zMin) * k)
                    GL.Vertex3(xMin * 1.5 + Math.Abs(xMin) * i, y(o) * 16 / 25 - d, zMin * 1.5 + Math.Abs(zMin) * k - d)

                    GL.Vertex3(xMin * 1.5 + Math.Abs(xMin) * i, y(o) * 7 / 25, zMin * 1.5 + Math.Abs(zMin) * k)
                    GL.Vertex3(xMin * 1.5 + Math.Abs(xMin) * i, y(o) * 7 / 25 - d, zMin * 1.5 + Math.Abs(zMin) * k + d)

                    GL.Vertex3(xMin * 1.5 + Math.Abs(xMin) * i, y(o) * 16 / 25, zMin * 1.5 + Math.Abs(zMin) * k)
                    GL.Vertex3(xMin * 1.5 + Math.Abs(xMin) * i, y(o) * 16 / 25 - d, zMin * 1.5 + Math.Abs(zMin) * k + d)
                Next
            Next
            GL.End()
            GL.Disable(EnableCap.LineStipple)
        ElseIf PoleType = 1 Then
            GL.Enable(EnableCap.LineStipple)
            GL.LineStipple(2, 127)
            Dim rPole, k As Double
            For j = 0 To 2 * Math.PI Step Math.PI / 6
                GL.Begin(BeginMode.LineStrip)
                k = Math.PI / (-2) - Math.PI * 2 / 20
                For i = 0 To 20
                    k += Math.PI * 2 / 20
                    rPole = m * Vn * Math.Sin(alphaN) * (Math.Sin(k) + 2) / (q * Bn)
                    GL.Vertex3(i * lPole / 20 - lPole / 2, rPole * Math.Cos(j), rPole * Math.Sin(j))
                Next
                GL.End()
                GL.Begin(BeginMode.Lines)

                GL.Vertex3(0 - lPole / 2 + Math.Abs(rPole / 6), rPole * Math.Cos(j), rPole * Math.Sin(j))
                GL.Vertex3(0 - lPole / 2, rPole * Math.Cos(j) + rPole / 8, rPole * Math.Sin(j))
                GL.Vertex3(0 - lPole / 2 + Math.Abs(rPole / 6), rPole * Math.Cos(j), rPole * Math.Sin(j))
                GL.Vertex3(0 - lPole / 2, rPole * Math.Cos(j) - rPole / 8, rPole * Math.Sin(j))

                GL.Vertex3(lPole / 2, rPole * Math.Cos(j), rPole * Math.Sin(j))
                GL.Vertex3(lPole / 2 - Math.Abs(rPole / 6), rPole * Math.Cos(j) + rPole / 8, rPole * Math.Sin(j))
                GL.Vertex3(lPole / 2, rPole * Math.Cos(j), rPole * Math.Sin(j))
                GL.Vertex3(lPole / 2 - Math.Abs(rPole / 6), rPole * Math.Cos(j) - rPole / 8, rPole * Math.Sin(j))

                rPole = m * Vn * Math.Sin(alphaN) * (Math.Sin(Math.PI / 2) + 2) / (q * Bn)

                GL.Vertex3(-Math.Abs(rPole / 6), rPole * Math.Cos(j) + rPole / 24, rPole * Math.Sin(j))
                GL.Vertex3(0, rPole * Math.Cos(j), rPole * Math.Sin(j))
                GL.Vertex3(-Math.Abs(rPole / 6), rPole * Math.Cos(j) - rPole / 24, rPole * Math.Sin(j))
                GL.Vertex3(0, rPole * Math.Cos(j), rPole * Math.Sin(j))
                GL.End()
            Next

            GL.Disable(EnableCap.LineStipple)
        End If

    End Sub

    Private Sub GlControl1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GlControl1.Paint
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.Clear(ClearBufferMask.DepthBufferBit)

        Dim perspective As OpenTK.Matrix4 = OpenTK.Matrix4.CreatePerspectiveFieldOfView(1.04, 6 / 5, 1, 1000) 'Настройка  перспективы
        Dim lookat As OpenTK.Matrix4 = OpenTK.Matrix4.LookAt(xEye + xEye2, yEye + yEye2, zEye + zEye2, xTarget, yTarget, zTarget, 0, 1, 0) 'Насройка камеры 

        GL.MatrixMode(MatrixMode.Projection) 'Загрузка перспективы 
        GL.LoadIdentity()
        GL.LoadMatrix(perspective)
        GL.MatrixMode(MatrixMode.Modelview)
        GL.LoadIdentity()
        GL.LoadMatrix(lookat)
        GL.Viewport(0, 0, GlControl1.Width, GlControl1.Width)
        GL.Enable(EnableCap.DepthTest)
        GL.Enable(EnableCap.DepthClamp)
        GL.DepthFunc(DepthFunction.Less)
        GL.LineWidth(lineWidth)

        If Rcamera >= 650 Then
            GL.DepthRange(0, 0)
        Else
            GL.DepthRange(0, 1)
        End If

        If Settings.CheckBox3.Checked = True Then
            GL.Enable(EnableCap.LineSmooth)
            GL.Enable(EnableCap.PointSmooth)
            GL.Enable(EnableCap.PolygonSmooth)
        Else
            GL.Disable(EnableCap.LineSmooth)
            GL.Disable(EnableCap.PointSmooth)
            GL.Disable(EnableCap.PolygonSmooth)
        End If

        If Settings.CheckBox1.Checked = True Then
            Axis() ' рисуем оси 
        End If

        Dim col As Integer = 0
        Dim a As Integer = 1

        If PoleType = 0 Then
            ' траектория в однородном поле
            GL.LineWidth(lineWidth + 1)
            GL.Begin(BeginMode.LineStrip)
            GL.Color3(Color.LightSlateGray)
            For i = 0 To Tick1
                GL.Vertex3(x(i), y(i), z(i))
            Next
            GL.End()
            GL.LineWidth(lineWidth)
            ' Сфера
            GL.PushMatrix()
            GL.Translate(x(Tick1), y(Tick1), z(Tick1))
            For i = 0 To c - 12
                ' цвета сферы 
                If i > 109 Then
                    a = -1
                    If i Mod 11 = 0 Then
                        col = 80
                    End If
                Else
                    a = 1
                    If i Mod 11 = 0 Then
                        col = 30

                    End If
                End If
                ' сама сфера 
                GL.Begin(BeginMode.Quads)
                GL.Color3(Color.FromArgb(col, col, col))
                GL.Vertex3(xSphere(i), ySphere(i), zSphere(i))
                GL.Vertex3(xSphere(i + 11), ySphere(i + 11), zSphere(i + 11))
                GL.Vertex3(xSphere(i + 12), ySphere(i + 12), zSphere(i + 12))
                GL.Vertex3(xSphere(i + 1), ySphere(i + 1), zSphere(i + 1))
                col += a * 5
                GL.End()
            Next
            GL.PopMatrix()
        ElseIf PoleType = 1 Then

            'траектория в не однородном
            GL.LineWidth(lineWidth + 1)
            GL.Begin(BeginMode.LineStrip)
            GL.Color3(Color.LightSlateGray)
            ' проверка настроeк 
            If Settings.CheckBox5.Checked = False Then
                If tick2 > 1001 Then
                    For i = 1000 To tick2 - 1
                        GL.Vertex3(xN(i), yN(i), zN(i))
                    Next
                Else
                    For i = 1 To tick2 - 1
                        GL.Vertex3(xN(i), yN(i), zN(i))
                    Next
                End If
            Else
                For i = 1 To tick2 - 1
                    If i > 1000 Then
                        GL.Color3(Color.Aqua)
                    End If
                    GL.Vertex3(xN(i), yN(i), zN(i))
                Next
            End If


            ' выдаем значения 
            Label1.Text = "T = " & StepFunc(TPol(tick2), 1) & "с"
            Label2.Text = "R = " & StepFunc(RPol(tick2), 2) & "м"
            Label3.Text = "B = " & StepFunc(BPol(tick2), 3) & "Тл"
            GL.End()
            GL.LineWidth(lineWidth)
            ' сфера
            GL.PushMatrix()
            GL.Translate(xN(tick2), yN(tick2), zN(tick2))
            For i = 0 To c - 12
                ' цвета сферы 
                If i > 109 Then
                    a = -1
                    If i Mod 11 = 0 Then
                        col = 110
                    End If
                Else
                    a = 1
                    If i Mod 11 = 0 Then
                        col = 0
                    End If
                End If
                ' сама сфера
                GL.Begin(BeginMode.Quads)
                GL.Color3(Color.FromArgb(col, col, col))
                GL.Vertex3(xSphere(i), ySphere(i), zSphere(i))
                GL.Vertex3(xSphere(i + 11), ySphere(i + 11), zSphere(i + 11))
                GL.Vertex3(xSphere(i + 12), ySphere(i + 12), zSphere(i + 12))
                GL.Vertex3(xSphere(i + 1), ySphere(i + 1), zSphere(i + 1))
                col += a * 10
                GL.End()
            Next
            GL.PopMatrix()
        End If
        If Settings.CheckBox2.Checked = True Then
            Pole()
        End If
        GraphicsContext.CurrentContext.VSync = True
        GlControl1.SwapBuffers()
    End Sub

    Private Sub GlControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GlControl1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Middle Then
            leftOnSphere = leftOnSphere + (xMause0 - e.X) * Math.PI / 350
            upOnSphere = upOnSphere + (e.Y - yMause0) * Math.PI / 350
            ' формулы для расчета поворота камеры 
            xEye = Rcamera * Math.Sin(leftOnSphere) * Math.Cos(upOnSphere)
            yEye = Rcamera * Math.Sin(upOnSphere)
            zEye = Rcamera * Math.Cos(leftOnSphere) * Math.Cos(upOnSphere)
            If Timer1.Enabled = False Then
                GlControl1.Invalidate()
            End If
        End If
        Dim xEye1, yEye1, zEye1 As Double
        Dim xSdUp, ySdUp, zSdUp, tSdUp, xSdLeft, zSdLeft, tSdLeft As Single
        If e.Button = Windows.Forms.MouseButtons.Left Then

            tSdLeft = tSdLeft + (xMause0 - e.X) * 0.001
            tSdUp = tSdUp + (e.Y - yMause0) * 0.001
            ' шар вписаный в квадрат со сдвигом вверх 
            xEye1 = Rcamera * Math.Sqrt(2) * Math.Sin(leftOnSphere) * Math.Cos(upOnSphere + Math.PI / 4)
            yEye1 = Rcamera * Math.Sqrt(2) * Math.Sin(upOnSphere + Math.PI / 4)
            zEye1 = Rcamera * Math.Sqrt(2) * Math.Cos(leftOnSphere) * Math.Cos(upOnSphere + Math.PI / 4)
            ' ветор направленый вверх
            xSdUp = (xEye1 - xEye) * tSdUp
            ySdUp = (yEye1 - yEye) * tSdUp
            zSdUp = (zEye1 - zEye) * tSdUp
            ' шар вписаный в квадрат со сдвигом в бока 
            xEye1 = Rcamera * Math.Sqrt(2) * Math.Sin(leftOnSphere + Math.PI / 4) * Math.Cos(upOnSphere)
            zEye1 = Rcamera * Math.Sqrt(2) * Math.Cos(leftOnSphere + Math.PI / 4) * Math.Cos(upOnSphere)
            ' ветор направленый в бок
            xSdLeft = (xEye1 - xEye) * tSdLeft
            zSdLeft = (zEye1 - zEye) * tSdLeft

            xEye2 = xEye2 + xSdUp + xSdLeft
            zEye2 = zEye2 + zSdUp + zSdLeft
            yEye2 = yEye2 + ySdUp

            xTarget = xTarget + xSdUp + xSdLeft
            zTarget = zTarget + zSdUp + zSdLeft
            yTarget = yTarget + ySdUp

            If Timer1.Enabled = False Then
                GlControl1.Invalidate()
            End If
        End If

        xMause0 = e.X
        yMause0 = e.Y
        tSdLeft = 0
        tSdUp = 0
    End Sub

    Private Sub GlControl1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GlControl1.MouseWheel
        If e.Delta > 0 Then
            If Rcamera > 1 Then
                Rcamera = Rcamera - Rcamera / 80
            End If

        Else
            Rcamera = Rcamera + Rcamera / 80
        End If

        ' формулы для расчета поворота камеры 
        xEye = Rcamera * Math.Sin(leftOnSphere) * Math.Cos(upOnSphere)
        yEye = Rcamera * Math.Sin(upOnSphere)
        zEye = Rcamera * Math.Cos(leftOnSphere) * Math.Cos(upOnSphere)
        GlControl1.Invalidate()
    End Sub


    Function StepFunc(ByVal chislo As Double, ByVal lbl As Byte) As String
        Dim stepen As String
        stepen = Nothing
        chislo = Math.Abs(chislo)
        If chislo >= 1 And chislo < 10 Then
            StepFunc = Mid(chislo, 1, 4) & " "

        ElseIf chislo = 0 Then
            StepFunc = 0 & " "
        Else
            If chislo > 10 Then
                Do
                    chislo = chislo / 10
                    stepen = Str(Val(stepen) + 1)
                Loop Until chislo >= 1 And chislo < 10
            ElseIf chislo < 1 Then
                Do
                    chislo = chislo * 10
                    stepen = Str(Val(stepen) - 1)
                Loop Until chislo >= 1 And chislo < 10

            End If
            StepFunc = Mid(chislo, 1, 4)
            If stepen = -3 Then
                StepFunc = StepFunc & " м"
                stepen = Nothing
            ElseIf stepen = -6 Then
                StepFunc = StepFunc & " мк"
                stepen = Nothing
            ElseIf stepen = 3 Then
                StepFunc = StepFunc & " к"
                stepen = Nothing
            ElseIf stepen = 6 Then
                StepFunc = StepFunc & " М"
                stepen = Nothing
            ElseIf stepen = 1 Then
                StepFunc = StepFunc & "·10 "
                stepen = Nothing
            Else
                StepFunc = StepFunc & "·10    "
            End If
        End If
        If lbl = 1 Then
            Label14.Text = stepen
        ElseIf lbl = 2 Then
            Label15.Text = stepen
        Else
            Label16.Text = stepen
        End If

        Label14.Left = Label1.Left + Label1.Width - 35
        Label15.Left = Label2.Left + Label2.Width - 38
        If PoleType = 1 Then
            Label16.Left = Label3.Left + Label3.Width - 45
        Else
            Label16.Left = Label3.Left + Label3.Width - 38
        End If

    End Function

    Sub Axis()
        ' ось Z+
        GL.Begin(BeginMode.Lines)
        GL.Color3(Color.Green)
        GL.Vertex3(0, 0, 300)
        GL.Vertex3(0, 0, 0)
        GL.Vertex3(0, 0, 300)
        GL.Vertex3(0, -1, 292)
        GL.Vertex3(0, 0, 300)
        GL.Vertex3(0, 1, 292)
        ' ось Y+
        GL.Color3(Color.Blue)
        GL.Vertex3(0, 300, 0)
        GL.Vertex3(0, 0, 0)
        GL.Vertex3(1, 292, 0)
        GL.Vertex3(0, 300, 0)
        GL.Vertex3(-1, 292, 0)
        GL.Vertex3(0, 300, 0)
        ' ось X+
        GL.Color3(Color.Red)
        GL.Vertex3(300, 0, 0)
        GL.Vertex3(0, 0, 0)
        GL.Vertex3(292, -1, 0)
        GL.Vertex3(300, 0, 0)
        GL.Vertex3(292, 1, 0)
        GL.Vertex3(300, 0, 0)
        GL.End()

        GL.Enable(EnableCap.LineStipple)
        GL.LineStipple(2, 43690)

        GL.Begin(BeginMode.Lines)
        ' ось Z-
        GL.Color3(Color.Green)
        GL.Vertex3(0, 0, -300)
        GL.Vertex3(0, 0, 0)
        ' ось Y-
        GL.Color3(Color.Blue)
        GL.Vertex3(0, -300, 0)
        GL.Vertex3(0, 0, 0)
        ' ось X-
        GL.Color3(Color.Red)
        GL.Vertex3(-300, 0, 0)
        GL.Vertex3(0, 0, 0)
        GL.End()
        GL.Disable(EnableCap.LineStipple)
    End Sub

    Private Sub ModelFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If MenuFrm.Visible = False Then
            Application.Exit()
        End If
    End Sub

    Private Sub ModelFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' стартовые данные 
        ComboBox1.SelectedIndex = 0
        PoleType = 0
        TraektoryOd()
        Acsept.PerformClick()
        Rcamera = 10
        lineWidth = 1
        GL.ClearColor(Color.White)
        Me.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\BackGround.jpg")
        leftOnSphere = 0.78539816339744828
        upOnSphere = 0.78539816339744828
        If Me.WindowState <> MenuFrm.window Then
            MaximizedBtn.PerformClick()
        End If
        'подсчет позиции камеры 
        xEye = Rcamera * Math.Sin(leftOnSphere) * Math.Cos(upOnSphere)
        yEye = Rcamera * Math.Sin(upOnSphere)
        zEye = Rcamera * Math.Cos(leftOnSphere) * Math.Cos(upOnSphere)
        ' конец
        sphere()
    End Sub

    Sub sphere()
        Dim rs As Double
        If PoleType = 0 Then
            rs = Math.Sqrt(x(o) ^ 2 + z(o) ^ 2) / 5
        Else
            rs = Math.Abs(RPol(5)) / 5
        End If
        ' заполняем массив сферы
        c = -1
        For i = 0 To 2 * Math.PI Step Math.PI / 10
            For k = 0 To Math.PI Step Math.PI / 10
                c += 1
                xSphere(c) = rs * Math.Sin(i) * Math.Cos(k)
                ySphere(c) = rs * Math.Sin(i) * Math.Sin(k)
                zSphere(c) = rs * Math.Cos(i)
            Next
        Next
        GlControl1.Invalidate()
        ' конец
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If PoleType = 0 Then
            If Tick1 = o - 1 Then
                Timer1.Stop()
                Start.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\play.png")
            End If
            Tick1 += 1
        Else
            If tick2 = o1 - 1 Then
                Timer1.Stop()
                Start.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\play.png")
            End If
            tick2 += 1
        End If
        GlControl1.Invalidate()
    End Sub

    Private Sub Rety_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rety.Click
        Start.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\pause.png")
        If PoleType = 0 Then
            Tick1 = 0
        ElseIf PoleType = 1 Then
            tick2 = 0
        End If
        Timer1.Start()
    End Sub

    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        If Timer1.Enabled Then
            Start.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\play.png")
        Else
            Start.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\pause.png")
        End If
        If PoleType = 0 Then
            If Timer1.Enabled = False And Tick1 <> o Then
                Timer1.Start()
            ElseIf Timer1.Enabled = True Then
                Timer1.Stop()
            ElseIf (Timer1.Enabled = False And Tick1 = o) Then
                Rety.PerformClick()
            End If
        Else
            If Timer1.Enabled = False And tick2 <> o1 Then
                Timer1.Start()
            ElseIf Timer1.Enabled = True Then
                Timer1.Stop()
            ElseIf (Timer1.Enabled = False And tick2 = o1) Then
                Rety.PerformClick()
            End If
        End If
    End Sub

    Private Sub Acsept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Acsept.Click
        PoleType = ComboBox1.SelectedIndex
        TraektoryOd()
        TraektoryNe()
        Timer1.Stop()
        Tick1 = 0
        tick2 = 0
        Start.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\play.png")
        Label18.Visible = False
        If Settings.CheckBox4.Checked = True Then
            FocusBtn.PerformClick()
        End If
        GlControl1.Invalidate()
        If PoleType = 1 Then
            Label26.Text = "Магнітна індукція"
            Label26.Left = 29
        ElseIf PoleType = 0 Then
            Label26.Text = "Крок спіралі"
            Label26.Left = 52
        End If
        sphere()
    End Sub

    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub

    Private Sub MaximizedBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximizedBtn.Click
        If Me.WindowState = 0 Then
            Me.WindowState = FormWindowState.Maximized
            GlControl1.SetBounds(234, 58, Me.Width - 12 - 234, Me.Height - 12 - 58)
            MaximizedBtn.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\restore_window.png")
            MenuFrm.window = 2
            Label17.Left = GlControl1.Left + GlControl1.Width / 2 - Label17.Width / 2
        Else
            GlControl1.SetBounds(234, 58, 966, 680)
            Me.WindowState = FormWindowState.Normal
            MenuFrm.window = 0
            MaximizedBtn.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\maximize_window.png")
            Label17.Left = GlControl1.Left + GlControl1.Width / 2 - Label17.Width / 2
        End If
        GlControl1.Invalidate()
        ExitBtn.Left = Me.Size.Width - 47
        MaximizedBtn.Left = Me.Size.Width - 47 - 8 - 35
        MinimizedBtn.Left = Me.Size.Width - 47 - 8 - 35 - 8 - 35
        BackBtn.Left = Me.Size.Width - 47 - 8 - 35 - 8 - 35 - 8 - 57
    End Sub

    Private Sub MinimizedBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizedBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BackBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackBtn.Click
        MenuFrm.Show()
        If MenuFrm.window <> MenuFrm.WindowState Then
            MenuFrm.Button4.PerformClick()
        End If
        Me.Close()

    End Sub

    Private Sub FocusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FocusBtn.Click
        If PoleType = 0 Then
            leftOnSphere = 0.78539816339744828
            upOnSphere = 0.78539816339744828

            Rcamera = Math.Sqrt(x(o) ^ 2 + z(o) ^ 2) * 10

            If Rcamera < 3 Then
                Rcamera = 10
            End If
            xEye = Rcamera * Math.Sin(leftOnSphere) * Math.Cos(upOnSphere)
            yEye = Rcamera * Math.Sin(upOnSphere)
            zEye = Rcamera * Math.Cos(leftOnSphere) * Math.Cos(upOnSphere)

        Else
            leftOnSphere = 0.78539816339744828
            upOnSphere = 0.78539816339744828
            Rcamera = Math.Abs(RPol(o1 / 2) * 15)
            xEye = Rcamera * Math.Sin(leftOnSphere) * Math.Cos(upOnSphere)
            yEye = Rcamera * Math.Sin(upOnSphere)
            zEye = Rcamera * Math.Cos(leftOnSphere) * Math.Cos(upOnSphere)
        End If
        xEye2 = 0
        yEye2 = 0
        zEye2 = 0
        xTarget = 0
        zTarget = 0
        yTarget = 0
        GlControl1.Invalidate()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Label7.Visible = False
            Label12.Visible = False
            NumericUpDown4.Visible = False
            Label23.Visible = False
            Label19.Text = "Магнітна індукція"
            Label19.Left = 29
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label7.Visible = True
            Label12.Visible = True
            Label23.Visible = True
            NumericUpDown4.Visible = True
            Label19.Text = "Мін. магнітна індукція"
            Label19.Left = 14
        End If
        Label18.Visible = True
        GlControl1.Invalidate()
    End Sub

    Private Sub SettingsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsBtn.Click
        Settings.ShowDialog()
    End Sub

    Private Sub StopBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopBtn.Click
        Timer1.Stop()
        Tick1 = 0
        tick2 = 0
        GlControl1.Invalidate()
        Start.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\play.png")
    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        Label18.Visible = True
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Label18.Visible = True
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        Label18.Visible = True
    End Sub

    Private Sub NumericUpDown4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown4.ValueChanged
        Label18.Visible = True
    End Sub

    Private Sub Electron_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Electron.CheckedChanged
        Label18.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Info.ShowDialog()
    End Sub
End Class