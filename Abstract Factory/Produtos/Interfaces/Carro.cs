namespace Abstract_Factory.Produtos.Interfaces
{
    public abstract class Carro
    {
        public static int qnt = 1;

        public Carro()
        {
            qnt = qnt++;
        }
        public abstract int Acelerar();

    }
}
