using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using Biblioteca.Util;

namespace WebService1
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service1 : System.Web.Services.WebService
    {


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public string gerarSenha(string _senha)
        {

            Utilitarios u = new Utilitarios();

            return u.gerarSenha(_senha);




        }
    }
}