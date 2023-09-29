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
    public partial class Obras : Form
    {
        public Obras()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show (" Salvo com sucesso!!! ");
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu telamenu = new Menu();
            telamenu.Show();
            this.Hide();
        }
    }
}
