namespace ExemploLibrary.Entidades
{
    //[Table("Person_Employee")]
    public class Empregado
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
