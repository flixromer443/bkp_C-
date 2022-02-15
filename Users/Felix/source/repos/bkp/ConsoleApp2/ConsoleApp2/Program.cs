using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          TextWriter texto = new StreamWriter("prueba.txt");
            texto.WriteLine("hola");
            texto.Close();
            Console.ReadKey();
        }
    }
}
