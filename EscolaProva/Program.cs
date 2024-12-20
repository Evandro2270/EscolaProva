using EscolaProva;
using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                Aluno aluno = new Aluno();

                Console.Write("Nome do Aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite tres notas ");
                aluno.Nota1 = double.Parse(Console.ReadLine(), CI);
                aluno.Nota2 = double.Parse(Console.ReadLine(), CI);
                aluno.Nota3 = double.Parse(Console.ReadLine(), CI);

                Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CI));

                if (aluno.Aprovado())
                {
                    Console.WriteLine("APROVADO");
                }
                else
                {
                    Console.WriteLine("REPROVADO");
                    Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CI) + " PONTOS");
                }
            }
        }
    }
}