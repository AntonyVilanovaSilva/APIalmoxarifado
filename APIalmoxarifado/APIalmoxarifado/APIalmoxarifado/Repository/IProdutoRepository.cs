using APIalmoxarifado.Models;

namespace APIalmoxarifado.Repository
{
    public interface IProdutoRepository
    {

        List<Produto> GetAll();

        void Add (Produto produto);

        Task<bool> DeleteProduto(int id);

        Task<Produto> UpdateProduto(Produto Model);

    }
}
