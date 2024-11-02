using System.Globalization;

namespace PrimeiroPrograma
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmStoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int valor)
        {
            Quantidade += valor;
        }
        public void RemoverProduto(int valor)
        {
            Quantidade -= valor;
        }
        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmStoque().ToString("F2", CultureInfo.InvariantCulture);
        }

       
    }
}
