using System;

namespace ejer06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arra2d=new int[4,2] {{1,2},{3,4},{5,6},{7,8}};

            //{1,2}
            //{3,4}
            //{5,6}
            //{7,8}
            for(int x=0;x<arra2d.GetLength(0);x++)
            {
                for(int y=0;y<arra2d.GetLength(1);y++)
                {
                    Console.Write(arra2d[x,y]+"\t");
                }   
                Console.WriteLine("");
            }





        }
    }
}
