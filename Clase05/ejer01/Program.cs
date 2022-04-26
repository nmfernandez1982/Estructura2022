using System;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero=27;

            int[,] array2d_int=new int[5,3] { {10,2,15} , {10,27,1} , {81,27,11} ,{102,88,1} ,{40,11,14} };
            Console.Clear();
            for(int x=0;x<array2d_int.GetLength(0) ;x++)
            {
                for(int y=0;y<array2d_int.GetLength(1);y++)
                {
                    if(array2d_int[x,y]==numero)
                    {
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.Write("["+x+"]"+"["+y+"]="+array2d_int[x,y]+"\t");  
                        //Console.Write("[{0},{1}={2}]",x,y,array2d_int[x,y]+"\t");
                        Console.ForegroundColor=ConsoleColor.White;
                    }
                    else
                    {   
                        Console.Write("["+x+"]"+"["+y+"]="+array2d_int[x,y]+"\t");                      
                        //Console.Write("[{0},{1}={2}]",x,y,array2d_int[x,y]+"\t");                        
                    }


                }

            }



        }
    }
}
