using System;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
           int opcion=0;

           do{
              Console.Clear();
              Console.Write("Ingrese Opcion: ");
              opcion=int.Parse(Console.ReadLine()); 
                if(opcion<1|opcion>4)
                {
                    Console.WriteLine("Opcion Incorrecta....");
                    Console.ReadKey();
                }
           }while(opcion<1|opcion>4);

        switch(opcion)
        {
            case 1:
            Console.WriteLine("Valor 1");
            break;

            case 2:
            Console.WriteLine("Valor 2");
            break;

            case 3:
            Console.WriteLine("Valor 3");
            break;

            case 4:
            Console.WriteLine("Valor 4");
            break; 


        }
      

        



        }
    }
}
