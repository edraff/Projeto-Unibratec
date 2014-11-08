using Aplicativo.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicativo.GUI
{
    public partial class Menu : Form
    {
        //Variaveis Globais
        int status;
        String função;
        Service1 s = new Service1();

        public Menu()
        {
            InitializeComponent();
        }
        public Menu(String login)
        {
            InitializeComponent();
            String[] dados = new String[2];
            dados = s.getDados(login);
            txtLogin.Text = dados[0];
            txtLogin.ForeColor = System.Drawing.Color.Green;


            switch (dados[1])
            {
                case "0":
                    txtCargo.Text = "Administrador";
                    txtCargo.ForeColor = System.Drawing.Color.Gray;
                    break;
                case "1":
                    txtCargo.Text = "Atendente";
                    break;
                case "2":
                    txtCargo.Text = "Mecânico";
                    break;
                default:
                    break;
            }                               



        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //this.Top = 0;
            //this.Left = 0;
            //this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            //this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Deseja realmente sair?", "Ateção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                
                MessageBox.Show("Usuario Desconectado!");
                new formTela().ShowDialog();
                
            }


            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            new CriaServiço().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
