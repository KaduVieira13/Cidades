using System;

namespace Cidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cidades do Litoral Sul");
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine("Peruibe, \"no rio dos tubarões\"");
             Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Itanhaém, \"Pedra que canta\"");
             Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Mongaguá, \"Agua pegajosa\"");
            Console.ResetColor();
        }
    }
}
