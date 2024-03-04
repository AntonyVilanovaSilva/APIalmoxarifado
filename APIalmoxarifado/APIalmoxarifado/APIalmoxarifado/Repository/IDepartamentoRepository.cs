using APIalmoxarifado.Models;

namespace APIalmoxarifado.Repository
{
    public interface IDepartamentoRepository
    {
        List<Departamento> GetAll();

        void Add(Departamento departamento);

        Task<Departamento> UpdateDepartamento(Departamento Model);
    }
}
