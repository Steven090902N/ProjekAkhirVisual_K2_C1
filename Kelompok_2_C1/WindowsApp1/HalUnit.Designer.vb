<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalUnit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HalUnit))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtidrum = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.Label()
        Me.txttiperum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtblokrum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnorum = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 210)
        Me.DataGridView1.TabIndex = 0
        '
        'txtidrum
        '
        Me.txtidrum.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidrum.Location = New System.Drawing.Point(267, 283)
        Me.txtidrum.Multiline = True
        Me.txtidrum.Name = "txtidrum"
        Me.txtidrum.Size = New System.Drawing.Size(270, 38)
        Me.txtidrum.TabIndex = 1
        '
        'txtid
        '
        Me.txtid.AutoSize = True
        Me.txtid.BackColor = System.Drawing.Color.White
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(12, 283)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(159, 37)
        Me.txtid.TabIndex = 2
        Me.txtid.Text = "Id Rumah"
        '
        'txttiperum
        '
        Me.txttiperum.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttiperum.Location = New System.Drawing.Point(267, 361)
        Me.txttiperum.Multiline = True
        Me.txttiperum.Name = "txttiperum"
        Me.txttiperum.Size = New System.Drawing.Size(270, 38)
        Me.txttiperum.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipe Rumah"
        '
        'txtblokrum
        '
        Me.txtblokrum.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtblokrum.Location = New System.Drawing.Point(267, 437)
        Me.txtblokrum.Multiline = True
        Me.txtblokrum.Name = "txtblokrum"
        Me.txtblokrum.Size = New System.Drawing.Size(270, 38)
        Me.txtblokrum.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blok Rumah"
        '
        'txtnorum
        '
        Me.txtnorum.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnorum.Location = New System.Drawing.Point(808, 283)
        Me.txtnorum.Multiline = True
        Me.txtnorum.Name = "txtnorum"
        Me.txtnorum.Size = New System.Drawing.Size(270, 38)
        Me.txtnorum.TabIndex = 1
        '
        'txtharga
        '
        Me.txtharga.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.Location = New System.Drawing.Point(808, 361)
        Me.txtharga.Multiline = True
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(270, 38)
        Me.txtharga.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(571, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 37)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "No. Rumah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(571, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 37)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Harga Rumah"
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Lime
        Me.BtnTambah.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(226, 638)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(150, 49)
        Me.BtnTambah.TabIndex = 3
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Red
        Me.BtnBatal.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.ForeColor = System.Drawing.Color.White
        Me.BtnBatal.Location = New System.Drawing.Point(434, 637)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(127, 49)
        Me.BtnBatal.TabIndex = 3
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.Color.Blue
        Me.BtnKembali.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.ForeColor = System.Drawing.Color.White
        Me.BtnKembali.Location = New System.Drawing.Point(615, 638)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(163, 49)
        Me.BtnKembali.TabIndex = 3
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Yellow
        Me.BtnHapus.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(846, 639)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(176, 47)
        Me.BtnHapus.TabIndex = 4
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'HalUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1090, 781)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtblokrum)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txttiperum)
        Me.Controls.Add(Me.txtnorum)
        Me.Controls.Add(Me.txtidrum)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "HalUnit"
        Me.Text = "HalUnit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtidrum As TextBox
    Friend WithEvents txtid As Label
    Friend WithEvents txttiperum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtblokrum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnorum As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnHapus As Button
End Class
