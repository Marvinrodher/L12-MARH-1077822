using System;

namespace NOTAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de notas: ");
            pruebaVector pv = new pruebaVector();
            pv.Cargar();
            pv.Imprimir();
        }

        class pruebaVector
        {
            private int[] sueldos;
            public int suma = 0;
            public void Cargar()
            {
                sueldos = new int[15];
                for (int f = 0; f < 15; f++)
                {
                    Console.WriteLine("Ingresa notas: ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[f] = int.Parse(linea);
                    suma = suma + sueldos[f];
                }
            }
            public void Imprimir()
            {
                for (int f = 0; f < 15; f++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Se ingreso ");
                    Console.WriteLine(sueldos[f]);
                }
                Console.WriteLine("La suma es : " + suma);
                Console.WriteLine("el promedio es: " + suma / 15);
                Console.ReadKey();
            }

        }
    }
}

