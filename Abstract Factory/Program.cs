using Abstract_Factory.Factories;
using Abstract_Factory.Factories.Interfaces;
using Abstract_Factory.Produtos.Interfaces;
using System;

namespace AbstractFactory;

public class Program
{
    static void Main()
    {
        Factory factory = new AFactory();
        
        Carro carro =  factory.CriarCarro();
    }
}