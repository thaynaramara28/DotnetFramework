using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFrameworkMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=4; i++)
            {
                Console.WriteLine("Digite o nome do " + i + " º aluno: ");
                string aluno1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite a primeira nota");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota");
                double nota3 = Convert.ToDouble(Console.ReadLine());
                double soma = nota1 + nota2 + nota3;
                Console.WriteLine("A média da nota de: " + aluno1 + " é: " + (soma / 3));
                Console.ReadLine();
            }
        }
    }
}
