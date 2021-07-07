using System;

namespace Tarea05_15
{
    class Program
    {

        static Random alea = new Random();
        static public int generaNumero(int n1, int n2)
        {
            int resultado = alea.Next(n1, n2);
            return resultado;
        }


        static void Main(string[] args)
        {

            int dimension = 0;
            Console.Write("Dimensión del array: ");
            dimension = Convert.ToInt32(Console.ReadLine());

            int[] lista = new int[dimension];
            int[] listaInvertida = new int[dimension];

            for (int i = 0; i < lista.Length; i++)  //genera lista principal
            {
                lista[i] = generaNumero(1, 10);
                
            }

            Console.WriteLine("Lista generada: ");
            for (int i = 0; i < lista.Length; i++)     // Muestra lista principal
            {
                Console.Write(" {0} ", lista[i] );
            }

            for (int i = 0; i < lista.Length; i++)         // invierte lista
            {
                listaInvertida[i] = lista[(lista.Length - 1)-i];

            }
            Console.WriteLine("");
            Console.WriteLine("Lista Invertida: ");
            for (int i = 0; i < lista.Length; i++)              // muestra lista invertida.
            {
                Console.Write(" {0} ", listaInvertida[i]);
            }


            Console.ReadKey();

        }
    }
}
