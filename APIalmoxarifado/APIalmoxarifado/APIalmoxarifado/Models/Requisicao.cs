using System.ComponentModel.DataAnnotations;

namespace APIalmoxarifado.Models
{
    public class Requisicao
    {
        [Key]
        public int Codigo {  get; set; }

        public DateTime DataRequisicao { get; set; }

        public List<ItensRequisicao> itens { get; set; }
     
    }
}
