using Abstract_Factory.Factories.Interfaces;
using Abstract_Factory.Produtos;
using Abstract_Factory.Produtos.Interfaces;

namespace Abstract_Factory.Factories
{
    public class AFactory : Factory
    {
        
        public override Carro CriarCarro()
        {
            return new CarroEletrico();
        }

        public override Computador CriarComputador()
        {
            return new ComputadorMicro();
        }
    }
}
