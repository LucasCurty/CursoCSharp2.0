using PrimeiroPrograma.Seção6.Class;
using System.Globalization;

namespace PrimeiroPrograma.Seção6 {
    internal class Program {
        static void Main(string[] args) {
            //Nullable();
            //VectorStruct();
            //VectorClass();
            ExercicioFixacao();
        }

        static void Nullable() {
            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;


            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void VectorStruct() {
            // aprendendo vetor de tipo structs
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            double sum = 0;

            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine(avg);


        }

        static void VectorClass() {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine($"AVARAGE PRICE = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static void ExercicioFixacao() {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Rooms[] rooms = new Rooms[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Informe seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe seu email: ");
                string email = Console.ReadLine();
                Console.Write("Informe o quarto desejado de 1 a 10: ");
                int roomChose = int.Parse(Console.ReadLine());
                rooms[i] = new Rooms { Nome = nome, Email = email, Room = roomChose };
                Console.WriteLine();
            }

            for (int i = 1; i < n; i++) {
                Console.WriteLine($"Rent #{i}");
                Console.WriteLine($"Nome: {rooms[i].Nome}");
                Console.WriteLine($"Email: {rooms[i].Email}");
                Console.WriteLine($"Room: {rooms[i].Room}");
                Console.WriteLine();

            }
            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < rooms.Length; i++) {
                rooms[i].ToString();
            }

        }
    }
}
