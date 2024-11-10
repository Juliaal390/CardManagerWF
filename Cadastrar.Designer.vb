<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cadastrar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpData = New System.Windows.Forms.DateTimePicker()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.TxtNumCartao = New System.Windows.Forms.MaskedTextBox()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.GridTransacoes = New System.Windows.Forms.DataGridView()
        Me.Editar = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.TxtPesValor = New System.Windows.Forms.TextBox()
        Me.TxtPesNumCartao = New System.Windows.Forms.MaskedTextBox()
        Me.DtpPesData = New System.Windows.Forms.DateTimePicker()
        Me.LblPesNumCartao = New System.Windows.Forms.Label()
        Me.LblPesValor = New System.Windows.Forms.Label()
        Me.BtnLimparPesquisa = New System.Windows.Forms.Button()
        Me.CbFiltrarData = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsbVoltar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.LblMensagem = New System.Windows.Forms.Label()
        Me.IdTransacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroCartaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorTransacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTransacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransacaoModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridTransacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TransacaoModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblTitle.Location = New System.Drawing.Point(27, 40)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(0, 29)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Número do Cartão: *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(249, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valor: *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(424, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Data: *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descrição:"
        '
        'DtpData
        '
        Me.DtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpData.Location = New System.Drawing.Point(431, 145)
        Me.DtpData.Name = "DtpData"
        Me.DtpData.Size = New System.Drawing.Size(155, 22)
        Me.DtpData.TabIndex = 6
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(256, 145)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(123, 22)
        Me.TxtValor.TabIndex = 7
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(58, 214)
        Me.TxtDescricao.Multiline = True
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(499, 59)
        Me.TxtDescricao.TabIndex = 9
        '
        'TxtNumCartao
        '
        Me.TxtNumCartao.Location = New System.Drawing.Point(58, 145)
        Me.TxtNumCartao.Mask = "0000 0000 0000 0000"
        Me.TxtNumCartao.Name = "TxtNumCartao"
        Me.TxtNumCartao.Size = New System.Drawing.Size(150, 22)
        Me.TxtNumCartao.TabIndex = 10
        Me.TxtNumCartao.ValidatingType = GetType(Integer)
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdicionar.Location = New System.Drawing.Point(587, 236)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(120, 37)
        Me.BtnAdicionar.TabIndex = 12
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'GridTransacoes
        '
        Me.GridTransacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridTransacoes.AutoGenerateColumns = False
        Me.GridTransacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridTransacoes.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GridTransacoes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTransacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTransacaoDataGridViewTextBoxColumn, Me.NumeroCartaoDataGridViewTextBoxColumn, Me.ValorTransacaoDataGridViewTextBoxColumn, Me.DataTransacaoDataGridViewTextBoxColumn, Me.DescricaoDataGridViewTextBoxColumn, Me.Editar, Me.Excluir})
        Me.GridTransacoes.DataSource = Me.TransacaoModelBindingSource
        Me.GridTransacoes.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GridTransacoes.Location = New System.Drawing.Point(32, 400)
        Me.GridTransacoes.Name = "GridTransacoes"
        Me.GridTransacoes.RowHeadersWidth = 51
        Me.GridTransacoes.RowTemplate.Height = 24
        Me.GridTransacoes.Size = New System.Drawing.Size(1053, 457)
        Me.GridTransacoes.TabIndex = 13
        '
        'Editar
        '
        Me.Editar.HeaderText = "Editar"
        Me.Editar.MinimumWidth = 6
        Me.Editar.Name = "Editar"
        Me.Editar.ReadOnly = True
        Me.Editar.Text = "Editar"
        Me.Editar.UseColumnTextForLinkValue = True
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.MinimumWidth = 6
        Me.Excluir.Name = "Excluir"
        Me.Excluir.ReadOnly = True
        Me.Excluir.Text = "Excluir"
        Me.Excluir.UseColumnTextForLinkValue = True
        '
        'TxtPesValor
        '
        Me.TxtPesValor.Location = New System.Drawing.Point(227, 363)
        Me.TxtPesValor.Name = "TxtPesValor"
        Me.TxtPesValor.Size = New System.Drawing.Size(115, 22)
        Me.TxtPesValor.TabIndex = 14
        '
        'TxtPesNumCartao
        '
        Me.TxtPesNumCartao.Location = New System.Drawing.Point(32, 363)
        Me.TxtPesNumCartao.Mask = "0000 0000 0000 0000"
        Me.TxtPesNumCartao.Name = "TxtPesNumCartao"
        Me.TxtPesNumCartao.Size = New System.Drawing.Size(139, 22)
        Me.TxtPesNumCartao.TabIndex = 16
        '
        'DtpPesData
        '
        Me.DtpPesData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPesData.Location = New System.Drawing.Point(402, 363)
        Me.DtpPesData.Name = "DtpPesData"
        Me.DtpPesData.Size = New System.Drawing.Size(155, 22)
        Me.DtpPesData.TabIndex = 17
        '
        'LblPesNumCartao
        '
        Me.LblPesNumCartao.AutoSize = True
        Me.LblPesNumCartao.Location = New System.Drawing.Point(32, 341)
        Me.LblPesNumCartao.Name = "LblPesNumCartao"
        Me.LblPesNumCartao.Size = New System.Drawing.Size(117, 16)
        Me.LblPesNumCartao.TabIndex = 18
        Me.LblPesNumCartao.Text = "Número do Cartão"
        '
        'LblPesValor
        '
        Me.LblPesValor.AutoSize = True
        Me.LblPesValor.Location = New System.Drawing.Point(227, 341)
        Me.LblPesValor.Name = "LblPesValor"
        Me.LblPesValor.Size = New System.Drawing.Size(39, 16)
        Me.LblPesValor.TabIndex = 19
        Me.LblPesValor.Text = "Valor"
        '
        'BtnLimparPesquisa
        '
        Me.BtnLimparPesquisa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimparPesquisa.Location = New System.Drawing.Point(804, 361)
        Me.BtnLimparPesquisa.Name = "BtnLimparPesquisa"
        Me.BtnLimparPesquisa.Size = New System.Drawing.Size(105, 24)
        Me.BtnLimparPesquisa.TabIndex = 21
        Me.BtnLimparPesquisa.Text = "Limpar"
        Me.BtnLimparPesquisa.UseVisualStyleBackColor = True
        '
        'CbFiltrarData
        '
        Me.CbFiltrarData.AutoSize = True
        Me.CbFiltrarData.Location = New System.Drawing.Point(402, 336)
        Me.CbFiltrarData.Name = "CbFiltrarData"
        Me.CbFiltrarData.Size = New System.Drawing.Size(115, 20)
        Me.CbFiltrarData.TabIndex = 22
        Me.CbFiltrarData.Text = "Filtrar por data"
        Me.CbFiltrarData.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbVoltar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1118, 31)
        Me.ToolStrip1.TabIndex = 23
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(38, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1047, 226)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações"
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.Location = New System.Drawing.Point(677, 361)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(121, 24)
        Me.BtnPesquisar.TabIndex = 25
        Me.BtnPesquisar.Text = "Pesquisar"
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'LblMensagem
        '
        Me.LblMensagem.BackColor = System.Drawing.Color.LightCoral
        Me.LblMensagem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblMensagem.ForeColor = System.Drawing.Color.Brown
        Me.LblMensagem.Location = New System.Drawing.Point(0, 959)
        Me.LblMensagem.Name = "LblMensagem"
        Me.LblMensagem.Size = New System.Drawing.Size(1118, 42)
        Me.LblMensagem.TabIndex = 26
        Me.LblMensagem.Text = "Ocorreu um erro durante a operação"
        Me.LblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IdTransacaoDataGridViewTextBoxColumn
        '
        Me.IdTransacaoDataGridViewTextBoxColumn.DataPropertyName = "Id_Transacao"
        Me.IdTransacaoDataGridViewTextBoxColumn.HeaderText = "Id_Transacao"
        Me.IdTransacaoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdTransacaoDataGridViewTextBoxColumn.Name = "IdTransacaoDataGridViewTextBoxColumn"
        '
        'NumeroCartaoDataGridViewTextBoxColumn
        '
        Me.NumeroCartaoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Cartao"
        Me.NumeroCartaoDataGridViewTextBoxColumn.HeaderText = "Numero_Cartao"
        Me.NumeroCartaoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroCartaoDataGridViewTextBoxColumn.Name = "NumeroCartaoDataGridViewTextBoxColumn"
        '
        'ValorTransacaoDataGridViewTextBoxColumn
        '
        Me.ValorTransacaoDataGridViewTextBoxColumn.DataPropertyName = "Valor_Transacao"
        Me.ValorTransacaoDataGridViewTextBoxColumn.HeaderText = "Valor_Transacao"
        Me.ValorTransacaoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ValorTransacaoDataGridViewTextBoxColumn.Name = "ValorTransacaoDataGridViewTextBoxColumn"
        '
        'DataTransacaoDataGridViewTextBoxColumn
        '
        Me.DataTransacaoDataGridViewTextBoxColumn.DataPropertyName = "Data_Transacao"
        Me.DataTransacaoDataGridViewTextBoxColumn.HeaderText = "Data_Transacao"
        Me.DataTransacaoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DataTransacaoDataGridViewTextBoxColumn.Name = "DataTransacaoDataGridViewTextBoxColumn"
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        '
        'TransacaoModelBindingSource
        '
        Me.TransacaoModelBindingSource.DataSource = GetType(CardManager.TransacaoModel)
        '
        'Cadastrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1118, 1001)
        Me.Controls.Add(Me.LblMensagem)
        Me.Controls.Add(Me.BtnPesquisar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.CbFiltrarData)
        Me.Controls.Add(Me.BtnLimparPesquisa)
        Me.Controls.Add(Me.LblPesValor)
        Me.Controls.Add(Me.LblPesNumCartao)
        Me.Controls.Add(Me.DtpPesData)
        Me.Controls.Add(Me.TxtPesNumCartao)
        Me.Controls.Add(Me.TxtPesValor)
        Me.Controls.Add(Me.GridTransacoes)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.TxtNumCartao)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.DtpData)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Cadastrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridTransacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TransacaoModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpData As DateTimePicker
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents TxtNumCartao As MaskedTextBox
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents GridTransacoes As DataGridView
    Friend WithEvents TransacaoModelBindingSource As BindingSource
    Friend WithEvents IdTransacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroCartaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorTransacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataTransacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewLinkColumn
    Friend WithEvents Excluir As DataGridViewLinkColumn
    Friend WithEvents TxtPesValor As TextBox
    Friend WithEvents TxtPesNumCartao As MaskedTextBox
    Friend WithEvents DtpPesData As DateTimePicker
    Friend WithEvents LblPesNumCartao As Label
    Friend WithEvents LblPesValor As Label
    Friend WithEvents BtnLimparPesquisa As Button
    Friend WithEvents CbFiltrarData As CheckBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents TsbVoltar As ToolStripButton
    Friend WithEvents LblMensagem As Label
End Class
