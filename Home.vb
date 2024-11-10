Public Class Home
#Region "Comportamentos"
    Private Sub BtnCallTransacao_Click(sender As Object, e As EventArgs) Handles BtnCallTransacao.Click
        Me.Hide()
        Dim transacaoRepository As New TransacaoRepository()
        Dim cadastrarView As New Cadastrar(transacaoRepository)
        cadastrarView.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BtnRelatorio_Click(sender As Object, e As EventArgs) Handles BtnRelatorio.Click
        Me.Hide()
        Dim relatorioRepository As New RelatorioRepository()
        Dim relatorioView As New Relatorio(relatorioRepository)
        relatorioView.ShowDialog()
        Me.Close()
    End Sub
#End Region
End Class
