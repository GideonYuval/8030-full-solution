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
            //Console.WriteLine(5/0); //compile error

            //int x = 0;
            //Console.WriteLine(5/x); //RT exception

            int x = 4;
            double y = x; //implicit cast
            y = (int)x; //explicit - not needed
            y = 4.3;
            //x = y; //won't work, need casting
            x = (int)y;
            //x = (int)("abc"); //can't convert
            
            
            Animal a1 = new Animal();
            Dog d1 = new Dog();
            Cat c1 = new Cat();

            Console.WriteLine("demo");
            Animal[] arr = new Animal[3];
            arr[0] = a1;
            arr[1] = d1;
            arr[2] = c1;

            Animal ad = d1;
            Animal ac = new Cat();

            Console.WriteLine(d1 is Dog);
            Console.WriteLine(d1 is Animal);
            Console.WriteLine(a1 is Dog);
            Car car1 = new Car();
            Console.WriteLine(car1 is Animal);

            Animal aa;
            aa = d1;
            aa = (Animal)d1;

            for (int i = 0;i<arr.Length;i++)
                arr[i].MakeNoise();
            foreach (Animal a in arr)
                a.MakeNoise();


            DoAnimalStuff(a1);
            DoAnimalStuff(d1);
            DoAnimalStuff(c1);

            //DoAnimalStuff(car); //can't convert
            //d1 = (Dog)c1; //can't convert
            
            Animal a2 = new Dog();
            //Dog d2 = new Animal();
            Cat c2 = new Cat();
            a2.MakeNoise();
            //a2.Growl();
            //((Dog)a2).Growl();
            //((Dog)c2).Growl();

            Animal a3 = new Cat();
            //((Dog)a3).Growl(); //RT exception



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