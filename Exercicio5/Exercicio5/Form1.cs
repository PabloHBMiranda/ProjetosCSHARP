using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5
{
    public partial class x : Form
    {
        public x()
        {
            InitializeComponent();
        }

        private void peso_Click(object sender, EventArgs e)
        {

        }

        private void x_Load(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(!(txtAltura.Text.Equals("")) && !(txtPeso.Text.Equals(""))){
                double imc;
                String p = txtPeso.Text.ToString(), h = txtAltura.Text.ToString();
                imc = Double.Parse(p) / (Double.Parse(h) * Double.Parse(h));
                IMC.Text = imc.ToString();
                if(imc < 18.5)
                {
                    pictureBox1.Image = global::Exercicio5.Properties.Resources._1_fw;
                }
                else
                {
                    if(imc <= 24.9)
                    {
                        pictureBox1.Image = global::Exercicio5.Properties.Resources._2_fw;
                    }
                    else
                    {
                        if(imc <= 29.9)
                        {
                            pictureBox1.Image = global::Exercicio5.Properties.Resources._3_fw;
                        }
                        else
                        {
                            if(imc <= 34.9){
                                pictureBox1.Image = global::Exercicio5.Properties.Resources._4_fw;
                            }
                            else
                            {
                                if(imc <= 39.9)
                                {
                                    pictureBox1.Image = global::Exercicio5.Properties.Resources._5_fw;
                                }
                                else
                                {
                                    pictureBox1.Image = global::Exercicio5.Properties.Resources._6_fw;
                                }
                                
                            }
                        }
                    }
                }
                txtAltura.Clear();
                txtPeso.Clear();
            }
            else
            {
                MessageBox.Show("Prencha os campos PESO e ALTURA", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
