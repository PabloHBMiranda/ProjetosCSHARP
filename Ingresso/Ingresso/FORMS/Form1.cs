using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingresso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            CriarConta criarcnt = new CriarConta();
            criarcnt.FormClosed += new FormClosedEventHandler(fechar_FormClosed);
            criarcnt.MdiParent = this;
            criarcnt.Show();
        }                                                                                                                             
        void fechar_FormClosed(object sender, FormClosedEventArgs e)
        {

            panel1.Visible = true;

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Login login = new Login();
            login.FormClosed += new FormClosedEventHandler(fecharLogin_FormClosed);
            login.MdiParent = this;
            login.Show();
        }
        void fecharLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

            panel1.Visible = true;
            txtUser.Text = global.LoginG.ToString();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(global.logado == false)
            {
                MessageBox.Show("Você não está logado.", "INGRESSO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Você foi deslogado.", "INGRESSO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                global.logado = false;
                global.LoginG = "Visitante";
                txtUser.Text = global.LoginG;
            }
        }

        private void pbVingadores_Click(object sender, EventArgs e)
        {
            if(global.logado == true)
            {
                panel1.Visible = false;
                ComprarIngresso compraring = new ComprarIngresso();
                compraring.FormClosed += new FormClosedEventHandler(compraring_FormClosed);
                compraring.MdiParent = this;
                global.filme_escolhido = 0;
                compraring.Show();
            }
            else
            {
                MessageBox.Show("Crie ou acesse sua conta para comprar o ingresso do filme", "INGRESSO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void compraring_FormClosed(object sender, FormClosedEventArgs e)
        {
            panel1.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            global.Vingadores = new int[9];
            global.Corra = new int[9];
            global.Queen = new int[9];
            global.Formes = new int[9];
            int i;
            for (i = 0; i < 9; i++)
            {
                global.Vingadores[i] = 0;
            }
            for (i = 0; i < 9; i++)
            {
                global.Queen[i] = 0;
            }
            for (i = 0; i < 9; i++)
            {
                global.Corra[i] = 0;
            }
            for (i = 0; i < 9; i++)
            {
                global.Formes[i] = 0;
            }
        }
    }
}
