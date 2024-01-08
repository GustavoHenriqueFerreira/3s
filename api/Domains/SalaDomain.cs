using System.ComponentModel.DataAnnotations;

namespace webapi.filmes.manha.Domains
{
    /// <summary>
    /// Classe que representa a entidade(tabela) sala
    /// </summary>
    public class SalaDomain
    {
        public int IdSala { get; set; }

        public string? Descricao { get; set; }

        public string? Nome { get; set; }
        public string? Status { get; set; }

    }
}
