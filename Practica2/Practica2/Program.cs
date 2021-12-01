using Practica2.Adapter;
using Practica2.Bridge;
using Practica2.Factory;
using Practica2.Interpreter;
using Practica2.PatronIterator;
using Practica2.Proxy;
using Practica2.VISITOR;
using System;
using System.Collections.Generic;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu =  true;
            do
            {
                Console.WriteLine("Escoja un numero: ");
                Console.WriteLine("1- Abstract Factory.  2-Factory Method");
                Console.WriteLine("3- Adapter  4-Bridge  5-Proxy");
                Console.WriteLine("6- Interpreter   7- literator  8- Visitor");
                int.TryParse(Console.ReadLine(), out int select);
                Console.Clear();
                switch (select)
                {
                    case 1:
                        Console.WriteLine("Patron Abstract: "); 
                        Console.WriteLine("Ingrese su modelo: ");
                        string marca = Console.ReadLine();
                        Avión avion = new Avión();
                        var avioneta = avion.SetMarca(marca).Crea();
                        Console.WriteLine("El modelo de su avion es: {0} " , avioneta.Marca);
                        break;

                    case 2:
                        Console.WriteLine("Patron Factory Method es: ");
                        Creador[] creadores = new Creador[2];
                        creadores[0] = new CreadorConcretoA();
                        creadores[1] = new CreadorConcretoB();

                        foreach(Creador crea in creadores)
                        {
                            Producto producto = crea.FactoryMethod();
                            Console.WriteLine("Creado {0}", producto.GetType().Name);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Patron Adapter ");

                        //Crear adaptador y realizar una solicitud
                        Destino destino = new Adaptador();
                        destino.Request();
                        break;

                    case 4:
                        Console.WriteLine("Patron Bridge");
                        Abstract ab = new Refinado();
                        ///Establecer implementación y llamada
                        ab.Implementador = new Concret_A();
                        ab.Operador();

                        ab.Implementador = new Concret_B();
                        ab.Operador();
                        break;

                    case 5:
                        Console.WriteLine("Patron Proxy");
                        // Create proxy and request a service
                        prox proxy = new prox();
                        proxy.Request();
                        break;

                    case 6:
                        Console.WriteLine("Patron Interpreter ");
                        Context context = new Context();
                        List<AbstraExpression> list = new List<AbstraExpression>();
                        list.Add(new Terminal());
                        list.Add(new NoTerminal());
                        list.Add(new Terminal());
                        list.Add(new Terminal());

                        //Interpret
                        foreach (AbstraExpression exp in list)
                        {
                            exp.Interpret(context);
                        }
                        break;

                    case 7:
                        Console.WriteLine("Patron Iterater ");
                        ConcreteAggregate a = new ConcreteAggregate();
                        a[0] = "Item A";
                        a[1] = "Item B";
                        a[2] = "Item C";
                        a[3] = "Item D";
                        // Create Iterator and provide aggregate
                        Iterator i = a.CreateIterator();
                        Console.WriteLine("Iterating over collection:");
                        object item = i.First();
                        while (item != null)
                        {
                            Console.WriteLine(item);
                            item = i.Next();
                        }

                        break;

                    case 8:
                        Console.WriteLine(" Patron Visitor");
                        // Setup structure
                        ObjectStructure o = new ObjectStructure();
                        o.Attach(new ConcreteElementA());
                        o.Attach(new ConcreteElementB());
                        // Create visitor objects
                        ConcreteVisitor1 v1 = new ConcreteVisitor1();
                        ConcreteVisitor2 v2 = new ConcreteVisitor2();
                        // Structure accepting visitors
                        o.Accept(v1);
                        o.Accept(v2);
                        break;

                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("¿Escoja otro nuevamnete? ");
                Console.WriteLine("Introduzca cualquier tecla para 'Si' y 2 para 'No'");
                int.TryParse(Console.ReadLine(), out int repeat);
                if(repeat == 2)
                {
                    menu = false;
                }
                Console.Clear();







            } while (menu == true);
        }
    }
}
