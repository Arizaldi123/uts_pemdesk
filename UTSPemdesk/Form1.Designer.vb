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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.totalPembelian = New System.Windows.Forms.TextBox()
        Me.jmlMakanan = New System.Windows.Forms.TextBox()
        Me.menuMkn = New System.Windows.Forms.ComboBox()
        Me.menuMnm = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.jmlMinuman = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.kembalian = New System.Windows.Forms.TextBox()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.uangPembeli = New System.Windows.Forms.Label()
        Me.uang = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Pembeli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Biaya Pembelian "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Pembelian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Menu Makanan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Menu Minuman"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(158, 48)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(155, 20)
        Me.nama.TabIndex = 5
        '
        'totalPembelian
        '
        Me.totalPembelian.Location = New System.Drawing.Point(158, 232)
        Me.totalPembelian.Name = "totalPembelian"
        Me.totalPembelian.Size = New System.Drawing.Size(155, 20)
        Me.totalPembelian.TabIndex = 6
        '
        'jmlMakanan
        '
        Me.jmlMakanan.Location = New System.Drawing.Point(158, 122)
        Me.jmlMakanan.Name = "jmlMakanan"
        Me.jmlMakanan.Size = New System.Drawing.Size(153, 20)
        Me.jmlMakanan.TabIndex = 7
        '
        'menuMkn
        '
        Me.menuMkn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.menuMkn.FormattingEnabled = True
        Me.menuMkn.Location = New System.Drawing.Point(158, 83)
        Me.menuMkn.Name = "menuMkn"
        Me.menuMkn.Size = New System.Drawing.Size(155, 21)
        Me.menuMkn.TabIndex = 8
        '
        'menuMnm
        '
        Me.menuMnm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.menuMnm.FormattingEnabled = True
        Me.menuMnm.Location = New System.Drawing.Point(158, 162)
        Me.menuMnm.Name = "menuMnm"
        Me.menuMnm.Size = New System.Drawing.Size(155, 21)
        Me.menuMnm.TabIndex = 9
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(40, 365)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(101, 30)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(167, 365)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 30)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(285, 367)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(99, 30)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Jumlah Pembelian"
        '
        'jmlMinuman
        '
        Me.jmlMinuman.Location = New System.Drawing.Point(158, 198)
        Me.jmlMinuman.Name = "jmlMinuman"
        Me.jmlMinuman.Size = New System.Drawing.Size(155, 20)
        Me.jmlMinuman.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Kembalian"
        '
        'kembalian
        '
        Me.kembalian.Location = New System.Drawing.Point(156, 311)
        Me.kembalian.Name = "kembalian"
        Me.kembalian.ReadOnly = True
        Me.kembalian.Size = New System.Drawing.Size(157, 20)
        Me.kembalian.TabIndex = 16
        '
        'btnLaporan
        '
        Me.btnLaporan.Location = New System.Drawing.Point(418, 365)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(120, 35)
        Me.btnLaporan.TabIndex = 17
        Me.btnLaporan.Text = "Lihat Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'uangPembeli
        '
        Me.uangPembeli.AutoSize = True
        Me.uangPembeli.Location = New System.Drawing.Point(37, 275)
        Me.uangPembeli.Name = "uangPembeli"
        Me.uangPembeli.Size = New System.Drawing.Size(73, 13)
        Me.uangPembeli.TabIndex = 18
        Me.uangPembeli.Text = "Uang Pembeli"
        '
        'uang
        '
        Me.uang.Location = New System.Drawing.Point(158, 275)
        Me.uang.Name = "uang"
        Me.uang.Size = New System.Drawing.Size(155, 20)
        Me.uang.TabIndex = 19
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(331, 39)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(446, 310)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.uang)
        Me.Controls.Add(Me.uangPembeli)
        Me.Controls.Add(Me.btnLaporan)
        Me.Controls.Add(Me.kembalian)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.jmlMinuman)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.menuMnm)
        Me.Controls.Add(Me.menuMkn)
        Me.Controls.Add(Me.jmlMakanan)
        Me.Controls.Add(Me.totalPembelian)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents totalPembelian As TextBox
    Friend WithEvents jmlMakanan As TextBox
    Friend WithEvents menuMkn As ComboBox
    Friend WithEvents menuMnm As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents jmlMinuman As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents kembalian As TextBox
    Friend WithEvents btnLaporan As Button
    Friend WithEvents uangPembeli As Label
    Friend WithEvents uang As TextBox
    Friend WithEvents ListView1 As ListView
End Class
