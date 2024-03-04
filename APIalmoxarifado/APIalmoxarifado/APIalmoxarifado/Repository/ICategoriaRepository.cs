using APIalmoxarifado.Models;

namespace APIalmoxarifado.Repository
{
    public interface ICategoriaRepository
    {
        List<Categoria> GetAll();

        void Add(Categoria Categoria);

        Task<bool> DeleteCategoria(int id);

        Task<Categoria> UpdateCategoria(Categoria Model);
    }
}
