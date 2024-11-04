using System.Globalization;

namespace PrimeiroPrograma
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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
        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }

        }

        public double ValorTotalEmStoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int valor)
        {
            _quantidade += valor;
        }
        public void RemoverProduto(int valor)
        {
            _quantidade -= valor;
        }
        public override string ToString()
        {
            return _nome
                + ", $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmStoque().ToString("F2", CultureInfo.InvariantCulture);
        }

       
    }
}
