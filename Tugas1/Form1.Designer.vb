<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.cmbMatkul = New System.Windows.Forms.ComboBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.uts = New System.Windows.Forms.Label()
        Me.uas = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.dgnip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgnama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgmatkul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dggrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mata Kuliah"
        '
        'txtNIP
        '
        Me.txtNIP.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIP.Location = New System.Drawing.Point(176, 30)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(188, 27)
        Me.txtNIP.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(176, 67)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(311, 27)
        Me.txtNama.TabIndex = 5
        '
        'cmbJurusan
        '
        Me.cmbJurusan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(176, 133)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(311, 27)
        Me.cmbJurusan.TabIndex = 6
        '
        'cmbMatkul
        '
        Me.cmbMatkul.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMatkul.FormattingEnabled = True
        Me.cmbMatkul.Location = New System.Drawing.Point(176, 173)
        Me.cmbMatkul.Name = "cmbMatkul"
        Me.cmbMatkul.Size = New System.Drawing.Size(311, 27)
        Me.cmbMatkul.TabIndex = 7
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.Menu
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnNew.Location = New System.Drawing.Point(13, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 28)
        Me.btnNew.TabIndex = 8
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nilai"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(156, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Tugas"
        '
        'uts
        '
        Me.uts.AutoSize = True
        Me.uts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uts.Location = New System.Drawing.Point(268, 212)
        Me.uts.Name = "uts"
        Me.uts.Size = New System.Drawing.Size(32, 16)
        Me.uts.TabIndex = 14
        Me.uts.Text = "UTS"
        '
        'uas
        '
        Me.uas.AutoSize = True
        Me.uas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uas.Location = New System.Drawing.Point(353, 212)
        Me.uas.Name = "uas"
        Me.uas.Size = New System.Drawing.Size(32, 16)
        Me.uas.TabIndex = 15
        Me.uas.Text = "UAS"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(427, 199)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(75, 16)
        Me.lblGrade.TabIndex = 16
        Me.lblGrade.Text = "--GRADE--"
        '
        'txtTugas
        '
        Me.txtTugas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTugas.Location = New System.Drawing.Point(212, 209)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(50, 23)
        Me.txtTugas.TabIndex = 17
        Me.txtTugas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUTS
        '
        Me.txtUTS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUTS.Location = New System.Drawing.Point(294, 209)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(50, 23)
        Me.txtUTS.TabIndex = 18
        Me.txtUTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUAS
        '
        Me.txtUAS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUAS.Location = New System.Drawing.Point(382, 209)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(47, 23)
        Me.txtUAS.TabIndex = 19
        Me.txtUAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbP.Location = New System.Drawing.Point(294, 106)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(91, 20)
        Me.rbP.TabIndex = 11
        Me.rbP.TabStop = True
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbL.Location = New System.Drawing.Point(176, 106)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(75, 20)
        Me.rbL.TabIndex = 10
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki-Laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblGrade)
        Me.Panel1.Location = New System.Drawing.Point(17, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 246)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Location = New System.Drawing.Point(17, 265)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(743, 50)
        Me.Panel2.TabIndex = 21
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.IndianRed
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnClose.Location = New System.Drawing.Point(401, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(147, 28)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnDelete.Location = New System.Drawing.Point(243, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 28)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSave.Location = New System.Drawing.Point(128, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 28)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dgvdata
        '
        Me.dgvdata.AllowUserToAddRows = False
        Me.dgvdata.AllowUserToDeleteRows = False
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgnip, Me.dgnama, Me.dgjeniskelamin, Me.dgjurusan, Me.dgmatkul, Me.dggrade})
        Me.dgvdata.Location = New System.Drawing.Point(17, 320)
        Me.dgvdata.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.ReadOnly = True
        Me.dgvdata.RowTemplate.Height = 24
        Me.dgvdata.Size = New System.Drawing.Size(743, 119)
        Me.dgvdata.TabIndex = 22
        '
        'dgnip
        '
        Me.dgnip.HeaderText = "NIP"
        Me.dgnip.Name = "dgnip"
        Me.dgnip.ReadOnly = True
        Me.dgnip.Width = 90
        '
        'dgnama
        '
        Me.dgnama.HeaderText = "Nama"
        Me.dgnama.Name = "dgnama"
        Me.dgnama.ReadOnly = True
        Me.dgnama.Width = 150
        '
        'dgjeniskelamin
        '
        Me.dgjeniskelamin.HeaderText = "Jenis Kelamin"
        Me.dgjeniskelamin.Name = "dgjeniskelamin"
        Me.dgjeniskelamin.ReadOnly = True
        '
        'dgjurusan
        '
        Me.dgjurusan.HeaderText = "Jurusan"
        Me.dgjurusan.Name = "dgjurusan"
        Me.dgjurusan.ReadOnly = True
        Me.dgjurusan.Width = 130
        '
        'dgmatkul
        '
        Me.dgmatkul.HeaderText = "Mata Kuliah"
        Me.dgmatkul.Name = "dgmatkul"
        Me.dgmatkul.ReadOnly = True
        Me.dgmatkul.Width = 150
        '
        'dggrade
        '
        Me.dggrade.HeaderText = "GRADE"
        Me.dggrade.Name = "dggrade"
        Me.dggrade.ReadOnly = True
        Me.dggrade.Width = 80
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 462)
        Me.Controls.Add(Me.dgvdata)
        Me.Controls.Add(Me.txtUAS)
        Me.Controls.Add(Me.txtUTS)
        Me.Controls.Add(Me.txtTugas)
        Me.Controls.Add(Me.uas)
        Me.Controls.Add(Me.uts)
        Me.Controls.Add(Me.rbP)
        Me.Controls.Add(Me.rbL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbMatkul)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.Text = "Tugas 4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMatkul As System.Windows.Forms.ComboBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents uts As System.Windows.Forms.Label
    Friend WithEvents uas As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents txtTugas As System.Windows.Forms.TextBox
    Friend WithEvents txtUTS As System.Windows.Forms.TextBox
    Friend WithEvents txtUAS As System.Windows.Forms.TextBox
    Friend WithEvents rbP As System.Windows.Forms.RadioButton
    Friend WithEvents rbL As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents dgnip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgnama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjeniskelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgmatkul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dggrade As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
