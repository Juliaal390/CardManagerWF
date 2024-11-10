Public Class Cadastrar

    Private _transacaoRepository As ITransacaoRepository
    Private Property TransacaoSelecionada As TransacaoModel

    Public Sub New(transacaoRepository As ITransacaoRepository)
        _transacaoRepository = transacaoRepository
        InitializeComponent()
    End Sub

#Region "Comportamentos"
    Private Sub Cadastrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblMensagem.Visible = False
        DtpPesData.Enabled = False
        DtpPesData.Visible = False

        Dim lista As List(Of TransacaoModel)
        lista = _transacaoRepository.ListarTransacoes()
        GridTransacoes.DataSource = lista

        LimparCampos()
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        Dim textoBotao As String = CType(sender, Button).Text

        If textoBotao = "Adicionar" Then

            If Not TxtNumCartao.MaskCompleted OrElse String.IsNullOrWhiteSpace(TxtValor.Text) Then
                MensagemErro()
                Return
            End If

            Dim transacao = New TransacaoModel
            Try
                With transacao
                    .Numero_Cartao = TxtNumCartao.Text
                    .Valor_Transacao = Decimal.Parse(TxtValor.Text)
                    .Data_Transacao = DtpData.Value
                    .Descricao = TxtDescricao.Text
                End With
            Catch ex As Exception
                MensagemErro()
                Return
            End Try

            Dim cadastro As Boolean = _transacaoRepository.Adicionar(transacao)

            If cadastro Then
                MensagemSalvo()
                LimparCampos()
            Else
                MensagemErro()
            End If
        Else ' Editar
            TransacaoSelecionada.Numero_Cartao = TxtNumCartao.Text
            TransacaoSelecionada.Valor_Transacao = Decimal.Parse(TxtValor.Text)
            TransacaoSelecionada.Data_Transacao = DtpData.Value
            TransacaoSelecionada.Descricao = TxtDescricao.Text

            Dim edicao As Boolean = _transacaoRepository.Editar(TransacaoSelecionada)

            If edicao Then
                MensagemSalvo()
                LimparCampos()
            Else
                MensagemErro()
            End If
        End If

        CarregarGrid()
    End Sub

    Private Sub GridTransacoes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridTransacoes.CellContentClick
        ' Verificar se a célula clicada é do tipo DataGridViewLinkCell
        If TypeOf GridTransacoes.Rows(e.RowIndex).Cells(e.ColumnIndex) Is DataGridViewLinkCell Then
            Dim celula As DataGridViewLinkCell = DirectCast(GridTransacoes.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewLinkCell)

            If celula.Value.ToString() = "Editar" Then
                LblTitle.Text = "Editar Transação"
                BtnAdicionar.Text = "Confirmar"

                ' Cria um novo objeto com os atributos da transação selecionada
                Dim transacao = New TransacaoModel With {
                    .Id_Transacao = Convert.ToInt32(GridTransacoes.Rows(e.RowIndex).Cells(0).Value),
                    .Numero_Cartao = GridTransacoes.Rows(e.RowIndex).Cells(1).Value.ToString(),
                    .Valor_Transacao = Convert.ToDecimal(GridTransacoes.Rows(e.RowIndex).Cells(2).Value),
                    .Data_Transacao = Convert.ToDateTime(GridTransacoes.Rows(e.RowIndex).Cells(3).Value),
                    .Descricao = GridTransacoes.Rows(e.RowIndex).Cells(4).Value.ToString()
                }

                Me.TransacaoSelecionada = transacao

                ' Preenche os inputs com os mesmos dados da transação selecionada
                TxtNumCartao.Text = transacao.Numero_Cartao
                TxtValor.Text = transacao.Valor_Transacao.ToString()
                TxtDescricao.Text = transacao.Descricao
                DtpData.Value = transacao.Data_Transacao

            ElseIf celula.Value.ToString() = "Excluir" Then

                Dim resposta As DialogResult = MessageBox.Show("Deseja excluir esta transação?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resposta = DialogResult.Yes Then
                    Dim id As Integer = Convert.ToInt32(GridTransacoes.Rows(e.RowIndex).Cells(0).Value)

                    Dim exclusao As Boolean = _transacaoRepository.Excluir(id)

                    If exclusao Then
                        MensagemSalvo()
                        CarregarGrid()
                    Else
                        MensagemErro()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        CarregarGrid(TxtPesNumCartao.Text, TxtPesValor.Text, DtpPesData.Value)
    End Sub

    Private Sub TsbVoltar_Click(sender As Object, e As EventArgs) Handles TsbVoltar.Click
        Me.Hide()
        Dim homeView As New Home
        homeView.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BtnLimparPesquisa_Click(sender As Object, e As EventArgs) Handles BtnLimparPesquisa.Click
        LimparPesquisa()
    End Sub

    Private Sub CbFiltrarData_CheckedChanged(sender As Object, e As EventArgs) Handles CbFiltrarData.CheckedChanged
        If CbFiltrarData.Checked Then
            DtpPesData.Enabled = True
            DtpPesData.Visible = True
        Else
            DtpPesData.Enabled = False
            DtpPesData.Visible = False
        End If
    End Sub
#End Region

#Region "Auxiliares"
    Private Sub CarregarGrid(Optional cartao As String = Nothing, Optional valor As String = Nothing, Optional data As String = Nothing)
        Dim lista As List(Of TransacaoModel)

        Dim dataFiltrar = If(CbFiltrarData.Checked, data, Nothing)
        lista = _transacaoRepository.FiltrarTransacoes(cartao, valor, dataFiltrar)

        GridTransacoes.DataSource = lista
    End Sub

    Private Sub LimparCampos()
        LblTitle.Text = "Cadastrar Transação"
        TxtNumCartao.Text = String.Empty
        TxtValor.Text = String.Empty
        TxtDescricao.Text = String.Empty
        DtpData.Value = DateTime.Now
        Me.TransacaoSelecionada = Nothing
        BtnAdicionar.Text = "Adicionar"
    End Sub

    Private Sub LimparPesquisa()
        TxtPesNumCartao.Text = String.Empty
        TxtPesValor.Text = String.Empty
        CbFiltrarData.Checked = False
        CarregarGrid()
    End Sub

    Private Sub MensagemSalvo()
        LblMensagem.Text = "Operação realizada com sucesso"
        LblMensagem.BackColor = Color.DarkSeaGreen
        LblMensagem.ForeColor = Color.DarkOliveGreen
        LblMensagem.Visible = True

        Dim timerMensagem As New Timer With {.Interval = 4000}
        AddHandler timerMensagem.Tick, Sub(sender, e)
                                           LblMensagem.Visible = False
                                           timerMensagem.Stop()
                                       End Sub
        timerMensagem.Start()
    End Sub

    Private Sub MensagemErro()
        LblMensagem.Text = "Ocorreu um erro durante a operação"
        LblMensagem.BackColor = Color.LightCoral
        LblMensagem.ForeColor = Color.Brown
        LblMensagem.Visible = True

        Dim timerMensagem As New Timer With {.Interval = 4000}
        AddHandler timerMensagem.Tick, Sub(sender, e)
                                           LblMensagem.Visible = False
                                           timerMensagem.Stop()
                                       End Sub
        timerMensagem.Start()
    End Sub
#End Region
End Class
