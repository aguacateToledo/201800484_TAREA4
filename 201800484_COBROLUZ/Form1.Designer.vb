<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cbxServicio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.txtSaldoAnterior = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConsumoKiloW = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxTarifa = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.button4 = New System.Windows.Forms.Button()
        Me.btnBodega = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.listServicios = New System.Windows.Forms.ListBox()
        Me.listTarifa = New System.Windows.Forms.ListBox()
        Me.listSaldoAnterior = New System.Windows.Forms.ListBox()
        Me.listPagoInicial = New System.Windows.Forms.ListBox()
        Me.listMora = New System.Windows.Forms.ListBox()
        Me.listDescuento = New System.Windows.Forms.ListBox()
        Me.listPagoTotal = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxServicio
        '
        Me.cbxServicio.FormattingEnabled = True
        Me.cbxServicio.Items.AddRange(New Object() {"residencial", "industrial"})
        Me.cbxServicio.Location = New System.Drawing.Point(149, 224)
        Me.cbxServicio.Name = "cbxServicio"
        Me.cbxServicio.Size = New System.Drawing.Size(121, 24)
        Me.cbxServicio.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nit"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(149, 32)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(121, 22)
        Me.txtNit.TabIndex = 2
        '
        'txtSaldoAnterior
        '
        Me.txtSaldoAnterior.AutoSize = True
        Me.txtSaldoAnterior.Location = New System.Drawing.Point(13, 94)
        Me.txtSaldoAnterior.Name = "txtSaldoAnterior"
        Me.txtSaldoAnterior.Size = New System.Drawing.Size(98, 17)
        Me.txtSaldoAnterior.TabIndex = 3
        Me.txtSaldoAnterior.Text = "Saldo Anterior"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(149, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 22)
        Me.TextBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Consumo Kilowatts"
        '
        'txtConsumoKiloW
        '
        Me.txtConsumoKiloW.Location = New System.Drawing.Point(149, 147)
        Me.txtConsumoKiloW.Name = "txtConsumoKiloW"
        Me.txtConsumoKiloW.Size = New System.Drawing.Size(121, 22)
        Me.txtConsumoKiloW.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tipo de servicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo de tarifa"
        '
        'cbxTarifa
        '
        Me.cbxTarifa.FormattingEnabled = True
        Me.cbxTarifa.Items.AddRange(New Object() {"social", "no social"})
        Me.cbxTarifa.Location = New System.Drawing.Point(149, 281)
        Me.cbxTarifa.Name = "cbxTarifa"
        Me.cbxTarifa.Size = New System.Drawing.Size(121, 24)
        Me.cbxTarifa.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Pink
        Me.GroupBox1.Controls.Add(Me.listPagoTotal)
        Me.GroupBox1.Controls.Add(Me.listDescuento)
        Me.GroupBox1.Controls.Add(Me.listMora)
        Me.GroupBox1.Controls.Add(Me.listPagoInicial)
        Me.GroupBox1.Controls.Add(Me.listSaldoAnterior)
        Me.GroupBox1.Controls.Add(Me.listTarifa)
        Me.GroupBox1.Controls.Add(Me.listServicios)
        Me.GroupBox1.Location = New System.Drawing.Point(316, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 323)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultados"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.button4)
        Me.Panel1.Controls.Add(Me.btnBodega)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, 450)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 120)
        Me.Panel1.TabIndex = 51
        '
        'button4
        '
        Me.button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.button4.FlatAppearance.BorderSize = 0
        Me.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Image = Global._201800484_COBROLUZ.My.Resources.Resources._exit
        Me.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button4.Location = New System.Drawing.Point(734, 0)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(367, 120)
        Me.button4.TabIndex = 9
        Me.button4.Text = "Salir"
        Me.button4.UseVisualStyleBackColor = True
        '
        'btnBodega
        '
        Me.btnBodega.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBodega.FlatAppearance.BorderSize = 0
        Me.btnBodega.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBodega.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBodega.Image = Global._201800484_COBROLUZ.My.Resources.Resources.clean
        Me.btnBodega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBodega.Location = New System.Drawing.Point(367, 0)
        Me.btnBodega.Name = "btnBodega"
        Me.btnBodega.Size = New System.Drawing.Size(367, 120)
        Me.btnBodega.TabIndex = 8
        Me.btnBodega.Text = "Limpiar"
        Me.btnBodega.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global._201800484_COBROLUZ.My.Resources.Resources.calculadora__1_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(367, 120)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'listServicios
        '
        Me.listServicios.FormattingEnabled = True
        Me.listServicios.ItemHeight = 16
        Me.listServicios.Location = New System.Drawing.Point(7, 38)
        Me.listServicios.Name = "listServicios"
        Me.listServicios.Size = New System.Drawing.Size(96, 260)
        Me.listServicios.TabIndex = 0
        '
        'listTarifa
        '
        Me.listTarifa.FormattingEnabled = True
        Me.listTarifa.ItemHeight = 16
        Me.listTarifa.Location = New System.Drawing.Point(109, 38)
        Me.listTarifa.Name = "listTarifa"
        Me.listTarifa.Size = New System.Drawing.Size(96, 260)
        Me.listTarifa.TabIndex = 1
        '
        'listSaldoAnterior
        '
        Me.listSaldoAnterior.FormattingEnabled = True
        Me.listSaldoAnterior.ItemHeight = 16
        Me.listSaldoAnterior.Location = New System.Drawing.Point(211, 38)
        Me.listSaldoAnterior.Name = "listSaldoAnterior"
        Me.listSaldoAnterior.Size = New System.Drawing.Size(96, 260)
        Me.listSaldoAnterior.TabIndex = 2
        '
        'listPagoInicial
        '
        Me.listPagoInicial.FormattingEnabled = True
        Me.listPagoInicial.ItemHeight = 16
        Me.listPagoInicial.Location = New System.Drawing.Point(313, 38)
        Me.listPagoInicial.Name = "listPagoInicial"
        Me.listPagoInicial.Size = New System.Drawing.Size(96, 260)
        Me.listPagoInicial.TabIndex = 3
        '
        'listMora
        '
        Me.listMora.FormattingEnabled = True
        Me.listMora.ItemHeight = 16
        Me.listMora.Location = New System.Drawing.Point(415, 38)
        Me.listMora.Name = "listMora"
        Me.listMora.Size = New System.Drawing.Size(96, 260)
        Me.listMora.TabIndex = 4
        '
        'listDescuento
        '
        Me.listDescuento.FormattingEnabled = True
        Me.listDescuento.ItemHeight = 16
        Me.listDescuento.Location = New System.Drawing.Point(517, 38)
        Me.listDescuento.Name = "listDescuento"
        Me.listDescuento.Size = New System.Drawing.Size(96, 260)
        Me.listDescuento.TabIndex = 5
        '
        'listPagoTotal
        '
        Me.listPagoTotal.FormattingEnabled = True
        Me.listPagoTotal.ItemHeight = 16
        Me.listPagoTotal.Location = New System.Drawing.Point(619, 38)
        Me.listPagoTotal.Name = "listPagoTotal"
        Me.listPagoTotal.Size = New System.Drawing.Size(96, 260)
        Me.listPagoTotal.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 577)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxTarifa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtConsumoKiloW)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtSaldoAnterior)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxServicio)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxServicio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNit As TextBox
    Friend WithEvents txtSaldoAnterior As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConsumoKiloW As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxTarifa As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents button4 As Button
    Private WithEvents btnBodega As Button
    Private WithEvents Button2 As Button
    Friend WithEvents listPagoTotal As ListBox
    Friend WithEvents listDescuento As ListBox
    Friend WithEvents listMora As ListBox
    Friend WithEvents listPagoInicial As ListBox
    Friend WithEvents listSaldoAnterior As ListBox
    Friend WithEvents listTarifa As ListBox
    Friend WithEvents listServicios As ListBox
End Class
