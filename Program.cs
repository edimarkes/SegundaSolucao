namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cadastrar 2 alunos e suas 2 notas - calcular a médias dessas notas
            //Se media maior que 6, aprovado, se não reprovado

            string aluno1 = "Edilson";
            string aluno2 = "Nádia";

            double a1n1 = 8.0;
            double a1n2 = 9.5;
            double a2n1 = 8.9;
            double a2n2 = 7.5;

            double ma1 = (a1n1 + a1n2) / 2;
            double ma2 = (a2n1 + a2n2) / 2;

            if (ma1 > 6)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            if (ma2 > 6)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }



            Console.WriteLine($"Media Aluno {aluno1} - {ma1}");
            Console.WriteLine($"Media Aluno {aluno2} - {ma2}");


        }
    }
}