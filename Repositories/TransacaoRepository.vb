Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms.AxHost
Public Class TransacaoRepository
    Implements ITransacaoRepository
    Private Property Conn As New SqlConnection("INSERIR STRING DE CONEXÃO")

    Public Function Adicionar(transacao As TransacaoModel) As Boolean Implements ITransacaoRepository.Adicionar
        Try
            Conn.Open()
            Dim query As String = "INSERT INTO Transacoes (Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao) " &
                      "VALUES (@Numero_Cartao, @Valor_Transacao, @Data_Transacao, @Descricao)"

            Dim numeroCartao As New SqlParameter("@Numero_Cartao", DbType.String) With {.Value = transacao.Numero_Cartao}
            Dim valorTransacao As New SqlParameter("@Valor_Transacao", DbType.Decimal) With {.Value = transacao.Valor_Transacao}
            Dim dataTransacao As New SqlParameter("@Data_Transacao", DbType.Date) With {.Value = transacao.Data_Transacao}
            Dim descricao As New SqlParameter("@Descricao", DbType.String) With {.Value = transacao.Descricao}

            Dim sqlCommand As New SqlCommand(query, Conn)
            sqlCommand.Parameters.Add(numeroCartao)
            sqlCommand.Parameters.Add(valorTransacao)
            sqlCommand.Parameters.Add(dataTransacao)
            sqlCommand.Parameters.Add(descricao)

            sqlCommand.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
        Finally
            Conn.Close()
        End Try
    End Function

    Public Function ListarTransacoes() As List(Of TransacaoModel) Implements ITransacaoRepository.ListarTransacoes

        Dim transacoesLista As New List(Of TransacaoModel)

        Try
            Conn.Open()
            Dim query As String = "SELECT TOP 100 Id_Transacao, Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao FROM Transacoes ORDER BY Data_Transacao DESC"
            Dim sqlCommand As New SqlCommand(query, Conn)

            ' Execução da consulta
            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()
                Dim transacao = New TransacaoModel With {
                .Id_Transacao = reader("Id_Transacao").ToString(),
                .Numero_Cartao = reader("Numero_Cartao").ToString(),
                .Valor_Transacao = reader("Valor_Transacao").ToString(),
                .Data_Transacao = reader("Data_Transacao").ToString(),
                .Descricao = reader("Descricao").ToString()
            }
                transacoesLista.Add(transacao)
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conn.Close()
        End Try

        Return transacoesLista
    End Function

    Public Function Editar(transacao As TransacaoModel) As Boolean Implements ITransacaoRepository.Editar
        Try
            Conn.Open()
            Dim query As String = "UPDATE Transacoes SET Numero_Cartao = @Numero_Cartao, " &
            "Valor_Transacao = @Valor_Transacao, Data_Transacao = @Data_Transacao, " &
            "Descricao = @Descricao " &
            "WHERE Id_Transacao = @Id_Transacao"

            Dim idTransacao As New SqlParameter("@Id_Transacao", DbType.Int32) With {.Value = transacao.Id_Transacao}
            Dim numeroCartao As New SqlParameter("@Numero_Cartao", DbType.String) With {.Value = transacao.Numero_Cartao}
            Dim valorTransacao As New SqlParameter("@Valor_Transacao", DbType.Decimal) With {.Value = transacao.Valor_Transacao}
            Dim dataTransacao As New SqlParameter("@Data_Transacao", DbType.Date) With {.Value = transacao.Data_Transacao}
            Dim descricao As New SqlParameter("@Descricao", DbType.String) With {.Value = transacao.Descricao}

            Dim sqlCommand As New SqlCommand(query, Conn)
            sqlCommand.Parameters.Add(idTransacao)
            sqlCommand.Parameters.Add(numeroCartao)
            sqlCommand.Parameters.Add(valorTransacao)
            sqlCommand.Parameters.Add(dataTransacao)
            sqlCommand.Parameters.Add(descricao)

            sqlCommand.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
        Finally
            Conn.Close()
        End Try
    End Function

    Public Function Excluir(Id As Integer) As Boolean Implements ITransacaoRepository.Excluir
        Try
            Conn.Open()

            Dim query As String = "DELETE FROM Transacoes WHERE Id_Transacao = @Id_Transacao"

            Dim idTransacao As New SqlParameter("@Id_Transacao", DbType.Int32) With {.Value = Id}

            Dim sqlCommand As New SqlCommand(query, Conn)
            sqlCommand.Parameters.Add(idTransacao)
            sqlCommand.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
        Finally
            Conn.Close()
        End Try
    End Function

    Public Function FiltrarTransacoes(Optional cartao As String = Nothing, Optional valor As String = Nothing, Optional data As String = Nothing) As List(Of TransacaoModel) Implements ITransacaoRepository.FiltrarTransacoes
        Dim transacoesLista As New List(Of TransacaoModel)

        Try
            Conn.Open()
            Dim query As String = "SELECT Id_Transacao, Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao FROM Transacoes"
            Dim possuiFiltro As Boolean = False ' Variável que verifica se há filtros

            ' Filtrar por numero do cartão
            If cartao IsNot Nothing AndAlso cartao.Trim() <> "" Then
                query += " WHERE Numero_Cartao = @Numero_Cartao"
                possuiFiltro = True
            End If

            ' Filtrar por valor da transação
            If valor IsNot Nothing AndAlso valor.Trim() <> "" Then
                If possuiFiltro Then
                    query += " AND Valor_Transacao = @Valor_Transacao"
                Else
                    query += " WHERE Valor_Transacao = @Valor_Transacao"
                    possuiFiltro = True
                End If
            End If

            ' Filtrar por data da transação
            If data IsNot Nothing Then
                If possuiFiltro Then
                    query += " AND Data_Transacao = @Data_Transacao"
                Else
                    query += " WHERE Data_Transacao = @Data_Transacao"
                    possuiFiltro = True
                End If
            End If

            query += " ORDER BY Data_Transacao DESC"

            Dim sqlCommand As New SqlCommand(query, Conn)

            Dim cartaoTransacao As New SqlParameter("@Numero_Cartao", DbType.String)
            If cartao IsNot Nothing Then
                cartaoTransacao.Value = cartao
                sqlCommand.Parameters.Add(cartaoTransacao)
            End If

            Dim valorTransacao As New SqlParameter("@Valor_Transacao", DbType.Decimal)
            If valor IsNot Nothing AndAlso valor.Trim() <> "" Then
                valorTransacao.Value = valor
                sqlCommand.Parameters.Add(valorTransacao)
            End If

            Dim dataTransacao As New SqlParameter("@Data_Transacao", SqlDbType.Date)
            If data IsNot Nothing Then
                dataTransacao.Value = data
                sqlCommand.Parameters.Add(dataTransacao)
            End If

            ' Execução da consulta
            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()
                Dim transacao = New TransacaoModel With {
                .Id_Transacao = reader("Id_Transacao").ToString(),
                .Numero_Cartao = reader("Numero_Cartao").ToString(),
                .Valor_Transacao = reader("Valor_Transacao").ToString(),
                .Data_Transacao = reader("Data_Transacao").ToString(),
                .Descricao = reader("Descricao").ToString()
            }
                transacoesLista.Add(transacao)
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conn.Close()
        End Try

        Return transacoesLista
    End Function
End Class
