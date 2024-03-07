namespace APIalmoxarifado.Models
{
    public class Motivo
    {
        public int Codigo { get; set; } 
        
        public string Descricao { get; set; }

        public int CodigoCategoriaMotivo { get; set; }  

        public CategoriaMotivo CategoriaMotivo { get; set; }
    }
}
