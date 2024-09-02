using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace basicCS
{
    class session_7
    {
        public string color = "red";
        public int price = 10000;
        public string system = "manual";
        
        public void car ()
        {
            Console.WriteLine("...");
        }

    }
    class Person
    {
        private string name; // field
        public string Name_property   // property
        {
            get { return name; }
            set { name = value; }
        }

        // one line get and set 
        public string Nickname { get; set; }
        public int Age { get; set; }

    }

    class properties
    {
        public void access_private_name()
        {
            Person myObj = new Person();
            myObj.Name_property = "Panupong";
            Console.WriteLine(myObj.Name_property);

            myObj.Age = 32;
            Console.WriteLine(myObj.Age);
           
            myObj.Nickname = "Jay";
            Console.WriteLine(myObj.Nickname);
        }
    }

    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");

        }
    }
    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: Woof");
        }
    }
    class Cat : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: Meow");
        }
    }
    class Animal_kingdom
    {
        public void animal_kingdom()
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal cat = new Cat();  // Create a Cat object
            Animal dog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            cat.animalSound();
            dog.animalSound();
        }
    }


    public class Shape
    {
        public virtual double GetArea()
        {
            return 0; // Default implementation for unknown shapes
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }

        public void inside_rectangle() {
            Console.WriteLine(" --> Call direct Rectangle by using   Rectangle rectangle = new Rectangle(4, 6);  ");

        }
    }

    class Shape_Override
    {
        public void shape_override()
        {
            Shape shapes = new Shape();
            Shape circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            rectangle.inside_rectangle();


            Console.WriteLine("Circle Area: " + circle.GetArea());
            Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
        }
    }

    // Abstract class representing a shape
    public abstract class ShapeAbs
    {
        // Abstract method for calculating area
        public abstract double CalculateArea();
    }

    // Concrete subclass representing a circle
    public class CircleAbs : ShapeAbs
    {
        private double radius;

        // Constructor to initialize the radius
        public CircleAbs(double radius)
        {
            this.radius = radius;
        }

        // Implementation of abstract method to calculate area for circle
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Concrete subclass representing a rectangle
    public class RectangleAbs : ShapeAbs
    {
        private double width;
        private double height;

        // Constructor to initialize width and height
        public RectangleAbs(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Implementation of abstract method to calculate area for rectangle
        public override double CalculateArea()
        {
            return width * height;
        }
    }

    class Abstract
    {
        public void absttract()
        {
            // Creating instances of Circle and Rectangle
            CircleAbs circle = new CircleAbs(5);
            RectangleAbs rectangle = new RectangleAbs(4, 6);

            //ShapeAbs xxx = new ShapeAbs();
            //xxx.CalculateArea();

            // Calculating and printing areas
            Console.WriteLine("Area of circle: " + circle.CalculateArea());
            Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());
        }
    }





}
