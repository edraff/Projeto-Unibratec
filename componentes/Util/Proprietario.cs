using System;
using System.Collections.Generic;
using System.Web;

namespace componentes.Util
{
    public class Proprietario
    {

        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String sexo;
        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private String nascimento;
        public String Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

        private String telefone;
        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Proprietario() { }

        public Proprietario(String nome, String sexo, String nascimento, String telefone)
        {

            this.Nome = nome;
            this.Sexo = sexo;
            this.Nascimento = nascimento;
            this.Telefone = telefone;

        }

    }
}