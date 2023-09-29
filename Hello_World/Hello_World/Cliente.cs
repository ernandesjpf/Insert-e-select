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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Menu telaMenu = new Menu();
            telaMenu.Show();
            this.Hide();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                try
                {
                    DateTime diasNascimento;
                    DateTime diadeHoje;
                    diasNascimento = DateTime.Parse(textBox10.Text);
                    diadeHoje = System.DateTime.Today;

                    int anoNascimento = DateTime.Parse(textBox10.Text).Year;
                    int anoAtual = System.DateTime.Now.Year;

                    int anoIdade = anoAtual - anoNascimento;

                    if (diasNascimento.DayOfYear > diadeHoje.DayOfYear)
                    {
                        anoIdade = anoIdade - 1;
                    }

                    if (anoIdade <= 17)
                    {
                        MessageBox.Show("Xiiiii!! Volte depois");
                        textBox10.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Parabéns você ja é maior de idade");
                        textBox10.Text = "";
                    }

                   /* int qtdeDiaVida = (diadeHoje.DayOfYear - diasNascimento.DayOfYear);

                    //MessageBox.Show("Opa data valida");*/


                }
                catch
                {
                    MessageBox.Show("Data inválida");
                    textBox10.Text = "";
                }

            }
            else
            {
                MessageBox.Show(" Data é um campo obrigátório ");
            }
                         

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            
            
        }
    }
}
