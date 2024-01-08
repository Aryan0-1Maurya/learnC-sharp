using System;

namespace OOPS
{
    public abstract class Shape
    {
        public abstract void draw();
    }

    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }

    class Triangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Draw Triangle");
        }
    }

    class AbstractExample
    {
        public static void Main()
        {
            Shape s1 = new Rectangle();

            s1.draw();
            s1 = new Triangle();
            s1.draw();

            Console.ReadKey();
        }
    }
}






using System;

namespace Amsr
{
    class Demo
    {
        private int val;

        public Demo()
        {
            Console.WriteLine("Inside Constructor");
            val = 42;
        }

        public int Value()
        {
            Console.WriteLine("\nInside Value function");
            return val * 20;
        }
    }

    static class Module1
    {
        public static void Main()
        {
            Demo x = new Demo();
            Console.WriteLine("\nReturn value by Value function : " + x.Value());
            Console.Read();
        }
    }
}






using System;

namespace OOPS
{
    class Encapsulation
    {
        private string manufacturer;
        private string operating_system;
        public string model;
        private int cost;

        // Constructor to set properties/characteristics of object
        Encapsulation(string manufac, string operatSys, string mod, int cst)
        {
            this.manufacturer = manufac;
            this.operating_system = operatSys;
            this.model = mod;
            this.cost = cst;
        }

        // Method to get access Model property of Object
        public string getModel()
        {
            return this.model;
        }

        public string getManufacturer()
        {
            return this.manufacturer;
        }

        public int getcost()
        {
            return this.cost;
        }

        public string getOperatingSystem()
        {
            return this.operating_system;
        }

        public static void Main()
        {
            Encapsulation en = new Encapsulation("Microsoft",
                    "Windows", "2007", 500);

            Console.WriteLine("Manufacturer: " + en.getManufacturer());
            Console.WriteLine("OS: " + en.getOperatingSystem());
            Console.WriteLine("Model: " + en.getModel());
            Console.WriteLine("Cost: " + en.getcost());

            Console.ReadKey();
        }
    }
}






using System;

namespace Method_Overloading_Test
{
    class MethodOverloadingTest
    {
        static void Main(string[] args)
        {
            MethodOverloading ob = new MethodOverloading();

            ob.display(20);

            ob.display(0.33f);

            ob.display('z');

            Console.ReadLine();
        }
    }

    class MethodOverloading
    {

        public void display(int number)
        {

            Console.WriteLine("Integer value: " + number);

        }

        public void display(float number)
        {

            Console.WriteLine("Float value: " + number);

        }

        public void display(char character)
        {

            Console.WriteLine("Character value: " + character);

        }

    }
}






using System;

namespace MethodOverridingTest
{
    class MethodOverridingTest
    {
        static void Main(string[] args)
        {
            A a;

            a = new A();
            a.display();

            a = new B();
            a.display();

            a = new C();
            a.display();

            Console.ReadLine();
        }
    }

    class A
    {
        public virtual void display()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public override void display()
        {
            Console.WriteLine("B");
        }
    }

    class C : A
    {
        public override void display()
        {
            Console.WriteLine("C");
        }
    }
}






using System;

namespace Inheritance
{
    class Multilevel : SuperChild
    {
        public void child()
        {
            Console.WriteLine("Level 3");
        }

        static void Main(string[] args)
        {
            Multilevel obj = new Multilevel();

            obj.super();
            obj.superchild();
            obj.child();

            Console.Read();
        }
    }

    class Super
    {
        public void super()
        {
            Console.WriteLine("Level 1");
        }
    }

    class SuperChild : Super
    {
        public void superchild()
        {
            Console.WriteLine("Level 2");
        }
    }
}






using System;

namespace Inheritance
{
    interface addition
    {
        int add(int a, int b);
    }

    interface subtraction
    {
        int sub(int x, int y);
    }

    interface multiplication
    {
        int mul(int r, int s);
    }

    interface division
    {
        float div(float c, float d);
    }

    class Calculation : addition, subtraction, multiplication, division
    {
        public int result1;
        public int add(int a, int b)
        {
            return result1 = a + b;
        }

        public int result2;
        public int sub(int x, int y)
        {
            return result2 = x - y;
        }

        public int result3;
        public int mul(int r, int s)
        {
            return result3 = r * s;
        }

        public float result4;
        public float div(float c, float d)
        {
            return result4 = (float)(c / d);
        }

        static void Main(string[] args)
        {
            Calculation c = new Calculation();

            c.add(8, 2);
            c.sub(20, 10);
            c.mul(5, 2);
            c.div(2, 3);

            Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");

            Console.WriteLine("Addition : " + c.result1);
            Console.WriteLine("Subtraction : " + c.result2);
            Console.WriteLine("Multiplication : " + c.result3);
            Console.WriteLine("Division : " + c.result4);

            Console.ReadKey();
        }
    }
}






using System;

namespace OOPS
{
    class SuperClass
    {
        //method declared with virtual keyword
        public virtual void display()
        {
            Console.WriteLine("Hello Superclass ");
        }
    }

    class Polymorphism : SuperClass
    {
        public override void display()
        {
            Console.WriteLine("Hello Subclass ");
        }

        public static void Main()
        {
            //This is called upcasting 
            SuperClass s = new Polymorphism();
            s.display();

            Console.ReadKey();
        }
    }
}






using System;

namespace Inheritance
{
    class SingleInheritance
    {
        static void Main(string[] args)
        {
            Teacher d = new Teacher();
            d.Teach();

            Student s = new Student();
            s.Learn();
            s.Teach();

            Console.ReadKey();
        }
        class Teacher
        {
            public void Teach()
            {
                Console.WriteLine("Teach");
            }
        }
        class Student : Teacher
        {
            public void Learn()
            {
                Console.WriteLine("Learn");
            }
        }
    }
}

using System;

namespace OOPS
{
    class SealedMethodDemo
    {
        public virtual void Method1()
        {
            Console.Write("Base class Method1");
        }
    }

    class ChildClass : SealedMethodDemo
    {
        public sealed override void Method1()
        {
            Console.Write("Derived class Method1");
        }

        public static void Main()
        {
            ChildClass c = new ChildClass();
            c.Method1();

            Console.ReadKey();
        }
    }
}
