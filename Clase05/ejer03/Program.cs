﻿using System;
using System.Collections.Generic;
using System.Linq;



namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> provincias =new List<string>();


            provincias.Add("Buenos Aires");
            provincias.Add("Santa Fe");
            provincias.Add("Salta");
            provincias.Add("Ciudad de Buenos Aires");
            provincias.Add("Santa Cruz");
            provincias.Add("La Pampa");


            Console.Clear();
            foreach(string x in provincias)
            {
               Console.WriteLine("Provincias : "+x);     
            }

            Console.WriteLine("-----------");
            IEnumerable<string> provinciasFiltradas=provincias.Where(a=>a.Contains("Sa"));
            foreach(string x in provinciasFiltradas)
            {
               Console.WriteLine("provinciasFiltradas : "+x);     
            }


        }
    }
}
