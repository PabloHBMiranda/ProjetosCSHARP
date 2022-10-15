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
    public partial class Login : Form
    {
        String vEmail = "Visitante", vSenha = "0";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login formulario = (Login)FindForm();
            global.LoginG = vEmail;
            formulario.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(global.logado == false)
            {
                int i, p = -1;
                for (i = 0; i < global.Email.Count && p == -1; i++)
                {
                    if (global.Email[i].Equals(txtLemail.Text.ToString()))
                    {
                        vEmail = txtLemail.Text.ToString();
                        p = i;
                    }
                    if (global.Senha[i].Equals(txtLsenha.Text.ToString()))
                    {
                        vSenha = txtLsenha.Text.ToString();
                        p = i;
                    }
                }

                if (vEmail.Equals("Visitante") || vSenha.Equals("0"))
                {
                    MessageBox.Show("Login ou senha inválido", "INGRESSO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    global.LoginG = global.Nome[p];
                    global.logado = true;
                    Login formulario = (Login)FindForm();
                    MessageBox.Show("Login realizado com Sucesso!", "INGRESSO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formulario.Close();
                }
            }
            else
            {
                MessageBox.Show("Já está logado", "INGRESSO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
