using APIalmoxarifado.Models;
using APIalmoxarifado.Repository;
using APIalmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/motivo")]
    public class MotivoController : Controller
    {

        private readonly MotivoRepository _motivoRepository = new ;
        public IActionResult Adicionar(ViewModelMotivo pMotivo)
        {
            try
            {
                var novoMotivo = new Motivo()
                {
                    Descricao = pMotivo.Descricao,
                    CodigoCategoriaMotivo = 1
                };

                return Ok("Cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                return Ok("Erro em cadastro" + ex.Message);
            }
        }
    }
}
