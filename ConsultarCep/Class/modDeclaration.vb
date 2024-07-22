Imports Janus.Windows.GridEX
Imports System.Data.SqlClient
Imports System.Xml


Module modDeclaration

#Region "::: VARIAVEIS GLOBAIS :::"

    'Conexão com o Banco de Dados    
    Public goDatabase As Database
    Public gSelecaoRow() As Janus.Windows.GridEX.GridEXRow


#End Region

#Region "::: ESTRUTURAS GLOBAIS :::"

    'Banco de Dados
    Public Structure Database
        Dim sConnection As String
        Dim sDataSource As String
        Dim sInitialCatalog As String
        Dim sUserID As String
        Dim sPassword As String
    End Structure



#End Region

#Region "::: FUNCTION / SUB GLOBAIS"

    Public Function ApplicationPath() As String

        Return System.AppDomain.CurrentDomain.BaseDirectory()

    End Function

    Public Function TesteConection(ByVal sConnectionString As String)

        Dim oSqlConnection As New SqlConnection

        Try

            'Seta Conexão
            oSqlConnection.ConnectionString = sConnectionString.Replace("Connect Timeout = 999;", "Connect Timeout = 100")

            'Abre Conexão                                                   
            oSqlConnection.Open()

            Return True

        Catch ex As Exception
            Return False
        Finally
            oSqlConnection.Close()
        End Try

    End Function

    Public Function GetConnectionString() As String
        Dim configFilePath As String = "C:\Users\leonardo.inacio\Documents\Desafio Paschoalotto\ConsultarCep\ConsultarCep\bin\Debug\Config\config.config"
        Dim doc As New XmlDocument()
        doc.Load(configFilePath)

        Dim connectionString As String = doc.SelectSingleNode("//ConfigDatabase/StringConnection").InnerText
        Return connectionString
    End Function

    Public Function VerificaSelecaoRow(ByVal oGrid As GridEX) As Boolean

        Try

            'Variáveis Loais
            Dim oCheckedRow() As GridEXRow
            Dim oRow As GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRow = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Recebendo o array de linhas selecionadas
                    oCheckedRow = .GetCheckedRows

                    'Varrendo os itens selecionados
                    For Each oRow In oCheckedRow

                        'Redimensiona Vetor caso necessário
                        If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                            ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                        End If

                        'Seta Retorno da Função
                        VerificaSelecaoRow = True

                        'Seta Valores
                        gSelecaoRow(UBound(gSelecaoRow)) = oRow

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub ConfigurarDataMemberGrid(ByVal oGrid As GridEX)
        Try

            With oGrid

                'Percorrendo as colunas
                For Each oCol As GridEXColumn In oGrid.RootTable.Columns
                    'Não atribuir o data member para a coluna de seleção
                    If oCol.Key <> "x" Then
                        'Atribuindo o datamember com o mesmo nome da coluna
                        .RootTable.Columns.Item(oCol.Key).DataMember = oCol.Key
                    End If
                Next

                For Each oChildTables As GridEXTable In oGrid.RootTable.ChildTables
                    For Each oCol As GridEXColumn In oChildTables.Columns
                        If oCol.Key <> "x" Then
                            oChildTables.Columns.Item(oCol.Key).DataMember = oCol.Key
                        End If

                        For Each oChildTables2 As GridEXTable In oChildTables.ChildTables
                            For Each oCol2 As GridEXColumn In oChildTables2.Columns
                                If oCol2.Key <> "x" Then
                                    oChildTables2.Columns.Item(oCol2.Key).DataMember = oCol2.Key
                                End If
                            Next
                        Next

                    Next
                Next

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Module
