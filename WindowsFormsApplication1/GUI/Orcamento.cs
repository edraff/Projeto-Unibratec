using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicativo.GUI
{
    public partial class Orcamento : Form
    {
        public Orcamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
          
        }

        private void Orcamento_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.textBox1, "INSIRA O CÓDIGO DO CLIENTE. PARA CONSULTAR, SETA PARA DIREITO DO TECLADO.");

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.textBox1, "CODIGO DO CLIENTE: CPF");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Right) {

                new pesquisaCliente().ShowDialog();
            
            }
        }
    }
}
