namespace ExemploLibrary.Entidades
{
    public class ProdutoEtiqueta
    {
        public int ProdutoId { get; set; }
        public int EtiquetaId { get; set; }
        public Produto Produto { get; set; }
        public Etiqueta Etiqueta { get; set; }
    }
}
