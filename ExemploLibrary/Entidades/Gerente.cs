namespace ExemploLibrary.Entidades
{
    //[Table("Person_Manager")]
    public class Gerente : IEntidade
    {
        public long Id { get; set; }           
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
