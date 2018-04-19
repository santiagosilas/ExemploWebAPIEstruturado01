using System.Collections.Generic;

namespace ExemploLibrary.Entidades
{
    /// <summary>
    /// Categoria possui vários Produtos (1 Produto possui uma category)
    /// </summary>
    public class Categoria : IEntidade
    {
        public Categoria()
        {
            Produtos = new List<Produto>();
        }
        public long Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
