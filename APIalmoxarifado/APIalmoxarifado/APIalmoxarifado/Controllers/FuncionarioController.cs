using APIalmoxarifado.Models;
using APIalmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/funcionario")]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioController(IFuncionarioRepository repositorio)
        {
            _funcionarioRepository = repositorio;
        }

        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAll()
        {
            return Ok(_funcionarioRepository.GetAll());
        }

        [HttpDelete]
        [Route("/Delete/{id}")]

        public async Task<IActionResult> DeleteFuncionario(int id) => Ok(await _funcionarioRepository.DeleteFuncionario(id));

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateFuncionario(Funcionario Model) => Ok(await _funcionarioRepository.UpdateFuncionario(Model));


    }
}

