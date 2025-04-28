using System;
using DesignPatterns.Bridge;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.Flyweight;
using DesignPatterns.ProxyExample;


namespace DesignPatterns

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("////////// Adapter //////////");
            Adaptee adaptee = new Adaptee();
            ITarget target = new global::DesignPatterns.Adapter(adaptee);

            Console.WriteLine("Client works with Target interface:");
            Console.WriteLine(target.GetRequest());
            Console.WriteLine();


            Console.WriteLine("////////// Bridge //////////");

            Client client = new Client();

            Abstraction abstraction;

            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
            Console.WriteLine();




            Console.WriteLine("////////// Composite //////////");
            Clients clients = new Clients();

                // Простий компонент
                Leaf leaf = new Leaf();
                Console.WriteLine("Client: I get a simple component:");
                clients.ClientCode(leaf);

            // Композитне дерево
            Composite.Composite tree = new Composite.Composite();
            Composite.Composite branch1 = new Composite.Composite();
                branch1.Add(new Leaf());
                branch1.Add(new Leaf());
            Composite.Composite branch2 = new Composite.Composite();
                branch2.Add(new Leaf());
                tree.Add(branch1);
                tree.Add(branch2);

                Console.WriteLine("Client: Now I've got a composite tree:");
                clients.ClientCode(tree);

                Console.WriteLine("Client: I don't need to check the components classes even when managing the tree:");
                clients.ClientCode2(tree, leaf);
            Console.WriteLine();



            Console.WriteLine("////////// Decorator //////////");
            Clientt clientt = new Clientt();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            clientt.ClientCode(simple);
            Console.WriteLine();

            // Декорований компонент
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            clientt.ClientCode(decorator2);
            Console.WriteLine();



            Console.WriteLine("////////// Facade //////////");
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facades facades = new Facades(subsystem1, subsystem2);
            Cllient.ClientCode(facades);
            Console.WriteLine();





            Console.WriteLine("////////// Flyweight //////////");
            var factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                new Car { Company = "BMW", Model = "M5", Color = "red" },
                new Car { Company = "BMW", Model = "X6", Color = "white" }
            );

            factory.ListFlyweights();

            Cliient.AddCarToPoliceDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "M5",
                Color = "red"
            });

            Cliient.AddCarToPoliceDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "X1",
                Color = "red"
            });

            factory.ListFlyweights();
            Console.WriteLine();



            Console.WriteLine("////////// Proxy //////////");
            // Create client instance
            Clieent clieent = new Clieent();

            // Using the real subject
            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            clieent.ClientCode(realSubject);

            Console.WriteLine();

            // Using the proxy
            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            clieent.ClientCode(proxy);
            Console.WriteLine();
        }
    }
} 
