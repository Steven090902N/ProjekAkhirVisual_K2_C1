Imports MySql.Data.MySqlClient
Public Class HalDataPembeli

    Sub Tampil()
        Da = New MySqlDataAdapter("select * from datapembeli", Cn)
        Ds = New DataSet
        Da.Fill(Ds, "datapembeli")
        DataGridView1.DataSource = Ds.Tables("datapembeli")
        DataGridView1.ReadOnly = True
    End Sub

    Sub Kosong()
        txtnohp.Text = ""
        txtnamapembeli.Text = ""
        txtidpem.Text = ""
        txtalamat.Text = ""
        txtnik.Text = ""
        txtnohp.Focus()
    End Sub

    Private Sub HalUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BukaDb()
        Call Tampil()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If txtidpem.Text = "" Then
            MsgBox("Wajib Diisi")
            Call Kosong()
        Else
            Cmd = New MySqlCommand("insert into datapembeli (id_pembeli,Nama_Pembeli,Alamat_Pembeli,NoHp,NIK)" & "values('" & txtidpem.Text & "','" & txtnamapembeli.Text & "','" & txtalamat.Text & "','" & txtnohp.Text & "','" & txtnik.Text & "')", Cn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Pembeli Berhasil Ditambah")
            Call Kosong()
        End If
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Hide()
        HalManagement.Show()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        txtnohp.Text = ""
        txtnamapembeli.Text = ""
        txtidpem.Text = ""
        txtalamat.Text = ""
        txtnik.Text = ""
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If txtidpem.Text = "" Then
            MsgBox("Kode Buku belum diisi!")
            txtidpem.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus Data mobil " & txtidpem.Text &
                               " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Cmd = New MySqlCommand("Delete From datapembeli Where id_pembeli = '" & txtidpem.Text & "'", Cn)
                Cmd.ExecuteNonQuery()
                Call Kosong()
                Call Tampil()
            Else
                Call Kosong()
            End If
        End If
    End Sub
End Class