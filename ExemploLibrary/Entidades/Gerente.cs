namespace ExemploLibrary.Entidades
{
    //[Table("Person_Manager")]
    public class Gerente
    {
        public int Id { get; set; }           
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
