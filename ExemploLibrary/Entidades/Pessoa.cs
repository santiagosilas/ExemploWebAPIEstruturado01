namespace ExemploLibrary.Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Empregado Empregado { get; set; }
        public virtual Gerente Gerente { get; set; }
    }
}
