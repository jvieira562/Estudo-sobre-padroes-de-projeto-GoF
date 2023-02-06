using Abstract_Factory.Produtos.Interfaces;

namespace Abstract_Factory.Produtos
{
    public class CarroEletrico : Carro
    {
        public int Cod_Carro { get; set; }
        public int AnoFabricacao { get; set; }
        public string Nome { get; set; }

        public CarroEletrico()
        {            
            Cod_Carro = qnt;
            AnoFabricacao = 2018;
            Nome = "Ford Eletrico";
        }

        public override int Acelerar()
        {
            return 120;
        }
    }
}
