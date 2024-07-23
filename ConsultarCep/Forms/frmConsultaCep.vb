Imports Janus.Windows.GridEX
Imports System.IO


Public Class FrmConsultaCep

#Region "::: VARIAVEIS :::"

    Private conn As ADODB.Connection
    Private rs As ADODB.Recordset
    Private oClsConfigXML As clsConfigDatabase
    Private oClsFrmConsultaCep As New clsFrmConsultaCep

#End Region


#Region "::: CONTROLES :::"

    Private Sub FrmConsultaCep_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    'If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridCEP() Else Control_Enter(sender)k

            End Select


        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmConsultaCep_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Function ParseJsonToResponseCep(json As String) As clsResponseCep

        Try

            Dim responsecep As clsResponseCep
            Dim jsonObject As Object

            jsonObject = CreateObject("ScriptControl")
            jsonObject.Language = "JScript"

            jsonObject = jsonObject.Eval("(" & json & ")")

            responsecep = New clsResponseCep

            responsecep.logradouro = jsonObject.logradouro
            responsecep.localidade = jsonObject.localidade
            responsecep.bairro = jsonObject.bairro
            responsecep.uf = jsonObject.uf

            ParseJsonToResponseCep = responsecep

        Catch ex As Exception

        End Try

    End Function

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            Call LoadGridCEP()

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try

    End Sub

    Private Sub btnCep_Click(sender As Object, e As EventArgs) Handles btnCep.Click

        Try

            Call ConsultarCep()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            MsgBox("Erro: " & ex.Message)
        End Try


    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Try

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            MsgBox("Erro: " & ex.Message)
        End Try

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGridCEP()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtCEPFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            MsgBox("Erro: " & ex.Message)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            Call Salvar()


        Catch ex As Exception
            'Trata Erro
            MsgBox("Erro: " & ex.Message)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna Selecionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            MsgBox("Erro: " & ex.Message)
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Try

            Call ExcluirCep()

        Catch ex As Exception
            'Trata Erro
            MsgBox("Erro: " & ex.Message)
        End Try


    End Sub

#End Region


#Region "::: FUNCTION / SUB"

    Public Sub ConfigurarFormulario()

        Try

            'Verifica se Existe o Arquivo Config.xml
            If File.Exists(ApplicationPath() & "Config\db.config") = False Then
                MsgBox("Arquivo de Configuração do Banco de Dados não foi encontrado.", MsgBoxStyle.Critical)
            Else
                oClsConfigXML = New clsConfigDatabase
            End If

            'Carrega Dados do XML
            goDatabase.sConnection = oClsConfigXML.StringConnection
            goDatabase.sDataSource = oClsConfigXML.DataSource
            goDatabase.sInitialCatalog = oClsConfigXML.InitialCatalog
            goDatabase.sUserID = oClsConfigXML.UserID
            goDatabase.sPassword = oClsConfigXML.Password

            'Testa Conexão
            If TesteConection(goDatabase.sConnection) = False Then
                MsgBox("Conexão Falhou.", MsgBoxStyle.Critical)
            End If

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtCEPFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            MsgBox("Erro: " & ex.Message)
        End Try

    End Sub

    Private Sub ConsultarCep()

        Try
            Dim xmlHttp As Object
            Dim url As String
            Dim responseText As String
            Dim responsecep As clsResponseCep
            Dim cep As String

            cep = txtCEP.Text

            url = "https://viacep.com.br/ws/" & cep & "/json/"

            xmlHttp = CreateObject("MSXML2.XMLHTTP.6.0")

            xmlHttp.Open("GET", url, False)
            xmlHttp.send()

            If xmlHttp.Status = 200 Then
                responseText = xmlHttp.responseText

                responsecep = ParseJsonToResponseCep(responseText)

                txtEndereco.Text = responsecep.logradouro
                txtBairro.Text = responsecep.bairro
                txtCidade.Text = responsecep.localidade
                txtUF.Text = responsecep.uf
            Else
                MsgBox("Erro ao buscar o CEP: " & xmlHttp.Status & " - " & xmlHttp.StatusText)
            End If

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try

    End Sub

    Private Sub LoadGridCEP()

        Try

            oClsFrmConsultaCep.LoadGridCEP(grdListagem,
                                           txtCEPFiltro.Text)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Controles
            txtCEP.Text = ""
            txtEndereco.Text = ""
            txtBairro.Text = ""
            txtCidade.Text = ""
            txtUF.Text = ""

            'Seta Focu
            txtCEP.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then
                oClsFrmConsultaCep.Update(btnSalvar.Tag,
                                          txtCEP.Text,
                                          txtEndereco.Text,
                                          txtBairro.Text,
                                          txtCidade.Text,
                                          txtUF.Text)
                MsgBox("Registro Alterado.", MsgBoxStyle.Information)
            Else
                oClsFrmConsultaCep.Insert(txtCEP.Text,
                                          txtEndereco.Text,
                                          txtBairro.Text,
                                          txtCidade.Text,
                                          txtUF.Text)
                MsgBox("Registro Inserido.", MsgBoxStyle.Information)
            End If

            Call Novo()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try


            'Limpa Controles
            Call Novo()

            'Seta Controles
            txtCEP.Text = grdListagem.CurrentRow.Cells("cep").Value
            txtEndereco.Text = grdListagem.CurrentRow.Cells("logradouro").Value
            txtBairro.Text = grdListagem.CurrentRow.Cells("bairro").Value
            txtCidade.Text = grdListagem.CurrentRow.Cells("cidade").Value
            txtUF.Text = grdListagem.CurrentRow.Cells("uf").Value

            btnSalvar.Tag = grdListagem.CurrentRow.Cells("id").Value

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Foco
            txtCEP.Focus()

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirCep()

        Try


            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoRow(grdListagem) = True Then

                Cursor.Current = Cursors.WaitCursor

                'Exclui Registro
                oClsFrmConsultaCep.Delete()

                MsgBox("Registro Excluido.", MsgBoxStyle.Information)

                Cursor.Current = Cursors.Default

            Else

                MsgBox("Selecione um registro.", MsgBoxStyle.Exclamation)

            End If

        Catch ex As Exception
            Throw ex
        End Try


    End Sub














#End Region


End Class
