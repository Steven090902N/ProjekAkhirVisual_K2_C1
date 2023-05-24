
Imports MySql.Data.MySqlClient
Public Class HalTransaksi

    Sub Tampil()
        Da = New MySqlDataAdapter("select * from transaksi", Cn)
        Ds = New DataSet
        Da.Fill(Ds, "transaksi")
        DataGridView1.DataSource = Ds.Tables("transaksi")
        DataGridView1.ReadOnly = True
    End Sub

    Sub Kosong()
        txtidrum.Text = ""
        txtidpem.Text = ""
        txtjlh.Text = ""
        txtharga.Text = ""
        txttotal.Text = ""
        txtidrum.Focus()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        HalManagement.Show()
    End Sub

    Private Sub HalTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BukaDb()
        Call Tampil()
        txttgl.Text = Today
        txttgl.Enabled = False
        txttotal.Enabled = False
        txtharga.Enabled = False
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If txtidrum.Text = "" Then
            MsgBox("Wajib Diisi")
            Call Kosong()
        Else
            Cmd = New MySqlCommand("insert into transaksi(Tgl_Transaksi,Id_Rumah,Id_Pembeli,Jumlah,Harga_Rumah,Total)" & "values('" & Format(Now, "yyyy/MM/dd") & "','" &
                                   txtidrum.Text & "','" & txtidpem.Text & "','" & txtjlh.Text & "','" & txtharga.Text & "','" & txttotal.Text & "')", Cn)
            Cmd.ExecuteNonQuery()
            Call Tampil()
            Call Kosong()
        End If
    End Sub

    Private Sub txtidrum_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidrum.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmd = New MySqlCommand("select * From rumahtb where Id_Rumah='" & txtidrum.Text & "'", Cn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                txtidrum.Text = Rd.GetString(0)
                txtharga.Text = Rd.GetValue(4)
                txtjlh.Focus()
            Else
                MsgBox("Unit sudah tidak tersedia")
                Call Kosong()
            End If
            Rd.Close()
        End If
    End Sub

    Private Sub txtjlh_KeyDown(sender As Object, e As KeyEventArgs) Handles txtjlh.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttotal.Text = Val(txtjlh.Text) * Val(txtharga.Text)
            BtnSimpan.Focus()
        End If
    End Sub

    Private Sub IdPembeli_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If txtidrum.Text = "" Then
            MsgBox("Kode Buku belum diisi!")
            txtidrum.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus Data mobil " & txtidrum.Text &
                               " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Cmd = New MySqlCommand("Delete From transaksi Where Id_Rumah = '" & txtidrum.Text & "'", Cn)
                Cmd.ExecuteNonQuery()
                Call Kosong()
                Call Tampil()
            Else
                Call Kosong()
            End If
        End If
    End Sub
End Class