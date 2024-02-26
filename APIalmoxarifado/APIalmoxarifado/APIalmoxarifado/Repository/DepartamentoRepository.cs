using APIalmoxarifado.Infraestrutura;
using APIalmoxarifado.Models;

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

        object? IDepartamentoRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
