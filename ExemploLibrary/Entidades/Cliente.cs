namespace ExemploLibrary.Entidades
{
    //[Table("Person_Client")]
    public class Cliente
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
