using APIalmoxarifado.Models;
using APIalmoxarifado.Repository;
using APIalmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/produto")]
    public class ProdutoController : Controller
    {
         private  readonly IProdutoRepository _produtosRepository = new ProdutoRepository();

        public ProdutoController(IProdutoRepository repositorio)
        {
            _produtosRepository = repositorio;
        }




        [HttpGet]
        [Route("Hello")]
        public IActionResult Index()
        {
            return Ok("Hello Mundo");
        }

        [HttpPost]
        [Route("GetAllFake")]
        public IActionResult GetAllFake()
        {
            var produtos = new List<Produto>()
            {
              new Produto()
              {
                  id = 1,
                  nome="PC HP",
                  estoque=10
              },
              new Produto()
              {
                id=2,
                nome="PC DELL",
                estoque=20
              }


            };
            return Ok(produtos);
        }

        [HttpGet]
        [Route ("GetAll")]

        public IActionResult GetAll()
        {
            return Ok(_produtosRepository.GetAll());
        }

        [HttpPost]
        [Route("AdiconarProdutoSemFoto")]

        public IActionResult AdicionarProdutoSemFoto(ProdutoViewModelSemFoto produto)
        {

            try
            {
                _produtosRepository.Add(
                     new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = null }
                       );

                 return Ok("Cadastro com Sucesso");

            } 

            catch (Exception ex)
            {
                return BadRequest("Não Cadastro. Erro" + ex.Message);
            }
            


 

        }

        [HttpPost]
        [Route("AdiconarProdutoComFoto")]

        public IActionResult AdicionarProdutoComFoto([FromForm] ProdutoViewModelComFoto produto)
        {

            try
            {
                var caminho = Path.Combine("Storange", produto.photo.FileName);
                using Stream fileStram = new FileStream(caminho, FileMode.Create);
                produto.photo.CopyTo(fileStram);

                _produtosRepository.Add(
                     new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = null }
                       );

                return Ok("Cadastro com Sucesso");

            }

            catch (Exception ex)
            {
                return BadRequest("Não Cadastro. Erro" + ex.Message);
            }
        
        }

        [HttpGet]
        [Route("{id}/GetProduto")]

        public IActionResult Download(int id) {

            try
            {
                var produto = _produtosRepository.GetAll().Find(x => x.id == id);
                if (produto.photourl == null)
                {
                    return Ok("Não existe falta cadastrada para o Produto");
                }
                else
                {
                    var dataBytes = System.IO.File.ReadAllBytes(produto.photourl);
                    return File(dataBytes, "image/jpg");

                }
            }
            catch (Exception ex)
            {

                return BadRequest("Erro em fazer download: " + ex.Message);
            }
            
            
        }
        
    }
}
