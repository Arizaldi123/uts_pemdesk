Imports System.Windows.Forms
Public Class Form1
    Private menuMakanan() As String = {"Nasi Goreng", "Mie Goreng", "Ayam Bakar", "Sate Ayam", "Soto Ayam"}
    Private menuMinuman() As String = {"Es Teh", "Es Jeruk", "Es Blewah", "Jus Jambu", "Jus Alpukat"}
    Private hargaMakanan() As Double = {15000, 12000, 18000, 15000, 12000}
    Private hargaMinuman() As Double = {5000, 6000, 7000, 8000, 10000}
    Private dataTransaksi As New List(Of Transaksi)()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In menuMakanan
            menuMkn.Items.Add(item)
        Next

        For Each item In menuMinuman
            menuMnm.Items.Add(item)
        Next
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim namaPembeli As String = nama.Text
        Dim jumlahMakanan As Integer = Convert.ToInt32(jmlMakanan.Text)
        Dim jumlahMinuman As Integer = Convert.ToInt32(jmlMinuman.Text)
        Dim uangPembeli As Double = Convert.ToDouble(uang.Text)
        Dim totalHargaMakanan As Double = hargaMakanan(menuMkn.SelectedIndex) * jumlahMakanan
        Dim totalHargaMinuman As Double = hargaMinuman(menuMnm.SelectedIndex) * jumlahMinuman
        Dim totalHarga As Double = totalHargaMakanan + totalHargaMinuman
        Dim kembalian As Double = uangPembeli - totalHarga

        Dim transaksi As New Transaksi(namaPembeli, kembalian, jumlahMakanan, jumlahMinuman, totalHarga, menuMkn.Text, menuMnm.Text)
        dataTransaksi.Add(transaksi)

        Dim listViewItem As New ListViewItem(namaPembeli)
        listViewItem.SubItems.Add(kembalian.ToString())
        listViewItem.SubItems.Add(jumlahMakanan.ToString())
        listViewItem.SubItems.Add(jumlahMinuman.ToString())
        listViewItem.SubItems.Add(totalHarga.ToString())
        listViewItem.SubItems.Add(menuMkn.Text)
        listViewItem.SubItems.Add(menuMnm.Text)
        ListView1.Items.Add(listViewItem)

        nama.Clear()
        jmlMakanan.Clear()
        jmlMinuman.Clear()
        uang.Clear()
        menuMkn.SelectedIndex = -1
        menuMnm.SelectedIndex = -1
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedTransaksi = dataTransaksi(ListView1.SelectedIndices(0))

            Dim jumlahMakananBaru As Integer = Convert.ToInt32(jmlMakanan.Text)
            Dim jumlahMinumanBaru As Integer = Convert.ToInt32(jmlMinuman.Text)
            Dim totalHargaMakananBaru As Double = hargaMakanan(menuMkn.SelectedIndex) * jumlahMakananBaru
            Dim totalHargaMinumanBaru As Double = hargaMinuman(menuMnm.SelectedIndex) * jumlahMinumanBaru
            Dim totalHargaBaru As Double = totalHargaMakananBaru + totalHargaMinumanBaru
            Dim kembalianBaru As Double = Convert.ToDouble(uang.Text) - totalHargaBaru

            selectedTransaksi.NamaPembeli = nama.Text
            selectedTransaksi.JumlahMakanan = jumlahMakananBaru
            selectedTransaksi.JumlahMinuman = jumlahMinumanBaru
            selectedTransaksi.TotalHarga = totalHargaBaru
            selectedTransaksi.MenuMakanan = menuMkn.Text
            selectedTransaksi.MenuMinuman = menuMnm.Text

            Dim selectedListViewItem = ListView1.SelectedItems(0)
            selectedListViewItem.SubItems(0).Text = nama.Text
            selectedListViewItem.SubItems(1).Text = kembalianBaru.ToString()
            selectedListViewItem.SubItems(2).Text = jumlahMakananBaru.ToString()
            selectedListViewItem.SubItems(3).Text = jumlahMinumanBaru.ToString()
            selectedListViewItem.SubItems(4).Text = totalHargaBaru.ToString()
            selectedListViewItem.SubItems(5).Text = menuMkn.Text
            selectedListViewItem.SubItems(6).Text = menuMnm.Text

            nama.Clear()
            jmlMakanan.Clear()
            jmlMinuman.Clear()
            uang.Clear()
            menuMkn.SelectedIndex = -1
            menuMnm.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedIndex = ListView1.SelectedIndices(0)
            ListView1.Items.RemoveAt(selectedIndex)
            dataTransaksi.RemoveAt(selectedIndex)
        End If
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Dim form2 As New Form2(dataTransaksi)
        form2.Show()
    End Sub

    Public Class Transaksi
        Public Property NamaPembeli As String
        Public Property Kembalian As Double
        Public Property JumlahMakanan As Integer
        Public Property JumlahMinuman As Integer
        Public Property TotalHarga As Double
        Public Property MenuMakanan As String
        Public Property MenuMinuman As String

        Public Sub New(namaPembeli As String, kembalian As Double, jumlahMakanan As Integer, jumlahMinuman As Integer, totalHarga As Double, menuMakanan As String, menuMinuman As String)
            Me.NamaPembeli = namaPembeli
            Me.Kembalian = kembalian
            Me.JumlahMakanan = jumlahMakanan
            Me.JumlahMinuman = jumlahMinuman
            Me.TotalHarga = totalHarga
            Me.MenuMakanan = menuMakanan
            Me.MenuMinuman = menuMinuman
        End Sub
    End Class


End Class
