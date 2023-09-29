using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        int contador = 3;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsuário.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser inderidos");
            }

            else 
            {
                if (contador <= 0)
                {
                    MessageBox.Show(" Usuário ou senha invalidos " + " ACESSO NEGADO ");
                    this.Close();
                }
                else
                {

                    if (txtUsuário.Text == "etec" && txtSenha.Text == "etec")
                    {
                        MessageBox.Show(" Usuário correto! ");
                        Menu telamenu = new Menu();
                        telamenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário incorreto!");
                    }
                }
            }            
        }

       
    }
}
