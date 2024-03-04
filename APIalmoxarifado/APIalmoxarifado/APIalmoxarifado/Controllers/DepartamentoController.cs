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

        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAll()
        {
            return Ok(_departamentoRepository.GetAll());
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateDepartamento(Departamento Model) => Ok(await _departamentoRepository.UpdateDepartamento(Model));
                

    }
}

