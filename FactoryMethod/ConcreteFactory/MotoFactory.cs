using FactoryMethod.Produtos;
using System.Runtime.InteropServices;

namespace FactoryMethod.ConcreteFactory
{
    public class MotoFactory : IFactory
    {
        public IAutomovel Create()
        {
            return new Moto
            {
                Nome = "Moto De Corrida"
            };
        }
    }
}
