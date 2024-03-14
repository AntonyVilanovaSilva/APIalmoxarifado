using System.ComponentModel.DataAnnotations;

namespace APIalmoxarifado.Models
{
    public class Entrada
    {
        [Key]
        public int codigo { get; set; }

        public DateTime dataentrada { get; set; }

        public List<Produto> produtos { get; set; }
    }
}
