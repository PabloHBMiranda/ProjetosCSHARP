using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados
{
    internal class Aluno
    {
        private string nome;
        private int matricula;
        private double n1;
        private double n2;
        private double media;
        private string status;
        private int v;

        public string Nome { get => nome; set => nome = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public double N1 { get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }
        public double Media { get => media; set => media = value; }
        public string Status { get => status; set => status = value; }

        public Aluno(string nome, int matricula, double n1, double n2, double media, string status)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.n1 = n1;
            this.n2 = n2;
            this.media = media;
            this.status = status;
        }

        public Aluno()
        {
            this.nome = null;
            this.matricula = 0;
            this.n1 = 0;
            this.n2 = 0;
            this.media = 0;
            this.status = null;
        }
    }
}
