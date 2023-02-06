using Abstract_Factory.Produtos.Interfaces;

namespace Abstract_Factory.Produtos
{
    public class ComputadorMicro : Computador
    { 
        public int Cod_Computador { get; set; }
        public string Marca { get;  set ; }
        public double Preco { get; set; }


        public ComputadorMicro()
        {
            Cod_Computador = quantidade;
            Marca = "Dell";
            Preco = 250.0;
        }

        public override string Jogar()
        {
            return "Valorant";
        }
    }
}
