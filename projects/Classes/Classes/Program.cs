using System;
using System.Collections.Generic;
using System.ComponentModel;

public interface IPoint
{
    double DistanceTo(Point B);
}
public interface ITriangle
{
    Point GetA { get; }
    Point GetB { get; }
    Point GetC { get; }
    string Name { get; }
    double AB { get; }
    double AC { get; }
    double BC { get; }
    double Perimeter { get; }
    double Area { get; }
    string ToString();
}
public interface IContainer
{
    int Length { get; }
    List<Triangle> Components { set; }
    void AddShape(Triangle shape);
    void PrintShapeInfo();
    string this[int index] { get; }
    bool SortByArea(Triangle t1, Triangle t2);
    bool SortByPerimeter(Triangle t1, Triangle t2);
}
public class Point : IPoint
{
    public double x;
    public double y;
    public Point()
    {
        this.x = 0;
        this.y = 0;
    }
    static public Point operator +(Point t1, Point t2)
    {
        return new Point(t1.x + t2.x, t1.y + t2.y);
    }
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public double DistanceTo(Point B)
    {
        double x1 = this.x;
        double y1 = this.y;
        double x2 = B.x;
        double y2 = B.y;
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}
public class Triangle : ITriangle
{
    protected Point A;
    protected Point B;
    protected Point C;
    public virtual string Name
    {
        get
        {
            return "Triangle";
        }
    }
    public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        this.A = new Point(x1, y1);
        this.B = new Point(x2, y2);
        this.C = new Point(x3, y3);
    }
    public Triangle(Point A, Point B, Point C)
    {
        this.A = A;
        this.B = B;
        this.C = C;
    }
    public double AB
    {
        get
        {
            return A.DistanceTo(B);
        }
    }
    public double AC
    {
        get
        {
            return A.DistanceTo(C);
        }
    }
    public double BC
    {
        get
        {
            return C.DistanceTo(B);
        }
    }
    public virtual double Perimeter
    {
        get
        {
            return AB + BC + AC;
        }
    }
    public virtual double Area//віртуальна властивість
    {
        get
        {
            double p = Perimeter / 2;
            return Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
        }
    }
    static public bool operator >(Triangle t1, Triangle t2)
    {
        return t1.Area > t2.Area;
    }
    static public bool operator <(Triangle t1, Triangle t2)
    {
        return t1.Area < t2.Area;
    }
    public override string ToString()
    {
        return " a= " + Math.Round(BC, 2) + "\n b= " + Math.Round(AC, 2) + "\n c= " +
            Math.Round(AB, 2) + "\n Area = " + Math.Round(Area, 2) + " Perimeter = " + Math.Round(Perimeter, 2);
    }
    static public Triangle operator +(Triangle t1, Triangle t2)
    {
        return new Triangle(t1.A + t2.A, t1.B + t2.B, t1.C + t2.C);
    }
    public Triangle()
    {
        this.A = new Point();
        this.B = new Point();
        this.C = new Point();
    }
    public Point GetA
    {
        get
        {
            return A;
        }
    }
    public Point GetB
    {
        get
        {
            return B;
        }
    }
    public Point GetC
    {
        get
        {
            return C;
        }
    }
}

public class Tetragon : Triangle
{

    private Point D;

    public override string Name
    {
        get
        {
            return "Tetragon";
        }
    }
    public Tetragon(Point D, Triangle t)
    {
        this.A = t.GetA;
        this.B = t.GetB;
        this.C = t.GetC;
        this.D = D;
    }
    public Tetragon(Point A, Point B, Point C, Point D) : base(A, B, C)
    {
        this.D = D;
    }

    public double CD
    {
        get
        {
            return C.DistanceTo(D);
        }
    }
    public double AD
    {
        get
        {
            return A.DistanceTo(D);
        }
    }

    public override double Area
    {
        get
        {

            Triangle t2 = new Triangle(A, C, D);

            return base.Area + t2.Area;
        }
    }
    public override double Perimeter
    {
        get
        {
            return base.Perimeter + CD + AD - AC;
        }
    }
    public override string ToString()
    {
        return base.ToString() + "\n CD=" + Math.Round(CD, 2) + "\n AD=" + Math.Round(AD, 2);
    }

}

class Container : IContainer
{
    private List<Triangle> components;

    public int Length
    {
        get
        {
            return this.components.Count;
        }
    }
    public List<Triangle> Components
    {
        set
        {
            this.components = value;
        }
    }

    public void AddShape(Triangle shape)
    {
        components.Add(shape);
    }
    public void PrintShapeInfo()
    {
        foreach (Triangle shape in components)
        {
            Console.WriteLine(shape);
            Console.WriteLine();
        }
    }
    public string this[int index]
    {
        get
        {
            return components[index].Name;
        }

    }
    public delegate bool Sort(Triangle t1, Triangle t2);

    public bool SortByArea(Triangle t1, Triangle t2)
    {

        return (t1.Area > t2.Area);

    }
    public bool SortByPerimeter(Triangle t1, Triangle t2)
    {
        return (t1.Perimeter > t2.Perimeter);
    }

    public void Sorter(Sort compare)
    {
        for (int i = 0; i < Length; i++)
        {
            for (int j = i + 1; j < Length; j++)
            {
                if (compare(components[i], components[j]))
                {
                    var temp = components[i];
                    components[i] = components[j];
                    components[j] = temp;
                }
            }
        }
    }

}



class Program
{
    static void Main()
    {
        Triangle t2 = new Triangle(5, 2, 3, 4, 5, 6);
        Triangle t3 = new Triangle(2, 2, 3, 3, 4, 6);
        Console.WriteLine("first triangle\n");
        Console.WriteLine(t2);
        Console.WriteLine("second triangle\n");
        Console.WriteLine(t3);
        Console.WriteLine("First is more?\n");
        Console.WriteLine(t3 > t2);
        Console.WriteLine("Sum of triangles\n");
        Console.WriteLine(t3 + t2);
        Point D = new Point(20, 20);

        Console.WriteLine("tetragon generated by triangle");
        Tetragon tetra = new Tetragon(D, t2);
        Console.WriteLine(tetra);
        Console.WriteLine();

        Console.WriteLine("container of shapes");
        Container Mshape = new Container();
        Mshape.Components = new List<Triangle>();
        Mshape.AddShape(tetra);
        Mshape.AddShape(t2);
        Mshape.AddShape(t3);
        for (int i = 0; i < 5; i++)
        {
            Mshape.AddShape(new Triangle(i, i, i * i, i * i, 0, 3));
        }
        Mshape.PrintShapeInfo();
        Console.WriteLine("name of first shape \n");
        Console.WriteLine(Mshape[0]);
        Console.WriteLine("sorting by area\n");
        Container.Sort del = Mshape.SortByArea;
        Mshape.Sorter(del);
        Mshape.PrintShapeInfo();
        Console.WriteLine("sorting by area and perimeter\n");
        del += Mshape.SortByPerimeter;
        Mshape.Sorter(del);
        Mshape.PrintShapeInfo();
    }

}
