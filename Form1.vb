Imports MySql.Data.MySqlClient
Public Class Form1
    Sub tampildatagrid()
        DA = New MySqlDataAdapter("select * from malas", CONN)
        DS = New DataSet
        DA.Fill(DS, "malas")
        dgvsiswa.DataSource = (DS.Tables("malas"))
    End Sub
    Sub aturlebarcolomgrid()
        dgvsiswa.Columns(0).Width = 60
        dgvsiswa.Columns(1).Width = 100
        dgvsiswa.Columns(2).Width = 100
        dgvsiswa.Columns(3).Width = 100
        dgvsiswa.Columns(4).Width = 150
        dgvsiswa.Columns(5).Width = 70
        dgvsiswa.Columns(6).Width = 100
        dgvsiswa.Columns(7).Width = 150
        dgvsiswa.Columns(8).Width = 50
        dgvsiswa.Columns(9).Width = 50
        dgvsiswa.Columns(10).Width = 50
        dgvsiswa.Columns(11).Width = 60
        dgvsiswa.Columns(12).Width = 100
        dgvsiswa.Columns(13).Width = 100
        dgvsiswa.Columns(14).Width = 100
        dgvsiswa.Columns(15).Width = 150
        dgvsiswa.Columns(16).Width = 70
        dgvsiswa.Columns(17).Width = 100
        dgvsiswa.Columns(18).Width = 150
        dgvsiswa.Columns(19).Width = 50
        dgvsiswa.Columns(20).Width = 50
        dgvsiswa.Columns(21).Width = 50
        dgvsiswa.Columns(22).Width = 60
        dgvsiswa.Columns(23).Width = 100
        dgvsiswa.Columns(24).Width = 100
        dgvsiswa.Columns(25).Width = 100
        dgvsiswa.Columns(26).Width = 150
        dgvsiswa.Columns(27).Width = 70
        dgvsiswa.Columns(28).Width = 100
        dgvsiswa.Columns(29).Width = 150
        dgvsiswa.Columns(30).Width = 50
        dgvsiswa.Columns(31).Width = 50
    End Sub
    Sub bersih()
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
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildatagrid()
        Call aturlebarcolomgrid()
        dgvsiswa.ReadOnly = True

        ComboBox9.Items.Add("Siswa/i")
        ComboBox9.Items.Add("Orang Tua/Wali")
        ComboBox9.Items.Add("Data Keseluruhan")

        ComboBox1.Items.Add("Laki-laki")
        ComboBox1.Items.Add("Perempuan")

        ComboBox2.Items.Add("Islam")
        ComboBox2.Items.Add("Protestan")
        ComboBox2.Items.Add("Katolik")
        ComboBox2.Items.Add("Buddha")
        ComboBox2.Items.Add("Hindu")
        ComboBox2.Items.Add("Konghucu")

        ComboBox4.Items.Add("Yatim")
        ComboBox4.Items.Add("Piatu")
        ComboBox4.Items.Add("Yatim Piatu")

        ComboBox6.Items.Add("Tata Busana")
        ComboBox6.Items.Add("Teknik Informatika")
        ComboBox6.Items.Add("Farmasi")
        ComboBox6.Items.Add("Keperawatan")

        ComboBox5.Items.Add("Orang Tua")
        ComboBox5.Items.Add("Saudara")
        ComboBox5.Items.Add("di Asrama")
        ComboBox5.Items.Add("di Kost")

        ComboBox3.Items.Add("AB")
        ComboBox3.Items.Add("A")
        ComboBox3.Items.Add("B")
        ComboBox3.Items.Add("O")

        Button1.Enabled = False
        
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ComboBox9.Text = "Orang Tua/Wali" Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox24_Click(sender As Object, e As EventArgs) Handles TextBox24.Click
        If TextBox24.Text = "" Then
            Button1.Enabled = True
            
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Or ComboBox2.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or ComboBox4.Text = "" Or TextBox10.Text = "" Or TextBox19.Text = "" Or TextBox26.Text = "" Or ComboBox5.Text = "" Or TextBox18.Text = "" Or ComboBox3.Text = "" Or TextBox17.Text = "" Or TextBox16.Text = "" Or TextBox15.Text = "" Or TextBox9.Text = "" Or TextBox21.Text = "" Or ComboBox6.Text = "" Or TextBox14.Text = "" Or TextBox13.Text = "" Or TextBox12.Text = "" Or TextBox11.Text = "" Or TextBox20.Text = "" Or TextBox23.Text = "" Or TextBox22.Text = "" Or TextBox25.Text = "" Or TextBox24.Text = "" Then

            MessageBox.Show("Data Harus Diisi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tanggalWaktu As String = DateTimePicker1.Value.ToString("dd MMMM yyyy")
            Dim tanggalWaktu1 As String = DateTimePicker3.Value.ToString("dd MMMM yyyy")
            Dim tanggalWaktu2 As String = DateTimePicker2.Value.ToString("dd MMMM yyyy")
            Dim sqlForm1 As String = "insert into malas(Nama,Panggilan,Jenis_Kelamin,Tempat_TanggalLahir,Agama,Kewarganegaraan,Anak_Ke,Jumlah_Saudara_Kandung,Jumlah_Saudara_Tiri,Jumlah_Saudara_Angkat,Yatim_Piatu_YatimPiatu,Bahasa,Alamat,No_Telp,Tinggal_Dengan,Jarak_Sekolah,Golongan_Darah,Penyakit,Kelainan_Jasmani,Tinggi_BeratBadan,Lulusan_Dari,Tanggal_NoIjazah,Lamanya_Belajar,Dari_Sekolah,Alasan,Di_Kelas,Jurusan,Tanggal,Kesenian,Olahraga,Kemasyarakatan_Organisasi,Lain_lain) values( '" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & ", " & tanggalWaktu & "','" & ComboBox2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & ComboBox4.Text & "','" & TextBox10.Text & "','" & TextBox19.Text & "','" & TextBox26.Text & "','" & ComboBox5.Text & "','" & TextBox18.Text & "','" & ComboBox3.Text & "','" & TextBox17.Text & "','" & TextBox16.Text & "','" & TextBox15.Text & "/ " & TextBox9.Text & "','" & TextBox14.Text & "','" & tanggalWaktu2 & ", " & TextBox13.Text & "','" & TextBox12.Text & "','" & TextBox11.Text & "','" & TextBox20.Text & "','" & TextBox21.Text & "','" & ComboBox6.Text & "','" & tanggalWaktu1 & "','" & TextBox23.Text & "','" & TextBox22.Text & "','" & TextBox25.Text & "','" & TextBox24.Text & "')"
            CMD = New MySqlCommand(sqlForm1, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data Telah Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call tampildatagrid()
            Call aturlebarcolomgrid()
            Call bersih()


        End If
    End Sub

    

    

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        
    End Sub

    Private Sub dgvsiswa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsiswa.CellContentClick
       
    End Sub
End Class
