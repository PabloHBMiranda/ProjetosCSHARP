using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;
using System.Data;

namespace BancoDados
{
    internal class AlunoDB
    {
        private string conexao;

        public AlunoDB()
        {
            this.conexao = ConfigurationManager.ConnectionStrings["conexaoBancoDados"].ConnectionString;
        }

        public DataTable getAlunos()
        {
            DataTable dt = new DataTable();
            NpgsqlConnection pgsqlConnection = new NpgsqlConnection(conexao);
            try
            {
                using (pgsqlConnection)
                {
                    pgsqlConnection.Open();
                    string sqlSelect = "SELECT * FROM PUBLIC.INFORMACOES;";
                    using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(sqlSelect, pgsqlConnection))
                    {
                        adaptador.Fill(dt);
                    }
                }
            }
            catch(NpgsqlException ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
            return dt;
        }

        public void IncluirAluno(Aluno aluno)
        {
            NpgsqlConnection pgsqlConnection = new NpgsqlConnection(conexao);
            try
            {
                using (pgsqlConnection)
                {
                    pgsqlConnection.Open();
                    string sqlInsert = String.Format("INSERT INTO" +  "PUBLIC.INFORMACOES(nome,matricula,n1,n2,media,status)" + 
                        "values('{0}',{1},{3},{4},'{5}')", 
                        aluno.Nome, aluno.Matricula, aluno.N1, aluno.N2, aluno.Media, aluno.Status);
                    using (NpgsqlCommand comando = new NpgsqlCommand(sqlInsert, pgsqlConnection))
                    {
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch(NpgsqlException ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

        }
    }
}
