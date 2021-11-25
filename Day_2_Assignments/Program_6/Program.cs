using System;

namespace SecondDay_Assignment2_Abstract_Animal
{

    abstract class Animal {

        public abstract void foodHabit();

    }


    class Herbivorous : Animal {

        public override void foodHabit()
        {
            Console.WriteLine("Consume only plants.");

        }
    }


    

        class Carnivorous : Animal
    {

        public override void foodHabit()
        {
            Console.WriteLine("Consume meat.");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Herbivorous animals ");
            new Herbivorous().foodHabit();
            Console.WriteLine("--------------------");
            Console.WriteLine("Carnivorous animals ");
            new Carnivorous().foodHabit();


            Console.ReadKey();
        }
    }
}
