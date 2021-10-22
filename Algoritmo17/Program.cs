using System;
using System.IO;

namespace Algoritmo17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese El Tamaño Del Vector Que Solicita");
            int Vector = Convert.ToInt32(Console.ReadLine());

            int[] Lista = new int[Vector];

            for (int i = 0; i < Lista.Length; i++)
            {
                Console.WriteLine("Ingrese Los Valores Que Quiera En El Vector : ");
                Lista[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp = 0;
            for (int i = 0; i < Lista.Length; i++)
            {
                for (int j = 0; j < Lista.Length; j++)
                {
                    if (Lista[i] < Lista[j])
                    {
                        temp = Lista[i];

                        Lista[i] = Lista[j];

                        Lista[j] = temp;
                    }
                }
            }
            for (int i = 0; i < Lista.Length; i++)
            {
                Console.Write("({0}), ", Lista[i]);
            }
            Console.Read();
        }
    }
}


