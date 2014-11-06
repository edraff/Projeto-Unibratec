using System;
using System.Collections.Generic;
using System.Web;

namespace componentes.Util
{
    public class Modelo
    {
        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private Double valor;
        public Double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private Int32 cd_fabricante;
        public Int32 Cd_fabricante
        {
            get { return cd_fabricante; }
            set { cd_fabricante = value; }
        }

        public Modelo() { }

        public Modelo(String nome, Double valor, Int32 cd_fabricante){

            this.Nome = nome;
            this.Valor = valor;
            this.Cd_fabricante = cd_fabricante;
             
        }

    }
}