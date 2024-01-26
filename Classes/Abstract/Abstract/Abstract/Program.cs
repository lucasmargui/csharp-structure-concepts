using System;

namespace Abstract
{


    ///////////Exemplo 1
    class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, 0)
        { }

        public override double Area() => pi * x * x;
    }

    class Cylinder : Circle
    {
        public Cylinder(double radius, double height)
            : base(radius)
        {
            y = height;
        }

        public override double Area() => (2 * base.Area()) + (2 * pi * x * y);
    }



    ///////////Exemplo 2
    public class Cat : Animal
    {
        public override string Sound => "Meow";

        public override void Move()
        {
            Console.WriteLine("Walking like a cat...");
        }
    }

    public class Dog : Animal
    {
        public override string Sound => "Woof";

        public override void Move()
        {
            Console.WriteLine("Running like a dog...");
        }
    }

    ///////////Exemplo 3
    
    // é possível chamar um método de classe base por meio da classe derivada.

    class Employee : Person
    {
        public string id = "ABC567EFG";
        public override void GetInfo()
        {
            // Calling the base class GetInfo method:
            base.GetInfo();
            Console.WriteLine("Employee ID: {0}", id);
        }
    }


    ///////////Exemplo 4
    public class DerivedClass : BaseClass
    {
        // This constructor will call BaseClass.BaseClass()
        public DerivedClass() : base()
        {
        }

        // This constructor will call BaseClass.BaseClass(int i)
        public DerivedClass(int i) : base(i)
        {
        }

        
    }
    class Program
	{
		static void Main(string[] args)
		{

            ///////////Exemplo 1
            double radius = 2.5;
            double height = 3.0;

            var ring = new Circle(radius);
            Console.WriteLine($"Area of the circle = {ring.Area():F2}");
          

            var tube = new Cylinder(radius, height);
            Console.WriteLine($"Area of the cylinder = {tube.Area():F2}");



            ///////////Exemplo 2
            Animal[] animals = new Animal[] { new Cat(), new Dog() };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"The {animal.GetType().Name} goes {animal.Sound}");
                animal.Move();
            }



            ///////////Exemplo 3
            Employee E = new Employee();
            E.GetInfo();


            ///////////Exemplo 4
            DerivedClass md = new DerivedClass();
            DerivedClass md1 = new DerivedClass(1);


        }

	}
}
