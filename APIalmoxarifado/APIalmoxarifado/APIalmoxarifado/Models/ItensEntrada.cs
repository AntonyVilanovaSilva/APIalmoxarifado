using System.ComponentModel.DataAnnotations;

namespace APIalmoxarifado.Models
{
    public class ItensEntrada
    {
        [Key]

        public int codigo { get; set; }

        public int CodigoEntrada { get; set; }

        public int CodigoProduto { get; set;}

        public int Estoque { get; set; }


    }
}
