<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Object_Demonstration
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
        Font = New GroupBox()
        Tahoma = New RadioButton()
        Magneto = New RadioButton()
        Garamond = New RadioButton()
        Display_test = New GroupBox()
        Sample_test = New TextBox()
        Font_color = New GroupBox()
        Red = New RadioButton()
        Blue = New RadioButton()
        Green = New RadioButton()
        Font_style = New GroupBox()
        Bold_Italic = New CheckBox()
        Bold = New CheckBox()
        Italic = New CheckBox()
        PictureBox1 = New PictureBox()
        Load_picture = New Button()
        Exit_button = New Button()
        Font.SuspendLayout()
        Display_test.SuspendLayout()
        Font_color.SuspendLayout()
        Font_style.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Font
        ' 
        Font.Controls.Add(Tahoma)
        Font.Controls.Add(Magneto)
        Font.Controls.Add(Garamond)
        Font.Location = New Point(380, 12)
        Font.Name = "Font"
        Font.Size = New Size(368, 76)
        Font.TabIndex = 0
        Font.TabStop = False
        Font.Text = "Font"
        ' 
        ' Tahoma
        ' 
        Tahoma.AutoSize = True
        Tahoma.Location = New Point(265, 39)
        Tahoma.Name = "Tahoma"
        Tahoma.Size = New Size(67, 19)
        Tahoma.TabIndex = 3
        Tahoma.TabStop = True
        Tahoma.Text = "Tahoma"
        Tahoma.UseVisualStyleBackColor = True
        ' 
        ' Magneto
        ' 
        Magneto.AutoSize = True
        Magneto.Location = New Point(131, 39)
        Magneto.Name = "Magneto"
        Magneto.Size = New Size(73, 19)
        Magneto.TabIndex = 2
        Magneto.TabStop = True
        Magneto.Text = "Magneto"
        Magneto.UseVisualStyleBackColor = True
        ' 
        ' Garamond
        ' 
        Garamond.AutoSize = True
        Garamond.Location = New Point(6, 39)
        Garamond.Name = "Garamond"
        Garamond.Size = New Size(81, 19)
        Garamond.TabIndex = 1
        Garamond.TabStop = True
        Garamond.Text = "Garamond"
        Garamond.UseVisualStyleBackColor = True
        ' 
        ' Display_test
        ' 
        Display_test.Controls.Add(Sample_test)
        Display_test.Location = New Point(66, 12)
        Display_test.Name = "Display_test"
        Display_test.Size = New Size(200, 76)
        Display_test.TabIndex = 1
        Display_test.TabStop = False
        Display_test.Text = "Display Text"
        ' 
        ' Sample_test
        ' 
        Sample_test.Location = New Point(26, 35)
        Sample_test.Name = "Sample_test"
        Sample_test.Size = New Size(110, 23)
        Sample_test.TabIndex = 2
        Sample_test.Text = "Sample Test"
        ' 
        ' Font_color
        ' 
        Font_color.Controls.Add(Red)
        Font_color.Controls.Add(Blue)
        Font_color.Controls.Add(Green)
        Font_color.Location = New Point(613, 113)
        Font_color.Name = "Font_color"
        Font_color.Size = New Size(135, 233)
        Font_color.TabIndex = 2
        Font_color.TabStop = False
        Font_color.Text = "Font Color"
        ' 
        ' Red
        ' 
        Red.AutoSize = True
        Red.Location = New Point(18, 175)
        Red.Name = "Red"
        Red.Size = New Size(45, 19)
        Red.TabIndex = 2
        Red.TabStop = True
        Red.Text = "&Red"
        Red.UseVisualStyleBackColor = True
        ' 
        ' Blue
        ' 
        Blue.AutoSize = True
        Blue.Location = New Point(18, 106)
        Blue.Name = "Blue"
        Blue.Size = New Size(48, 19)
        Blue.TabIndex = 1
        Blue.TabStop = True
        Blue.Text = "&Blue"
        Blue.UseVisualStyleBackColor = True
        ' 
        ' Green
        ' 
        Green.AutoSize = True
        Green.Location = New Point(18, 38)
        Green.Name = "Green"
        Green.Size = New Size(56, 19)
        Green.TabIndex = 0
        Green.TabStop = True
        Green.Text = "&Green"
        Green.UseVisualStyleBackColor = True
        ' 
        ' Font_style
        ' 
        Font_style.Controls.Add(Bold_Italic)
        Font_style.Controls.Add(Bold)
        Font_style.Controls.Add(Italic)
        Font_style.Location = New Point(409, 113)
        Font_style.Name = "Font_style"
        Font_style.Size = New Size(151, 233)
        Font_style.TabIndex = 3
        Font_style.TabStop = False
        Font_style.Text = "Font Style"
        ' 
        ' Bold_Italic
        ' 
        Bold_Italic.AutoSize = True
        Bold_Italic.Font = New Font("Constantia", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Bold_Italic.Location = New Point(22, 175)
        Bold_Italic.Name = "Bold_Italic"
        Bold_Italic.Size = New Size(89, 19)
        Bold_Italic.TabIndex = 2
        Bold_Italic.Text = "Bold Italic"
        Bold_Italic.UseVisualStyleBackColor = True
        ' 
        ' Bold
        ' 
        Bold.AutoSize = True
        Bold.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bold.Location = New Point(22, 106)
        Bold.Name = "Bold"
        Bold.Size = New Size(55, 21)
        Bold.TabIndex = 1
        Bold.Text = "Bold"
        Bold.UseVisualStyleBackColor = True
        ' 
        ' Italic
        ' 
        Italic.AutoSize = True
        Italic.Location = New Point(22, 38)
        Italic.Name = "Italic"
        Italic.Size = New Size(51, 19)
        Italic.TabIndex = 0
        Italic.Text = "Italic"
        Italic.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(66, 113)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(267, 233)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Load_picture
        ' 
        Load_picture.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Load_picture.Location = New Point(104, 377)
        Load_picture.Name = "Load_picture"
        Load_picture.Size = New Size(109, 38)
        Load_picture.TabIndex = 7
        Load_picture.Text = "&Load Picture"
        Load_picture.UseVisualStyleBackColor = True
        ' 
        ' Exit_button
        ' 
        Exit_button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Exit_button.Location = New Point(637, 377)
        Exit_button.Name = "Exit_button"
        Exit_button.Size = New Size(75, 38)
        Exit_button.TabIndex = 8
        Exit_button.Text = "E&xit"
        Exit_button.UseVisualStyleBackColor = True
        ' 
        ' Object_Demonstration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Exit_button)
        Controls.Add(Load_picture)
        Controls.Add(PictureBox1)
        Controls.Add(Font_style)
        Controls.Add(Font_color)
        Controls.Add(Display_test)
        Controls.Add(Font)
        Name = "Object_Demonstration"
        RightToLeftLayout = True
        Text = "Object Demonstration"
        Font.ResumeLayout(False)
        Font.PerformLayout()
        Display_test.ResumeLayout(False)
        Display_test.PerformLayout()
        Font_color.ResumeLayout(False)
        Font_color.PerformLayout()
        Font_style.ResumeLayout(False)
        Font_style.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Font As GroupBox
    Friend WithEvents Tahoma As RadioButton
    Friend WithEvents Magneto As RadioButton
    Friend WithEvents Garamond As RadioButton
    Friend WithEvents Display_test As GroupBox
    Friend WithEvents Sample_test As TextBox
    Friend WithEvents Font_color As GroupBox
    Friend WithEvents Red As RadioButton
    Friend WithEvents Blue As RadioButton
    Friend WithEvents Green As RadioButton
    Friend WithEvents Font_style As GroupBox
    Friend WithEvents Bold_Italic As CheckBox
    Friend WithEvents Bold As CheckBox
    Friend WithEvents Italic As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Load_picture As Button
    Friend WithEvents Exit_button As Button
End Class
