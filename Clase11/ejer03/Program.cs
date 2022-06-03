using System;
using System.Collections.Generic;
using System.IO;


namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
         var reader=new StreamReader(File.OpenRead(@"C:\Valen\users.csv"));

         List<string> usuarios=new List<string>(); 
         List<string> pass=new List<string>();
         List<string> tusuarios=new List<string>();

         Console.Clear();

         while(!reader.EndOfStream)
         {
             var line = reader.ReadLine();
             var valores = line.Split(';');

            usuarios.Add(valores[0]);
            pass.Add(valores[1]);
            tusuarios.Add(valores[2]);
         }  

         for(int x=0;x<usuarios.Count;x++)
         {
            Console.WriteLine(usuarios[x]+"-"+pass[x]+"-"+tusuarios[x]); 
         }



        }
    }
}
