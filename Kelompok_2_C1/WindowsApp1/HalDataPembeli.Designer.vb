<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalDataPembeli
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.txtnik = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtidpem = New System.Windows.Forms.TextBox()
        Me.txtnamapembeli = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(716, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 37)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "No HP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(716, 383)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 37)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "NIK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 444)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 37)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Alamat Pembeli"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(175, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 37)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Id_Pembeli"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama Pembeli"
        '
        'txtnohp
        '
        Me.txtnohp.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnohp.Location = New System.Drawing.Point(976, 319)
        Me.txtnohp.Multiline = True
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(257, 38)
        Me.txtnohp.TabIndex = 9
        '
        'txtnik
        '
        Me.txtnik.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnik.Location = New System.Drawing.Point(976, 383)
        Me.txtnik.Multiline = True
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(257, 38)
        Me.txtnik.TabIndex = 8
        '
        'txtalamat
        '
        Me.txtalamat.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(435, 444)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(257, 38)
        Me.txtalamat.TabIndex = 7
        '
        'txtidpem
        '
        Me.txtidpem.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidpem.Location = New System.Drawing.Point(435, 319)
        Me.txtidpem.Multiline = True
        Me.txtidpem.Name = "txtidpem"
        Me.txtidpem.Size = New System.Drawing.Size(257, 38)
        Me.txtidpem.TabIndex = 6
        '
        'txtnamapembeli
        '
        Me.txtnamapembeli.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamapembeli.Location = New System.Drawing.Point(435, 380)
        Me.txtnamapembeli.Multiline = True
        Me.txtnamapembeli.Name = "txtnamapembeli"
        Me.txtnamapembeli.Size = New System.Drawing.Size(257, 38)
        Me.txtnamapembeli.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(169, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1087, 217)
        Me.DataGridView1.TabIndex = 5
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.Color.Blue
        Me.BtnKembali.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.ForeColor = System.Drawing.Color.White
        Me.BtnKembali.Location = New System.Drawing.Point(744, 571)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(163, 49)
        Me.BtnKembali.TabIndex = 18
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Red
        Me.BtnBatal.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.ForeColor = System.Drawing.Color.White
        Me.BtnBatal.Location = New System.Drawing.Point(541, 571)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(127, 49)
        Me.BtnBatal.TabIndex = 19
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Lime
        Me.BtnTambah.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(313, 571)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(150, 49)
        Me.BtnTambah.TabIndex = 20
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Yellow
        Me.BtnHapus.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(976, 571)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(163, 43)
        Me.BtnHapus.TabIndex = 21
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'HalDataPembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.gambar_bentuk_rumah_besar__27_
        Me.ClientSize = New System.Drawing.Size(1424, 755)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtidpem)
        Me.Controls.Add(Me.txtnamapembeli)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "HalDataPembeli"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnohp As TextBox
    Friend WithEvents txtnik As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txtidpem As TextBox
    Friend WithEvents txtnamapembeli As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnHapus As Button
End Class
