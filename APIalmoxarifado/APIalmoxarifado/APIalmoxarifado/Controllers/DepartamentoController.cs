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

        [HttpDelete]
        [Route("/Delete/{id}")]

        public async Task<IActionResult> DeleteDepartamento(int id) => Ok(await _departamentoRepository.DeleteDepartamento(id));

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateDepartamento(Departamento Model) => Ok(await _departamentoRepository.UpdateDepartamento(Model));
                

    }
}

