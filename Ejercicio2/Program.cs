using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        List<ArmaduraCuero> tienda = new List<ArmaduraCuero>();

        static void Main(string[] args)
        {
            ArmasCuerpoaCuerpo espada = new ArmasCuerpoaCuerpo("Espada", 7, 2.5f, 50);
            Proyectiles flechas = new Proyectiles("Flecha", 2, 5);
            Proyectiles bala = new Proyectiles("Bala", 3, 5);
            ArmasDistancia arco = new ArmasDistancia("Arco", 1.5f, 1, 100, flechas);
            ArmasDistancia pistola = new ArmasDistancia("Pistola", 1.5f, 3, 150, bala);
            ArmaduraCuero armaduraCuero = new ArmaduraCuero("Armadura hecha de cuero", 15, 98, 179);
            ArmaduraMetal armaduraMetal = new ArmaduraMetal("Armadura hecha de metal", 50, 100, 299);
            List<Tienda> tienda = new List<Tienda>();

            while (true)
            {

                Console.WriteLine("Bienvenido a la tienda de armas y armaduras, elija que va a comprar.");

                Console.WriteLine("1. Que va a comprar...");
                Console.WriteLine("2. Irse de la tienda.");


                string x = Console.ReadLine();

                if (x == "1")
                {

                    Console.WriteLine("¿Que va a comprar?");
                    Console.WriteLine("1. Espada");
                    Console.WriteLine("2. Arco");
                    Console.WriteLine("3. Pistola");
                    Console.WriteLine("4. Armadura cuero");
                    Console.WriteLine("5. Armadura metal");

                    string elec;
                    elec = Console.ReadLine();

                    switch (elec)
                    {
                        case "1":
                            Console.WriteLine(espada.Data());
                            tienda.Add(espada);
                            Console.WriteLine("Se añadio a tu inventario");
                            InventarioObjetos(tienda);
                            break;

                        case "2":
                            Console.WriteLine(arco.Data());
                            tienda.Add(arco);
                            Console.WriteLine("Se añadio a tu inventario");
                            InventarioObjetos(tienda);
                            break;

                        case "3":
                            Console.WriteLine(pistola.Data());
                            tienda.Add(pistola);
                            Console.WriteLine("Se añadio a tu inventario");
                            InventarioObjetos(tienda);
                            break;

                        case "4":
                            Console.WriteLine(armaduraCuero.Data());
                            tienda.Add(armaduraCuero);
                            Console.WriteLine("Se añadio a tu inventario");
                            InventarioObjetos(tienda);
                            break;


                        case "5":
                            Console.WriteLine(armaduraMetal.Data());
                            tienda.Add(armaduraMetal);
                            Console.WriteLine("Se añadio a tu inventario");
                            InventarioObjetos(tienda);
                            break;

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


        static void InventarioObjetos(List<Tienda> tienda)
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
                        for (int i = 0; i < tienda.Count; i++)
                        {

                            Console.WriteLine($"{i + 1}. {tienda[i].ObtenernmbrObjeto()}");

                        }
                        break;

                    case "3":
                        //eliminar objetos del inventario
                        if (tienda.Count > 0)
                        {
                            Console.WriteLine("¿Que objeto va a eliminar?");

                            for (int i = 0; i < tienda.Count; i++)
                            {

                                Console.WriteLine($"{i + 1}. {tienda[i].ObtenernmbrObjeto()}");

                            }
                            if (int.TryParse(Console.ReadLine(), out int choice))
                            {

                                tienda.RemoveAt(choice - 1);

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