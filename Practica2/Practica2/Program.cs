using Practica2.Patrón_Composite;
using Practica2.Patrón_Prototype;
using Practica2.Patrón_Singleton;
using System;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int select = 0;
            Console.WriteLine("Escoja una de las siguientes opciones: ");
            Console.WriteLine("1- Singleton. 2- Prototype. 3- Composite");
            Console.WriteLine("4- Facade. 5- Chain of responsability. 6- Command");
            Console.WriteLine("7- Observer. 8- Template Method.");
            int.TryParse(Console.ReadLine(), out select);
            switch (select)
            {
                case 1:
                    Console.WriteLine("Patrón Singleton: ");
                    Singleton singleton = Singleton.Instancia;
                    singleton.DoSomething();
                    break;
                case 2:
                    Console.WriteLine("Patrón Prototype");
                    Carro bwm_base = new BMW("BMW Serie 4 Coupe") { Precio = 300000 };
                    Carro ford_base = new Ford("Ford Lobo") { Precio = 100000};
                    Carro carro1;
                    //BMW
                    carro1 = bwm_base.Clone();
                    carro1.Precio = bwm_base.Precio + Carro.SetPrecio();
                    Console.WriteLine($"El carro es: {carro1.Modelo}, y su precio es: ${carro1.Precio} MXN");
                    //Ford
                    carro1 = ford_base.Clone();
                    carro1.Precio = ford_base.Precio + Carro.SetPrecio();
                    Console.WriteLine($"El carro es: {carro1.Modelo}, y su precio es: ${carro1.Precio} MXN");
                    break;
                case 3:
                    Console.WriteLine("Patrón Composite");
                    // Crear estructura de árbol
                    Composite root = new Composite("root");
                    root.Add(new Leaf("Hoja A"));
                    root.Add(new Leaf("Hoja B"));
                    Composite comp = new Composite("Composite X");
                    comp.Add(new Leaf("Hoja XA"));
                    comp.Add(new Leaf("Hoja XB"));
                    root.Add(comp);
                    root.Add(new Leaf("Hoja C"));
                    // Añadir hoja
                    Leaf leaf = new Leaf("Hoja D");
                    root.Add(leaf);
                    // Árbol de visualización recursiva
                    root.Display(1);
                    //Remover hoja
                    root.Remove(leaf);
                    
                    root.Display(1);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("No ha escogido una opcion válida.");
                    break;
            }
        }
    }
}
