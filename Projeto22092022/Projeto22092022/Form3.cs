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
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Listagem formulario = (Listagem)FindForm();
            formulario.Close();
        }

        private void Listagem_Enter(object sender, EventArgs e)
        {
            Selecione.Items.Clear();
            foreach(Aluno aluno in global.Sala1)
            {
                Selecione.Items.Add(aluno.Matricula.ToString());
            }
        }

        private void Selecione_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selecao = Selecione.SelectedItem.ToString();
            foreach(Aluno aluno in global.Sala1)
            {
                if (selecao.Equals(aluno.Matricula.ToString()))
                {
                    Nome.Text = aluno.Nome;
                    Idade.Text = aluno.Idade.ToString();
                }
            }
        }
    }
}
