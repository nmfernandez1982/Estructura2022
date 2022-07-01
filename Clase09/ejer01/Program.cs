using System;
using System.Collections.Generic;



namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
          List<int> Paises=new List<int>()
          {
              34,
              2,
              6,
              107,
              55,
              44
          };

            int aux=1;
          for(int x=0;x<Paises.Count;x++)
          {
            aux=Paises[x];
          }

          Console.WriteLine(aux);

            /*
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

            
            */
            







        }
    }
}
