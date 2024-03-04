namespace APIalmoxarifado.Models
{
    public class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cargo { get; set; }
        public DateTime datanascimento { get; set; }

        public decimal salario { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
    }
}
