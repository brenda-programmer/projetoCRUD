using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // ADO.NET -> SQL SERVER

namespace DAL.Persistence
{
    public class Conexao
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        //Método para abrir conexão
        protected void AbrirConexao()
        {
           
            try
            {
                // Connection string
                var texto = @"Data Source=BR-OLIVEIB2-01\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                Con = new SqlConnection(texto.Replace(@"\", @"\\")); 
                Con.Open();
            }
            catch(Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Método para fechar conexão
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
