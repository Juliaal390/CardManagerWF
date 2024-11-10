Public Interface ITransacaoRepository
    Function Adicionar(transacao As TransacaoModel) As Boolean
    Function Editar(transacao As TransacaoModel) As Boolean
    Function Excluir(Id As Integer) As Boolean

    Function ListarTransacoes() As List(Of TransacaoModel)
    Function FiltrarTransacoes(Optional cartao As String = Nothing,
                              Optional valor As String = Nothing,
                              Optional data As String = Nothing) As List(Of TransacaoModel)

End Interface
