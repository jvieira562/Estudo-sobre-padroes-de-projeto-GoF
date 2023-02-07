using Abstract_Factory.Factories;
using Abstract_Factory.Factories.Interfaces;
using Abstract_Factory.Produtos.Interfaces;
using System;

namespace AbstractFactory;

public class Program
{
    static void Main()
    {
        Factory factoryA = new AFactory();
        Factory factoryB = new BFactory();
        
        Carro carroA =  factoryA.CriarCarro();
        Carro carroB = factoryB.CriarCarro();

        Console.WriteLine($"carroA.Acelerar);
    }
}