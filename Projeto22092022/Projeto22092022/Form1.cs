using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto22092022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro{MdiParent = this};
            cadastro.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listagem listagem = new Listagem();
            listagem.MdiParent = this;
            listagem.Show();
        }
    }
}
