using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Avaliacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void txtBX1_TextChanged(object sender, EventArgs e)
        {
        }

        private void addProduto_Click(object sender, EventArgs e)
        {
            if(txtBX1.Text.ToString() != "" && txtBX2.Text.ToString() != "" && txtBX3.Text.ToString() != "" 
                && valorT.Text.ToString() != "" )
            {
                listView1.Items.Add(txtBX1.Text);
                listView2.Items.Add(txtBX2.Text);
                listView3.Items.Add(txtBX3.Text);
                listView4.Items.Add(valorT.Text);
                txtBX1.Clear();
                txtBX2.Clear();
                txtBX3.Clear();
                valorT.Text = "";
            }
            else
            {
                MessageBox.Show("Não pode ficar nenhum campo em branco", "PREENCHA TODOS OS CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removerLista_Click(object sender, EventArgs e)
        {
            int i;
            if (listView1.Items.Count!=0 && listView2.Items.Count !=0 && listView1.Items.Count != 0 && listView1.Items.Count != 0)
            {
                if(listView1.SelectedIndex >= 0)
                {
                    i = listView1.SelectedIndex;
                    listView1.Items.RemoveAt(i);
                    listView2.Items.RemoveAt(i);
                    listView3.Items.RemoveAt(i);
                    listView4.Items.RemoveAt(i);
                }
                else
                {
                    if (listView2.SelectedIndex >=0)
                    {
                        i = listView2.SelectedIndex;
                        listView1.Items.RemoveAt(i);
                        listView2.Items.RemoveAt(i);
                        listView3.Items.RemoveAt(i);
                        listView4.Items.RemoveAt(i);
                    }
                    else
                    {
                        if(listView3.SelectedIndex >= 0)
                        {
                            i = listView3.SelectedIndex;
                            listView1.Items.RemoveAt(i);
                            listView2.Items.RemoveAt(i);
                            listView3.Items.RemoveAt(i);
                            listView4.Items.RemoveAt(i);
                        }
                        else
                        {
                            if(listView4.SelectedIndex >= 0)
                            {
                                i = listView4.SelectedIndex;
                                listView1.Items.RemoveAt(i);
                                listView2.Items.RemoveAt(i);
                                listView3.Items.RemoveAt(i);
                                listView4.Items.RemoveAt(i);
                            }
                            else
                            {
                                MessageBox.Show("É NECESSÁRIO SELECIONAR O ITEM A SER REMOVIDO", "SELEÇÃO VAZIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("É NECESSÁRIO SELECIONAR O ITEM A SER REMOVIDO", "SELEÇÃO VAZIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtBX3_TextChanged(object sender, EventArgs e)
        {
            if(txtBX2.Text.ToString()!="" && txtBX3.Text.ToString() != "")
            {
                double total;
                total = Convert.ToDouble(txtBX2.Text) * Convert.ToDouble(txtBX3.Text);
                valorT.Text = total.ToString("C");
            }
        }

        private void fehcarVenda_Click(object sender, EventArgs e)
        {
            if(listView4.Items.Count != 0)
            {
                double total;
                int i;
                for(i = 0, total = 0; i < listView4.Items.Count; i++)
                {
                    total += Double.Parse(listView4.Items[i].ToString(), System.Globalization.NumberStyles.Currency);    
                }
                txtTOTAL.Text = total.ToString("C");
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("É NECESSÁRIO INSERIR UM ITEM NA LISTA", "LISTA VAZIA", MessageBoxButtons.OK);
            }
        }

        private void cancelarVenda_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();
            txtTOTAL.Text = "";
            txtBX1.Clear();
            txtBX2.Clear();
            txtBX3.Clear();
            valorT.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listView1.SelectedIndex;
            listView2.SelectedIndex = i;
            listView3.SelectedIndex = i;
            listView4.SelectedIndex = i;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listView2.SelectedIndex;
            listView1.SelectedIndex = i;
            listView3.SelectedIndex = i;
            listView4.SelectedIndex = i;
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listView3.SelectedIndex;
            listView1.SelectedIndex = i;
            listView2.SelectedIndex = i;
            listView4.SelectedIndex = i;
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listView4.SelectedIndex;
            listView1.SelectedIndex = i;
            listView2.SelectedIndex = i;
            listView3.SelectedIndex = i;
        }

        private void txtBX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBX3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
