using System;

namespace PassByValueExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            PassByValue(i);
            Console.WriteLine($"Utanför metod i={i}");
            
            var animal = new Animal();
            animal.Age = 5;
            PassByReference(animal);
            Console.WriteLine($"Age utanför metod: {animal.Age}");

            PassIntByRef(ref i);
            Console.WriteLine($"Utanför metod i={i}");
        }

        static void PassByValue(int i)
        {
            i = 2;
            Console.WriteLine($"I metod i={i}");
        }

        static void PassByReference(Animal animal)
        {
            animal.Age = 10;
            Console.WriteLine($"Age i metod: {animal.Age}");
        }

        static void PassIntByRef(ref int i)
        {
            i = 10;
            Console.WriteLine($"I metod i={i}");
        }
    }

    internal class Animal
    {
        public int Age { get; set; }
    }
}
