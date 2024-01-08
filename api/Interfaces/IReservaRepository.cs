using webapi.filmes.manha.Domains;

namespace webapi.filmes.manha.Interfaces
{
 
    public interface IFilmeRepository
    {

        void Cadastrar(ReservaDomain novoFilme);


        List<ReservaDomain> ListarTodos();


        ReservaDomain BuscarPorId(int id);

    }
}
