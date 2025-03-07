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
        Me.cmbFakultas = New System.Windows.Forms.ComboBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fakultas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jurusan"
        '
        'txtNIP
        '
        Me.txtNIP.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIP.Location = New System.Drawing.Point(152, 10)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(188, 27)
        Me.txtNIP.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(152, 64)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(244, 27)
        Me.txtNama.TabIndex = 5
        '
        'cmbFakultas
        '
        Me.cmbFakultas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFakultas.FormattingEnabled = True
        Me.cmbFakultas.Items.AddRange(New Object() {"FMIPA", "FKIP", "FEB"})
        Me.cmbFakultas.Location = New System.Drawing.Point(152, 161)
        Me.cmbFakultas.Name = "cmbFakultas"
        Me.cmbFakultas.Size = New System.Drawing.Size(98, 27)
        Me.cmbFakultas.TabIndex = 6
        '
        'cmbJurusan
        '
        Me.cmbJurusan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.cmbJurusan.Location = New System.Drawing.Point(152, 216)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(244, 27)
        Me.cmbJurusan.TabIndex = 7
        '
        'btnProses
        '
        Me.btnProses.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.Location = New System.Drawing.Point(17, 286)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(82, 38)
        Me.btnProses.TabIndex = 8
        Me.btnProses.Text = "Process"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jenis Kelamin"
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbL.Location = New System.Drawing.Point(152, 118)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(75, 20)
        Me.rbL.TabIndex = 10
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki-Laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbP.Location = New System.Drawing.Point(263, 118)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(91, 20)
        Me.rbP.TabIndex = 11
        Me.rbP.TabStop = True
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 347)
        Me.Controls.Add(Me.rbP)
        Me.Controls.Add(Me.rbL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.cmbFakultas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cmbFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbL As System.Windows.Forms.RadioButton
    Friend WithEvents rbP As System.Windows.Forms.RadioButton

End Class
