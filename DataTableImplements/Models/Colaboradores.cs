using Microsoft.AspNetCore.Mvc;

namespace DataTableImplements.Models
{
    public class Colaboradores : Conexao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Re { get; set; }
        public string NumeroAtivo { get; set; }
        public string Local { get; set; }

        public Colaboradores() { 
        
        }

        public List<Colaboradores> GetAll() {
            try
            {
                AbrirConexao();
                Cmd = new Microsoft.Data.SqlClient.SqlCommand("SELECT TOP 100 *  FROM DBADS001_DEV.dbo._TMP_COLABORADORES ORDER BY DESCRICAO ", Con);
                DataReader = Cmd.ExecuteReader();
                List<Colaboradores> colaboradores = new List<Colaboradores>();

                while(DataReader.Read())
                {
                    Colaboradores c = new Colaboradores();
                    c.Id  = Convert.ToInt32(DataReader.GetInt32(0));
                    c.Descricao = Convert.ToString(DataReader.GetString(1));
                    c.Re = Convert.ToString(DataReader.GetString(2));
                    c.NumeroAtivo = Convert.ToString(DataReader.GetString(3));
                    c.Local = Convert.ToString(DataReader.GetString(4));

                    colaboradores.Add(c);
                }
                return colaboradores;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        
    }
}
