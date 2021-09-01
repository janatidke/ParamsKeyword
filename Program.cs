using System;

namespace ParamsKeyword
{
    abstract class Shape
    {
    public int r, l, b, a;
    public abstract void accept();
    public abstract void area(params int[] lst);
    

    public abstract void closing();

}
class Rectangle: Shape
    {
    public override void accept()
        {
        Console.WriteLine("Enter lenght");
        l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            b = Convert.ToInt32(Console.ReadLine());
    }
    public override void area(params int[] lst)
        {
        a = l * b;
        Console.WriteLine("The area of the rectangle is {0}", a);
    }

    public override void closing() { }

}


class Square: Shape
    {
    public override void accept()
        {
        Console.WriteLine("Enter the side for square");
        l = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(l);
    }

    public override void area(params int[] lst)
        {
        a = l * l;
        Console.WriteLine("Area of the Square {0}", a);
    }

    public override void closing()
        {
        Console.WriteLine("Created Square");
    }
}

class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Constructor Demo!");
        Rectangle rect = new Rectangle();
        rect.accept();
        rect.area();
        Square s = new Square();
        s.accept();
        s.area();

    }
}
}
