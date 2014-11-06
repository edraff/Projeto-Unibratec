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
    public partial class formTela : Form
    {
        Service1 s = new Service1();
        
        
       



        public formTela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                bool logado = false;

                logado = s.getSenha(textBox1.Text, textBox2.Text);
                if (logado == false)
                {
                    MessageBox.Show("Login Não Cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                    return;

                }

                logado = s.getSenha(textBox1.Text,textBox2.Text);
                
                if (logado == true)
                {
                    MessageBox.Show("Login efetuado com Sucesso!");
                    this.Hide();
                    new Menu(textBox1.Text).ShowDialog();
                    
                    
                }
                else
                {
                    MessageBox.Show("Login ou Senha Inválida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                    return;

                }

            }
            catch (Exception x)
            {
                String erroLogin = "Login não cadastrado";

               
                MessageBox.Show((erroLogin + x).Substring(0,23));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formTela_Load(object sender, EventArgs e)
        {

        }
    }
}
