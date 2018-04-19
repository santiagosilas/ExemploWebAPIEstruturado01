using System.IO;
using ExemploLibrary.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ExemploLibrary.Contextos
{
    public class DataContext : DbContext
    {
        public IConfigurationRoot Configuration { get; set; }

        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<ProdutoEtiqueta> ProdutosEtiquetas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Empregado> Empregados { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Obtém as configurações especificadas em appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Define a base de dados a ser usada
            var cnn = config.GetConnectionString("LP2Exemplo");
            optionsBuilder.UseSqlServer(cnn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relacionamento Many-to-Many (chaves compostas)
            modelBuilder.Entity<ProdutoEtiqueta>()
                .HasKey(pt => new { ProdutoId = pt.ProdutoId, EtiquetaId = pt.EtiquetaId });

            // Chaves Únicas
            modelBuilder.Entity<Cliente>().HasIndex(c => c.PessoaId).IsUnique(true);
            modelBuilder.Entity<Empregado>().HasIndex(e => e.PessoaId).IsUnique(true);
            modelBuilder.Entity<Gerente>().HasIndex(m => m.PessoaId).IsUnique(true);

            // Solução OnDelete
            //modelBuilder.Entity<ProdutoEtiqueta>()
            //    .HasOne(p => p.Produto)
            //    .WithMany(m => m.ProdutosEtiquetas)
            //    .OnDelete(DeleteBehavior.Restrict);
            
        }

    }

}

