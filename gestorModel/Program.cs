﻿using DataModels;

namespace gestorModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo para acceder a la base de datos
            using (var db = new BDGestorCapasDB())
            {
                var q =
                    from c in db.Usuarios
                    select c;

                foreach (var c in q)
                    Console.WriteLine(c.Username);
            }
        }
    }


}
