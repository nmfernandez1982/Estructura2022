using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Dictionary<string,string> usuarios=new Dictionary<string,string>();

            do{
              Console.Clear();
              opc=menu();

              switch (opc)
              {
                  case 1:
                        ingresar(ref usuarios);
                        break;
                  case 2:
                        //modificar();
                        break;
                  case 3:
                        imprimir(usuarios);
                        break;                  
              }


            }while(opc!=4);           
        }


            static int menu()
            {
                int opcion=0;
                Console.WriteLine("1-Ingresar");
                Console.WriteLine("2-MOdificar");
                Console.WriteLine("3-Ver");
                Console.Write("Ingrese Opcion: ");
                opcion=Int32.Parse(Console.ReadLine());
                return opcion;
            }

            static void imprimir(Dictionary<string,string> usuarios)
            {
                Console.Clear();

                foreach (KeyValuePair<string,string> aux in usuarios  )
                {
                    Console.WriteLine("EL usuario es: "+aux.Key+" Contraseña:  "+aux.Value);
                }
                Console.ReadKey();
            }

            static void ingresar(ref Dictionary<string,string> usuarios)
            {
             Console.Clear();
             string usuario;
             string pass;
             bool validaUsuario;
             bool validaPass;

             Console.Write("Ingrese nombre de Usuario: ");
             usuario=Console.ReadLine();

             Console.Write("Ingrese Contraseña: ");
             pass=Console.ReadLine();

             if(usuarios.ContainsKey(usuario))
             {
                 validaUsuario=false;
             }
             else
             {
                 validaUsuario=true;
             }
   
              //validar contraseña
              validaPass=validarContraseña(pass);

              if(validaUsuario==true&&validaPass==true)
              {
                  usuarios.Add(usuario,pass);
              }  
            else
            {
                Console.WriteLine("El usuario ya existe o la contraseña no cumple requisitos");
                Console.ReadKey();
            }





            }

            static bool validarContraseña (string pass)
            {
             string formato = "^([a-zA-Z0-9]{4,16})$";  
            //string formato = "^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$";  

             
             Regex r=new Regex(formato);

             if(r.IsMatch(pass))  
             {
                 return true;
             }   
             else
             {
                 return false;
             }
            }


            static void modificar(ref Dictionary<string,string> usuarios )
            {
                
            }




    }
}
