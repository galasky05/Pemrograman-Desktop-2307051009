Public Class Form1

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim nip As Long
        If Not Long.TryParse(txtNIP.Text, nip) Then
            MessageBox.Show("NIP harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim nama As String = txtNama.Text
        Dim fakultas As String = cmbFakultas.Text
        Dim jurusan As String = cmbJurusan.Text

        MessageBox.Show("Hai : " & nama & vbCrLf &
                        "NIP : " & nip & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

End Class
