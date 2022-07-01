using System;
using System.Collections.Generic;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> lista=new List<string>();

            lista.Add("Nicolas");
            lista.Add("Julieta");
            lista.Add("Oscar");
            lista.Add("Paola");
            */
            List<string> lista=new List<string>()
            {
                "Nicolas",
                "Pedro",
                "ALberto",
                "Paola"
            };

            //lista.Clear();

            lista.RemoveAt(1);

            lista.Sort();

            lista.Reverse();

            foreach (string aux in lista)
            {
                Console.WriteLine("Valor:"+aux);
            }













           
        }
    }
}
