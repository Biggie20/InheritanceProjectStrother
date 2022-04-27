
using System;
namespace InheritanceProject.Strother
{
    class MainClass
    {
        class Animal 
        {
            public string name;
            public int age;
            public float happiness;

            public void PrintBase()
            {
               Console.WriteLine("Name:"+name);
               Console.WriteLine("Age:"+age);
               Console.WriteLine("Happiness:"+happiness);
            }
        }
        class Dog: Animal
        {
        public int furcolor;

        public void Bark()
        {
            Console.WriteLine("WOOF!!");
            base.happiness+=0.1f;
        }
        }
        class Duck: Animal
        {
            public float cuteness;
            public void Quack()
            {
                Console.WriteLine("Hello Peterrrrr!!");
            }
        }

        public static void Main(string[]args)
        {
          Dog Dexter=new Dog();
          Dexter.name="Dexter";
          Dexter.age=2;
          Dexter.happiness=0.8f;
          Dexter.furcolor=brown;
          Dexter.PrintBase():
          Dexter.Bark();
          Console.WriteLine("New Happiness:"+Dexter.Happiness);

          Console.ReadKey();
        }
    }
}
