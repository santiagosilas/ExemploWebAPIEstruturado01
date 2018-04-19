using System.ComponentModel.DataAnnotations.Schema;

namespace ExemploLibrary.Entidades
{
    public class ProdutoEtiqueta : IEntidade
    {
        [NotMapped]
        public long Id { get; set; }

        public int ProdutoId { get; set; }
        public int EtiquetaId { get; set; }
        public Produto Produto { get; set; }
        public Etiqueta Etiqueta { get; set; }
    }
}
