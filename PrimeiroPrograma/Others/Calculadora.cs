namespace PrimeiroPrograma.Others
{
    internal class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double x)
        {
            return 2.0 * Pi * x;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
