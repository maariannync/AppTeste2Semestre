using System;

namespace ApptesteVerificarVoto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 16)
            {
                Console.WriteLine("Não pode votar.");
            }
            else if (idade >= 16 && idade < 18)
            {
                Console.WriteLine("Voto opcional.");
            }
            else
            {
                Console.WriteLine("Pode votar.");
            }
        }
    }
}

