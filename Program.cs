﻿using System;
using System.Collections.Generic;

namespace Proyectofinal
{



    class Program
    {

        static void Main(string[] args)
        {
            /*
            int entrada;
            Console.WriteLine("1- Iniciar seción\n2-Salir");
            entrada = int.TryParse();
            */
            bool condicion = false;
            bool condicionAll = false;
            string UserName;
            int Contraseña;
            do
            {
                do
                {
                    Console.Clear();

                    //bool condicion;

                    Console.Write("User Name: ");
                    UserName = Console.ReadLine();
                    Console.Write("\nContreseña: ");
                    condicion = int.TryParse(Console.ReadLine(), out Contraseña);
                    if (condicion == false)
                    {
                        Console.WriteLine("Las contraseñas son numericas!, vuelve a intentarlo.");
                        Console.ReadKey();
                    }

                } while (condicion == false);


                User users1 = new User();
                User users2 = new User();
                User users3 = new User();
                List<User> listaUsers = new List<User>();
                users1.Nombre = "Miguel";
                users1.UserName = "033-2871667-2";
                users1.Password = 123456;
                users1.Cargo = "Supervisor";
                users1.FechaCreacion = "11/04/2018";
                users1.Estado = true;
                listaUsers.Add(users1);

                users2.Nombre = "Alejo";
                users2.UserName = "402-2860582-6";
                users2.Password = 123;
                users2.Cargo = "Administrador";
                users2.FechaCreacion = "25/06/2019";
                users2.Estado = true;
                listaUsers.Add(users2);

                users3.Nombre = "Gabriel";
                users3.UserName = "026-2978667-2";
                users3.Password = 1234;
                users3.Cargo = "Vendedor";
                users3.FechaCreacion = "04/08/2020";
                users3.Estado = false;
                listaUsers.Add(users3);


                for (int i = 0; i < 3; i++)
                {
                    string User = listaUsers[i].UserName;
                    int Password = listaUsers[i].Password;
                    string estado;
                    if (UserName == User && Contraseña == Password && listaUsers[i].Estado == true)
                    {
                        estado = "Activo";
                        Console.Clear();
                        Console.WriteLine("Bienvenido {0}!, Tu cargo es {1}", listaUsers[i].Nombre, listaUsers[i].Cargo);
                        Console.WriteLine("User: {0}.\nUserName: {1}. \nCargo: {2}.\nFecha de Creación: {3}.\nEstado: Activo.", listaUsers[i].Nombre, UserName, listaUsers[i].Cargo, listaUsers[i].FechaCreacion);
                        Console.ReadKey();
                        condicionAll = true;
                        break;
                    }
                    else if (UserName == User && Contraseña == Password && listaUsers[i].Estado == false)
                    {
                        Console.WriteLine("Lo sentimos, el Usuario {0} está inactivo.", UserName);
                        Console.WriteLine("Intenta con otro.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimoss, el usuario posiblemente no existe");
                        Console.ReadKey();
                        break;
                    }

                }
            } while (condicionAll == false);

        }

    }

    class User
    {
        public string Nombre;
        public string UserName;
        public int Password;
        public string Cargo;
        public string FechaCreacion;
        public bool Estado;

    }
}
    