using Abstract_Factory.Produtos.Interfaces;

namespace Abstract_Factory.Produtos
{
    public class CarroVoador : Carro
    {
        public int Cod_Carro { get; set ; }
        public int AnoFabricacao { get  ; set   ; }
        public string Nome { get; set; }

        public CarroVoador()
        {
            Cod_Carro = qnt;
            AnoFabricacao = 2062;
            Nome = "Ford Voador";
        }

        public override int Acelerar()
        {
            return 200;
        }
    }
}
