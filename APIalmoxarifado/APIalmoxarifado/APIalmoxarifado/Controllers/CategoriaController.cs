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


        [HttpPost]
        [Route("GetAllFake")]
        public IActionResult GetAllFake()
        {
            var categorias = new List<Categoria>()
            {
              new Categoria()
              {
                  id = 1,
                  descricao="Latícinios",
                  
              },
              new Categoria()
              {
                id=2,
                descricao="Eletronicos",
                
              },
              new Categoria
              {
                  id = 3,
                  descricao="Bebidas",
              }


            };
            return Ok(categorias);
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

    }
}
