namespace ExemploLibrary.Entidades
{
    //[Table("Person_Employee")]
    public class Empregado : IEntidade
    {
        public long Id { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
