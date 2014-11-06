using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Web;

namespace componentes.Dao
{
    public class Conexao
    {
        OdbcConnection conexao = new OdbcConnection("dsn=helltibia");

        #region Abrir a conexão com o Banco
        public OdbcConnection abrirConexao()
        {

            try
            {
                conexao.Open();
                return conexao;
            }
            catch (Exception x)
            {

                throw new Exception("Erro 99 - Conexao com Banco  ", x);
            }

        }
        #endregion

        #region Fechar a conexão com o Banco
        public OdbcConnection fecharConexao()
        {

            try
            {
                conexao.Close();
                return conexao;
            }
            catch (Exception x)
            {

                throw new Exception("Erro 99 - Conexao com Banco  ", x);
            }

        }
        #endregion 
    }
}