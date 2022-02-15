using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {   

            //Uso esto para crear archivo de texto.
            ///TextWriter texto = new StreamWriter("texto.txt");

           
            //Creo 2 variables independientes para los ingresos.
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            string apellido= Console.ReadLine();

           
            //Abro el archivo previamente creado para escribirlo
            StreamWriter texto = File.AppendText("texto.txt");
            texto.WriteLine(nombre + "," + apellido);
            texto.Close();



            //abro el archivo despues de haber sido escrito para poder mostrarlo
            //en pantalla

            StreamReader leer = new StreamReader("texto.txt");

            //Uso read to end para leer el archivo completo
            Console.WriteLine(leer.ReadToEnd());
            leer.Close();
           
            Console.ReadKey();
        }
    }
}
