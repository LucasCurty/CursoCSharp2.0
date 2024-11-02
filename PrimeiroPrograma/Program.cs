using System;
using System.Globalization;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //basicoVariaveis();
            //conferirSePar(5);
            //leituraEntrada();
            //Maior(3, 5, 7);
            //conferirNegativo();
            enquanto();
        }
        static void conferirSePar(int numero)
        {

            Console.WriteLine("Digite um numero:");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {

                Console.WriteLine("Numero é par");
            }
            else
            {
               Console.WriteLine("numero é impar!");
            }

        }
        static void basicoVariaveis()
        {
          
          bool completo = false;
           char sexo = 'A';
           string nome = "Lucas";

           object obj1 = "Leeo";
           double obj2 = 888.656516;


           int n1 = 127;
           long n2 = 561561651651561651L;
           float n3 = 1.4f;
           double n4 = 4.5;

           Console.WriteLine(n1);
           Console.WriteLine(n2);
           Console.WriteLine(n4);
           Console.WriteLine(n3);
           Console.WriteLine(completo);
           Console.WriteLine(sexo);
           Console.WriteLine(nome);
           Console.WriteLine(obj1);
           Console.WriteLine(obj2.ToString("F2"));
           Console.WriteLine($"{nome} esta estudando CSharp, com uma porcentagem de  {obj2}%");
          
        }

        static void leituraEntrada()
        {

            // teste de leitura do input


           Console.WriteLine("digite o primeiro numero!");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero!");
            int valor2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"a soma dos dois valores digitados é: {valor1 + valor2}");
        }
        static int Maior(int a, int b, int c)
        {
            int result;
            if (a > b && a > c)
            {
                result = a;
            }
            else if (b > c)
            {
                result = b;
            }
            else
            {
                result = c;
            }
            return result;
        }

        static void conferirNegativo()
        {
            int numero = int.Parse (Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine($"Numero digitado foi o {numero}, portanto ele é NEGATIVO");
            }
            else if (numero > 0)
            {
                Console.WriteLine($"Numero digitado foi o {numero}, portanto ele é POSITIVO");
            }
        }

        static void enquanto()
        {
            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x > 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"Raiz quadrada de {x} é: {raiz.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Digite um número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
    
}