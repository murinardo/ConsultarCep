Imports System.Data.SqlClient
Imports Janus.Windows.GridEX


Public Class clsFrmConsultaCep


    Public Sub Update(ByVal lCodigo As Long,
                      ByVal sCep As String,
                      ByVal sEndereco As String,
                      ByVal sBairro As String,
                      ByVal sCidade As String,
                      ByVal sUF As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "id"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCep : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEndereco : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sBairro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCidade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUF

            ' Obtém a string de conexão a partir do arquivo de configuração personalizado
            Dim connectionString As String = GetConnectionString()

            ' Conexão com o banco de dados
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Using cmd As New SqlCommand("sp_update_cep_endereco", conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' Adiciona os parâmetros ao comando
                    cmd.Parameters.AddRange(oSqlParameter)

                    ' Executa a procedure
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Insert(ByVal sCep As String,
                   ByVal sEndereco As String,
                   ByVal sBairro As String,
                   ByVal sCidade As String,
                   ByVal sUF As String)

        ' Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try
            ' Seta Parametros - Data Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "@cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCep : i += 1

            ' Seta Parametros - Data Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "@logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEndereco : i += 1

            ' Seta Parametros - Data Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "@bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sBairro : i += 1

            ' Seta Parametros - Data Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "@cidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCidade : i += 1

            ' Seta Parametros - Data Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "@uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUF

            ' Obtém a string de conexão a partir do arquivo de configuração personalizado
            Dim connectionString As String = GetConnectionString()

            ' Conexão com o banco de dados
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Using cmd As New SqlCommand("sp_insert_cep_endereco", conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' Adiciona os parâmetros ao comando
                    cmd.Parameters.AddRange(oSqlParameter)

                    ' Executa a procedure
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCEP(ByVal oGrid As GridEX, ByVal sCep As String)
        ' Variáveis Locais
        Dim oDataSet As New DataSet()
        Dim oSqlParameter As New SqlParameter("@cep", SqlDbType.VarChar) With {
            .Value = sCep
        }
        Dim connectionString As String = GetConnectionString() ' Adicione a função GetConnectionString()

        Try
            ' Conexão com o banco de dados
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("sp_select_cep_endereco", conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' Adiciona os parâmetros ao comando
                    cmd.Parameters.Add(oSqlParameter)

                    ' Preenche o DataSet com os dados da procedure
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(oDataSet)
                    End Using
                End Using
            End Using

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            ' Trate a exceção SQL aqui
            Throw SqlEx
        Catch ex As Exception
            ' Trate outras exceções aqui
            Throw ex
        End Try
    End Sub

    Public Sub Delete()

        ' Variáveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim connectionString As String = GetConnectionString()

        Try
            ' Conexão com o banco de dados
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Preparar o comando SQL
                Using cmd As New SqlCommand("DELETE FROM tb_cep_endereco WHERE id = @id", conn)
                    cmd.CommandType = CommandType.Text

                    ' Adicionar parâmetro ao comando
                    cmd.Parameters.Add("@id", SqlDbType.Int)

                    For Each oRow As GridEXRow In gSelecaoRow
                        ' Define o valor do parâmetro
                        cmd.Parameters("@id").Value = oRow.Cells("id").Value

                        ' Executa o comando
                        cmd.ExecuteNonQuery()

                        ' Exclui Linha da Grid
                        oRow.Delete()
                    Next
                End Using
            End Using

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
