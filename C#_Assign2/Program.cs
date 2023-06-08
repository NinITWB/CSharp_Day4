using System;

namespace Task2
{
    class Program
    {
        static void Main(string [] args)
        {
            //Point 2D
            Point2D p2D = new Point2D();
            p2D.X = 5;
            p2D.Y = 3;
            /*
                p2D.SetXY(8, 10);
                float[] xy = p2D.GetXY();
            */
            Console.WriteLine(p2D.ToString());

            Console.WriteLine();

            //Point 3D
            Point3D p3D = new Point3D(3, 6, 4);
            /*
                p3D.SetXYZ(5, 5, 5);
                float[] xyz = p3D.GetXYZ();
            */
            Console.WriteLine(p3D.ToString());

        }
    }
}
