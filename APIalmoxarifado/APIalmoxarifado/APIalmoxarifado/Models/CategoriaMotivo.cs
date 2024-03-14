using System.ComponentModel.DataAnnotations;

namespace APIalmoxarifado.Models
{
    public class CategoriaMotivo
    {
        [Key]
        public int CatId { get; set; }
        public string descricao { get; set; }

        public List<Motivo> Motivos { get; set;}
    }
}
