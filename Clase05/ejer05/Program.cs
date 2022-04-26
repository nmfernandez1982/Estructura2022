using System;
using System.Collections.Generic;


namespace ejer05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuarios> usuariosBaseDeDatos = new List<Usuarios>()
            {
                new Usuarios(){id=1,nombre="nicolas",apellido="Fernandez"},
                new Usuarios(){id=2,nombre="Juan",apellido="Lopez"},
                new Usuarios(){id=3,nombre="Pedro",apellido="Alvarez"},
            };

            foreach(Usuarios x in usuariosBaseDeDatos)
            {
                Console.WriteLine("id:{0} ,Nombre: {1}, Apellido: {2}",x.id,x.nombre,x.apellido);
            }
        }
    }
}
