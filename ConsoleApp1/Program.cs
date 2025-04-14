using Adapter1;
using Bridge1;
using Composite1;
using Decorator1;
using Facade1;
using Proxy1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Adapter.");
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());





            Console.WriteLine("Bridge.");
        ClientBridge client = new ClientBridge();

            Abstraction abstraction;
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);





            Console.WriteLine("Composite:");
        ClientComposite ClientComposite = new ClientComposite();

            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
        ClientComposite.ClientCode(leaf);

            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
        ClientComposite.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
        ClientComposite.ClientCode2(tree, leaf);






            Console.WriteLine("Decorator:");
        ClientDecorator ClientDecorator = new ClientDecorator();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
        ClientDecorator.ClientCode(simple);
            Console.WriteLine();
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
        ClientDecorator.ClientCode(decorator2);






            Console.WriteLine("Fasade:");

            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
        ClientFacade.ClientCode(facade);




            Console.WriteLine("Proxy:");
        ClientProxy ClientProxy = new ClientProxy();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
        ClientProxy.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
        ClientProxy.ClientCode(proxy);

        }
    }    

    
