using System;

namespace PassByValueExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            //En kopia av variabeln i skickas in. 
            PassByValue(i);
            Console.WriteLine($"Utanför metod i={i}"); //Värdet för i blir oförändrat.
            
            var animal = new Animal();
            animal.Age = 5;
            //En kopia av referensen skickas in. Ändringar som görs i metoden sker på själva objektet som vi refererar till.
            PassByReference(animal);
            Console.WriteLine($"Age utanför metod: {animal.Age}"); //Värdet blev förändrad i metoden.

            //Keyword ref gör så att vi kan skicka referensen till i variabeln och förändra dess värde i metoden.
            PassIntByRef(ref i);
            Console.WriteLine($"Utanför metod i={i}"); //Värdet för i blev förändrad i metoden.
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
