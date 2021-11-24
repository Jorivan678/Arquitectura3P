using Practica2.Patrón_Chain_of_responsability;
using Practica2.Patrón_Command;
using Practica2.Patrón_Composite;
using Practica2.Patrón_Façade;
using Practica2.Patrón_Prototype;
using Practica2.Patrón_Singleton;
using System;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool i = true;
            do
            {
                Console.WriteLine("Escoja una de las siguientes opciones: ");
                Console.WriteLine("1- Singleton. 2- Prototype. 3- Composite");
                Console.WriteLine("4- Façade. 5- Chain of responsability. 6- Command");
                Console.WriteLine("7- Observer. 8- Template Method.");
                int.TryParse(Console.ReadLine(), out int select);
                Console.Clear();
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
                        Carro ford_base = new Ford("Ford Lobo") { Precio = 100000 };
                        Carro carro1;
                        //BMW
                        carro1 = bwm_base.Clone();
                        carro1.Precio = bwm_base.Precio + Carro.SetPrecio();
                        Console.WriteLine($"El carro es: {carro1.Modelo}, y su precio es: ${carro1.Precio} MXN\n");
                        //Ford
                        carro1 = ford_base.Clone();
                        carro1.Precio = ford_base.Precio + Carro.SetPrecio();
                        Console.WriteLine($"El carro es: {carro1.Modelo}, y su precio es: ${carro1.Precio} MXN\n");
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
                        break;
                    case 4:
                        Console.WriteLine("Patrón Façade");
                        string cliente;
                        int monto;
                        Hipoteca hipoteca = new Hipoteca();

                        //Evalua la elegibilidad para el cliente
                        Console.WriteLine("Ingrese su nombre por favor: ");
                        cliente = Console.ReadLine();
                        Console.WriteLine("Ingrese el monto que desea pedir prestado: ");
                        int.TryParse(Console.ReadLine(), out monto);

                        Cliente cliente1 = new Cliente(cliente);
                        bool elegible = hipoteca.EsElegible(cliente1, monto);

                        Console.WriteLine("\n" + cliente1.Nombre + " ha sido " + (elegible ? "Aprovado/a" : "Rechazado/a"));
                        break;
                    case 5:
                        Console.WriteLine("Patrón Chain of responsability");

                        Handler h1 = new ConcreteHandler1();
                        Handler h2 = new ConcreteHandler2();
                        h1.SetSuccessor(h2);

                        //Generar y procesar solicitud

                        int[] requests = { 2, 5, 14, 16, 3, 10 };

                        foreach(int request in requests)
                        {
                            h1.HandleRequest(request);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Patrón command");

                        //Crea receiver, command e invoker

                        Receiver receiver = new Receiver();
                        Command command = new ConcreteCommand(receiver);
                        Invoker invoker = new Invoker();

                        //Establecer y ejecutar Command

                        invoker.SetCommand(command);
                        invoker.ExecuteCommand();
                        break;
                    default:
                        Console.WriteLine("No ha escogido una opcion válida.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("¿Desea elegir nuevamente?");
                Console.WriteLine("Introduzca cualquier tecla para 'Si' y 2 para 'No'");
                int.TryParse(Console.ReadLine(), out int repeat);
                if(repeat == 2)
                {
                    i = false;
                }
                Console.Clear();

            } while (i == true);
        }
    }
}
