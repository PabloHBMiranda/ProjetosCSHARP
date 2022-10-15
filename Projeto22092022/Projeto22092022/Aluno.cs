using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto22092022
{
    internal class Aluno
    {
        private String nome;
        private int matricula;
        private int idade;

        public string Nome { get => nome; set => nome = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public int Idade { get => idade; set => idade = value; }

        public Aluno(string nome, int matricula, int idade)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.idade = idade;
        }
        public Aluno()
        {
            nome = null;
            matricula = 0;
            idade = 0;
        }
    }
}
