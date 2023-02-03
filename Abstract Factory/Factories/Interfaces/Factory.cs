using Abstract_Factory.Produtos.Interfaces;

namespace Abstract_Factory.Factories.Interfaces
{
    public interface Factory
    {
        public Computador CriarComputador();
    }
}
