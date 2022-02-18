using System;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderBySortReverse();
            OrderByComparison();
            OrderByLinq();
        }

        private static void OrderBySortReverse()
        {
            Console.WriteLine("Ordenamiento por Sort y Reverse");
            int[] arregloNumeros = new int[] { 1, 4, 2, 7, 55, 9, 7, 10 };
            string[] arregloPalabras = new string[] { "gerson", "eder", "azabache", "martínez" };

            Array.Sort(arregloNumeros);
            Array.Reverse(arregloNumeros);

            Array.Sort(arregloPalabras);

            Console.WriteLine(string.Join(", ", arregloNumeros));
            Console.WriteLine(string.Join(", ", arregloPalabras));
        }

        private static void OrderByComparison()
        {
            Console.WriteLine("Ordenamiento por Comparison");
            int[] arregloNumeros = new int[] { 1, 4, 2, 7, 55, 9, 7, 10, 99, 3 };
            string[] arregloPalabras = new string[] { "gerson", "eder", "azabache", "martínez" };

            //Array.Sort<int>(arregloNumeros, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));
            //Array.Sort<string>(arregloPalabras, new Comparison<string>((i1, i2) => i1.CompareTo(i2)));

            //De este modo alternativo el ordenamiento sería descendente
            Array.Sort<int>(arregloNumeros, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
            Array.Sort<string>(arregloPalabras, new Comparison<string>((i1, i2) => i2.CompareTo(i1)));

            Console.WriteLine(string.Join(", ", arregloNumeros));
            Console.WriteLine(string.Join(", ", arregloPalabras));
        }

        private static void OrderByLinq()
        {
            Console.WriteLine("Ordenamiento por Linq");
            int[] arregloNumeros = new int[] { 1, 4, 2, 7, 55, 9, 7, 10, 99, 3 };
            string[] arregloPalabras = new string[] { "gerson", "eder", "azabache", "martínez" };

            arregloNumeros = arregloNumeros.OrderBy(x => x).ToArray();
            arregloPalabras = arregloPalabras.OrderBy(x => x).ToArray();

            //Ordenamientos descendientes
            //arregloNumeros = arregloNumeros.OrderByDescending(x => x).ToArray();
            //arregloPalabras = arregloPalabras.OrderByDescending(x => x).ToArray();

            Console.WriteLine(string.Join(", ", arregloNumeros));
            Console.WriteLine(string.Join(", ", arregloPalabras));
        }
    }
}
