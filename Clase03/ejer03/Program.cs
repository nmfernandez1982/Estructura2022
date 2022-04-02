using System;

namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros={1,45,23,15,67,87,12,67,13,22,1,23,23,11};
                       //  0  1  2  3  4  5  6  7

             int[] enteros2= new int[500];

             string[] cadena={"Nicolas","Julieta","Pedro","Carlos"};
            /*
             foreach(var aux in numeros)
             {
                 Console.WriteLine("Valor de Enteros:"+aux);
             }
             */
             for(int x=0;x<numeros.Length;x++)
             {
                 Console.WriteLine("Valor de Enteros:"+numeros[x]);
             }

            



        }
    }
}
