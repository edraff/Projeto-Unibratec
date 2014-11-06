using componentes.Dao;
using componentes.RNegocio;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

namespace componentes
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service1 : System.Web.Services.WebService
    {
        Usuario user = new Usuario();

        Utilitarios util = new Utilitarios();


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

         [WebMethod]
        public void inserirSenha(String login, String senha) {
            
            user.inserirSenha(login, senha);
           
        }

         [WebMethod]
         public Boolean getSenha(String login, String senha)
         {

             bool logado = user.getSenha(login, senha);

             return logado;


         }

        [WebMethod]
        public Boolean verificaLogin(String login, String senha)
         {

             bool logado = user.verificaLogin(login, senha);

             return logado;


         }
        [WebMethod]
        public String[] getDados(String login)
        {
            String[] dados = new String[2];
            dados = user.getDados(login);

            return dados;

        }
    }
}