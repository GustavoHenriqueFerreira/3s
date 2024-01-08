using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;
using webapi.filmes.manha.Repositories;

namespace webapi.filmes.manha.Controllers
{
    //Define que a rota de uma requisição será no seguinte formato
    //dominio/api/nomeController
    //ex: http://localhost:5000/api/sala
    [Route("api/[controller]")]

    //Define que é um controlador de API
    [ApiController]

    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    //Classe controladora que herda da controller base
    //Onde será criado os Endpoints (rotas)
    public class SalaController : ControllerBase
    {

        private ISalaRepository _salaRepository { get; set; }


        public SalaController()
        {
            _salaRepository = new SalaRepository();
        }



        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<SalaDomain> listaSalas = _salaRepository.ListarTodos();

      
                return Ok(listaSalas);
            }
            catch (Exception erro)
            {
    
                return BadRequest(erro);
            }

        }




        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {

                SalaDomain salaBuscada = _salaRepository.BuscarPorId(id);


                if (salaBuscada == null)
                {
                    return NotFound("Nenhum sala encontrado!");
                }

                return Ok(salaBuscada);
            }
            catch (Exception erro)
            {

                // Retorna um status 400 - BadRequest e o código do erro
                return BadRequest(erro);
            }


        }
    }
}
