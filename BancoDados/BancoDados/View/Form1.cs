using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
            txtNome.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtMedia.Clear();
            txtMatricula.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.informacoes'. Você pode movê-la ou removê-la conforme necessário.
            //this.informacoesTableAdapter.Fill(this.dataSet1.informacoes);

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Equals(""))
            {
                MessageBox.Show("Informe o nome do aluno");
                return;
            }
            try
            {
                String status = null;
                if(Double.Parse(txtMedia.Text)>= 6.0)
                {
                    status = "APROVADO";
                }
                else
                {
                    status = "REPROADO";
                }
                AlunoDB alunoDB = new AlunoDB();
                Aluno aluno = new Aluno(txtNome.Text, int.Parse(txtMatricula.Text),
                                        Double.Parse(txtN1.Text), Double.Parse(txtN2.Text),
                                        Double.Parse(txtMedia.Text),status);
                alunoDB.IncluirAluno(aluno);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
