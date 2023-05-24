<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HalManagement))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Keluar = New System.Windows.Forms.Button()
        Me.DataPembeli = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(336, 104)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Management Unit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(12, 194)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(336, 104)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Transaksi"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Keluar
        '
        Me.Keluar.BackColor = System.Drawing.Color.Blue
        Me.Keluar.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keluar.ForeColor = System.Drawing.Color.White
        Me.Keluar.Location = New System.Drawing.Point(12, 492)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(336, 104)
        Me.Keluar.TabIndex = 0
        Me.Keluar.Text = "Keluar"
        Me.Keluar.UseVisualStyleBackColor = False
        '
        'DataPembeli
        '
        Me.DataPembeli.BackColor = System.Drawing.Color.Blue
        Me.DataPembeli.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPembeli.ForeColor = System.Drawing.Color.White
        Me.DataPembeli.Location = New System.Drawing.Point(12, 341)
        Me.DataPembeli.Name = "DataPembeli"
        Me.DataPembeli.Size = New System.Drawing.Size(336, 104)
        Me.DataPembeli.TabIndex = 0
        Me.DataPembeli.Text = "Data Pembeli"
        Me.DataPembeli.UseVisualStyleBackColor = False
        '
        'HalManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1360, 1055)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.DataPembeli)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "HalManagement"
        Me.Text = "HalManagement"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Keluar As Button
    Friend WithEvents DataPembeli As Button
End Class
