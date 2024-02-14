Public Class Object_Demonstration
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Tahoma.CheckedChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles Font_color.Enter

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles Green.CheckedChanged
        Sample_test.ForeColor = Color.Green
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles Red.CheckedChanged
        Sample_test.ForeColor = Color.Red
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles Blue.CheckedChanged
        Sample_test.ForeColor = Color.Blue
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Italic.CheckedChanged
        If Italic.Checked Then
            Sample_test.Font = New Font(Sample_test.Font, Sample_test.Font.Style Or FontStyle.Italic)
        Else
            Sample_test.Font = New Font(Sample_test.Font, Sample_test.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles Bold_Italic.CheckedChanged
        If Bold_Italic.Checked Then
            Sample_test.Font = New Font(Sample_test.Font, Sample_test.Font.Style Or FontStyle.Bold Or FontStyle.Italic)
        Else
            Sample_test.Font = New Font(Sample_test.Font, Sample_test.Font.Style And Not (FontStyle.Bold Or FontStyle.Italic))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Load_picture.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files|*.jpg;*.png;*.gif|All files|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFileName As String = openFileDialog.FileName

            ' Check if the selected file is an image file
            If System.IO.Path.GetExtension(selectedFileName).ToLower() = ".jpg" _
            Or System.IO.Path.GetExtension(selectedFileName).ToLower() = ".png" _
            Or System.IO.Path.GetExtension(selectedFileName).ToLower() = ".gif" Then

                PictureBox1.ImageLocation = selectedFileName
            Else
                MessageBox.Show("Please select a valid image file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles Display_test.Enter

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Magneto.CheckedChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles Exit_button.Click
        Welcoming_form.Show()
        Me.Close()
    End Sub
End Class