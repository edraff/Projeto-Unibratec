using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using componentes.RNegocio;
namespace componentes.Dao
{
    public class Usuario
    {
        Conexao conexao = new Conexao();
        Utilitarios u = new Utilitarios();

        public Usuario() { }

        public Usuario(String login, String senha)
        {

            this.Login = login;
            this.Senha = u.gerarSenha(login, senha);
        }


        private String login;

        public String Login
        {
            get { return login; }
            set { login = value; }
        }
        private String senha;

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private Int32 status;

        public Int32 Status
        {
            get { return status; }
            set { status = value; }
        }



        public void inserirSenha(String login, String senha)
        {
            Usuario user = new Usuario();

            try
            {

                String sql = "INSERT INTO usuario (login,senha,status) values (?,?,?)";
                OdbcCommand comando = new OdbcCommand(sql, conexao.abrirConexao());
                comando.Parameters.AddWithValue("@login", login);
                comando.Parameters.AddWithValue("@senha", u.gerarSenha(login, senha));
                comando.Parameters.AddWithValue("@status", 0);
                comando.ExecuteScalar();
                comando.Dispose();
                conexao.fecharConexao();
            }
            catch (Exception x)
            {

                throw new Exception("Erro 99 -  Erro ao conectar", x);
            }
        }
        #region Login da tela
        public Boolean getSenha(String login, String senha)
        {
            bool logado = false;
            Usuario user = new Usuario();

            try
            {

                String sql = "Select senha from usuario where login = ?";

                OdbcCommand comando = new OdbcCommand(sql, conexao.abrirConexao());
                comando.Parameters.AddWithValue("@login", login);

                OdbcDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    user.Senha = reader.GetString(reader.GetOrdinal("senha"));
                }




                if (user.senha == u.gerarSenha(login, senha))
                {

                    logado = true;


                }
                reader.Close();
                comando.Dispose();
                conexao.fecharConexao();
                return logado;
            }
            catch (Exception x)
            {

                throw new Exception("ERRO 23 - Usuario não encontrado", x);
            }
        }
        #endregion

        public Boolean verificaLogin(String login, String senha)
        {
            bool logado = false;
            Usuario user = new Usuario();

            try
            {

                String sql = "Select senha from usuario where login = ?";

                OdbcCommand comando = new OdbcCommand(sql, conexao.abrirConexao());
                comando.Parameters.AddWithValue("@login", login);

                OdbcDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    user.login = reader.GetString(reader.GetOrdinal("login"));
                }




                if (user.login != null)
                {

                    logado = true;


                }
                reader.Close();
                comando.Dispose();
                conexao.fecharConexao();
                return logado;
            }
            catch (Exception x)
            {

                throw new Exception("ERRO 23 - Usuario não encontrado", x);
            }


        }

        #region PEgar Login e Status
        public String[] getDados(String login)
        {
            String[] dados = new String[2];

            Usuario user = new Usuario();

            try
            {

                String sql = "Select login, status from usuario where login = ?";

                OdbcCommand comando = new OdbcCommand(sql, conexao.abrirConexao());
                comando.Parameters.AddWithValue("@login", login);

                OdbcDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    dados[0] = reader.GetString(reader.GetOrdinal("login"));
                    dados[1] = reader.GetString(reader.GetOrdinal("status"));
                }




                reader.Close();
                comando.Dispose();
                conexao.fecharConexao();
                return dados;
            }
            catch (Exception x)
            {

                throw new Exception("ERRO 23 - Usuario não encontrado", x);
            }
        }
        #endregion

    }
    
    
}
