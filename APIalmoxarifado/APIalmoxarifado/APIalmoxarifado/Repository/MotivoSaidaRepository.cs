using APIalmoxarifado.Infraestrutura;
using APIalmoxarifado.Models;
using Microsoft.EntityFrameworkCore;

namespace APIalmoxarifado.Repository
{
    public class MotivoSaidaRepository: IMotivoSaidaRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(MotivoSaida motivoSaida)
        {
            bdConexao.Add(motivoSaida);
            bdConexao.SaveChanges();
        }
        public List<MotivoSaida> GetAll()
        {
            return bdConexao.MotivoSaida.ToList();
        }

        public async Task<bool> DeleteMotivoSaida(int id)
        {
            var f = await bdConexao.MotivoSaida.FirstOrDefaultAsync(x => x.MotId == id);
            bdConexao.MotivoSaida.Remove(f);
            await bdConexao.SaveChangesAsync();
            return true;
        }
        public async Task<MotivoSaida> UpdateMotivoSaida(MotivoSaida Model)
        {
            bdConexao.Update(Model);
            await bdConexao.SaveChangesAsync();
            return Model;
        }
    }
}
