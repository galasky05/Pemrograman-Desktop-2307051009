Public Class Form2

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles rbMin.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNilai1.TextChanged

    End Sub

    Private Sub txtNilai1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai1.KeyPress
        ' hanya menerima angka
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNilai2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim nilai1 As Integer = CInt(txtNilai1.Text)
        Dim nilai2 As Integer = CInt(txtNilai2.Text)
        Dim hasil As Integer

        If (rbKali.Checked) Then
            hasil = nilai1 * nilai2
        ElseIf (rbBagi.Checked) Then
            hasil = nilai1 / nilai2
        ElseIf (rbPlus.Checked) Then
            hasil = nilai1 + nilai2
        ElseIf (rbMin.Checked) Then
            hasil = nilai1 - nilai2
        End If
        txtHasil.Text = hasil
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtNilai1.Text = ""
        txtNilai2.Text = ""
        rbKali.Checked = False
        rbBagi.Checked = False
        rbPlus.Checked = False
        rbMin.Checked = False
        txtHasil.Text = ""
        txtNilai1.Focus()
    End Sub
End Class