using System;
using System.Collections.Generic;
using System.Web;

namespace componentes.Util
{
    public class Fabricante
    {
        private Int32 cd_fabricante;

        public Int32 Cd_fabricante
        {
            get { return cd_fabricante; }
            set { cd_fabricante = value; }
        }
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Fabricante() { }
        public Fabricante(Int32 cd_fabricante, String nome) {

            this.Cd_fabricante = cd_fabricante;
            this.Nome = nome;
        
        }


    }
}