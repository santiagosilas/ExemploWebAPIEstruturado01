using System.Collections.Generic;

namespace ExemploLibrary.Entidades
{
    public class Produto : IEntidade
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<ProdutoEtiqueta> ProdutosEtiquetas { get; set; }

        public Produto()
        {
            ProdutosEtiquetas = new List<ProdutoEtiqueta>();
        }
    }
}
