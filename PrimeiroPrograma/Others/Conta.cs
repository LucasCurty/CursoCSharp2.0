namespace PrimeiroPrograma.Others
{
    internal class Conta
    {

        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }


        public Conta(string titular, int numeroConta)
        {
            Titular = titular;
            NumeroConta = numeroConta;
        }
        public Conta(string titular, int numeroConta, double saldo) : this(titular, numeroConta)
        {
            Saldo = saldo;
        }


        public double Deposito(double deposito)
        {
            return Saldo + deposito;
        }

        public double Saque(double saque)
        {
            return Saldo - saque + 5.00;
        }


    }
}
