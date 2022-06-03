using System;
using System.Text.RegularExpressions;


namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //formato url 
           //string formato =  @"\A[w]{3}(\.)[a-z0-9]+(\.)(com|edu|gob|mil)\Z";
           //string formato =  @"\A[w]{3}(\.)[a-z0-9]+(\.)(com|edu|gob|mil)+(\.)(ar|cl|uy|br|ie)\Z";
           //string formato =  @"\A(\w+\.?\w*\@\w+\.)(com|edu)\Z";
           //string formato =  "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9]).{6,50}$";
           string formato =  "^(?=.*[A-Z])(?=.*[a-z])(?=.*[?_*])(?=.*[0-9]).{6,50}$";
 

           string palabra="Qweasd12_";


           Regex r=new Regex(formato);

           if(r.IsMatch(palabra))
           {
               Console.WriteLine("Aprobado");
           }
           else
           {
               Console.WriteLine("No Aprobado");
           }


        }
    }
}
