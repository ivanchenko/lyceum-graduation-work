<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModelFrm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModelFrm))
        Me.Electron = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Proton = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Acsept = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.MaximizedBtn = New System.Windows.Forms.Button()
        Me.MinimizedBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.Rety = New System.Windows.Forms.Button()
        Me.FocusBtn = New System.Windows.Forms.Button()
        Me.StopBtn = New System.Windows.Forms.Button()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GlControl1 = New OpenTK.GLControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Electron
        '
        Me.Electron.AutoSize = True
        Me.Electron.Checked = True
        Me.Electron.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Electron.Location = New System.Drawing.Point(6, 89)
        Me.Electron.Name = "Electron"
        Me.Electron.Size = New System.Drawing.Size(112, 27)
        Me.Electron.TabIndex = 42
        Me.Electron.TabStop = True
        Me.Electron.Text = "Електрон"
        Me.Electron.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Electron)
        Me.GroupBox1.Controls.Add(Me.Proton)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Acsept)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 414)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Вихідні дані"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Georgia", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label23.Location = New System.Drawing.Point(46, 319)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(123, 20)
        Me.Label23.TabIndex = 70
        Me.Label23.Text = "Довжина поля"
        Me.Label23.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label22.Location = New System.Drawing.Point(146, 265)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(23, 21)
        Me.Label22.TabIndex = 69
        Me.Label22.Text = "Ʋ"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Georgia", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label21.Location = New System.Drawing.Point(41, 266)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(113, 20)
        Me.Label21.TabIndex = 68
        Me.Label21.Text = "Кут між B та "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Georgia", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label20.Location = New System.Drawing.Point(19, 214)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(177, 20)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "Швидкість частинки"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Georgia", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 159)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(187, 20)
        Me.Label19.TabIndex = 66
        Me.Label19.Text = "Мін магнітна індукція"
        '
        'Proton
        '
        Me.Proton.AutoSize = True
        Me.Proton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Proton.Location = New System.Drawing.Point(6, 122)
        Me.Proton.Name = "Proton"
        Me.Proton.Size = New System.Drawing.Size(95, 27)
        Me.Proton.TabIndex = 43
        Me.Proton.Text = "Протон"
        Me.Proton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Однорідне поле", "Неоднорідне поле"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(191, 31)
        Me.ComboBox1.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Вибір виду поля")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(147, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 21)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "B ="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(143, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 15)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "-5"
        '
        'Acsept
        '
        Me.Acsept.BackColor = System.Drawing.Color.Transparent
        Me.Acsept.BackgroundImage = CType(resources.GetObject("Acsept.BackgroundImage"), System.Drawing.Image)
        Me.Acsept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Acsept.Location = New System.Drawing.Point(78, 374)
        Me.Acsept.Name = "Acsept"
        Me.Acsept.Size = New System.Drawing.Size(58, 35)
        Me.Acsept.TabIndex = 15
        Me.Acsept.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.Acsept, "Прийняти зміни")
        Me.Acsept.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(117, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 21)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "∙10    м/с"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.Location = New System.Drawing.Point(117, 185)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 21)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "∙10    Тл"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(117, 347)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 21)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "м"
        Me.Label12.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(56, 182)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDown1.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.NumericUpDown1, "Сила магн. індукції")
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(117, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "°"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(56, 237)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDown2.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.NumericUpDown2, "Швидкість")
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 21)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "l ="
        Me.Label7.Visible = False
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NumericUpDown3.Location = New System.Drawing.Point(56, 290)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDown3.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.NumericUpDown3, "Кут нахилу")
        Me.NumericUpDown3.Value = New Decimal(New Integer() {70, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 21)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "α ="
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NumericUpDown4.Location = New System.Drawing.Point(56, 342)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDown4.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.NumericUpDown4, "Довжина поля")
        Me.NumericUpDown4.Value = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 21)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Ʋ ="
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label18.Location = New System.Drawing.Point(131, 374)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 21)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "*"
        Me.Label18.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.Location = New System.Drawing.Point(111, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(10, 15)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = " "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.Location = New System.Drawing.Point(108, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 15)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = " "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.Location = New System.Drawing.Point(503, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(429, 24)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Моделювання руху часток в магнітному полі"
        '
        'BackBtn
        '
        Me.BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.Location = New System.Drawing.Point(1014, 12)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(57, 35)
        Me.BackBtn.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.BackBtn, "До головного меню")
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'MaximizedBtn
        '
        Me.MaximizedBtn.BackColor = System.Drawing.Color.Transparent
        Me.MaximizedBtn.BackgroundImage = CType(resources.GetObject("MaximizedBtn.BackgroundImage"), System.Drawing.Image)
        Me.MaximizedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MaximizedBtn.Location = New System.Drawing.Point(1122, 12)
        Me.MaximizedBtn.Name = "MaximizedBtn"
        Me.MaximizedBtn.Size = New System.Drawing.Size(35, 35)
        Me.MaximizedBtn.TabIndex = 57
        Me.MaximizedBtn.Tag = "1"
        Me.ToolTip1.SetToolTip(Me.MaximizedBtn, "На весь екран")
        Me.MaximizedBtn.UseVisualStyleBackColor = False
        '
        'MinimizedBtn
        '
        Me.MinimizedBtn.BackColor = System.Drawing.Color.Transparent
        Me.MinimizedBtn.BackgroundImage = CType(resources.GetObject("MinimizedBtn.BackgroundImage"), System.Drawing.Image)
        Me.MinimizedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MinimizedBtn.Location = New System.Drawing.Point(1079, 12)
        Me.MinimizedBtn.Name = "MinimizedBtn"
        Me.MinimizedBtn.Size = New System.Drawing.Size(35, 35)
        Me.MinimizedBtn.TabIndex = 58
        Me.MinimizedBtn.Text = " "
        Me.ToolTip1.SetToolTip(Me.MinimizedBtn, "Згорнути")
        Me.MinimizedBtn.UseVisualStyleBackColor = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.BackgroundImage = CType(resources.GetObject("ExitBtn.BackgroundImage"), System.Drawing.Image)
        Me.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitBtn.Location = New System.Drawing.Point(1165, 12)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(35, 35)
        Me.ExitBtn.TabIndex = 56
        Me.ExitBtn.Text = " "
        Me.ToolTip1.SetToolTip(Me.ExitBtn, "Вихід")
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Transparent
        Me.Start.BackgroundImage = CType(resources.GetObject("Start.BackgroundImage"), System.Drawing.Image)
        Me.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Start.Location = New System.Drawing.Point(28, 662)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(58, 35)
        Me.Start.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Start, "Старт / Пауза")
        Me.Start.UseVisualStyleBackColor = False
        '
        'Rety
        '
        Me.Rety.BackColor = System.Drawing.Color.Transparent
        Me.Rety.BackgroundImage = CType(resources.GetObject("Rety.BackgroundImage"), System.Drawing.Image)
        Me.Rety.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Rety.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Rety.Location = New System.Drawing.Point(28, 703)
        Me.Rety.Name = "Rety"
        Me.Rety.Size = New System.Drawing.Size(58, 35)
        Me.Rety.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.Rety, "Повторити")
        Me.Rety.UseVisualStyleBackColor = False
        '
        'FocusBtn
        '
        Me.FocusBtn.BackgroundImage = CType(resources.GetObject("FocusBtn.BackgroundImage"), System.Drawing.Image)
        Me.FocusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FocusBtn.Location = New System.Drawing.Point(139, 703)
        Me.FocusBtn.Name = "FocusBtn"
        Me.FocusBtn.Size = New System.Drawing.Size(58, 35)
        Me.FocusBtn.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.FocusBtn, "Фокус")
        Me.FocusBtn.UseVisualStyleBackColor = True
        '
        'StopBtn
        '
        Me.StopBtn.BackgroundImage = CType(resources.GetObject("StopBtn.BackgroundImage"), System.Drawing.Image)
        Me.StopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StopBtn.Location = New System.Drawing.Point(139, 663)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.Size = New System.Drawing.Size(58, 35)
        Me.StopBtn.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.StopBtn, "Зупинити")
        Me.StopBtn.UseVisualStyleBackColor = True
        '
        'SettingsBtn
        '
        Me.SettingsBtn.BackColor = System.Drawing.Color.Transparent
        Me.SettingsBtn.BackgroundImage = CType(resources.GetObject("SettingsBtn.BackgroundImage"), System.Drawing.Image)
        Me.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SettingsBtn.Location = New System.Drawing.Point(234, 10)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(35, 35)
        Me.SettingsBtn.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.SettingsBtn, "Налаштування")
        Me.SettingsBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(277, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.Button2, "Довідка")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.Location = New System.Drawing.Point(108, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 15)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = " "
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "h ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "R ="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "T ="
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 473)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 183)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Отримані результати"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Georgia", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label26.Location = New System.Drawing.Point(52, 130)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(111, 20)
        Me.Label26.TabIndex = 73
        Me.Label26.Text = "Крок спіралі"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Georgia", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label25.Location = New System.Drawing.Point(57, 81)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 20)
        Me.Label25.TabIndex = 72
        Me.Label25.Text = "Радіус кола"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Georgia", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label24.Location = New System.Drawing.Point(31, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(152, 20)
        Me.Label24.TabIndex = 71
        Me.Label24.Text = "Період обертання"
        '
        'GlControl1
        '
        Me.GlControl1.BackColor = System.Drawing.Color.White
        Me.GlControl1.Location = New System.Drawing.Point(234, 53)
        Me.GlControl1.Name = "GlControl1"
        Me.GlControl1.Size = New System.Drawing.Size(966, 685)
        Me.GlControl1.TabIndex = 65
        Me.GlControl1.VSync = False
        '
        'ModelFrm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1212, 750)
        Me.Controls.Add(Me.GlControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.FocusBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.MaximizedBtn)
        Me.Controls.Add(Me.MinimizedBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Rety)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StopBtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModelFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModelFrm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Electron As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Proton As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Acsept As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BackBtn As System.Windows.Forms.Button
    Friend WithEvents MaximizedBtn As System.Windows.Forms.Button
    Friend WithEvents MinimizedBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Rety As System.Windows.Forms.Button
    Friend WithEvents SettingsBtn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FocusBtn As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents StopBtn As System.Windows.Forms.Button
    Friend WithEvents GlControl1 As OpenTK.GLControl
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
