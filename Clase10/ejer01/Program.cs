using System;
using System.Collections.Generic;


namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> AbrirCon=new Dictionary<string,string>();            

            AbrirCon.Add("txt","notepad.exe");
            AbrirCon.Add("bmp","paint.exe");
            AbrirCon.Add("cvs","excel.exe");
            AbrirCon.Add("doc","word.exe");

            //imprimir diccionario
            Console.Clear();
            Console.WriteLine("");

            foreach (KeyValuePair<string,string> aux in AbrirCon)
            {
                Console.WriteLine("Key = {0}, Value= {1}",aux.Key,aux.Value);                
            }

            try
            {
              AbrirCon.Add("doc","word.exe");    
            }
            catch (ArgumentException)
            {
               Console.WriteLine("El elemento ya se encuentra en la lista");              
            }

            //el id se puede cambiar
            AbrirCon["cvs"]="Illustrator.exe";

            //SI no existe en la lista, se agrega nuevo elemento.
            AbrirCon["jpg"]="Photoshop.exe";


            //Buscar dentro de un diccionario
            if(!AbrirCon.ContainsKey("bat"))
            {
                AbrirCon.Add("bat","notepad.exe");         

            }

            




            

         



        }
    }
}
