using FactoryMethod.ConcreteFactory;
using System;

namespace FactoryMethod;

public class Program
{
    static void Main(string[] args)
    {
        var factoryA = new MotoFactory();
        var factoryB = new CarroFactory();
        var moto = factoryA.Create();
        var carro = factoryB.Create();

        Console.WriteLine(moto.Nome);
        Console.WriteLine(carro.Nome);
    }
}
