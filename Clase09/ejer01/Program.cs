using System;
using System.Collections.Generic;



namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
          List<string> Paises=new List<string>()
          {
              "Argentina",
              "Chile",
              "Uruguay",
              "Paraguay",
              "Brasil",
              "Bolivia"
          };

            //metodos 
            Paises.Add("Colombia");   

            Console.WriteLine("Pos. Colombia: "+Paises.IndexOf("Colombia"));


            string aux="Venezuela";
            Paises.Add(aux);


            Paises.Add(Console.ReadLine());

            Paises.Remove("Paraguay");

            foreach(string x in Paises)
            {
                Console.WriteLine("Pais :"+x);
            }

            Paises.Sort();
             Console.WriteLine("-----------------");
            foreach(string x in Paises)
            {
                Console.WriteLine("Pais :"+x);
            }

            Paises.Reverse();

            Paises.Clear(); // vacia la lista.
            
            Paises.Contains("");

             Console.WriteLine("-----------------");
            Paises.IndexOf("Colombia");

            
            
            







        }
    }
}
