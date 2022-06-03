using System;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();            
            char [] operaciones={'C','D','D','D','C','D','D','D','C','C','C','D','C','C','C','D','C','C','C','D','C','D','C','D','D','D','D','D','C','D','C','D','D','D','C','D','C','D','C','D','C','D','C','D','D'};     
            double[] estados=new double[45];
            double[] montos=new double[45];
            Random rnd=new Random();


            Console.WriteLine("Listado de Operaciones");
            for(int x=0;x<45;x++)
            {
                if(operaciones[x]=='C')
                {
                    montos[x]=rnd.Next(0,10001);
                }
                else
                {
                    montos[x]=rnd.Next(0,20001);
                }
            estados[x]=rnd.Next(1,10001);
            Console.Write("{0} Estado de Cuenta: {1:c} - Operacion: {2} - Monto:{3:c}",x,estados[x],operaciones[x],montos[x]);
            Console.WriteLine();
            }

            Console.WriteLine("----------------------");

            for(int x=0;x<45;x++)
            {
                if(operaciones[x]=='C')
                {
                   estados[x]=estados[x]+montos[x];
                   Console.WriteLine("{0}-Estado Cuenta :{1:c}, Operacion: {2}, Monto: {3}",x,estados[x],operaciones[x],montos[x]);      
                }
                else
                {
                    if(estados[x]<montos[x])
                    {
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine("{0}-Estado Cuenta :{1:c}, Operacion: {2}, Monto: {3}",x,estados[x],operaciones[x],montos[x]);      
                        Console.ForegroundColor=ConsoleColor.White;
                    }
                    else
                    {
                        estados[x]=estados[x]-montos[x]; 
                        Console.WriteLine("{0}-Estado Cuenta :{1:c}, Operacion: {2}, Monto: {3}",x,estados[x],operaciones[x],montos[x]);      

                    }



                }



            }


        
        
        }
    }
}
