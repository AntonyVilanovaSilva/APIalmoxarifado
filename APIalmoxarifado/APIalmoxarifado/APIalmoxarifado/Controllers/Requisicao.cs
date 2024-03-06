using APIalmoxarifado.Models;
using APIalmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/requisicao")]
    public class Requisicao
    {
        public IActionResult AdicionarRequisicao(ViewModelRequisicaoProdutoAdicionar carrinho) 
        {

            var requisicao = new Requisicao()
            {
                DataRequisicao = DateTime.Now,
                departamento = new Departamento() {  Codigo= carrinho.codigoDepartamento},
                itens


            };
        
        
        }


    }
}
