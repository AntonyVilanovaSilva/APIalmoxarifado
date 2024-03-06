using APIalmoxarifado.Models;
using APIalmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/motivosaida")]
    public class MotivoSaidaController : Controller
    {
        private readonly IMotivoSaidaRepository _motivosaidaRepository;

        public MotivoSaidaController(IMotivoSaidaRepository repositorio)
        {
            _motivosaidaRepository = repositorio;
        }


        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAll()
        {
            return Ok(_motivosaidaRepository.GetAll());
        }

        [HttpPost]
        [Route("/MotivoSaída/Create")]

        public IActionResult CriarMotivoSaida(MotivoSaida Model)
        {
            _motivosaidaRepository.Add(Model);
            return Ok("Massa");
        }

        [HttpDelete]
        [Route("/Delete/{id}")]

        public async Task<IActionResult> DeleteMotivoSaida(int id) => Ok(await _motivosaidaRepository.DeleteMotivoSaida(id));

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateMotivoSaida(MotivoSaida Model) => Ok(await _motivosaidaRepository.UpdateMotivoSaida(Model));
    }
}
