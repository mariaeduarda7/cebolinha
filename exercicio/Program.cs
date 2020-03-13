//Solicite que o usuário digite uma frase. Exiba a frase como se ela fosse dita pelo Cebolinha, da Turma da Mônica.

using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite uma frase");
            string  Cebolinha = Console.ReadLine().Replace("r", "l");
            Console.WriteLine(Cebolinha);
        }
    }
}
