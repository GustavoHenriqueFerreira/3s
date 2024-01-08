using System.ComponentModel.DataAnnotations;

namespace webapi.filmes.manha.Domains
{
    /// <summary>
    /// Classe que representa a entidade(tabela) reserva
    /// </summary>
    public class ReservaDomain
    {
        public int IdReserva { get; set; }

        public DateTime? CheckOut { get; set; }
        public DateTime? CheckIn { get; set; }
        public int IdUsuario { get; set; }
        public int idSala { get; set; }

        public SalaDomain? Genero { get; set; }
        public UsuarioDomain? Usuario { get; set; }
    }
}
