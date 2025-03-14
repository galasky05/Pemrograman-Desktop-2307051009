Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFakultas.Items.Add("FMIPA")
        cmbFakultas.Items.Add("FKIP")
        cmbFakultas.Items.Add("FEB")
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        Dim nip As Long
        If Not Long.TryParse(txtNIP.Text.Trim(), nip) Then
            Exit Sub
        End If
        Dim nama As String = txtNama.Text.Trim()
        Dim fakultas As String = cmbFakultas.Text.Trim()
        Dim jurusan As String = cmbJurusan.Text.Trim()
        Dim tugas As Double = Double.Parse(txtTugas.Text)
        Dim uts As Double = Double.Parse(txtUTS.Text)
        Dim uas As Double = Double.Parse(txtUAS.Text)
        Dim total As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)

        Dim grade As String
        Select Case total
            Case Is >= 78
                grade = "A"
            Case Is >= 65
                grade = "B"
            Case Is >= 50
                grade = "C"
            Case Is >= 40
                grade = "D"
            Case Else
                grade = "E"
        End Select

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
                        "Jenis Kelamin : " & jenisKelamin & vbCrLf &
                        "Nilai Akhir: " & total.ToString("F2") & vbCrLf &
                        "GRADE: " & grade,
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


    Private Sub cmbFakultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFakultas.SelectedIndexChanged
        Dim fakultas As String = cmbFakultas.SelectedItem
        cmbJurusan.Items.Clear()
        Select Case (fakultas)
            Case "FMIPA"
                cmbJurusan.Items.Add("Sistem Informasi")
                cmbJurusan.Items.Add("Manajemen Informatika")
                cmbJurusan.Items.Add("Ilmu Komputer")
            Case "FKIP"
                cmbJurusan.Items.Add("Pendidikan Teknologi Informasi")
                cmbJurusan.Items.Add("Pendidikan Jasmani")
            Case "FEB"
                cmbJurusan.Items.Add("Manajemen")
                cmbJurusan.Items.Add("Perbankan")
                cmbJurusan.Items.Add("Akuntansi")
        End Select

    End Sub

    
    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        txtNIP.Clear()
        txtNama.Clear()
        txtTugas.Clear()
        txtUTS.Clear()
        txtUAS.Clear()

        ' Mengosongkan ComboBox
        cmbFakultas.SelectedIndex = -1
        cmbJurusan.Items.Clear()
        cmbJurusan.Text = ""

        ' Menghapus pilihan RadioButton
        rbL.Checked = False
        rbP.Checked = False

        ' Fokus kembali ke NIP untuk kemudahan input baru
        txtNIP.Focus()

    End Sub
End Class
  
