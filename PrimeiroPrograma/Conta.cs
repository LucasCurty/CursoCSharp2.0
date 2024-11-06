namespace PrimeiroPrograma {
    internal class Conta {

        public int NumeroConta {  get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        private readonly double Taxa = 5.00;

        public Conta(string titular, int numeroConta) {
            Titular = titular;
            NumeroConta = numeroConta;
        }
        public Conta(string titular, int numeroConta, double saldo) : this() {
            Titular = titular;
            NumeroConta = numeroConta;
            Deposito(saldo);
        }


        public double Deposito(double deposito) {
            return Saldo + deposito;
        }

        public double Saque(double saque) {
            return Saldo - saque - Taxa;
        }


    }
}
