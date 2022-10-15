using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        private int[] Velha;
        private int jogador;
        public Form1()
        {
            InitializeComponent();
        }

        public void testeGanhou()
        {
            if (Velha[0] == Velha[1] && Velha[1]==Velha[2] && Velha[0] != -1)
            {
                traco.Image = global::JogoDaVelha.Properties.Resources.traco4;
                traco.Visible = true;
                if (Velha[0] == 0)
                {
                    MessageBox.Show("Jogador CIRCULO ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Jogador X ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                }
                Application.Exit();
            }
            else
            {
                if (Velha[3] == Velha[4] && Velha[4] == Velha[5] && Velha[3] != -1)
                {
                    traco.Image = global::JogoDaVelha.Properties.Resources.traco5;
                    traco.Visible = true;
                    if (Velha[0] == 0)
                    {
                        MessageBox.Show("Jogador CIRCULO ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Jogador X ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                    }
                    Application.Exit();
                }
                else
                {
                    if (Velha[6] == Velha[7] && Velha[7] == Velha[8] && Velha[7] != -1)
                    {
                        traco.Image = global::JogoDaVelha.Properties.Resources.traco6;
                        traco.Visible = true;
                        if (Velha[0] == 0)
                        {
                            MessageBox.Show("Jogador CIRCULO ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Jogador X ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                        }
                        Application.Exit();
                    }
                    else
                    {
                        if (Velha[0] == Velha[4] && Velha[4] == Velha[8] && Velha[0] != -1)
                        {
                            traco.Image = global::JogoDaVelha.Properties.Resources.traco1;
                            traco.Visible = true;
                            if (Velha[0] == 0)
                            {
                                MessageBox.Show("Jogador CIRCULO ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Jogador X ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                            }
                            Application.Exit();
                        }
                        else
                        {
                            if (Velha[2] == Velha[4] && Velha[4] == Velha[6] && Velha[2] != -1)
                            {
                                traco.Image = global::JogoDaVelha.Properties.Resources.traco2;
                                traco.Visible = true;
                                if (Velha[0] == 0)
                                {
                                    MessageBox.Show("Jogador CIRCULO ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("Jogador X ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                                }
                                Application.Exit();
                            }
                            else
                            {
                                if (Velha[0] == Velha[3] && Velha[3] == Velha[6] && Velha[0] != -1)
                                {
                                    traco.Image = global::JogoDaVelha.Properties.Resources.traco7;
                                    traco.Visible = true;
                                    if (Velha[0] == 0)
                                    {
                                        MessageBox.Show("Jogador CIRCULO ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Jogador X ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                                    }
                                    Application.Exit();
                                }
                                else
                                {
                                    if (Velha[1] == Velha[4] && Velha[4] == Velha[7] && Velha[1] != -1)
                                    {
                                        traco.Image = global::JogoDaVelha.Properties.Resources.traco3;
                                        traco.Visible = true;
                                        if (Velha[0] == 0)
                                        {
                                            MessageBox.Show("Jogador CIRCULO ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Jogador X ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                                        }
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        if (Velha[2] == Velha[5] && Velha[5] == Velha[8] && Velha[2] != -1)
                                        {
                                            traco.Image = global::JogoDaVelha.Properties.Resources.traco8;
                                            traco.Visible = true;
                                            if (Velha[0] == 0)
                                            {
                                                MessageBox.Show("Jogador CIRCULO ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                                            }
                                            else
                                            {
                                                MessageBox.Show("Jogador X ganhou!", "JogoDaVelha", MessageBoxButtons.OK);
                                            }
                                            Application.Exit();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Image = null;
            label2.Image = null;
            label3.Image = null;
            label4.Image = null;
            label5.Image = null;
            label6.Image = null;
            label7.Image = null;
            label8.Image = null;
            label9.Image = null;
            this.Velha = new int[9];
            for(int i = 0; i < 9; i++)
            {
                Velha[i] = -1;
            }
            Random rnd = new Random();
            this.jogador = rnd.Next(2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (this.Velha[0] == -1)
            {
                this.Velha[0] = jogador;
                if(jogador == 0)
                {
                    label1.Image = global::JogoDaVelha.Properties.Resources.bola;
                    jogador = 1;
                }
                else
                {
                    if (jogador == 1)
                    {
                        label1.Image = global::JogoDaVelha.Properties.Resources.x;
                        jogador = 0;
                    }
                }
                testeGanhou();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (this.Velha[1] == -1)
            {
                this.Velha[1] = jogador;
                if (jogador == 0)
                {
                    label2.Image = global::JogoDaVelha.Properties.Resources.bola;
                    jogador = 1;
                }
                else
                {
                    if (jogador == 1)
                    {
                        label2.Image = global::JogoDaVelha.Properties.Resources.x;
                        jogador = 0;
                    }
                }
                testeGanhou();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (this.Velha[2] == -1)
            {
                this.Velha[2] = jogador;
                if (jogador == 0)
                {
                    label3.Image = global::JogoDaVelha.Properties.Resources.bola;
                    jogador = 1;
                }
                else
                {
                    if (jogador == 1)
                    {
                        label3.Image = global::JogoDaVelha.Properties.Resources.x;
                        jogador = 0;
                    }
                }
                testeGanhou();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (this.Velha[3] == -1)
            {
                this.Velha[3] = jogador;
                if (jogador == 0)
                {
                    label4.Image = global::JogoDaVelha.Properties.Resources.bola;
                    jogador = 1;
                }
                else
                {
                    if (jogador == 1)
                    {
                        label4.Image = global::JogoDaVelha.Properties.Resources.x;
                        jogador = 0;
                    }
                }
                testeGanhou();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (this.Velha[4] == -1)
            {
                this.Velha[4] = jogador;
                if (jogador == 0)
                {
                    label5.Image = global::JogoDaVelha.Properties.Resources.bola;
                    jogador = 1;
                }
                else
                {
                    if(jogador == 1)
                    {
                        label5.Image = global::JogoDaVelha.Properties.Resources.x;
                        jogador = 0;
                    }
                }
                testeGanhou();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (this.Velha[5] == -1)
            {
                this.Velha[5] = jogador;
                if (jogador == 0)
                {
                    label6.Image = global::JogoDaVelha.Properties.Resources.bola;
                    jogador = 1;
                }
                else
                {
                    if (jogador == 1)
                    {
                        label6.Image = global::JogoDaVelha.Properties.Resources.x;
                        jogador = 0;
                    }
                }
                testeGanhou();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (this.Velha[6] == -1)
            {
                this.Velha[6] = jogador;
                if (jogador == 0)
                {
                    label7.Image = global::JogoDaVelha.Properties.Resources.bola;
                    jogador = 1;
                }
                else
                {
                    if (jogador == 1)
                    {
                        label7.Image = global::JogoDaVelha.Properties.Resources.x;
                        jogador = 0;
                    }
                }
                testeGanhou();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (this.Velha[7] == -1)
            {
                this.Velha[7] = jogador;
                if (jogador == 0)
                {
                    label8.Image = global::JogoDaVelha.Properties.Resources.bola;
                    jogador = 1;
                }
                else
                {
                    if (jogador == 1)
                    {
                        label8.Image = global::JogoDaVelha.Properties.Resources.x;
                        jogador = 0;
                    }
                }
                testeGanhou();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (this.Velha[8] == -1)
            {
                this.Velha[8] = jogador;
                if (jogador == 0)
                {
                    label9.Image = global::JogoDaVelha.Properties.Resources.bola;
                    jogador = 1;
                }
                else
                {
                    if (jogador == 1)
                    {
                        label9.Image = global::JogoDaVelha.Properties.Resources.x;
                        jogador = 0;
                    }
                }
                testeGanhou();
            }
        }
    }
}
