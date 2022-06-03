using System;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sexo=new int[45];
            double[] sueldo=new double[45];
            Random rnd=new Random();
            int cantM=0;
            int cantV=0;
            int cantSueldo=0;
            double promedioV=0;
            double promedioM=0;
            

            for(int x=0;x<45;x++)
            {
                sexo[x]=rnd.Next(1,3);
                sueldo[x]=rnd.Next(10000,200000);
                if(sexo[x]==1){promedioM=promedioM+sueldo[x];cantM++;}
                if(sexo[x]==2){promedioV=promedioV+sueldo[x];cantV++;}
                if(sueldo[x]>100000){cantSueldo++;}
                Console.WriteLine("Legajo {0}, Sexo:{1}, Sueldo:{2:c}",x,sexo[x],sueldo[x]);
            }

            Console.WriteLine("Cantidad de Empleadas Mujeres: {0}, Sueldo Promedio: {1:c}",cantM,(promedioM/cantM));
            Console.WriteLine("Cantidad de Empleados Varones: {0}, Sueldo Promedio: {1:c}",cantV,(promedioV/cantV));
            Console.WriteLine("Empleados con SUeldos mayores a $100.000 :"+cantSueldo);

        }
    }
}
