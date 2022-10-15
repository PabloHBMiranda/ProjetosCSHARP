using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio001Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbProdutos.SelectedIndex)
            {
                case 1:
                    lbVProduto.Text = "500,00";
                    break;
                case 2:
                    lbVProduto.Text = "2.200,00";
                    break;
                case 3:
                    lbVProduto.Text = "4.000,00";
                    break;
                case 4:
                    lbVProduto.Text = "800,00";
                    break;
                case 5:
                    lbVProduto.Text = "1.000,00";
                    break;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cmbProdutos.Text = "[ Selecione ]";
            cmbLocal.Text = "[ Selecione ]";
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            cmbProdutos.Text = "[ Selecione ]";
            cmbLocal.Text = "[ Selecione ]";
            lbVProduto.Text = "R$ 0";
            lbFrete.Text = "R$ 0";
            lbTotal.Text = "R$ 0";
        }

        private void cmbLocal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbLocal.SelectedIndex)
            {
                case 1:
                    lbFrete.Text = "20,00";
                    break;
                case 2:
                    lbFrete.Text = "40,00";
                    break;
                case 3:
                    lbFrete.Text = "100,00";
                    break;
                case 4:
                    lbFrete.Text = "50,00";
                    break;
                case 5:
                    lbFrete.Text = "60,00";
                    break;
            }
        }

        private void CalcularVTotal_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (cmbProdutos.SelectedIndex.Equals(0)){
                result = MessageBox.Show("Selecione um produto.", "Selecione um produto para continuar", MessageBoxButtons.OK);
            }
            else
            {
                if (cmbLocal.SelectedIndex.Equals(0)) {
                    result = MessageBox.Show("Selecione o local de entrega", "Selecione um local", MessageBoxButtons.OK);
                }
                else
                {
                    double total;
                    total = Convert.ToDouble(lbVProduto.Text) + Convert.ToDouble(lbFrete.Text);
                    lbTotal.Text = String.Format("{0:C}", total);
                }
            }
        }
    }
}
