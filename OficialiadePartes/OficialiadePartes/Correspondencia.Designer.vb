<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Correspondencia
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.CorrespondenciaDataSet = New OficialiadePartes.CorrespondenciaDataSet()
        Me.DocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentoTableAdapter = New OficialiadePartes.CorrespondenciaDataSetTableAdapters.DocumentoTableAdapter()
        Me.IdDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroOficioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaOficioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRecepcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsuntoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemitenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinatarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDFDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.CorrespondenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.GroupBox1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(944, 556)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(944, 595)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 541)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Correspondencia Recibida"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDocumentoDataGridViewTextBoxColumn, Me.NumeroOficioDataGridViewTextBoxColumn, Me.FechaOficioDataGridViewTextBoxColumn, Me.FechaRecepcionDataGridViewTextBoxColumn, Me.AsuntoDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.RemitenteDataGridViewTextBoxColumn, Me.DestinatarioDataGridViewTextBoxColumn, Me.PDFDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.DocumentoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(914, 522)
        Me.DataGridView1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.ToolStripButton2, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(487, 39)
        Me.ToolStrip1.TabIndex = 0
        '
        'Nuevo
        '
        Me.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo.Image = Global.OficialiadePartes.My.Resources.Resources.Add_32x32
        Me.Nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(36, 36)
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.ToolTipText = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.OficialiadePartes.My.Resources.Resources.Edit_32x32
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "Editar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.OficialiadePartes.My.Resources.Resources.Delete_32x32
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton4.Text = "Borrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(250, 39)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.OficialiadePartes.My.Resources.Resources.Search_32x32
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton3.Text = "Buscar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.OficialiadePartes.My.Resources.Resources.Log_Out_32x32
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton5.Text = "Exit"
        '
        'CorrespondenciaDataSet
        '
        Me.CorrespondenciaDataSet.DataSetName = "CorrespondenciaDataSet"
        Me.CorrespondenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DocumentoBindingSource
        '
        Me.DocumentoBindingSource.DataMember = "Documento"
        Me.DocumentoBindingSource.DataSource = Me.CorrespondenciaDataSet
        '
        'DocumentoTableAdapter
        '
        Me.DocumentoTableAdapter.ClearBeforeFill = True
        '
        'IdDocumentoDataGridViewTextBoxColumn
        '
        Me.IdDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Id_Documento"
        Me.IdDocumentoDataGridViewTextBoxColumn.HeaderText = "Id_Documento"
        Me.IdDocumentoDataGridViewTextBoxColumn.Name = "IdDocumentoDataGridViewTextBoxColumn"
        Me.IdDocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroOficioDataGridViewTextBoxColumn
        '
        Me.NumeroOficioDataGridViewTextBoxColumn.DataPropertyName = "NumeroOficio"
        Me.NumeroOficioDataGridViewTextBoxColumn.HeaderText = "NumeroOficio"
        Me.NumeroOficioDataGridViewTextBoxColumn.Name = "NumeroOficioDataGridViewTextBoxColumn"
        Me.NumeroOficioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaOficioDataGridViewTextBoxColumn
        '
        Me.FechaOficioDataGridViewTextBoxColumn.DataPropertyName = "FechaOficio"
        Me.FechaOficioDataGridViewTextBoxColumn.HeaderText = "FechaOficio"
        Me.FechaOficioDataGridViewTextBoxColumn.Name = "FechaOficioDataGridViewTextBoxColumn"
        Me.FechaOficioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaRecepcionDataGridViewTextBoxColumn
        '
        Me.FechaRecepcionDataGridViewTextBoxColumn.DataPropertyName = "FechaRecepcion"
        Me.FechaRecepcionDataGridViewTextBoxColumn.HeaderText = "FechaRecepcion"
        Me.FechaRecepcionDataGridViewTextBoxColumn.Name = "FechaRecepcionDataGridViewTextBoxColumn"
        Me.FechaRecepcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AsuntoDataGridViewTextBoxColumn
        '
        Me.AsuntoDataGridViewTextBoxColumn.DataPropertyName = "Asunto"
        Me.AsuntoDataGridViewTextBoxColumn.HeaderText = "Asunto"
        Me.AsuntoDataGridViewTextBoxColumn.Name = "AsuntoDataGridViewTextBoxColumn"
        Me.AsuntoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemitenteDataGridViewTextBoxColumn
        '
        Me.RemitenteDataGridViewTextBoxColumn.DataPropertyName = "Remitente"
        Me.RemitenteDataGridViewTextBoxColumn.HeaderText = "Remitente"
        Me.RemitenteDataGridViewTextBoxColumn.Name = "RemitenteDataGridViewTextBoxColumn"
        Me.RemitenteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DestinatarioDataGridViewTextBoxColumn
        '
        Me.DestinatarioDataGridViewTextBoxColumn.DataPropertyName = "Destinatario"
        Me.DestinatarioDataGridViewTextBoxColumn.HeaderText = "Destinatario"
        Me.DestinatarioDataGridViewTextBoxColumn.Name = "DestinatarioDataGridViewTextBoxColumn"
        Me.DestinatarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PDFDataGridViewImageColumn
        '
        Me.PDFDataGridViewImageColumn.DataPropertyName = "PDF"
        Me.PDFDataGridViewImageColumn.HeaderText = "PDF"
        Me.PDFDataGridViewImageColumn.Name = "PDFDataGridViewImageColumn"
        Me.PDFDataGridViewImageColumn.ReadOnly = True
        '
        'Correspondencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 595)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "Correspondencia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Correspondencia"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.CorrespondenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Nuevo As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents CorrespondenciaDataSet As CorrespondenciaDataSet
    Friend WithEvents DocumentoBindingSource As BindingSource
    Friend WithEvents DocumentoTableAdapter As CorrespondenciaDataSetTableAdapters.DocumentoTableAdapter
    Friend WithEvents IdDocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroOficioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaOficioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaRecepcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AsuntoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemitenteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DestinatarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDFDataGridViewImageColumn As DataGridViewImageColumn
End Class
