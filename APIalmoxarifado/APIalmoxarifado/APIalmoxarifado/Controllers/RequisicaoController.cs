using APIalmoxarifado.Models;
using APIalmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/requisicao")]
    public class RequisicaoController : Controller
    {
        public IActionResult AdicionarRequisicao(ViewModelRequisicaoProdutoAdicionar carrinho) 
        {

            var requisicao = new Requisicao()
            {
                DataRequisicao = DateTime.Now,
                Departamento = new Departamento() { id = carrinho.codigoDepartamento},
                itens = carrinho.itens


            };
            return View();
        
        }


    }
}
