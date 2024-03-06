namespace APIalmoxarifado.Models
{
    public class ItensRequisicao
    { 
      public int IteId { get; set; }
      public Requisicao requisicao {  get; set; }
      public int CodigoRequisicao { get; set; }

      public Produto produto { get; set; }
      
      public int CodigoProduto { get; set; }

      public double Preco {  get; set; }

      public int Quantidade { get; set; }
    }
}
