using System;

namespace Task1
{
    class Program
    {
        static void Main(string [] args)
        {
            //Circle
            Circle circle = new Circle();
            circle.Radius = 5;
            circle.Color = "White";

            Console.WriteLine("Area: {0}", circle.Area());
            Console.WriteLine("Info: " + circle.ToString());

            Console.WriteLine();

            //Cylinder
            Cylinder cylinder =  new Cylinder();
            cylinder.Radius = 7;
            cylinder.Height = 3;

            Console.WriteLine("Area: {0}", cylinder.Area());
            Console.WriteLine("Volume: {0}", cylinder.Volume());
            Console.WriteLine("Info: " + cylinder.ToString());
            
        }
    }
}
