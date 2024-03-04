using APIalmoxarifado.Models;

namespace APIalmoxarifado.Repository
{
    public interface IFuncionarioRepository
    {
            List<Funcionario> GetAll();

            void Add(Funcionario funcionario);

            Task<bool> DeleteFuncionario(int id);

        Task<Funcionario> UpdateFuncionario(Funcionario Model);


    }
}
