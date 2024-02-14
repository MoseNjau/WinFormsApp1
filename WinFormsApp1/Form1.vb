Public Class Welcoming_form
    ' Create a ToolTip instance
    Private WithEvents toolTipButtons As New ToolTip()

    Private Sub Load_Object_demo_Click(sender As Object, e As EventArgs) Handles Load_Object_demo.Click
        Object_Demonstration.Show()
    End Sub

    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles Exit_button.Click
        Me.Close()
    End Sub

    Private Sub Welcoming_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add your initialization code here if needed

        ' Set tooltips for buttons
        toolTipButtons.SetToolTip(Load_Object_demo, "Load Object Demonstrations Form")
        toolTipButtons.SetToolTip(Exit_button, "Exit Application")
    End Sub

    Private Sub Welcoming_form_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' Maximize the form
        Me.WindowState = FormWindowState.Maximized

        ' Change background color to RED
        Me.BackColor = Color.Red
    End Sub
End Class
