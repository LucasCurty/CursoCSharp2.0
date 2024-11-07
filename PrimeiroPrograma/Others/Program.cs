using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace PrimeiroPrograma.Others
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //basicoVariaveis();
        //    //conferirSePar(5);
        //    //leituraEntrada();
        //    //Maior(3, 5, 7);
        //    //conferirNegativo();
        //    //estruturaWhile();
        //    //estruturaFor();
        //    //areaTriangulo();
        //    //exercicioPessoa();
        //    //produtos();
        //    //notasAluno();
        //    //retangulo();
        //    //salario();
        //    //Pi();
        //    //banco();
        //}
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
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine($"Numero digitado foi o {numero}, portanto ele é NEGATIVO");
            }
            else if (numero > 0)
            {
                Console.WriteLine($"Numero digitado foi o {numero}, portanto ele é POSITIVO");
            }
        }

        static void estruturaWhile()
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

        static void estruturaFor()
        {
            Console.Write("Quantos numeros inteiros voce ira digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Valor #{i}");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");
        }

        static void areaTriangulo()
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            Console.WriteLine($"Area de X = {areaX}");
            Console.WriteLine($"Area de Y = {areaY}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Mario area: Y");
            }

        }

        static void exercicioPessoa()
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");

            }



        }

        static void produtos()
        {

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            //produto.Nome = "TV4K";

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque");
            quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine("Digite o numero de produtos a ser removidos do estoque");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProduto(quantidade);
            Console.WriteLine("Dados atualizados: " + produto);

        }

        static void notasAluno()
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno " + aluno.nome);
            aluno.notaA = double.Parse(Console.ReadLine());
            aluno.notaB = double.Parse(Console.ReadLine());
            aluno.notaC = double.Parse(Console.ReadLine());
            aluno.Resultado();

        }

        static void retangulo()
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Altura: ");
            retangulo.altura = double.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            retangulo.largura = double.Parse(Console.ReadLine());

            Console.WriteLine($"AREA = {retangulo.CalculaArea().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {retangulo.CalculaPerimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {retangulo.CalculaDiagonal().ToString("F2", CultureInfo.InvariantCulture)}");

        }

        static void salario()
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.salarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.imposto = double.Parse(Console.ReadLine());


            Console.WriteLine($"Funcionário {funcionario.Name}, $ {funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados atualizados: {funcionario.Name}, $ {funcionario.AumentarSalario(porcentagem).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static void Pi()
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");

        }

        static void banco()
        {
            // arrummar exercicio! 

        }
    }

}