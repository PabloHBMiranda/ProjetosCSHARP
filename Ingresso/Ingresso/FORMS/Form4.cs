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
    public partial class ComprarIngresso : Form
    {
        public ComprarIngresso()
        {
            InitializeComponent();
        }

        private void ComprarIngresso_Load(object sender, EventArgs e)
        {
            cbTipo.Text = "[ Selecione ]";
            cbMeio.Text = "[ Selecione ]";
            global.Totaling = 0;
            txtQtd.Text = global.Totaling.ToString();
            txtTotal.Text = global.Valoring.ToString("C");
            carregar_cadeiras(global.filme_escolhido);
        }

        private void cd0_Click(object sender, EventArgs e)
        {
            qual_filme(global.)
        }


        //cor das cadeiras
        public void carregar_cadeiras(int xFilme)
        {
            // VINGADORES
            if(xFilme == 0)
            {
                qual_filme(global.Vingadores);
            }
            else
            {
                //TRANSFORMES
                if(xFilme == 1)
                {
                    qual_filme(global.Formes);
                }
                else
                {
                    //CORRA
                    if(xFilme == 2)
                    {
                        qual_filme(global.Corra);
                    }
                    //QUEEN E SLIM
                    else
                    {
                        qual_filme(global.Queen);
                    }
                }
            }
        }

        public void qual_filme(int[] x)
        {
            //cadeira 1
            if (x[0] != 0)
            {
                cd0.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd0.Image = global::Ingresso.Properties.Resources.cadeira_azul;
                cd0.Enabled = false;
            }
            //cadeira 2
            if (x[1] == 0)
            {
                cd1.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd1.Image = global::Ingresso.Properties.Resources.cadeira_azul;
                cd0.Enabled = false;
            }
            //cadeira 3
            if (x[2] == 0)
            {
                cd2.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd2.Image = global::Ingresso.Properties.Resources.cadeira_azul;
                cd0.Enabled = false;
            }
            //cadeira 4
            if (x[3] == 0)
            {
                cd3.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd3.Image = global::Ingresso.Properties.Resources.cadeira_azul;
                cd0.Enabled = false;
            }
            //cadeira 5
            if (x[4] == 0)
            {
                cd4.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd4.Image = global::Ingresso.Properties.Resources.cadeira_azul;
                cd0.Enabled = false;
            }
            //cadeira 6
            if (x[5] == 0)
            {
                cd5.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd5.Image = global::Ingresso.Properties.Resources.cadeira_azul;
                cd0.Enabled = false;
            }
            //cadeira 7
            if (x[6] == 0)
            {
                cd6.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd6.Image = global::Ingresso.Properties.Resources.cadeira_azul;
                cd0.Enabled = false;
            }
            //cadeira 8
            if (x[7] == 0)
            {
                cd7.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd7.Image = global::Ingresso.Properties.Resources.cadeira_azul;
                cd0.Enabled = false;
            }
            //cadeira 9
            if (x[8] == 0)
            {
                cd8.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd8.Image = global::Ingresso.Properties.Resources.cadeira_azul;
                cd0.Enabled = false;
            }
        }
        //fim





        public void mudar_cadeiras(int xFilme)
        {
            // VINGADORES
            if (xFilme == 0)
            {
                trocar_cor(global.Vingadores);
            }
            else
            {
                //TRANSFORMES
                if (xFilme == 1)
                {
                    trocar_cor(global.Formes);
                }
                else
                {
                    //CORRA
                    if (xFilme == 2)
                    {
                        trocar_cor(global.Corra);
                    }
                    //QUEEN E SLIM
                    else
                    {
                        trocar_cor(global.Queen);
                    }
                }
            }
        }

        public void trocar_cor(int[] x)
        {
            //cadeira 1
            if (x[0] == 0)
            {
                cd0.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd0.Image = global::Ingresso.Properties.Resources.cadeira_verde_ok;
            }
            //cadeira 2
            if (x[1] == 0)
            {
                cd1.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd1.Image = global::Ingresso.Properties.Resources.cadeira_verde_ok;
            }
            //cadeira 3
            if (x[2] == 0)
            {
                cd2.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd2.Image = global::Ingresso.Properties.Resources.cadeira_verde_ok;
            }
            //cadeira 4
            if (x[3] == 0)
            {
                cd3.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd3.Image = global::Ingresso.Properties.Resources.cadeira_verde_ok;
            }
            //cadeira 5
            if (x[4] == 0)
            {
                cd4.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd4.Image = global::Ingresso.Properties.Resources.cadeira_verde_ok;
            }
            //cadeira 6
            if (x[5] == 0)
            {
                cd5.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd5.Image = global::Ingresso.Properties.Resources.cadeira_verde_ok;
            }
            //cadeira 7
            if (x[6] == 0)
            {
                cd6.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd6.Image = global::Ingresso.Properties.Resources.cadeira_verde_ok;
            }
            //cadeira 8
            if (x[7] == 0)
            {
                cd7.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd7.Image = global::Ingresso.Properties.Resources.cadeira_verde_ok;
            }
            //cadeira 9
            if (x[8] == 0)
            {
                cd8.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd8.Image = global::Ingresso.Properties.Resources.cadeira_verde_ok;
            }
        }
    }
}
