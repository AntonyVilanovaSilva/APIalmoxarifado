using APIalmoxarifado.Models;
using Microsoft.EntityFrameworkCore;

namespace APIalmoxarifado.Infraestrutura
{
    public class ConexaoSQL : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
             =>
               optionBuilder.UseSqlServer("Data Source=PC03LAB2040\\SENAI;Initial Catalog=dbAlmoxarifado;User ID=sa;Password=senai.123");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Requisicao>()
           .HasMany(e => e.itens)
           .WithOne(e => e.requisicao)
           .HasForeignKey(e => e.CodigoRequisicao)
           .HasPrincipalKey(e => e.Codigo);
        }
        




        public DbSet<Produto> Produto {  get; set; } 
        public DbSet<Categoria> Categoria {  get; set; } 

        public DbSet<Departamento> Departamento { get; set;}

        public DbSet<Funcionario> Funcionario { get; set; }

        public DbSet<CategoriaMotivo> CategoriaMotivo { get; set; }

        public DbSet<MotivoSaida> MotivoSaida { get; set; }

        public DbSet<Motivo> motivos { get; set; }    
        
        public DbSet<ItensRequisicao> itensRequisicaos { get; set; }    
        public DbSet<Requisicao> Requisicao { get; set;}
    }
}
