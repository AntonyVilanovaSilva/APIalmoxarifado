using APIalmoxarifado.Models;

namespace APIalmoxarifado.Repository
{
    public interface IDepartamentoRepository
    {
        object? GetAll();

        public interface IDepartamentoRepository
        {

            List<Departamento> GetAll();

            void Add(Departamento departamento);

        }
    }
}
