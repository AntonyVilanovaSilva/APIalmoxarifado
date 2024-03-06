using APIalmoxarifado.Models;

namespace APIalmoxarifado.Repository
{
    public interface IMotivoSaidaRepository
    {
        List<MotivoSaida> GetAll();

        void Add(MotivoSaida motivoSaida);

        Task<bool> DeleteMotivoSaida(int id);

        Task<MotivoSaida> UpdateMotivoSaida(MotivoSaida Model);
    }
}
