using System.Globalization;

namespace PrimeiroPrograma.Others
{
    internal class Aluno
    {
        public string nome;
        public double notaA, notaB, notaC;

        public double NotaFinal()
        {
            return notaA + notaB + notaC;
        }
        public void Resultado()
        {
            double media = (notaA + notaB + notaC) / 3;

            if (media > 60.00)
            {
                Console.WriteLine($"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"SUA MEDIA FOI DE: {media}");
                Console.WriteLine("Aprovado!!");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"SUA MEDIA FOI DE: {media}");
                Console.WriteLine("Reprovado!!");
            }
        }
    }
}
