using System;
using System.Collections.Generic;




namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<string> ListaDeNombres=new List<string>()
            {
             "Cecilia",
             "Juan",
             "ALberto",
             "Camila"   
            } ;
             //agregar Elementos.
             ListaDeNombres.Add("German");
             ListaDeNombres.Add("Nicolas");

            //agregar Elementos en rango
             ListaDeNombres.AddRange(new string[]
             {
             "Silvana",
             "Patricia",
             "Juana"
             }
             );   

              //borrar la lista
             //ListaDeNombres.Clear();
             //Eliminar un elemento de la lista.
             //ListaDeNombres.RemoveAt(1);
            
              //Ordenar la lista
             ListaDeNombres.Sort();             
             //revertir la lista.   
             ListaDeNombres.Reverse();
             
             foreach(var x in ListaDeNombres)
             {
                 Console.WriteLine("Nombre: "+x);
             }  










            
        }
    }
}
