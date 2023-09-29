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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Form1 Botaosair = new Form1();
            Botaosair.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Funcionarios telafunc = new Funcionarios();
            telafunc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente telacliente = new Cliente();
            telacliente.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Obras telaobras = new Obras();
            telaobras.Show();
            this.Hide();
        }
    }
}
