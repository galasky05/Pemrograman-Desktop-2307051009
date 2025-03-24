Public Class Form2

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        ' membersihkan semua textfield dillayar
        txtNIP.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""

        ' membesihkan selection pada data grid
        DataGridView1.ClearSelection()
        ' membuat kursor kembali ke posisi txtNIP
        txtNIP.Focus()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' jika datagrid ada yang dipilih maka
        If (DataGridView1.SelectedRows().Count > 0) Then
            ' buat variable baru yaitu baris yang dipilih
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            selectedRow.Cells(0).Value = txtNIP.Text
            selectedRow.Cells(1).Value = txtNama.Text
            selectedRow.Cells(2).Value = txtAlamat.Text

            DataGridView1.Refresh()
        Else
            DataGridView1.Rows.Add(txtNIP.Text, txtNama.Text, txtAlamat.Text)

            btnNew.PerformClick()
        End If
        ' menambahkan data pada masing-masing
        ' text field ke dalam data grideview


    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        DataGridView1.Rows(e.RowIndex).Selected = True
        txtNIP.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        txtNama.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
        txtAlamat.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim res As DialogResult = MessageBox.Show("Apakah anda yakin ingin meghapus data dengan NIP " +
                        selectedRow.Cells(0).Value + " ?",
                        "Konfirmasi",
            MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If (res = Windows.Forms.DialogResult.Yes) Then
            DataGridView1.Rows.Remove(selectedRow)
        End If

    End Sub
End Class
