using Microsoft.Data.SqlClient;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace DataTableImplements.Models
{
    public class Conexao
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader DataReader;

        // metodo - abrir conexão

        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Server=201.30.147.53;DataBase=DBADS001_DEV; User Id=u_ron001; Password=ronaldo_led321;TrustServerCertificate=True");
                  Con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }     
}
