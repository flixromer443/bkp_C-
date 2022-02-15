using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double[] vector1 = new double[5];
            Double[] vector2 = new double[5];
            Console.WriteLine("Ingrese los datos del vector : ");
            for(int i=0; i < vector1.Length; i++)
            {
              vector1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i < vector1.Length; i++)
            {
                Console.WriteLine("vector : " + vector1[i]);
            }
            vector1 = ordenar(vector1);
            Console.WriteLine("Vector invertido : ");
            for(int j=0;j<vector1.Length;j++)
            {
                Console.WriteLine(vector1[j]);
            }
            Console.ReadKey();
            


        }

        private static double[] ordenar(double[] vec)
        {
            double[] vector = new double[5];
            for(int i=0, x=vec.Length-1;i<vec.Length;i++,x--)
            {
                vector[x] = vec[i];
            }
            return vector;
        }
    }
}
