using APIalmoxarifado.Infraestrutura;
using APIalmoxarifado.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIalmoxarifado.Repository
{
    public class MotivoRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Motivo motivo)
        {
            bdConexao.Add(motivo);
            bdConexao.SaveChanges();
        }
        public List<Motivo> GetAll()
        {
            return bdConexao.Motivo.ToList();
        }

        [HttpDelete]

        public async Task<bool> DeleteMotivo(int id)
        {
            var g = await bdConexao.Motivo.FirstOrDefaultAsync(x => x.id == id);
            bdConexao.Motivo.Remove(g);
            await bdConexao.SaveChangesAsync();
            return true;
        }

        public async Task<Motivo> UpdateMotivo(Motivo Model)
        {
            bdConexao.Update(Model);
            await bdConexao.SaveChangesAsync();
            return Model;
        }

    }
}
