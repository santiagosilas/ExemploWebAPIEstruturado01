using ExemploLibrary.Contextos;
using ExemploLibrary.Entidades;

namespace ExemploLibrary.Repositorios
{
    public class ContatoRepositorio: RepositorioBase<Contato>, IContatoRepositorio
    {
        public ContatoRepositorio(DataContext context) : base(context)
        {
        }
    }
}
