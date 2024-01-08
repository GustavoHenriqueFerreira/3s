using System.Data.SqlClient;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;

namespace webapi.filmes.manha.Repositories
{

    public class SalaRepository : ISalaRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; Initial Catalog=db_3s; Integrated Security=True";





    

        /// <summary>
        /// Busca um sala através do seu id
        /// </summary>
        /// <param name="id">id do sala que será buscado</param>
        /// <returns>Um sala buscado ou null caso não seja encontrado</returns>
        public SalaDomain BuscarPorId(int id)
        {
            // Declara a SqlConnection con passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                // Declara a query a ser executada
                string querySelectById = "SELECT sala.idSala, sala.descricao, sala.nome, sala.status";

                // Abre a conexão com o banco de dados
                con.Open();

                // Deckara o SqlDataReader rdr para receber os valores do banco de dados
                SqlDataReader rdr;

                // Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    // Passa o valor para o parâmetro @ID
                    cmd.Parameters.AddWithValue("@idSala", id);

                    // Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    // Verifica se o resultado da query retornou algum registro
                    if (rdr.Read())
                    {

                        SalaDomain salaBuscada = new SalaDomain()


   
                        {

                            IdSala = Convert.ToInt32(rdr["idSala"]),



                            Nome = rdr["nome"].ToString(),

                        };

                        return salaBuscada;
                    }

                    // Se não, retorna null
                    return null;
                }
            }
        }


        public List<SalaDomain> ListarTodos()
        {
            List<SalaDomain> ListaSalas = new List<SalaDomain>();

    
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelectAll = "SELECT sala.idSala, sala.descricao, sala.nome, sala.status";

                con.Open();


                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll,con))
                {
  
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        SalaDomain sala = new SalaDomain()
                        {
                        
                            IdSala = Convert.ToInt32(rdr["idSala"]),


                     
                            Nome = rdr["nome"].ToString(),

                        };
 
                        ListaSalas.Add(sala);
                    }
                }
            }
            return ListaSalas;
        }
    }
}