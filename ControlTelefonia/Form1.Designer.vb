<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.division = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.centroGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargar = New System.Windows.Forms.Button()
        Me.txtTotalMovil = New System.Windows.Forms.TextBox()
        Me.txtTotalFijo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtImporteConsumoMovil = New System.Windows.Forms.TextBox()
        Me.txtImporteConsumoFijo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFichero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.division, Me.factura, Me.tipoLinea, Me.centroGasto, Me.concepto, Me.linea, Me.fecha, Me.importe, Me.usuario, Me.ubicacion, Me.tarifa})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1358, 316)
        Me.DataGridView1.TabIndex = 0
        '
        'division
        '
        Me.division.HeaderText = "Division"
        Me.division.Name = "division"
        '
        'factura
        '
        Me.factura.HeaderText = "Factura"
        Me.factura.Name = "factura"
        '
        'tipoLinea
        '
        Me.tipoLinea.HeaderText = "Tipo Linea"
        Me.tipoLinea.Name = "tipoLinea"
        '
        'centroGasto
        '
        Me.centroGasto.HeaderText = "Centro Gasto"
        Me.centroGasto.Name = "centroGasto"
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        '
        'linea
        '
        Me.linea.HeaderText = "Linea"
        Me.linea.Name = "linea"
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        '
        'importe
        '
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        '
        'ubicacion
        '
        Me.ubicacion.HeaderText = "Ubicacion"
        Me.ubicacion.Name = "ubicacion"
        '
        'tarifa
        '
        Me.tarifa.HeaderText = "Tarifa"
        Me.tarifa.Name = "tarifa"
        '
        'Cargar
        '
        Me.Cargar.Location = New System.Drawing.Point(1223, 388)
        Me.Cargar.Name = "Cargar"
        Me.Cargar.Size = New System.Drawing.Size(147, 44)
        Me.Cargar.TabIndex = 1
        Me.Cargar.Text = "Cargar fichero"
        Me.Cargar.UseVisualStyleBackColor = True
        '
        'txtTotalMovil
        '
        Me.txtTotalMovil.Location = New System.Drawing.Point(306, 355)
        Me.txtTotalMovil.Name = "txtTotalMovil"
        Me.txtTotalMovil.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalMovil.TabIndex = 2
        '
        'txtTotalFijo
        '
        Me.txtTotalFijo.Location = New System.Drawing.Point(306, 387)
        Me.txtTotalFijo.Name = "txtTotalFijo"
        Me.txtTotalFijo.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalFijo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Importe movil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Importe fijo"
        '
        'txtImporteConsumoMovil
        '
        Me.txtImporteConsumoMovil.Location = New System.Drawing.Point(424, 355)
        Me.txtImporteConsumoMovil.Name = "txtImporteConsumoMovil"
        Me.txtImporteConsumoMovil.Size = New System.Drawing.Size(100, 22)
        Me.txtImporteConsumoMovil.TabIndex = 6
        '
        'txtImporteConsumoFijo
        '
        Me.txtImporteConsumoFijo.Location = New System.Drawing.Point(424, 387)
        Me.txtImporteConsumoFijo.Name = "txtImporteConsumoFijo"
        Me.txtImporteConsumoFijo.Size = New System.Drawing.Size(100, 22)
        Me.txtImporteConsumoFijo.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1052, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 44)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Seleccionar fichero"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFichero
        '
        Me.txtFichero.Location = New System.Drawing.Point(755, 387)
        Me.txtFichero.Name = "txtFichero"
        Me.txtFichero.Size = New System.Drawing.Size(261, 22)
        Me.txtFichero.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(593, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fichero seleccionado"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(1400, 470)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFichero)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtImporteConsumoFijo)
        Me.Controls.Add(Me.txtImporteConsumoMovil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalFijo)
        Me.Controls.Add(Me.txtTotalMovil)
        Me.Controls.Add(Me.Cargar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IntranetDataSet As IntranetDataSet
    Friend WithEvents TLCONTROLTELEFONIABindingSource As BindingSource
    Friend WithEvents TL_CONTROL_TELEFONIATableAdapter As IntranetDataSetTableAdapters.TL_CONTROL_TELEFONIATableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCargarFichero As Button
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents FacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipolineaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipogastoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LineaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarifaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cargar As Button
    Friend WithEvents txtTotalMovil As TextBox
    Friend WithEvents txtTotalFijo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtImporteConsumoMovil As TextBox
    Friend WithEvents txtImporteConsumoFijo As TextBox
    Friend WithEvents division As DataGridViewTextBoxColumn
    Friend WithEvents factura As DataGridViewTextBoxColumn
    Friend WithEvents tipoLinea As DataGridViewTextBoxColumn
    Friend WithEvents centroGasto As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents linea As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents tarifa As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFichero As TextBox
    Friend WithEvents Label3 As Label
End Class
