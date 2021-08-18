using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo(a) Valkiria, digite a primeira nota:");
            double nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            double nota2 = Convert.ToInt32(Console.ReadLine());
            double soma = nota1 + nota2;
            Console.WriteLine("a soma total é " + soma);
            Console.ReadLine();
        }
    }
}
