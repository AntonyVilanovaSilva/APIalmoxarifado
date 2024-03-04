using APIalmoxarifado.Infraestrutura;
using APIalmoxarifado.Models;
using Microsoft.EntityFrameworkCore;

namespace APIalmoxarifado.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Funcionario funcionario)
        {
            bdConexao.Add(funcionario);
            bdConexao.SaveChanges();
        }
        public List<Funcionario> GetAll()
        {
            return bdConexao.Funcionario.ToList();
        }

        public async Task<bool> DeleteFuncionario(int id)
        {
            var d = await bdConexao.Funcionario.FirstOrDefaultAsync(x => x.id == id);
            bdConexao.Funcionario.Remove(d);
            await bdConexao.SaveChangesAsync();
            return true;
        }
        public async Task<Funcionario> UpdateFuncionario(Funcionario Model)
        {
            bdConexao.Update(Model);
            await bdConexao.SaveChangesAsync();
            return Model;
        }
    }
}
