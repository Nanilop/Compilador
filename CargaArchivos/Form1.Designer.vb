<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCarga = New System.Windows.Forms.Button()
        Me.btnCompila = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbEntra = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.lbIden = New System.Windows.Forms.ListBox()
        Me.lbEnter = New System.Windows.Forms.ListBox()
        Me.lbReal = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbStr = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGVSalida = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.PictureBox()
        CType(Me.DGVSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCarga
        '
        Me.btnCarga.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarga.Location = New System.Drawing.Point(12, 316)
        Me.btnCarga.Name = "btnCarga"
        Me.btnCarga.Size = New System.Drawing.Size(105, 50)
        Me.btnCarga.TabIndex = 0
        Me.btnCarga.Text = "CARGAR ARCHIVO"
        Me.btnCarga.UseVisualStyleBackColor = True
        '
        'btnCompila
        '
        Me.btnCompila.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompila.Location = New System.Drawing.Point(1054, 316)
        Me.btnCompila.Name = "btnCompila"
        Me.btnCompila.Size = New System.Drawing.Size(105, 50)
        Me.btnCompila.TabIndex = 1
        Me.btnCompila.Text = "COMPILAR"
        Me.btnCompila.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Programa Fuente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Archivo de Salida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(527, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "P. Reservadas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(662, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Identificadores"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(795, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cte. Enteras"
        '
        'lbEntra
        '
        Me.lbEntra.FormattingEnabled = True
        Me.lbEntra.Location = New System.Drawing.Point(12, 87)
        Me.lbEntra.Name = "lbEntra"
        Me.lbEntra.Size = New System.Drawing.Size(136, 212)
        Me.lbEntra.TabIndex = 7
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(531, 87)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(108, 212)
        Me.ListBox3.TabIndex = 9
        '
        'lbIden
        '
        Me.lbIden.FormattingEnabled = True
        Me.lbIden.Location = New System.Drawing.Point(666, 87)
        Me.lbIden.Name = "lbIden"
        Me.lbIden.Size = New System.Drawing.Size(113, 212)
        Me.lbIden.TabIndex = 10
        '
        'lbEnter
        '
        Me.lbEnter.FormattingEnabled = True
        Me.lbEnter.Location = New System.Drawing.Point(799, 87)
        Me.lbEnter.Name = "lbEnter"
        Me.lbEnter.Size = New System.Drawing.Size(105, 212)
        Me.lbEnter.TabIndex = 11
        '
        'lbReal
        '
        Me.lbReal.FormattingEnabled = True
        Me.lbReal.Location = New System.Drawing.Point(930, 87)
        Me.lbReal.Name = "lbReal"
        Me.lbReal.Size = New System.Drawing.Size(105, 212)
        Me.lbReal.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(926, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cte. Reales"
        '
        'lbStr
        '
        Me.lbStr.FormattingEnabled = True
        Me.lbStr.Location = New System.Drawing.Point(1054, 87)
        Me.lbStr.Name = "lbStr"
        Me.lbStr.Size = New System.Drawing.Size(105, 212)
        Me.lbStr.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1050, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cte. String"
        '
        'DGVSalida
        '
        Me.DGVSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSalida.Location = New System.Drawing.Point(169, 87)
        Me.DGVSalida.Name = "DGVSalida"
        Me.DGVSalida.Size = New System.Drawing.Size(343, 212)
        Me.DGVSalida.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(300, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(540, 55)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "COMPILADOR DBASE"
        '
        'btnExportar
        '
        Me.btnExportar.Enabled = False
        Me.btnExportar.Location = New System.Drawing.Point(989, 316)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(46, 50)
        Me.btnExportar.TabIndex = 19
        Me.btnExportar.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1171, 378)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGVSalida)
        Me.Controls.Add(Me.lbStr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbReal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbEnter)
        Me.Controls.Add(Me.lbIden)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.lbEntra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCompila)
        Me.Controls.Add(Me.btnCarga)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGVSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCarga As System.Windows.Forms.Button
    Friend WithEvents btnCompila As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbEntra As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents lbIden As System.Windows.Forms.ListBox
    Friend WithEvents lbEnter As System.Windows.Forms.ListBox
    Friend WithEvents lbReal As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbStr As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DGVSalida As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents btnExportar As PictureBox
End Class
