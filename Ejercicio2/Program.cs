using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        List<ArmaduraCuero> invobjetos = new List<ArmaduraCuero>();

        static void Main(string[] args)
        {
            //lista de armaduras, armas, proyectiles
            ArmaduraCuero armaduraCuero = new ArmaduraCuero("Armadura hecha de cuero", 15, 98, 179);
            ArmaduraMetal armaduraMetal = new ArmaduraMetal("Armadura hecha de metal", 50, 100, 299);
            List<Invobjetos> invobjetos = new List<Invobjetos>();

            while (true)
            {

                Console.WriteLine("Bienvenido a la tienda de armas y armaduras, elija que va a comprar.");

                Console.WriteLine("1. Que va a comprar...");
                Console.WriteLine("2. Irse de la tienda.");


                string x = Console.ReadLine();

                if (x == "1")
                {

                    Console.WriteLine("¿Que va a comprar?");

                    Console.WriteLine("1. Armadura cuero");
                    Console.WriteLine("2. Armadura metal");
                    //Console.WriteLine("3. Armas");

                    //aqui arriba ponen la lista de tipos de armas, si quieren pueden expandirlo más la interfaz.

                    string elec;
                    elec = Console.ReadLine();

                    switch (elec)
                    {
                        case "1":
                            Console.WriteLine(armaduraCuero.GetData());
                            invobjetos.Add(armaduraCuero);
                            Console.WriteLine("Se añadio a tu inventario");
                            InventarioObjetos(invobjetos);
                            break;

                        case "2":
                            Console.WriteLine(armaduraMetal.GetData());
                            invobjetos.Add(armaduraMetal);
                            Console.WriteLine("Se añadio a tu inventario");
                            InventarioObjetos(invobjetos);
                            break;

                        //case "3":
                        //    Console.WriteLine(pistol.GetData());
                        //    invobjetos.Add(pistol);
                        //    Console.WriteLine("Se añadio a tu inventario");
                        //    InventarioObjetos(invobjetos);
                        // break;

                        //agregan mas armas


                        default:
                            Console.WriteLine("¿Podria repetir?");
                            break;
                    }
                }

                if (x == "2")
                {
                    //sale de la tienda
                    Environment.Exit(0);
                }
            }
        }

        static void InventarioObjetos(List<Invobjetos> invobjetos)
        {
            while (true)
            {
                Console.WriteLine("\nEste es su inventario");

                Console.WriteLine("1. Cerrar inventario y volver a la tienda");
                Console.WriteLine("2. Ver todos los objetos del inventario");
                Console.WriteLine("3. Eliminar un objeto del inventario");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        //volver a la tienda
                        return;

                    case "2":
                        //ver objetos de inventario listadas
                        for (int i = 0; i < invobjetos.Count; i++)
                        {

                            Console.WriteLine($"{i + 1}. {invobjetos[i].ObtenernmbrObjeto()}");

                        }
                        break;

                    case "3":
                        //eliminar objetos del inventario
                        if (invobjetos.Count > 0)
                        {
                            Console.WriteLine("¿Que objeto va a eliminar?");

                            for (int i = 0; i < invobjetos.Count; i++)
                            {

                                Console.WriteLine($"{i + 1}. {invobjetos[i].ObtenernmbrObjeto()}");

                            }
                            if (int.TryParse(Console.ReadLine(), out int choice))
                            {

                                invobjetos.RemoveAt(choice - 1);

                            }

                            Console.WriteLine("Se elimino el objeto de el inventario.");

                        }
                        else
                        {
                            Console.WriteLine("No hay objetos en el inventario");
                        }
                        break;

                }
            }
        }
    }
}