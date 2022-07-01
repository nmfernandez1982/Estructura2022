using System;
using System.Collections;


namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0;
            Stack MiPila=new Stack();

            /*    
            Queue numeros=new Queue();
            numeros.Enqueue(1);
            numeros.Enqueue(6);
            numeros.Enqueue(7);
            numeros.Enqueue(8);

            numeros.Dequeue();
            numeros.Dequeue();
            numeros.Dequeue();
            numeros.Dequeue();
            */

            do{
                Console.Clear();                
                opcion=menu();
                  switch(opcion)
                  {
                      case 1:
                            agregar(ref MiPila);                            
                            break;
                      case 2:
                            eliminar(ref MiPila);                            
                            break;
                      case 3:
                            vaciar(ref MiPila);
                            break;                     
                      case 4:
                            imprimir(MiPila);
                            break;
                      case 5:
                            mensaje("Gracias por utilizar la aplicacion...");
                            break;
                      default:
                            mensaje("El dato no es valido");
                             break;
                  }  
            }while(opcion!=5);





        }


        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1-Agregar");
            Console.WriteLine("2-Eliminar");
            Console.WriteLine("3-Vaciar");
            Console.WriteLine("4-Imprimir");
            Console.WriteLine("5-Salir");
            Console.Write("Ingrese un valor: ");
            try
            {
            int valor=Convert.ToInt32(Console.ReadLine());
            return valor;
            }
            catch
            {
            return 0;
            }        
        }

        static void mensaje(string texto)
        {
            Console.WriteLine(texto);
            Console.ReadKey();
        }


        static void agregar(ref Stack pila)
        {
           
         Console.Write("Ingrese un valor: ");


        try
        {
            int valor=0;
            valor=Convert.ToInt32(Console.ReadLine());

            if(valor>50 || valor<=0)
            {
            mensaje("EL valor no cumple con los requisitos");   
            }
            else
            {
            pila.Push(valor);
            Console.WriteLine("Se agrego un Elemento");
            Console.ReadKey();   
            }
            
        }
        catch
        {
            mensaje("El valor no es valido");
        }

         

        }

        static void imprimir(Stack pila)
        {
            foreach(var x in pila)
            {
              Console.WriteLine(x);
            }

        Console.ReadKey();
        }

        static void eliminar(ref Stack pila)
        {
            if(pila.Count>0)
            {
            int valor=(int)pila.Pop();
            Console.WriteLine("Se Elimino un Elemento: "+valor);
            Console.ReadKey();  
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                Console.ReadKey();
            }



            
        }

        static void vaciar(ref Stack pila)
        {
         pila.Clear();   
         Console.WriteLine("Se vacio la pila");
         Console.ReadKey();
        }




    }
}
