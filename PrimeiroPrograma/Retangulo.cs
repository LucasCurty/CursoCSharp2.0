
namespace PrimeiroPrograma
{
    internal class Retangulo
    {
        public double largura, altura;

        public double CalculaArea()
        {
            return (largura * altura);
        }

        public double CalculaPerimetro()
        {
            return 2 * (largura + altura);
        }

        public double CalculaDiagonal()
        {
            return Math.Sqrt(altura * altura + largura * largura);
        }
    }
}
