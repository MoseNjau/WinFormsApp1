<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcoming_form
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
        Load_Object_demo = New Button()
        Exit_button = New Button()
        SuspendLayout()
        ' 
        ' Load_Object_demo
        ' 
        Load_Object_demo.Location = New Point(90, 223)
        Load_Object_demo.Name = "Load_Object_demo"
        Load_Object_demo.Size = New Size(138, 47)
        Load_Object_demo.TabIndex = 0
        Load_Object_demo.Text = "Load Object Demo"
        Load_Object_demo.UseVisualStyleBackColor = True
        ' 
        ' Exit_button
        ' 
        Exit_button.Location = New Point(578, 223)
        Exit_button.Name = "Exit_button"
        Exit_button.Size = New Size(75, 35)
        Exit_button.TabIndex = 1
        Exit_button.Text = "E&XIT"
        Exit_button.UseVisualStyleBackColor = True
        ' 
        ' Welcoming_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Exit_button)
        Controls.Add(Load_Object_demo)
        Name = "Welcoming_form"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Load_Object_demo As Button
    Friend WithEvents Exit_button As Button

End Class
