using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie_konstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent("Parent");
            Child ch1 = new Child("Child");

           //p1.method_1();
           //ch1.method_1();

            p1.method_2();
            ch1.method_2();


        }
    }

    class Parent
    {
        string name;

        public Parent(string name)
        {
            this.name = name;
            Console.WriteLine("Parent constructor");
        }


        public virtual void method_1()
        {
            Console.WriteLine("method_1 from Parent");
        }

        public void method_2()
        {
            Console.WriteLine("Name: " + name);
        }


    }

    class Child: Parent
    {
        public Child(string name)
            : base(name)
        {
            Console.WriteLine("Child constructor");
        }

        public override void method_1()
        {
            //base.method_1();

            Console.WriteLine("method_1 from Child");
        }

    }
}
