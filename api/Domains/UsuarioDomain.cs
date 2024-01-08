using System.ComponentModel.DataAnnotations;

namespace webapi.filmes.manha.Domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }


        [Required(ErrorMessage ="O campo email é obrigatório!")]
        public string Email { get; set; }
        public string Nome { get; set; }


        [Required(ErrorMessage ="O campo senha é obrigatório!")]
        public string Senha { get; set; }

        public string Funcao { get; set; }
    }
}
