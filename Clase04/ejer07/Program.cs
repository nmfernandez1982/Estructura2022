using System;

namespace ejer07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arra2d=new string[3,2] {{"uno","dos"},
                                              {"tres","cuatro"},
                                              {"cinco","seis"}};

            for(int x=0;x<arra2d.GetLength(0);x++)
            {
                for(int y=0;y<arra2d.GetLength(1);y++)
                {
                    Console.Write(arra2d[x,y]+" ");
                }   
                Console.WriteLine(" ");
            }


            
            foreach(String dato in arra2d)
            {
                Console.WriteLine(dato);
            }















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
