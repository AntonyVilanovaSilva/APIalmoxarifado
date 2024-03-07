using APIalmoxarifado.Infraestrutura;
using APIalmoxarifado.Models;
using Microsoft.EntityFrameworkCore;

namespace APIalmoxarifado.Repository
{
    public class CategoriaMotivoRepository : ICategoriaMotivoRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(CategoriaMotivo categoriaMotivo)
        {
            bdConexao.Add(categoriaMotivo);
            bdConexao.SaveChanges();
        }
        public List<CategoriaMotivo> GetAll()
        {
            return bdConexao.CategoriaMotivo.ToList();
        }

        public async Task<bool> DeleteCategoriaMotivo(int id)
        {
            var e = await bdConexao.CategoriaMotivo.FirstOrDefaultAsync(x => x.CatId == id);
            bdConexao.CategoriaMotivo.Remove(e);
            await bdConexao.SaveChangesAsync();
            return true;
        }

        public async Task<CategoriaMotivo> UpdateCategoriaMotivo(CategoriaMotivo Model)
        {
            bdConexao.Update(Model);
            await bdConexao.SaveChangesAsync();
            return Model;
        }

        
    }
}

