using APIalmoxarifado.Models;
using APIalmoxarifado.Repository;
using APIalmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/categoria")]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository repositorio)
        {
            _categoriaRepository = repositorio;
        }
     

        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAll()
        {
            return Ok(_categoriaRepository.GetAll());
        }

        [HttpPost]
        [Route("/Categoria/Create")]

        public IActionResult CriarProduto(Categoria Model)
        {
            _categoriaRepository.Add(Model);
            return Ok("Massa");
        }

        [HttpDelete]
        [Route("/Delete/{id}")]

        public async Task<IActionResult> DeleteCategoria(int id) => Ok(await _categoriaRepository.DeleteCategoria(id));

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateCategoria(Categoria Model) => Ok(await _categoriaRepository.UpdateCategoria(Model));
    }
}
