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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            Nome.Clear();
            Idade.Clear();
            Matricula.Clear();
            Nome.Focus();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Cadastro formulario = (Cadastro)FindForm();
            formulario.Close();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if(("".Equals(Nome.Text)) || Matricula.Text.Equals("") || ("".Equals(Idade.Text))){
                var result = MessageBox.Show("Preencha TODOS os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Aluno objAluno = new Aluno();
                objAluno.Nome = Nome.Text;
                objAluno.Matricula = Convert.ToInt32(Matricula.Text);
                objAluno.Idade = Convert.ToInt32(Idade.Text);
                global.Sala1.Add(objAluno);
                Nome.Clear();
                Idade.Clear();
                Matricula.Clear();
                Nome.Focus();
                MessageBox.Show("Aluno Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
