using System.Collections.Generic;

namespace ExemploLibrary.Entidades
{
    public class Etiqueta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<ProdutoEtiqueta> ProdutoEtiqueta { get; set; }

        public Etiqueta()
        {
            ProdutoEtiqueta = new List<ProdutoEtiqueta>();
        }
    }
}
