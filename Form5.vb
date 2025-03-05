Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class Form5
    Sub tampildatagrid()
        DA = New MySqlDataAdapter("select * from malesin", CONN)
        DS = New DataSet
        DA.Fill(DS, "malesin")
        dgvtua.DataSource = (DS.Tables("malesin"))
    End Sub
    Sub tampildatagrid1()
        DA = New MySqlDataAdapter("select * from malas", CONN)
        DS = New DataSet
        DA.Fill(DS, "malas")
        dgvsiswa.DataSource = (DS.Tables("malas"))
    End Sub
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
    Private dataCetak As String = ""

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tanggalWaktu As String = DateTimePicker1.Value.ToString("dd MMMM yyyy")
        Dim tanggalWaktu2 As String = DateTimePicker2.Value.ToString("dd MMMM yyyy")
        Dim tanggalWaktu1 As String = DateTimePicker3.Value.ToString("dd MMMM yyyy")
        Dim tanggalWaktu3 As String = DateTimePicker6.Value.ToString("dd MMMM yyyy")
        Dim tanggalWaktu4 As String = DateTimePicker4.Value.ToString("dd MMMM yyyy")
        dataCetak = "Nama: " & TextBox1.Text & vbCrLf &
                    "Nama Panggilan/Sapaan: " & TextBox2.Text & vbCrLf &
                    "Jenis Kelamin: " & ComboBox1.Text & vbCrLf &
                    "Tempat/Tanggal Lahir: " & TextBox3.Text & ", " & tanggalWaktu & vbCrLf &
                    "Agama: " & ComboBox2.Text & vbCrLf &
                    "Kewarganegaraan: " & TextBox4.Text & vbCrLf &
                    "Anak Keberapa: " & TextBox5.Text & vbCrLf &
                    "Jumlah Saudara Kandung: " & TextBox6.Text & vbCrLf &
                    "Jumlah Saudara Tiri: " & TextBox7.Text & vbCrLf &
                    "Jumlah Saudara Angkat: " & TextBox8.Text & vbCrLf &
                    "Anak Yatim/Piatu/Yatim Piatu: " & ComboBox4.Text & vbCrLf &
                    "Bahasa: " & TextBox10.Text & vbCrLf &
                    "Alamat: " & TextBox19.Text & vbCrLf &
                    "No. Telp: " & TextBox26.Text & vbCrLf &
                    "Tinggal Dengan: " & ComboBox5.Text & vbCrLf &
                    "Jarak Rumah ke Sekolah: " & TextBox18.Text & vbCrLf &
                    "Golongan Darah: " & ComboBox3.Text & vbCrLf &
                    "Penyakit yang Pernah Diderita: " & TextBox17.Text & vbCrLf &
                    "Kelainan Jasmani: " & TextBox16.Text & vbCrLf &
                    "Tinggi dan Berat Badan: " & TextBox15.Text & "/ " & TextBox9.Text & vbCrLf &
                    "Lulusan Dari: " & TextBox14.Text & vbCrLf &
                    "Tanggal dan  No Ijazah: " & tanggalWaktu2 & "/ " & TextBox13.Text & vbCrLf &
                    "Lamanya Belajar: " & TextBox12.Text & vbCrLf &
                    "Dari Sekolah: " & TextBox11.Text & vbCrLf &
                    "Alasan: " & TextBox20.Text & vbCrLf &
                    "Di Kelas: " & TextBox21.Text & vbCrLf &
                    "Jurusan: " & ComboBox6.Text & vbCrLf &
                    "Tanggal: " & tanggalWaktu1 & vbCrLf &
                    "Kesenian: " & TextBox23.Text & vbCrLf &
                    "Olahraga: " & TextBox22.Text & vbCrLf &
                    "Kemasyarakatan/Organisasi: " & TextBox25.Text & vbCrLf &
                    "Lain-lain: " & TextBox24.Text & vbCrLf &
                    "Nama Ayah: " & TextBox50.Text & vbCrLf &
                    "Tempat/Tanggal Lahir: " & TextBox49.Text & ", " & tanggalWaktu3 & vbCrLf &
                    "Agama: " & ComboBox11.Text & vbCrLf &
                    "Kewarganegaraan: " & TextBox47.Text & vbCrLf &
                    "Pendidikan Terakhir: " & TextBox26.Text & vbCrLf &
                    "Pekerjaan: " & TextBox27.Text & vbCrLf &
                    "Penghasilan Per Bulan: " & TextBox28.Text & vbCrLf &
                    "Alamat Rumah: " & TextBox29.Text & vbCrLf &
                    "No. Telp: " & TextBox30.Text & vbCrLf &
                    "Hidup/Tanggal Kematian: " & TextBox31.Text & vbCrLf &
                    "Nama Ibu: " & TextBox40.Text & vbCrLf &
                    "Tempat/Tanggal Lahir: " & TextBox39.Text & ", " & tanggalWaktu4 & vbCrLf &
                    "Agama: " & ComboBox7.Text & vbCrLf &
                    "Kewarganegaraan: " & TextBox38.Text & vbCrLf &
                    "Pendidikan Terakhir: " & TextBox37.Text & vbCrLf &
                    "Pekerjaan: " & TextBox36.Text & vbCrLf &
                    "Penghasilan Per Bulan: " & TextBox35.Text & vbCrLf &
                    "Alamat Rumah: " & TextBox34.Text & vbCrLf &
                    "No. Telp: " & TextBox33.Text & vbCrLf &
                    "Hidup/Tanggal Kematian: " & TextBox32.Text & vbCrLf &
                    "Nama Wali: " & TextBox53.Text & vbCrLf &
                    "Tempat/Tanggal Lahir: " & TextBox52.Text & vbCrLf &
                    "Agama: " & ComboBox8.Text & vbCrLf &
                    "Kewarganegaraan: " & TextBox51.Text & vbCrLf &
                    "Pendidikan Terakhir: " & TextBox48.Text & vbCrLf &
                    "Pekerjaan: " & TextBox46.Text & vbCrLf &
                    "Penghasilan Per Bulan: " & TextBox45.Text & vbCrLf &
                    "Alamat Rumah: " & TextBox44.Text & vbCrLf &
                    "No. Telp: " & TextBox43.Text & vbCrLf &
                    "Hubungan Keluarga: " & TextBox42.Text

        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf PrintPageHandler

        Dim printDialog As New PrintDialog()
        printDialog.Document = pd
        If printDialog.ShowDialog() = DialogResult.OK Then
            pd.Print()
        End If
    End Sub
    Private lineIndex As Integer = 0

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim printFont As New Font("Arial", 12)
        Dim yPos As Single = 100
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim linesPerPage As Single = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)
        Dim count As Integer = 0

        While lineIndex < dataCetak.Length AndAlso count < linesPerPage
            Dim line As String = GetNextLine()
            e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos)
            yPos += printFont.GetHeight(e.Graphics)
            count += 1
        End While

        If lineIndex < dataCetak.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            lineIndex = 0
        End If
    End Sub

    Private Function GetNextLine() As String
        Dim line As String = ""
        While lineIndex < dataCetak.Length AndAlso dataCetak(lineIndex) <> vbLf
            line += dataCetak(lineIndex)
            lineIndex += 1
        End While
        lineIndex += 1
        Return line
    End Function

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildatagrid()
        Call tampildatagrid1()
        dgvsiswa.ReadOnly = True
        dgvtua.ReadOnly = True

        ComboBox9.Items.Add("Data Siswa/i")
        ComboBox9.Items.Add("Data Orang Tua/Wali")

        GroupBox1.Show()
        GroupBox2.Hide()
        
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE malas SET Nama=?, Panggilan=?, Jenis_Kelamin=?, Tempat_TanggalLahir=?, Agama=?, Kewarganegaraan=?, Anak_Ke=?, Jumlah_Saudara_Kandung=?, Jumlah_Saudara_Tiri=?, Jumlah_Saudara_Angkat=?, Yatim_Piatu_YatimPiatu=?, Bahasa=?, Alamat=?, No_Telp=?, Tinggal_Dengan=?, Jarak_Sekolah=?, Golongan_Darah=?, Penyakit=?, Kelainan_Jasmani=?, Tinggi_BeratBadan=?, Lulusan_Dari=?, Tanggal_NoIjazah=?, Lamanya_Belajar=?, Dari_Sekolah=?, Alasan=?, Di_Kelas=?, Jurusan=?, Tanggal=?, Kesenian=?, Olahraga=?, Kemasyarakatan_Organisasi=?, Lain_lain=? where Nama='" & TextBox1.Text & "'"
            Dim tanggalWaktu As String = DateTimePicker1.Value.ToString("dd MMMM yyyy")
            Dim tanggalWaktu1 As String = DateTimePicker3.Value.ToString("dd MMMM yyyy")
            Dim tanggalWaktu2 As String = DateTimePicker2.Value.ToString("dd MMMM yyyy")
            Dim cmd As New MySqlCommand(str, CONN)
            With cmd
                .Parameters.Clear()
                .Parameters.Add(New MySqlParameter("Nama", MySqlDbType.VarChar, 100)).Value = TextBox1.Text
                .Parameters.Add(New MySqlParameter("Panggilan", MySqlDbType.VarChar, 50)).Value = TextBox2.Text
                .Parameters.Add(New MySqlParameter("Jenis_Kelamin", MySqlDbType.VarChar, 30)).Value = ComboBox1.Text
                .Parameters.Add(New MySqlParameter("Tempat_TanggalLahir", MySqlDbType.VarChar, 100)).Value = TextBox3.Text & ", " & tanggalWaktu
                .Parameters.Add(New MySqlParameter("Agama", MySqlDbType.VarChar, 20)).Value = ComboBox2.Text
                .Parameters.Add(New MySqlParameter("Kewarganegaraan", MySqlDbType.VarChar, 20)).Value = TextBox4.Text
                .Parameters.Add(New MySqlParameter("Anak_Ke", MySqlDbType.VarChar, 10)).Value = TextBox5.Text
                .Parameters.Add(New MySqlParameter("Jumlah_Saudara_Kandung", MySqlDbType.VarChar, 10)).Value = TextBox6.Text
                .Parameters.Add(New MySqlParameter("Jumlah_Saudara_Tiri", MySqlDbType.VarChar, 10)).Value = TextBox7.Text
                .Parameters.Add(New MySqlParameter("Jumlah_Saudara_Angkat", MySqlDbType.VarChar, 10)).Value = TextBox8.Text
                .Parameters.Add(New MySqlParameter("Yatim_Piatu_YatimPiatu", MySqlDbType.VarChar, 20)).Value = ComboBox4.Text
                .Parameters.Add(New MySqlParameter("Bahasa", MySqlDbType.VarChar, 30)).Value = TextBox10.Text
                .Parameters.Add(New MySqlParameter("Alamat", MySqlDbType.VarChar, 100)).Value = TextBox19.Text
                .Parameters.Add(New MySqlParameter("No_Telp", MySqlDbType.VarChar, 20)).Value = TextBox26.Text
                .Parameters.Add(New MySqlParameter("Tinggal_Dengan", MySqlDbType.VarChar, 20)).Value = ComboBox5.Text
                .Parameters.Add(New MySqlParameter("Jarak_Sekolah", MySqlDbType.VarChar, 20)).Value = TextBox18.Text
                .Parameters.Add(New MySqlParameter("Golongan_Darah", MySqlDbType.VarChar, 10)).Value = ComboBox3.Text
                .Parameters.Add(New MySqlParameter("Penyakit", MySqlDbType.VarChar, 50)).Value = TextBox17.Text
                .Parameters.Add(New MySqlParameter("Kelainan_Jasmani", MySqlDbType.VarChar, 50)).Value = TextBox16.Text
                .Parameters.Add(New MySqlParameter("Tinggi_BeratBadan", MySqlDbType.VarChar, 30)).Value = TextBox15.Text & "/ " & TextBox9.Text
                .Parameters.Add(New MySqlParameter("Lulusan_Dari", MySqlDbType.VarChar, 50)).Value = TextBox14.Text
                .Parameters.Add(New MySqlParameter("Tanggal_NoIjazah", MySqlDbType.VarChar, 30)).Value = tanggalWaktu2 & ", " & TextBox13.Text
                .Parameters.Add(New MySqlParameter("Lamanya_Belajar", MySqlDbType.VarChar, 20)).Value = TextBox12.Text
                .Parameters.Add(New MySqlParameter("Dari_Sekolah", MySqlDbType.VarChar, 50)).Value = TextBox11.Text
                .Parameters.Add(New MySqlParameter("Alasan", MySqlDbType.VarChar, 100)).Value = TextBox20.Text
                .Parameters.Add(New MySqlParameter("Di_Kelas", MySqlDbType.VarChar, 30)).Value = TextBox21.Text
                .Parameters.Add(New MySqlParameter("Jurusan", MySqlDbType.VarChar, 30)).Value = ComboBox6.Text
                .Parameters.Add(New MySqlParameter("Tanggal", MySqlDbType.VarChar, 10)).Value = tanggalWaktu1
                .Parameters.Add(New MySqlParameter("Kesenian", MySqlDbType.VarChar, 100)).Value = TextBox23.Text
                .Parameters.Add(New MySqlParameter("Olahraga", MySqlDbType.VarChar, 100)).Value = TextBox22.Text
                .Parameters.Add(New MySqlParameter("Kemasyarakatan_Organisasi", MySqlDbType.VarChar, 100)).Value = TextBox25.Text
                .Parameters.Add(New MySqlParameter("Lain_lain", MySqlDbType.VarChar, 100)).Value = TextBox24.Text
                .ExecuteNonQuery()
                CONN.Close()
            End With
            MessageBox.Show("update berhasil di lakukan", "PEMBERITAHUAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Pilih Siswa/i Dengan Benar",
           "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If MessageBox.Show("Yakin Data Akan Dihapus?", "konfirmasi",
           MessageBoxButtons.YesNo) =
            Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("delete from malas where Nama='" &
               TextBox1.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call tampildatagrid()
            Else
                Call tampildatagrid()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim tables As DataTableCollection = DS.Tables
        Dim source1 As New BindingSource
        DA = New MySqlDataAdapter("Select * from malas", CONN)
        DS = New DataSet
        DA.Fill(DS, "malas")
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        dgvsiswa.DataSource = tampil
        dgvsiswa.Refresh()
        tampil.RowFilter = "Nama='" & TextBox1.Text & "'"
        dgvsiswa.Refresh()
    End Sub

    Private Sub dgvsiswa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsiswa.CellContentClick
        Dim baris As Integer
        With dgvsiswa
            baris = .CurrentRow.Index
            Dim tanggalWaktu1 As String = DateTimePicker3.Value.ToString("dd MMMM yyyy")
            TextBox1.Text = .Item(0, baris).Value
            TextBox2.Text = .Item(1, baris).Value
            ComboBox1.Text = .Item(2, baris).Value
            TextBox3.Text = .Item(3, baris).Value
            ComboBox2.Text = .Item(4, baris).Value
            TextBox4.Text = .Item(5, baris).Value
            TextBox5.Text = .Item(6, baris).Value
            TextBox6.Text = .Item(7, baris).Value
            TextBox7.Text = .Item(8, baris).Value
            TextBox8.Text = .Item(9, baris).Value
            ComboBox4.Text = .Item(10, baris).Value
            TextBox10.Text = .Item(11, baris).Value
            TextBox19.Text = .Item(12, baris).Value
            TextBox26.Text = .Item(13, baris).Value
            ComboBox5.Text = .Item(14, baris).Value
            TextBox18.Text = .Item(15, baris).Value
            ComboBox3.Text = .Item(16, baris).Value
            TextBox17.Text = .Item(17, baris).Value
            TextBox16.Text = .Item(18, baris).Value
            TextBox15.Text = .Item(19, baris).Value
            TextBox14.Text = .Item(20, baris).Value
            TextBox13.Text = .Item(21, baris).Value
            TextBox12.Text = .Item(22, baris).Value
            TextBox11.Text = .Item(23, baris).Value
            TextBox20.Text = .Item(24, baris).Value
            TextBox21.Text = .Item(25, baris).Value
            ComboBox6.Text = .Item(26, baris).Value
            tanggalWaktu1 = .Item(27, baris).Value
            TextBox23.Text = .Item(28, baris).Value
            TextBox22.Text = .Item(29, baris).Value
            TextBox25.Text = .Item(30, baris).Value
            TextBox24.Text = .Item(31, baris).Value
        End With
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ComboBox9.Text = "Data Siswa/i" Then
            GroupBox1.Show()
            GroupBox2.Hide()
        ElseIf ComboBox9.Text = "Data Orang Tua/Wali" Then
            GroupBox2.Show()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox3.Text = ""
        ComboBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComboBox4.Text = ""
        TextBox10.Text = ""
        TextBox19.Text = ""
        TextBox26.Text = ""
        ComboBox5.Text = ""
        TextBox18.Text = ""
        ComboBox3.Text = ""
        TextBox17.Text = ""
        TextBox16.Text = ""
        TextBox15.Text = ""
        TextBox9.Text = ""
        TextBox21.Text = ""
        ComboBox6.Text = ""
        TextBox14.Text = ""
        TextBox13.Text = ""
        TextBox12.Text = ""
        TextBox11.Text = ""
        TextBox20.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
        TextBox25.Text = ""
        TextBox24.Text = ""
        TextBox50.Text = ""
        TextBox49.Text = ""
        ComboBox11.Text = ""
        TextBox47.Text = ""
        TextBox26.Text = ""
        TextBox27.Text = ""
        TextBox28.Text = ""
        TextBox29.Text = ""
        TextBox30.Text = ""
        TextBox31.Text = ""
        TextBox40.Text = ""
        TextBox39.Text = ""
        ComboBox7.Text = ""
        TextBox38.Text = ""
        TextBox37.Text = ""
        TextBox36.Text = ""
        TextBox35.Text = ""
        TextBox34.Text = ""
        TextBox33.Text = ""
        TextBox32.Text = ""
        TextBox53.Text = ""
        TextBox52.Text = ""
        ComboBox8.Text = ""
        TextBox51.Text = ""
        TextBox48.Text = ""
        TextBox46.Text = ""
        TextBox45.Text = ""
        TextBox44.Text = ""
        TextBox43.Text = ""
        TextBox42.Text = ""
    End Sub

    


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE malesin SET Nama_Ayah=?, Tempat_TanggalLahir=?, Agama=?, Kewarganegaraan=?, Pendidikan_Terakhir=?, Pekerjaan=?, Penghasilan_Per_Bulan=?, Alamat_Rumah=?, No_Telp=?, Hidup_TanggalKematian=?, Nama_Ibu=?, Tempat_TanggalLahir1=?, Agama1=?, Kewarganegaraan1=?, Pendidikan_Terakhir1=?, Pekerjaan1=?, Penghasilan_Per_Bulan1=?, Alamat_Rumah1=?, No_Telp1=?, Hidup_TanggalKematian1=?, Nama_Wali=?, Tempat_TanggalLahir2=?, Agama2=?, Kewarganegaraan2=?, Pendidikan_Terakhir2=?, Pekerjaan2=?, Penghasilan_Per_Bulan2=?, Alamat_Rumah2=?, No_Telp2=?, Hubungan_Keluarga=? where Nama_Ayah='" & TextBox50.Text & "'"
            Dim tanggalWaktu As String = DateTimePicker6.Value.ToString("dd MMMM yyyy")
            Dim tanggalWaktu1 As String = DateTimePicker4.Value.ToString("dd MMMM yyyy")
            Dim cmd As New MySqlCommand(str, CONN)
            With cmd
                .Parameters.Clear()
                .Parameters.Add(New MySqlParameter("Nama_Ayah", MySqlDbType.VarChar, 100)).Value = TextBox50.Text
                .Parameters.Add(New MySqlParameter("Tempat_TanggalLahir", MySqlDbType.VarChar, 100)).Value = TextBox49.Text & ", " & tanggalWaktu
                .Parameters.Add(New MySqlParameter("Agama", MySqlDbType.VarChar, 30)).Value = ComboBox11.Text
                .Parameters.Add(New MySqlParameter("Kewarganegaraan", MySqlDbType.VarChar, 20)).Value = TextBox47.Text
                .Parameters.Add(New MySqlParameter("Pendidikan_Terakhir", MySqlDbType.VarChar, 50)).Value = TextBox26.Text
                .Parameters.Add(New MySqlParameter("Pekerjaan", MySqlDbType.VarChar, 50)).Value = TextBox27.Text
                .Parameters.Add(New MySqlParameter("Penghasilan_Per_Bulan", MySqlDbType.VarChar, 30)).Value = TextBox28.Text
                .Parameters.Add(New MySqlParameter("Alamat_Rumah", MySqlDbType.VarChar, 100)).Value = TextBox29.Text
                .Parameters.Add(New MySqlParameter("No_Telp", MySqlDbType.VarChar, 20)).Value = TextBox30.Text
                .Parameters.Add(New MySqlParameter("Hidup_TanggalKematian", MySqlDbType.VarChar, 20)).Value = TextBox31.Text
                .Parameters.Add(New MySqlParameter("Nama_Ibu", MySqlDbType.VarChar, 100)).Value = TextBox40.Text
                .Parameters.Add(New MySqlParameter("Tempat_TanggalLahir1", MySqlDbType.VarChar, 100)).Value = TextBox39.Text & ", " & tanggalWaktu1
                .Parameters.Add(New MySqlParameter("Agama1", MySqlDbType.VarChar, 30)).Value = ComboBox7.Text
                .Parameters.Add(New MySqlParameter("Kewarganegaraan1", MySqlDbType.VarChar, 20)).Value = TextBox38.Text
                .Parameters.Add(New MySqlParameter("Pendidikan_Terakhir1", MySqlDbType.VarChar, 50)).Value = TextBox37.Text
                .Parameters.Add(New MySqlParameter("Pekerjaan1", MySqlDbType.VarChar, 50)).Value = TextBox36.Text
                .Parameters.Add(New MySqlParameter("Penghasilan_Per_Bulan1", MySqlDbType.VarChar, 30)).Value = TextBox35.Text
                .Parameters.Add(New MySqlParameter("Alamat_Rumah1", MySqlDbType.VarChar, 100)).Value = TextBox34.Text
                .Parameters.Add(New MySqlParameter("No_Telp1", MySqlDbType.VarChar, 20)).Value = TextBox33.Text
                .Parameters.Add(New MySqlParameter("Hidup_TanggalKematian1", MySqlDbType.VarChar, 20)).Value = TextBox32.Text
                .Parameters.Add(New MySqlParameter("Nama_Wali", MySqlDbType.VarChar, 100)).Value = TextBox53.Text
                .Parameters.Add(New MySqlParameter("Tempat_TanggalLahir2", MySqlDbType.VarChar, 100)).Value = TextBox52.Text
                .Parameters.Add(New MySqlParameter("Agama2", MySqlDbType.VarChar, 30)).Value = ComboBox8.Text
                .Parameters.Add(New MySqlParameter("Kewarganegaraan2", MySqlDbType.VarChar, 20)).Value = TextBox51.Text
                .Parameters.Add(New MySqlParameter("Pendidikan_Terakhir2", MySqlDbType.VarChar, 50)).Value = TextBox48.Text
                .Parameters.Add(New MySqlParameter("Pekerjaan2", MySqlDbType.VarChar, 50)).Value = TextBox46.Text
                .Parameters.Add(New MySqlParameter("Penghasilan_Per_Bulan2", MySqlDbType.VarChar, 30)).Value = TextBox45.Text
                .Parameters.Add(New MySqlParameter("Alamat_Rumah2", MySqlDbType.VarChar, 100)).Value = TextBox44.Text
                .Parameters.Add(New MySqlParameter("No_Telp2", MySqlDbType.VarChar, 20)).Value = TextBox43.Text
                .Parameters.Add(New MySqlParameter("Hubungan_Keluarga", MySqlDbType.VarChar, 30)).Value = TextBox42.Text
                .ExecuteNonQuery()
                CONN.Close()
            End With
            MessageBox.Show("update berhasil di lakukan", "PEMBERITAHUAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If TextBox50.Text = "" Then
            MessageBox.Show("Pilih Orang Tua Dengan Benar",
           "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If MessageBox.Show("Yakin Data Akan Dihapus?", "konfirmasi",
           MessageBoxButtons.YesNo) =
            Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("delete from malesin where Nama_Ayah='" &
               TextBox50.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call tampildatagrid()
            Else
                Call tampildatagrid()
            End If
        End If
    End Sub

    Private Sub TextBox50_TextChanged(sender As Object, e As EventArgs)
        Dim tables As DataTableCollection = DS.Tables
        Dim source1 As New BindingSource
        DA = New MySqlDataAdapter("Select * from malesin", CONN)
        DS = New DataSet
        DA.Fill(DS, "malesin")
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        dgvtua.DataSource = tampil
        dgvtua.Refresh()
        tampil.RowFilter = "Nama_Ayah='" & TextBox50.Text & "'"
        dgvtua.Refresh()
    End Sub

    Private Sub dgvtua_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtua.CellContentClick
        Dim baris As Integer
        With dgvtua
            baris = .CurrentRow.Index
            TextBox50.Text = .Item(0, baris).Value
            TextBox49.Text = .Item(1, baris).Value
            ComboBox11.Text = .Item(2, baris).Value
            TextBox47.Text = .Item(3, baris).Value
            TextBox41.Text = .Item(4, baris).Value
            TextBox27.Text = .Item(5, baris).Value
            TextBox28.Text = .Item(6, baris).Value
            TextBox29.Text = .Item(7, baris).Value
            TextBox30.Text = .Item(8, baris).Value
            TextBox31.Text = .Item(9, baris).Value
            TextBox40.Text = .Item(10, baris).Value
            TextBox39.Text = .Item(11, baris).Value
            ComboBox7.Text = .Item(12, baris).Value
            TextBox38.Text = .Item(13, baris).Value
            TextBox37.Text = .Item(14, baris).Value
            TextBox36.Text = .Item(15, baris).Value
            TextBox35.Text = .Item(16, baris).Value
            TextBox34.Text = .Item(17, baris).Value
            TextBox33.Text = .Item(18, baris).Value
            TextBox32.Text = .Item(19, baris).Value
            TextBox53.Text = .Item(20, baris).Value
            TextBox52.Text = .Item(21, baris).Value
            ComboBox8.Text = .Item(22, baris).Value
            TextBox51.Text = .Item(23, baris).Value
            TextBox48.Text = .Item(24, baris).Value
            TextBox46.Text = .Item(25, baris).Value
            TextBox45.Text = .Item(26, baris).Value
            TextBox44.Text = .Item(27, baris).Value
            TextBox43.Text = .Item(28, baris).Value
            TextBox42.Text = .Item(29, baris).Value
        End With
    End Sub
End Class