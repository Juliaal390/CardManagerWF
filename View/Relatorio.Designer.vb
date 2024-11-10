<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Relatorio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DgvTransacoes = New System.Windows.Forms.DataGridView()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsbVoltar = New System.Windows.Forms.ToolStripButton()
        Me.LblMensagem = New System.Windows.Forms.Label()
        Me.NumeroCartaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorTransacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTransacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelatorioModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DgvTransacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.RelatorioModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvTransacoes
        '
        Me.DgvTransacoes.AllowUserToAddRows = False
        Me.DgvTransacoes.AllowUserToDeleteRows = False
        Me.DgvTransacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvTransacoes.AutoGenerateColumns = False
        Me.DgvTransacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTransacoes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DgvTransacoes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTransacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroCartaoDataGridViewTextBoxColumn, Me.ValorTransacaoDataGridViewTextBoxColumn, Me.DataTransacaoDataGridViewTextBoxColumn, Me.DescricaoDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn})
        Me.DgvTransacoes.DataSource = Me.RelatorioModelBindingSource
        Me.DgvTransacoes.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvTransacoes.Location = New System.Drawing.Point(90, 132)
        Me.DgvTransacoes.Name = "DgvTransacoes"
        Me.DgvTransacoes.ReadOnly = True
        Me.DgvTransacoes.RowHeadersWidth = 51
        Me.DgvTransacoes.RowTemplate.Height = 24
        Me.DgvTransacoes.Size = New System.Drawing.Size(1027, 369)
        Me.DgvTransacoes.TabIndex = 0
        '
        'LblTitulo
        '
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblTitulo.Location = New System.Drawing.Point(86, 67)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(1097, 25)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "Transações realizadas no último mês:"
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcel.Location = New System.Drawing.Point(951, 534)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(166, 38)
        Me.BtnExcel.TabIndex = 2
        Me.BtnExcel.Text = "Exportar para Excel"
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbVoltar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1183, 31)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsbVoltar
        '
        Me.TsbVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbVoltar.Image = Global.CardManager.My.Resources.Resources.icons8_esquerda_50
        Me.TsbVoltar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbVoltar.Name = "TsbVoltar"
        Me.TsbVoltar.Size = New System.Drawing.Size(29, 28)
        Me.TsbVoltar.Text = "Voltar"
        '
        'LblMensagem
        '
        Me.LblMensagem.BackColor = System.Drawing.Color.LightCoral
        Me.LblMensagem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblMensagem.ForeColor = System.Drawing.Color.Brown
        Me.LblMensagem.Location = New System.Drawing.Point(0, 645)
        Me.LblMensagem.Name = "LblMensagem"
        Me.LblMensagem.Size = New System.Drawing.Size(1183, 42)
        Me.LblMensagem.TabIndex = 5
        Me.LblMensagem.Text = "Ocorreu um erro durante a operação"
        Me.LblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumeroCartaoDataGridViewTextBoxColumn
        '
        Me.NumeroCartaoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Cartao"
        Me.NumeroCartaoDataGridViewTextBoxColumn.HeaderText = "Numero_Cartao"
        Me.NumeroCartaoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroCartaoDataGridViewTextBoxColumn.Name = "NumeroCartaoDataGridViewTextBoxColumn"
        Me.NumeroCartaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorTransacaoDataGridViewTextBoxColumn
        '
        Me.ValorTransacaoDataGridViewTextBoxColumn.DataPropertyName = "Valor_Transacao"
        Me.ValorTransacaoDataGridViewTextBoxColumn.HeaderText = "Valor_Transacao"
        Me.ValorTransacaoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ValorTransacaoDataGridViewTextBoxColumn.Name = "ValorTransacaoDataGridViewTextBoxColumn"
        Me.ValorTransacaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataTransacaoDataGridViewTextBoxColumn
        '
        Me.DataTransacaoDataGridViewTextBoxColumn.DataPropertyName = "Data_Transacao"
        Me.DataTransacaoDataGridViewTextBoxColumn.HeaderText = "Data_Transacao"
        Me.DataTransacaoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DataTransacaoDataGridViewTextBoxColumn.Name = "DataTransacaoDataGridViewTextBoxColumn"
        Me.DataTransacaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        Me.DescricaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RelatorioModelBindingSource
        '
        Me.RelatorioModelBindingSource.DataSource = GetType(CardManager.RelatorioModel)
        '
        'Relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1183, 687)
        Me.Controls.Add(Me.LblMensagem)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.DgvTransacoes)
        Me.Name = "Relatorio"
        Me.Text = "Card Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvTransacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.RelatorioModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvTransacoes As DataGridView
    Friend WithEvents LblTitulo As Label
    Friend WithEvents BtnExcel As Button
    Friend WithEvents NumeroCartaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorTransacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataTransacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RelatorioModelBindingSource As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TsbVoltar As ToolStripButton
    Friend WithEvents LblMensagem As Label
End Class
