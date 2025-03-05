Imports MySql.Data.MySqlClient
Public Class Form2
    Sub tampildatagrid()
        DA = New MySqlDataAdapter("select * from malesin", CONN)
        DS = New DataSet
        DA.Fill(DS, "malesin")
        dgvtua.DataSource = (DS.Tables("malesin"))
    End Sub
    Sub aturlebarcolomgrid()
        dgvtua.Columns(0).Width = 60
        dgvtua.Columns(1).Width = 100
        dgvtua.Columns(2).Width = 100
        dgvtua.Columns(3).Width = 100
        dgvtua.Columns(4).Width = 150
        dgvtua.Columns(5).Width = 70
        dgvtua.Columns(6).Width = 100
        dgvtua.Columns(7).Width = 150
        dgvtua.Columns(8).Width = 50
        dgvtua.Columns(9).Width = 50
        dgvtua.Columns(10).Width = 50
        dgvtua.Columns(11).Width = 60
        dgvtua.Columns(12).Width = 100
        dgvtua.Columns(13).Width = 100
        dgvtua.Columns(14).Width = 100
        dgvtua.Columns(15).Width = 150
        dgvtua.Columns(16).Width = 70
        dgvtua.Columns(17).Width = 100
        dgvtua.Columns(18).Width = 150
        dgvtua.Columns(19).Width = 50
        dgvtua.Columns(20).Width = 50
        dgvtua.Columns(21).Width = 50
        dgvtua.Columns(22).Width = 60
        dgvtua.Columns(23).Width = 100
        dgvtua.Columns(24).Width = 100
        dgvtua.Columns(25).Width = 100
        dgvtua.Columns(26).Width = 150
        dgvtua.Columns(27).Width = 70
        dgvtua.Columns(28).Width = 100
        dgvtua.Columns(29).Width = 150

    End Sub
    Sub bersih()
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

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ComboBox9.Text = "Siswa/i" Then
            Form1.Show()
            Me.Hide()
        ElseIf ComboBox9.Text = "Data Keseluruhan" Then
            Form5.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildatagrid()
        Call aturlebarcolomgrid()
        dgvtua.ReadOnly = True

        ComboBox9.Items.Add("Siswa/i")
        ComboBox9.Items.Add("Orang Tua/Wali")
        ComboBox9.Items.Add("Data Keseluruhan")

        ComboBox11.Items.Add("Islam")
        ComboBox11.Items.Add("Protestan")
        ComboBox11.Items.Add("Katolik")
        ComboBox11.Items.Add("Buddha")
        ComboBox11.Items.Add("Hindu")
        ComboBox11.Items.Add("Konghucu")

        ComboBox7.Items.Add("Islam")
        ComboBox7.Items.Add("Protestan")
        ComboBox7.Items.Add("Katolik")
        ComboBox7.Items.Add("Buddha")
        ComboBox7.Items.Add("Hindu")
        ComboBox7.Items.Add("Konghucu")

        ComboBox8.Items.Add("Islam")
        ComboBox8.Items.Add("Protestan")
        ComboBox8.Items.Add("Katolik")
        ComboBox8.Items.Add("Buddha")
        ComboBox8.Items.Add("Hindu")
        ComboBox8.Items.Add("Konghucu")

        Button1.Enabled = False
        
    End Sub

    Private Sub TextBox42_Click(sender As Object, e As EventArgs) Handles TextBox42.Click
        If TextBox42.Text = "" Then
            Button1.Enabled = True
            
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox50.Text = "" Or TextBox49.Text = "" Or ComboBox11.Text = "" Or TextBox47.Text = "" Or TextBox26.Text = "" Or TextBox27.Text = "" Or TextBox28.Text = "" Or TextBox29.Text = "" Or TextBox30.Text = "" Or TextBox31.Text = "" Or TextBox40.Text = "" Or TextBox39.Text = "" Or ComboBox7.Text = "" Or TextBox38.Text = "" Or TextBox37.Text = "" Or TextBox36.Text = "" Or TextBox35.Text = "" Or TextBox34.Text = "" Or TextBox33.Text = "" Or TextBox32.Text = "" Or TextBox53.Text = "" Or TextBox52.Text = "" Or ComboBox8.Text = "" Or TextBox51.Text = "" Or TextBox48.Text = "" Or TextBox46.Text = "" Or TextBox45.Text = "" Or TextBox44.Text = "" Or TextBox43.Text = "" Or TextBox42.Text = "" Then

            MessageBox.Show("Data Harus Diisi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tanggalWaktu As String = DateTimePicker6.Value.ToString("dd MMMM yyyy")
            Dim tanggalWaktu1 As String = DateTimePicker4.Value.ToString("dd MMMM yyyy")
            Dim sqlForm1 As String = "insert into malesin(Nama_Ayah,Tempat_TanggalLahir,Agama,Kewarganegaraan,Pendidikan_Terakhir,Pekerjaan,Penghasilan_Per_Bulan,Alamat_Rumah,No_Telp,Hidup_TanggalKematian,Nama_Ibu,Tempat_TanggalLahir1,Agama1,Kewarganegaraan1,Pendidikan_Terakhir1,Pekerjaan1,Penghasilan_Per_Bulan1,Alamat_Rumah1,No_Telp1,Hidup_TanggalKematian1,Nama_Wali,Tempat_TanggalLahir2,Agama2,Kewarganegaraan2,Pendidikan_Terakhir2,Pekerjaan2,Penghasilan_Per_Bulan2,Alamat_Rumah2,No_Telp2,Hubungan_Keluarga) values( '" & TextBox50.Text & "','" & TextBox49.Text & ", " & tanggalWaktu & "','" & ComboBox11.Text & "','" & TextBox47.Text & "','" & TextBox26.Text & "','" & TextBox27.Text & "','" & TextBox28.Text & "','" & TextBox29.Text & "','" & TextBox30.Text & "','" & TextBox31.Text & "','" & TextBox40.Text & "','" & TextBox39.Text & ", " & tanggalWaktu1 & "','" & ComboBox7.Text & "','" & TextBox38.Text & "','" & TextBox37.Text & "','" & TextBox36.Text & "','" & TextBox35.Text & "','" & TextBox34.Text & "','" & TextBox33.Text & "','" & TextBox32.Text & "','" & TextBox53.Text & "','" & TextBox52.Text & "','" & ComboBox8.Text & "','" & TextBox51.Text & "','" & TextBox48.Text & "','" & TextBox46.Text & "','" & TextBox45.Text & "','" & TextBox44.Text & "','" & TextBox43.Text & "','" & TextBox42.Text & "')"
            CMD = New MySqlCommand(sqlForm1, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data Telah Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call tampildatagrid()
            Call aturlebarcolomgrid()
            Call bersih()


        End If
    End Sub

   

   

    Private Sub TextBox50_TextChanged(sender As Object, e As EventArgs) Handles TextBox50.TextChanged
    End Sub
End Class