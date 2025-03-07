<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNilai1 = New System.Windows.Forms.TextBox()
        Me.rbKali = New System.Windows.Forms.RadioButton()
        Me.rbBagi = New System.Windows.Forms.RadioButton()
        Me.rbPlus = New System.Windows.Forms.RadioButton()
        Me.rbMin = New System.Windows.Forms.RadioButton()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtNilai2 = New System.Windows.Forms.TextBox()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.txtHasil)
        Me.Panel1.Controls.Add(Me.txtNilai2)
        Me.Panel1.Controls.Add(Me.btnHitung)
        Me.Panel1.Controls.Add(Me.rbMin)
        Me.Panel1.Controls.Add(Me.rbPlus)
        Me.Panel1.Controls.Add(Me.rbBagi)
        Me.Panel1.Controls.Add(Me.rbKali)
        Me.Panel1.Controls.Add(Me.txtNilai1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 220)
        Me.Panel1.TabIndex = 0
        '
        'txtNilai1
        '
        Me.txtNilai1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNilai1.Location = New System.Drawing.Point(-1, 4)
        Me.txtNilai1.Name = "txtNilai1"
        Me.txtNilai1.Size = New System.Drawing.Size(260, 26)
        Me.txtNilai1.TabIndex = 0
        '
        'rbKali
        '
        Me.rbKali.AutoSize = True
        Me.rbKali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbKali.Location = New System.Drawing.Point(3, 38)
        Me.rbKali.Name = "rbKali"
        Me.rbKali.Size = New System.Drawing.Size(34, 24)
        Me.rbKali.TabIndex = 1
        Me.rbKali.TabStop = True
        Me.rbKali.Text = "x"
        Me.rbKali.UseVisualStyleBackColor = True
        '
        'rbBagi
        '
        Me.rbBagi.AutoSize = True
        Me.rbBagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBagi.Location = New System.Drawing.Point(67, 38)
        Me.rbBagi.Name = "rbBagi"
        Me.rbBagi.Size = New System.Drawing.Size(31, 24)
        Me.rbBagi.TabIndex = 2
        Me.rbBagi.TabStop = True
        Me.rbBagi.Text = "/"
        Me.rbBagi.UseVisualStyleBackColor = True
        '
        'rbPlus
        '
        Me.rbPlus.AutoSize = True
        Me.rbPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPlus.Location = New System.Drawing.Point(220, 38)
        Me.rbPlus.Name = "rbPlus"
        Me.rbPlus.Size = New System.Drawing.Size(36, 24)
        Me.rbPlus.TabIndex = 3
        Me.rbPlus.TabStop = True
        Me.rbPlus.Text = "+"
        Me.rbPlus.UseVisualStyleBackColor = True
        '
        'rbMin
        '
        Me.rbMin.AutoSize = True
        Me.rbMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMin.Location = New System.Drawing.Point(145, 38)
        Me.rbMin.Name = "rbMin"
        Me.rbMin.Size = New System.Drawing.Size(32, 24)
        Me.rbMin.TabIndex = 4
        Me.rbMin.TabStop = True
        Me.rbMin.Text = "-"
        Me.rbMin.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(91, 100)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 27)
        Me.btnHitung.TabIndex = 6
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(91, 177)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 28)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtNilai2
        '
        Me.txtNilai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNilai2.Location = New System.Drawing.Point(-1, 68)
        Me.txtNilai2.Name = "txtNilai2"
        Me.txtNilai2.Size = New System.Drawing.Size(260, 26)
        Me.txtNilai2.TabIndex = 7
        '
        'txtHasil
        '
        Me.txtHasil.Enabled = False
        Me.txtHasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasil.Location = New System.Drawing.Point(0, 145)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(260, 26)
        Me.txtHasil.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 242)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbMin As System.Windows.Forms.RadioButton
    Friend WithEvents rbPlus As System.Windows.Forms.RadioButton
    Friend WithEvents rbBagi As System.Windows.Forms.RadioButton
    Friend WithEvents rbKali As System.Windows.Forms.RadioButton
    Friend WithEvents txtNilai1 As System.Windows.Forms.TextBox
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox
    Friend WithEvents txtNilai2 As System.Windows.Forms.TextBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
