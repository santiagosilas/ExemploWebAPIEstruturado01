using System.Collections.Generic;

namespace ExemploLibrary.Entidades
{
    /// <summary>
    /// Categoria possui vários Produtos (1 Produto possui uma category)
    /// </summary>
    public class Categoria
    {
        public Categoria()
        {
            Produtos = new List<Produto>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
