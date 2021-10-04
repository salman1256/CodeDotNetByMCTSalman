using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDessignPatternOne
{
    public class Client
    {
        public static void Main(string[] args)
        {
            
        }
        AbstractProductA proA;
        AbstractProductB proB;

        public Client(AbstractFactory factory)
        {
            proA = factory.CreateProductA();
            proB = factory.CreateProductB();
            
        }
    }
    public  abstract class AbstractFactory {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();

    }
    public class ConcreteFactoryA : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
           return  new ProductB1();
        }
    }
    public class ConcreteFactoryB : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
           return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
           return new ProductB2();
        }
    }
    public abstract class AbstractProductA { }
    public class ProductA1 : AbstractProductA
    { }
    public class ProductA2 : AbstractProductA
    { }
    public abstract class AbstractProductB{ }
    public class ProductB1 : AbstractProductB
    { }
    public class ProductB2 : AbstractProductB
    { }
}
