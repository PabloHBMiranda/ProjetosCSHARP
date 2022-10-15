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
            if (global.Vingadores[0] == 0)
            {
                cd0.Image = global::Ingresso.Properties.Resources.cadeira_verde;
                global.Vingadores[0] = 1;
                global.Totaling++;
            }
            else
            {
                if(global.Vingadores[0] == 1)
                {
                    cd0.Image = global::Ingresso.Properties.Resources.cadeira_branca;
                    global.Vingadores[0] = 0;
                    global.Totaling--;
                }
            }
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
                cd0.Image = global::Ingresso.Properties.Resources.cadeira_verde_ok;
            }
            else
            {
                cd0.Image = global::Ingresso.Properties.Resources.cadeira_azul;
            }
            //cadeira 2
            if (x[1] == 0)
            {
                cd1.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd1.Image = global::Ingresso.Properties.Resources.cadeira_azul;
            }
            //cadeira 3
            if (x[2] == 0)
            {
                cd2.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd2.Image = global::Ingresso.Properties.Resources.cadeira_azul;
            }
            //cadeira 4
            if (x[3] == 0)
            {
                cd3.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd3.Image = global::Ingresso.Properties.Resources.cadeira_azul;
            }
            //cadeira 5
            if (x[4] == 0)
            {
                cd4.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd4.Image = global::Ingresso.Properties.Resources.cadeira_azul;
            }
            //cadeira 6
            if (x[5] == 0)
            {
                cd5.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd5.Image = global::Ingresso.Properties.Resources.cadeira_azul;
            }
            //cadeira 7
            if (x[6] == 0)
            {
                cd6.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd6.Image = global::Ingresso.Properties.Resources.cadeira_azul;
            }
            //cadeira 8
            if (x[7] == 0)
            {
                cd7.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd7.Image = global::Ingresso.Properties.Resources.cadeira_azul;
            }
            //cadeira 9
            if (x[8] == 0)
            {
                cd8.Image = global::Ingresso.Properties.Resources.cadeira_branca;
            }
            else
            {
                cd8.Image = global::Ingresso.Properties.Resources.cadeira_azul;
            }
        }
        //fim
    }
}
