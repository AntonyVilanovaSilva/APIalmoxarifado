using APIalmoxarifado.Models;

namespace APIalmoxarifado.Repository
{
    public interface ICategoriaMotivoRepository
    {
        List<CategoriaMotivo> GetAll();

        void Add(CategoriaMotivo categoriaMotivo);

        Task<bool> DeleteCategoriaMotivo(int id);

        Task<CategoriaMotivo> UpdateCategoriaMotivo(CategoriaMotivo Model);
    }
}
