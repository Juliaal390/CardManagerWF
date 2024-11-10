Imports System.Configuration
Imports System.Data.SqlClient

Public Class RelatorioRepository
    Implements IRelatorioRepository

    Private ReadOnly Property Conn As New SqlConnection(ConfigurationManager.ConnectionStrings("ConnString").ConnectionString)
    Public Function ListarTransacoesMensais() As List(Of RelatorioModel) Implements IRelatorioRepository.ListarTransacoesMensais
        Dim transacoesLista As New List(Of RelatorioModel)
        Try
            Conn.Open()

            Dim inicioMes As New Date(Date.Now.Year, Date.Now.Month, 1)
            Dim fimMes As Date = inicioMes.AddMonths(1).AddDays(-1)

            Dim query As String = "SELECT Numero_Cartao, Valor_Transacao, Data_Transacao, " &
                "Descricao, dbo.fu_CategorizarTransacao(Valor_Transacao) AS Categoria " &
                "FROM Transacoes WHERE Data_Transacao BETWEEN @DataInicial AND @DataFinal " &
                "ORDER BY Id_Transacao DESC"

            Dim dataInicial As New SqlParameter("@DataInicial", SqlDbType.Date) With {.Value = inicioMes}
            Dim dataFinal As New SqlParameter("@DataFinal", SqlDbType.Date) With {.Value = fimMes}

            Dim sqlCommand As New SqlCommand(query, Conn)
            sqlCommand.Parameters.Add(dataInicial)
            sqlCommand.Parameters.Add(dataFinal)

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()
                Dim dadoRelatorio = New RelatorioModel With {
                .Numero_Cartao = reader("Numero_Cartao").ToString(),
                .Valor_Transacao = reader("Valor_Transacao").ToString(),
                .Data_Transacao = reader("Data_Transacao").ToString(),
                .Descricao = reader("Descricao").ToString(),
                .Categoria = reader("Categoria").ToString()
            }
                transacoesLista.Add(dadoRelatorio)
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conn.Close()
        End Try

        Return transacoesLista
    End Function
End Class
