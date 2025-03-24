Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbJurusan.Items.Add("Manajemen Informatika")
        cmbJurusan.Items.Add("Ilmu Komputer")
        cmbJurusan.Items.Add("Sistem Informasi")
    End Sub

    Private Sub cmbJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJurusan.SelectedIndexChanged
        Dim jurusan As String = cmbJurusan.SelectedItem
        cmbMatkul.Items.Clear()
        Select Case (jurusan)
            Case "Manajemen Informatika"
                cmbMatkul.Items.Add("Pemrograman Desktop")
                cmbMatkul.Items.Add("Pemrograman WEB Lanjut")
                cmbMatkul.Items.Add("Keamanan Sistem Informasi")
            Case "Ilmu Komputer"
                cmbMatkul.Items.Add("Kecerdasan Buatan")
                cmbMatkul.Items.Add("Aljabar Linear")
                cmbMatkul.Items.Add("Matematika Diskrit")
            Case "Sistem Informasi"
                cmbMatkul.Items.Add("Pemrograman Web")
                cmbMatkul.Items.Add("PBO")
                cmbMatkul.Items.Add("Dasar-Dasar Pemrograman")
        End Select
    End Sub

    Private Sub txtNIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIP.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub UpdateGrade()
        Dim tugas, uts, uas As Double
        If Double.TryParse(txtTugas.Text, tugas) AndAlso Double.TryParse(txtUTS.Text, uts) AndAlso Double.TryParse(txtUAS.Text, uas) Then
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

            lblGrade.Text = " " & grade
        Else
            lblGrade.Text = " -GRADE- "
        End If
    End Sub

    Private Sub txtTugas_TextChanged(sender As Object, e As EventArgs) Handles txtTugas.TextChanged
        UpdateGrade()
    End Sub

    Private Sub txtUTS_TextChanged(sender As Object, e As EventArgs) Handles txtUTS.TextChanged
        UpdateGrade()
    End Sub

    Private Sub txtUAS_TextChanged(sender As Object, e As EventArgs) Handles txtUAS.TextChanged
        UpdateGrade()
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtNIP.Clear()
        txtNama.Clear()
        cmbMatkul.Items.Clear()
        cmbMatkul.Text = ""
        cmbJurusan.SelectedIndex = -1
        cmbMatkul.SelectedIndex = -1
        txtTugas.Clear()
        txtUTS.Clear()
        txtUAS.Clear()
        lblGrade.Text = " -GRADE- "
        txtNIP.Enabled = True
        txtNIP.Focus()
        rbL.Checked = False
        rbP.Checked = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtNIP.Text = "" Or txtNama.Text = "" Or cmbMatkul.Text = "" Or (Not rbL.Checked And Not rbP.Checked) Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim rowIndex As Integer = -1
        For Each row As DataGridViewRow In dgvdata.Rows
            If row.Cells("dgnip").Value IsNot Nothing AndAlso row.Cells("dgnip").Value.ToString() = txtNIP.Text Then
                rowIndex = row.Index
                Exit For
            End If
        Next

        If rowIndex = -1 Then
            dgvdata.Rows.Add(txtNIP.Text, txtNama.Text, If(rbL.Checked, "Laki-Laki", "Perempuan"), cmbJurusan.Text, cmbMatkul.Text, lblGrade.Text)
        Else
            dgvdata.Rows(rowIndex).Cells("dgnip").Value = txtNIP.Text
            dgvdata.Rows(rowIndex).Cells("dgnama").Value = txtNama.Text
            dgvdata.Rows(rowIndex).Cells("dgjeniskelamin").Value = If(rbL.Checked, "Laki-Laki", "Perempuan")
            dgvdata.Rows(rowIndex).Cells("dgjurusan").Value = cmbJurusan.Text
            dgvdata.Rows(rowIndex).Cells("dgmatkul").Value = cmbMatkul.Text
            dgvdata.Rows(rowIndex).Cells("dggrade").Value = lblGrade.Text
        End If
        btnNew.PerformClick()
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvdata.SelectedRows.Count > 0 Then
            Dim confirm As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                dgvdata.Rows.RemoveAt(dgvdata.SelectedRows(0).Index)
                btnNew.PerformClick()
            End If
        Else
            MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvdata_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdata.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = dgvdata.Rows(e.RowIndex)

            txtNIP.Text = row.Cells("dgnip").Value.ToString()
            txtNama.Text = row.Cells("dgnama").Value.ToString()

            If row.Cells("dgjeniskelamin").Value.ToString() = "Laki-Laki" Then
                rbL.Checked = True
            Else
                rbP.Checked = True
            End If

            cmbJurusan.Text = row.Cells("dgjurusan").Value.ToString()
            cmbMatkul.Text = row.Cells("dgmatkul").Value.ToString()
            lblGrade.Text = row.Cells("dggrade").Value.ToString()

            'disable nip saat klik dua kali pada data grid view
            txtNIP.Enabled = False
        End If
    End Sub

End Class