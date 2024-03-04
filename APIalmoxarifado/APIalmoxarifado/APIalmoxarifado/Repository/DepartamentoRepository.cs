using APIalmoxarifado.Infraestrutura;
using APIalmoxarifado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIalmoxarifado.Repository
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Departamento departamento)
        {
            bdConexao.Add(departamento);
            bdConexao.SaveChanges();
        }
        public List<Departamento> GetAll()
        {
            return bdConexao.Departamento.ToList();
        }

        [HttpDelete]

        public async Task<bool> DeleteDepartamento(int id)
        {
            var c = await bdConexao.Departamento.FirstOrDefaultAsync(x => x.id == id);
            bdConexao.Departamento.Remove(c);
            await bdConexao.SaveChangesAsync();
            return true;
        }

        public async Task<Departamento> UpdateDepartamento(Departamento Model)
        {
            bdConexao.Update(Model);
            await bdConexao.SaveChangesAsync();
            return Model;
        }



    }
}
