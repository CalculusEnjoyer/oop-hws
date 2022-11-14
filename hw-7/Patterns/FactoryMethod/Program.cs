using System;
namespace FactoryMethodExample
{
    //абстрактний клас творця, який має абстрактний метод CreateDevice, що приймає тип продукта
    public abstract class DeviceCreator
    {
        public abstract Product CreateDevice(int type);
    }

    public class ConcreteCreator : DeviceCreator
    {
        public override Product CreateDevice(int type)
        {
            switch (type)
            {
                //повертає об'єкт A, якщо type==1
                case 1: return new Smartphone();
                //повертає об'єкт B, якщо type==2  
                case 2: return new Monitor();
                default: throw new ArgumentException("Invalid type.", "type");
            }
        }
    }

    public abstract class Product {
        protected string name;
        public string Name { get => name; set => name = value; }
    } //абстрактний клас продукт

    //конкретні продукти з різною реалізацією
    public class Smartphone : Product {
        private int _megapixels;
        public int Megapixels { get => _megapixels; set => _megapixels = value; }
    }

    public class Monitor : Product {
        private int _diagonal;
        public int Diagonal { get => _diagonal; set => _diagonal = value; }
    }

    class MainApp
    {
        static void Main()
        {       //створюємо творця
            DeviceCreator creator = new ConcreteCreator();
            for (int i = 1; i <= 2; i++)
            {
                //створюємо спочатку продукт з типом 1, потім з типом 2
                var product = creator.CreateDevice(i);
                Console.WriteLine("Where id = {0}, Created {1} ", i, product.GetType());
            }
            Console.ReadKey();
        }
    }
}

