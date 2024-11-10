Public Class Relatorio
    Private _relatorioRepository As IRelatorioRepository
    Public Sub New(relatorioRepository As IRelatorioRepository)
        _relatorioRepository = relatorioRepository
        InitializeComponent()
    End Sub

#Region "Comportamentos"
    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        Dim xlApp As Object = CreateObject("Excel.Application")
        Dim xlWorkBook As Object = xlApp.Workbooks.Add()
        Dim xlWorkSheet As Object = xlWorkBook.Sheets(1)

        Dim mesAtualTexto As String = Date.Now.ToString("MMMM")

        Try
            xlWorkSheet.Cells(1, 1).Value = "Relatório mensal de " + mesAtualTexto
            xlWorkSheet.Cells(1, 1).Font.Size = 16
            xlWorkSheet.Cells(1, 1).Font.Bold = True
            xlWorkSheet.Range("A1:E1").Merge() ' Mescla células

            ' Cabeçalho da tabela
            Dim headers() As String = {"Numero_Cartao", "Valor_Transacao", "Data_Transacao", "Descricao", "Categoria"}
            For col As Integer = 0 To headers.Length - 1
                xlWorkSheet.Cells(2, col + 1).Value = headers(col)
                xlWorkSheet.Cells(2, col + 1).Font.Bold = True
                xlWorkSheet.Cells(2, col + 1).Interior.Color = RGB(215, 228, 242)
            Next

            ' Preencher com os dados do DataGridView
            For i As Integer = 0 To DgvTransacoes.Rows.Count - 1
                For j As Integer = 0 To DgvTransacoes.Columns.Count - 1
                    xlWorkSheet.Cells(i + 3, j + 1).Value = DgvTransacoes.Rows(i).Cells(j).Value

                    If j = 2 Then
                        xlWorkSheet.Cells(i + 3, j + 1).NumberFormat = "dd/MM/yyyy"
                    End If
                Next
            Next

            ' Ajustar largura das colunas
            xlWorkSheet.Columns("A:E").AutoFit()

            Dim saveFileDialog As New SaveFileDialog With {
            .Filter = "Excel Files (*.xlsx)|*.xlsx",
            .FileName = "Relatório Mensal - transações de " + mesAtualTexto
            }
            MensagemSalvo()

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                xlWorkBook.SaveAs(saveFileDialog.FileName)
            End If

        Catch ex As Exception
            MensagemErro()
        Finally
            ' Liberar recursos
            If Not IsNothing(xlWorkBook) Then
                xlWorkBook.Close(False)
            End If
            If Not IsNothing(xlApp) Then
                xlApp.Quit()
            End If
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
        End Try
    End Sub

    Private Sub Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblMensagem.Visible = False
        Dim lista As List(Of RelatorioModel)
        lista = _relatorioRepository.ListarTransacoesMensais()
        DgvTransacoes.DataSource = lista
    End Sub

    Private Sub TsbVoltar_Click(sender As Object, e As EventArgs) Handles TsbVoltar.Click
        Me.Hide()
        Dim homeView As New Home
        homeView.ShowDialog()
        Me.Close()
    End Sub
#End Region

#Region "Auxiliares"
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