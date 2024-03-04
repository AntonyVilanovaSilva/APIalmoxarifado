using APIalmoxarifado.Models;
using Microsoft.EntityFrameworkCore;

namespace APIalmoxarifado.Infraestrutura
{
    public class ConexaoSQL : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
             =>
               optionBuilder.UseSqlServer("Data Source=PC03LAB2040\\SENAI;Initial Catalog=dbAlmoxarifado;User ID=sa;Password=senai.123");

        public DbSet<Produto> Produto {  get; set; } 
        public DbSet<Categoria> Categoria {  get; set; } 

        public DbSet<Departamento> Departamento { get; set;}

        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
