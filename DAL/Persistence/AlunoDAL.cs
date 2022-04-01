using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Biblioteca de acesso ao SQL Server
using DAL.Model;

namespace DAL.Persistence
{
    //Regras de negócio - consultas!
    //Select, Update, Insert, Delete, ObterPorId
    public class AlunoDAL : Conexao
    {
        // Método para gravar dados: INSERT
        public void Gravar(Aluno a)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Aluno (Nome, Endereco, Email) values(@v1, @v2, @v3)",Con);

                Cmd.Parameters.AddWithValue("@v1", a.Nome);
                Cmd.Parameters.AddWithValue("@v2", a.Endereco);
                Cmd.Parameters.AddWithValue("@v3", a.Email);

                Cmd.ExecuteNonQuery(); // executa a query
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar aluno: "+ ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para atualizar dados: UPDATE
        public void Atualizar(Aluno a)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Aluno set Nome=@v1, Endereco=@v2, Email=@v3 where Matricula=@v4", Con);

                Cmd.Parameters.AddWithValue("@v1", a.Nome);
                Cmd.Parameters.AddWithValue("@v2", a.Endereco);
                Cmd.Parameters.AddWithValue("@v3", a.Email);
                Cmd.Parameters.AddWithValue("@v4", a.Matricula);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar o aluno: "+ ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para excluir dados: DELETE
        public void Excluir(int Matricula)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Aluno where Matricula=@v1",Con);

                Cmd.Parameters.AddWithValue("@v1", Matricula);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir o Aluno: "+ ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para obter 1 Aluno pela Matricula (Chave primária)
        public Aluno PesquisarPorMatricula(int Matricula)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluno where Matricula=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Matricula);
                Dr = Cmd.ExecuteReader(); //execução da leitura das informações no BD

                Aluno a = null; // criando um espaço de memória - ponteiro

                if (Dr.Read())
                {
                    a = new Aluno();

                    a.Matricula = Convert.ToInt32(Dr["Matricula"]);
                    a.Nome = Convert.ToString(Dr["Nome"]);
                    a.Endereco = Convert.ToString(Dr["Endereco"]);
                    a.Email = Convert.ToString(Dr["Email"]);
                }
                return a;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar o Aluno: "+ ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para listar todos os Alunos cadastrados
        public List<Aluno> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluno", Con);
                Dr = Cmd.ExecuteReader();

                List<Aluno> lista = new List<Aluno>(); // lista vazia

                while(Dr.Read())
                {
                    Aluno a = new Aluno();

                    a.Matricula = Convert.ToInt32(Dr["Matricula"]);
                    a.Nome = Convert.ToString(Dr["Nome"]);
                    a.Endereco = Convert.ToString(Dr["Endereco"]);
                    a.Email = Convert.ToString(Dr["Email"]);

                    lista.Add(a);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar os Alunos: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
