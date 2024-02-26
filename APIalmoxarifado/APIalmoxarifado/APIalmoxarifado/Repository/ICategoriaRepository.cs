using APIalmoxarifado.Models;

namespace APIalmoxarifado.Repository
{
    public interface ICategoriaRepository
    {
        List<Categoria> GetAll();

        void Add(Categoria Categoria);
    }
}
