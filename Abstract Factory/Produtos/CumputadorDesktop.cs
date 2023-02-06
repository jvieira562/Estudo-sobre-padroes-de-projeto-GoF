using Abstract_Factory.Produtos.Interfaces;

namespace Abstract_Factory.Produtos
{
    public class CumputadorDesktop : Computador
    {
        public int Cod_Computador { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public CumputadorDesktop()
        {
            Cod_Computador = quantidade;
            Marca = "Positivo";
            Preco = 100.0;
        }

        public override string Jogar()
        {
            return "Pubg";
        }
    }
}
