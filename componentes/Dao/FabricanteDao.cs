using componentes.Util;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Web;

namespace componentes.Dao
{
    public class FabricanteDao
    {


        #region cadastrar Fabricante
        public void cadastrarFabricante(Fabricante fabricante) {

            Conexao conexao = new Conexao();
            try
            {
                String sql = "INSERT INTO Fabricante (nome) values (?)";
                OdbcCommand comando = new OdbcCommand(sql, conexao.abrirConexao());

                comando.Parameters.AddWithValue("@Nome", fabricante.Nome);
                comando.ExecuteScalar();
                comando.Dispose();
                conexao.fecharConexao();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message + Environment.NewLine + (ex.InnerException != null ? ex.InnerException.ToString() : String.Empty));
            }



        }
        #endregion 
    }
}