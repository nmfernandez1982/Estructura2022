using System;

namespace ejer06
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] votos =new int[2,30];
            Random rnd=new Random();
            int Obama=0;
            int Trump=0;


           
            Console.Clear();

            for(int x=0;x<votos.GetLength(0);x++)
            {
                for(int y=0;y<votos.GetLength(1);y++)
                {
                    votos[x,y]=rnd.Next(0,2);
                    if(x==0)
                    {
                        Obama=Obama+votos[x,y];
                    }
                    if(x==1)
                    {
                        Trump=Trump+votos[x,y];
                    }
                }   
            }


             for(int x=0;x<votos.GetLength(0);x++)
            {
                for(int y=0;y<votos.GetLength(1);y++)
                {
                  Console.Write(votos[x,y]+" ");                    
                }   
                Console.WriteLine("");
            }

            Console.WriteLine("");



            if(Obama>Trump)
            {
                Console.WriteLine("El ganador es: "+nameof(Obama)+" Con:"+Obama+" Votos");
            }
            else
            {
                Console.WriteLine("El ganador es: "+nameof(Trump)+" Con:"+Trump+" Votos");
            }




        }
    }
}
