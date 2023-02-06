using Abstract_Factory.Produtos.Interfaces;

namespace Abstract_Factory.Factories.Interfaces
{
    public abstract class Factory
    {
        public virtual Computador CriarComputador() 
        {
            return null;
        }
        public virtual Carro CriarCarro()
        {
            return null;
        }
    }
}
