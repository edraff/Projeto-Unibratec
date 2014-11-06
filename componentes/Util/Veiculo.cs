using System;
using System.Collections.Generic;
using System.Web;

namespace componentes.Util
{
    public class Veiculo
    {
        private String placa;

        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        private Int32 cd_modelo;

        public Int32 Cd_modelo
        {
            get { return cd_modelo; }
            set { cd_modelo = value; }
        }
        private Int32 cd_proprietario;

        public Int32 Cd_proprietario
        {
            get { return cd_proprietario; }
            set { cd_proprietario = value; }
        }

        private Double vi_Apolice;

        public Double Vi_Apolice
        {
            get { return vi_Apolice; }
            set { vi_Apolice = value; }
        }

        public Veiculo() { }

        public Veiculo(String placa, Int32 cd_modelo, Int32 cd_proprietario,Double  vi_apolice ) {

            this.Placa = placa;
            this.Cd_modelo = cd_modelo;
            this.Cd_proprietario = cd_proprietario;
            this.Vi_Apolice = vi_apolice;

        
        }

    }
}