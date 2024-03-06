using APIalmoxarifado.Models;

namespace APIalmoxarifado.Repository
{
    public interface IDepartamentoRepository
    {
        List<Departamento> GetAll();

        void Add(Departamento departamento);
        Task<bool> DeleteDepartamento(int id);
        Task<Departamento> UpdateDepartamento(Departamento Model);
    }
}
