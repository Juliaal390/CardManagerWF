<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.BtnCallTransacao = New System.Windows.Forms.Button()
        Me.BtnRelatorio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCallTransacao
        '
        Me.BtnCallTransacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCallTransacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCallTransacao.Location = New System.Drawing.Point(292, 221)
        Me.BtnCallTransacao.Name = "BtnCallTransacao"
        Me.BtnCallTransacao.Size = New System.Drawing.Size(547, 57)
        Me.BtnCallTransacao.TabIndex = 0
        Me.BtnCallTransacao.Text = "Cadastrar Transação"
        Me.BtnCallTransacao.UseVisualStyleBackColor = True
        '
        'BtnRelatorio
        '
        Me.BtnRelatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRelatorio.Location = New System.Drawing.Point(292, 296)
        Me.BtnRelatorio.Name = "BtnRelatorio"
        Me.BtnRelatorio.Size = New System.Drawing.Size(547, 57)
        Me.BtnRelatorio.TabIndex = 1
        Me.BtnRelatorio.Text = "Relatório Mensal"
        Me.BtnRelatorio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(12, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1129, 63)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CARD MANAGER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1153, 534)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRelatorio)
        Me.Controls.Add(Me.BtnCallTransacao)
        Me.Name = "Home"
        Me.Text = "Card Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCallTransacao As Button
    Friend WithEvents BtnRelatorio As Button
    Friend WithEvents Label1 As Label
End Class
