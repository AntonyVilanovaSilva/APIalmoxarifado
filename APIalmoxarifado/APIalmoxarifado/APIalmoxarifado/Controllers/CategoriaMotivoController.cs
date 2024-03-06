using APIalmoxarifado.Models;
using APIalmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/categoriamotivo")]
    public class CategoriaMotivoController : Controller
    {
        private readonly ICategoriaMotivoRepository _categoriamotivoRepository;

        public CategoriaMotivoController(ICategoriaMotivoRepository repositorio)
        {
            _categoriamotivoRepository = repositorio;
        }


        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAll()
        {
            return Ok(_categoriamotivoRepository.GetAll());
        }

        [HttpPost]
        [Route("/CategoriaMotivo/Create")]

        public IActionResult CriarCategoriaMotivo(CategoriaMotivo Model)
        {
            _categoriamotivoRepository.Add(Model);
            return Ok("Massa");
        }

        [HttpDelete]
        [Route("/Delete/{id}")]

        public async Task<IActionResult> DeleteCategoriaMotivo(int id) => Ok(await _categoriamotivoRepository.DeleteCategoriaMotivo(id));

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateCategoriaMotivo(CategoriaMotivo Model) => Ok(await _categoriamotivoRepository.UpdateCategoriaMotivo(Model));
    }
}
