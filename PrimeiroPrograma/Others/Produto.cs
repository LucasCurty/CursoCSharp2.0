using System.Globalization;

namespace PrimeiroPrograma.Others
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public double Quantidade { get; private set; }

        public Produto() { }
        public Produto(string nome, double preco, int quantidade) // contrutor = mesmo nome da classe
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

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
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmStoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
