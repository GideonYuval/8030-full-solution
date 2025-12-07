using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8030_full_solution
{
    internal class Program //
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Dog d1 = new Dog();
            Cat c1 = new Cat();

            Console.WriteLine("demo");
            Animal[] arr = new Animal[3];
            arr[0] = a1;
            arr[1] = d1;
            arr[2] = c1;
            foreach (Animal a in arr)
                a.MakeNoise();


            Console.WriteLine(d1 is Animal);
            Console.WriteLine(a1 is Dog);

            DoAnimalStuff(a1);
            DoAnimalStuff(d1);
            DoAnimalStuff(c1);
            Car car = new Car();
            //DoAnimalStuff(car); //can't convert

            Animal a2 = new Dog(); //no need to write explicitly (Animal) new Dog();
            a2.MakeNoise();

            ((Dog)a2).Growl();
            //((Dog)c1).Growl(); //can't do this

            Animal an = new Dog();
            an.MakeNoise();
            Animal ca = new Cat();
            //((Dog)ca).Growl(); //RT exception

            c1.MakeNoise();
            c1.MakeNoise(3);
        }

        static void DoAnimalStuff(Animal a)
        {
            a.MakeNoise();

            if (a is Dog)
                ((Dog)a).Growl();
        }
    }

    public class Animal
    {
        string name;
        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal Noise");
        }
    }

    public class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Woof!");
        }

        public void Growl()
        {
            Console.WriteLine("Grrrr");
        }
    }

    public class Cat : Animal
    {

        public override void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }


        public void MakeNoise(int times)
        {
            Console.WriteLine($"Meow {times} times");
        }

    }

    public class Car
    {
        public void MakeNoise()
        {
            Console.WriteLine("Voom!");
        }
    }
}