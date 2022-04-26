using System;
using System.Collections.Generic;
using System.Linq;

namespace ejer04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros=new List<int>()
            {
                22,356,11,2,78,68,1,2,357,5678
            };

            int minimo=numeros.Min();
            int maximo=numeros.Max();
            Console.WriteLine("Minimo:"+minimo);
            Console.WriteLine("Maximo:"+maximo);





        }
    }
}
