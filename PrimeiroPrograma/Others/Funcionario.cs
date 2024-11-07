namespace PrimeiroPrograma.Others
{
    internal class Funcionario
    {
        public string Name;
        public double salarioBruto, imposto;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            return SalarioLiquido() + salarioBruto * (porcentagem / 100);
        }

    }
}
