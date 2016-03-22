using System;


namespace RectangleApplication
{
    class Rectangle
    {
        // member variables
        double length;
        double width;
        double perimetr;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
            perimetr = 5.5;
        }

        public double GetArea()
        {
            return length * width;

        }

        public double GetPeri()
        {
            return length * width*perimetr;

        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
            Console.WriteLine("Perimeter: {0}", GetPeri());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
