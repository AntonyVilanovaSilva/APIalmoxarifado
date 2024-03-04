using APIalmoxarifado.Infraestrutura;
using APIalmoxarifado.Models;
using Microsoft.EntityFrameworkCore;

namespace APIalmoxarifado.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Produto produto)
        {
            bdConexao.Add(produto);
            bdConexao.SaveChanges();
        }
        public List<Produto> GetAll()
        {
            return bdConexao.Produto.ToList();
        }

        public async Task<bool> DeleteProduto(int id)
        {
            var a = await bdConexao.Produto.FirstOrDefaultAsync(x => x.id == id);
            bdConexao.Produto.Remove(a);
            await bdConexao.SaveChangesAsync();
            return true;
        }

        public async Task<Produto> UpdateProduto(Produto Model)
        {
            bdConexao.Update(Model);
            await bdConexao.SaveChangesAsync();
            return Model;
        }
    }
}
