Public Class Form1

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        Dim nip As Long
        If Not Long.TryParse(txtNIP.Text.Trim(), nip) Then
            Exit Sub
        End If
        Dim nama As String = txtNama.Text.Trim()
        Dim fakultas As String = cmbFakultas.Text.Trim()
        Dim jurusan As String = cmbJurusan.Text.Trim()

        Dim jenisKelamin As String = ""
        If rbL.Checked Then
            jenisKelamin = "Laki-Laki"
        ElseIf rbP.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Silakan pilih jenis kelamin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        MessageBox.Show("Hai : " & nama & vbCrLf &
                        "NIP : " & nip & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan & vbCrLf &
                        "Jenis Kelamin : " & jenisKelamin,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub txtnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIP.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNIP_TextChanged(sender As Object, e As EventArgs) Handles txtNIP.TextChanged

    End Sub
End Class
  
