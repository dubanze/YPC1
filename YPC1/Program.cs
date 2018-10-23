using System;

namespace YPC1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var animal = new Dog();
            //var animalSound = (IAnimalLegs) animal;
            Console.WriteLine(animal.GiveVoice());
            Console.WriteLine(animal.Number);
        }

        public interface IAnimalSound
        {
            string GiveVoice();
        }

        public interface IAnimalLegs
        {
            int Number { get; }
        }

        public class Duck : IAnimalSound, IAnimalLegs
        {
            public string GiveVoice()
            {
                return "Quack";
            }

            public int Number => 2;
        }

        public class Dog : IAnimalSound, IAnimalLegs
        {
            public string GiveVoice()
            {
                return "Woof";
            }

            public int Number => 4;
        }
        public class Cat : IAnimalSound
        {
            public string GiveVoice()
            {
                return "Meow";
            }
        }

    }
    
}
