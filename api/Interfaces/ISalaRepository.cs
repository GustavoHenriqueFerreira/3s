using webapi.filmes.manha.Domains;

namespace webapi.filmes.manha.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório SalaRepository
    /// Definir os métodos que serão implementados pelo SalaRepository
    /// </summary>
    public interface ISalaRepository
    {



        List<SalaDomain> ListarTodos();


        SalaDomain BuscarPorId(int id); 
    }
}
