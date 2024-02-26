using APIalmoxarifado.Models;
using APIalmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/departamento")]
    public class DepartamentoController : Controller
    {
        private readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoController(IDepartamentoRepository repositorio)
        {
            _departamentoRepository = repositorio;
        }


        [HttpPost]
        [Route("GetAllFake")]
        public IActionResult GetAllFake()
        {
            var departamentos = new List<Departamento>()
            {
              new Departamento()
              {
                  id = 1,
                  descricao="1",

              },

            };
            return Ok(departamentos);
        }

        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAll()
        {
            return Ok(_departamentoRepository.GetAll());
        }

        

    }
}

