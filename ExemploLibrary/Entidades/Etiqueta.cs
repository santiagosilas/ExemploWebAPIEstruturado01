using System.Collections.Generic;

namespace ExemploLibrary.Entidades
{
    public class Etiqueta : IEntidade
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<ProdutoEtiqueta> ProdutoEtiqueta { get; set; }

        public Etiqueta()
        {
            ProdutoEtiqueta = new List<ProdutoEtiqueta>();
        }
    }
}
