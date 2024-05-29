<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        Button2 = New Button()
        CheckBox2 = New CheckBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Aquamarine
        Label1.Location = New Point(138, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 26)
        Label1.TabIndex = 0
        Label1.Text = "Username -"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Aquamarine
        Label2.Location = New Point(138, 258)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 26)
        Label2.TabIndex = 1
        Label2.Text = "Password -"
        ' 
        ' txtUser
        ' 
        txtUser.Cursor = Cursors.IBeam
        txtUser.Location = New Point(297, 183)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(209, 31)
        txtUser.TabIndex = 2
        ' 
        ' txtPass
        ' 
        txtPass.BackColor = SystemColors.Window
        txtPass.Cursor = Cursors.IBeam
        txtPass.Font = New Font("Segoe UI Variable Text", 9F)
        txtPass.ForeColor = Color.Black
        txtPass.Location = New Point(297, 257)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(209, 31)
        txtPass.TabIndex = 3
        txtPass.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.RoyalBlue
        Button1.Location = New Point(347, 343)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 36)
        Button1.TabIndex = 4
        Button1.Text = "Sign IN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = SystemColors.ActiveCaptionText
        CheckBox1.Location = New Point(297, 294)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(148, 25)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "I Am Not Robot"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.Fuchsia
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("MV Boli", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(589, 71)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 36)
        Button2.TabIndex = 7
        Button2.Text = "Sign Up"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Transparent
        CheckBox2.Cursor = Cursors.Hand
        CheckBox2.Location = New Point(524, 257)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(82, 29)
        CheckBox2.TabIndex = 8
        CheckBox2.Text = "Show"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("Monotype Corsiva", 12F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(188, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(397, 28)
        Label3.TabIndex = 9
        Label3.Text = "Welcome to Library Management System"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.Black
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(781, 450)
        Controls.Add(Label3)
        Controls.Add(CheckBox2)
        Controls.Add(Button2)
        Controls.Add(CheckBox1)
        Controls.Add(Button1)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.Red
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Log-In "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label

End Class
