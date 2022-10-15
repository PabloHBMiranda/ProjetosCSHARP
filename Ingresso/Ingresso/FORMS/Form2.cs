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
    public partial class CriarConta : Form
    {   
        
        public CriarConta()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            CriarConta formulario = (CriarConta)FindForm();
            formulario.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)        
        {
            int igual = 1;
            if(!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtSenha.Text.Equals("") && !txtCsenha.Text.Equals(""))
            {
                if (txtSenha.Text.Equals(txtCsenha.Text))
                {
                    for(int i =0; i < global.Email.Count; i++)
                    {
                        if (global.Email[i].Equals(txtEmail.Text.ToString()))
                        {
                            igual = 0;
                        }
                    }
                    if(igual == 1)
                    {
                        global.Email.Add(txtEmail.Text.ToString());
                        global.Senha.Add(txtSenha.Text.ToString());
                        global.Nome.Add(txtNome.Text.ToString());
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtCsenha.Clear();
                        MessageBox.Show("Cadastro efetuado com Sucesso!", "INGRESSO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CriarConta formulario = (CriarConta)FindForm();
                        formulario.Close();
                    }
                    else
                    {
                        MessageBox.Show("E-mail já cadastrado", "INGRESSO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("As senhas não são iguais", "INGRESSO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "INGRESSO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
