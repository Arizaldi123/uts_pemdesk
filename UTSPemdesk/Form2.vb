Imports UTSPemdesk.Form1

Public Class Form2
    Private dataTransaksi As List(Of Transaksi)
    Public Sub New(dataTransaksi As List(Of Transaksi))
        InitializeComponent()
        Me.dataTransaksi = dataTransaksi
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each transaksi In dataTransaksi
            Dim listViewItem As New ListViewItem(transaksi.NamaPembeli)
            listViewItem.SubItems.Add(transaksi.Kembalian.ToString())
            listViewItem.SubItems.Add(transaksi.JumlahMakanan.ToString())
            listViewItem.SubItems.Add(transaksi.JumlahMinuman.ToString())
            listViewItem.SubItems.Add(transaksi.TotalHarga.ToString())
            listViewItem.SubItems.Add(transaksi.MenuMakanan)
            listViewItem.SubItems.Add(transaksi.MenuMinuman)
            ListView1.Items.Add(listViewItem)
        Next
    End Sub
End Class
