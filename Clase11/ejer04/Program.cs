using System;
using System.Collections.Generic;

namespace ejer04
{
    class Program
    {
        static void Main(string[] args)
        {
         List<string> productos=new List<string>{"TV","Heladera","Lavarropa","Cocina"};
         List<double> precios=new List<double>{44000,80800.99,59430.50,48210.20};
         List<int> cantidades=new List<int>{4,5,8,3};
         int opcion; 
         do{
             Console.Clear();
             opcion=Menu();

            switch (opcion)
            {
                case 1:
                        //ingresar();
                        break;
                case 2:
                        ver(productos,precios,cantidades);
                        break;
                case 3:
                        //incrementar();
                        break;
                case 4:
                        //Venta();
                        break;                
                default:
                        //Venta();
                        break;  
            }
         }while(opcion!=5);

            
        static int Menu()
        {
            int opcion;            
            Console.WriteLine("1-Agregar.");
            Console.WriteLine("2-ver productos.");
            Console.WriteLine("3-incrementar stock.");
            Console.WriteLine("4-realizar venta.");
            Console.WriteLine("5-Salir.");
        
          try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch
            {                    
                opcion = 0;
                Console.WriteLine("¡Opcion no valida!");
                Console.ReadKey();
            }
            return opcion;
        }


        static void ver(List<string> productos,List<double> precios,List<int> cantidades)
        {
            Console.Clear();
            for(int x=0;x<precios.Count;x++)
            {
                Console.WriteLine("Producto: {0}    Cant: {1}      Precio: {2:c2}",productos[x],cantidades[x],precios[x]);
            }
            Console.ReadLine();
        }







        }
    }
}
