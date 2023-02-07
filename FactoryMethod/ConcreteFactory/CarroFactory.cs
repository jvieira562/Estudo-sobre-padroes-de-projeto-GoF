using FactoryMethod.Produtos;

namespace FactoryMethod.ConcreteFactory
{
    public class CarroFactory : IFactory
    {
        public IAutomovel Create()
        {
            return new Carro
            {
                Nome = "Carro de Passeio"
            };
        }
    }
}
