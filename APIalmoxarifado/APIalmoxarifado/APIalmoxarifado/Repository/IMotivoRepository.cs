using APIalmoxarifado.Models;

namespace APIalmoxarifado.Repository
{
    public interface IMotivoRepository
    {
        List<Motivo> GetAll();

        void Add(Motivo motivo);
        Task<bool> DeleteMotivo(int id);
        Task<Motivo> UpdateMotivo(Motivo Model);
    }
}
