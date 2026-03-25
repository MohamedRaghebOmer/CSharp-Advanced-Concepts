using System;

public class Point
{
    private int _X, _Y;

    /// <summary>
    /// Gets or sets the value of X. The value is always non-negative. If a negative value is assigned, the property is
    /// set to 0.
    /// </summary>
    public int X
    {
        get => _X;

        set
        {
            if (value >= 0)
                _X = value;
            else
                _X = 0;
        }
    }

    /// <summary>
    /// Gets or sets the value of Y. The value is always non-negative. If a negative value is assigned, the property is
    /// set to 0.
    /// </summary>
    public int Y
    {
        get => _Y;

        set
        {
            if (value >= 0)
                _Y = value;
            else
                _Y = 0;
        }
    }


    public static Point operator +(Point point1, Point point2)
    {
        return new Point(point1.X + point2.X, point1.Y + point2.Y);
    }

    public static Point operator -(Point point1, Point point2)
    {
        return new Point(point1.X - point2.X, point1.Y - point2.Y);
    }

    public static Point operator *(Point point1, Point point2)
    {
        return new Point(point1.X * point2.X, point1.Y * point2.Y);
    }

    public static Point operator /(Point point1, Point point2)
    {
        Point newPoint2 = new Point(point2.X, point2.Y);

        // Avoid division by zero
        if (newPoint2.X == 0)
            newPoint2.X = 1;

        if (newPoint2.Y == 0)
            newPoint2.Y = 1;

        return new Point(point1.X / newPoint2.X, point1.Y / newPoint2.Y);
    }

    public static bool operator ==(Point point1, Point point2)
    {
        return point1.X == point2.X && point1.Y == point2.Y;
    }

    public static bool operator !=(Point point1, Point point2)
    {
        return point1.X != point2.X || point1.Y != point2.Y;
    }

    public static bool operator <(Point point1, Point point2)
    {
        return point1.X < point2.X && point1.Y < point2.Y;
    }

    public static bool operator >(Point point1, Point point2)
    {
        return point1.X > point2.X && point1.Y > point2.Y;
    }

    public static bool operator <=(Point point1, Point point2)
    {
        return point1.X <= point2.X && point1.Y <= point2.Y;
    }

    public static bool operator >=(Point point1, Point point2)
    {
        return point1.X >= point2.X && point1.Y >= point2.Y;
    }

    public override bool Equals(object obj)
    {
        if (obj is Point other)
        {
            return this.X == other.X && this.Y == other.Y;
        }
        
        return false;
    }

    public override int GetHashCode()
    {
        int hash = 17;

        hash = hash * 23 + X.GetHashCode();
        hash = hash * 23 + Y.GetHashCode();

        return hash;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }


    public Point() { }

    /// <summary>
    /// Initializes a new instance of the Point structure with the specified x and y coordinates. x and y values must be positive, if not values will be set to 0.
    /// </summary>
    /// <param name="x">The horizontal position of the point.</param>
    /// <param name="y">The vertical position of the point.</param>
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}

static class OperatorOverloading
{
    static void Main(string[] args)
    {
        Point p1 = new Point(10, 20);
        Point p2 = new Point(5, 4);
        Point p3 = new Point(10, 20);

        // Print values
        Console.WriteLine($"p1: {p1} | Hash code = {p1.GetHashCode()}");
        Console.WriteLine($"p2: {p2} | Has code = {p2.GetHashCode()}");

        Console.WriteLine("-----------");

        // Arithmetic operations
        Point sum = p1 + p2;
        Point sub = p1 - p2;
        Point mul = p1 * p2;
        Point div = p1 / p2;

        Console.WriteLine("Sum: " + sum.X + ", " + sum.Y);
        Console.WriteLine("Sub: " + sub.X + ", " + sub.Y);
        Console.WriteLine("Mul: " + mul.X + ", " + mul.Y);
        Console.WriteLine("Div: " + div.X + ", " + div.Y);

        Console.WriteLine("-----------");

        // Comparison
        Console.WriteLine("p1 == p2: " + (p1 == p2));
        Console.WriteLine("p1 != p2: " + (p1 != p2));
        Console.WriteLine("p1 > p2: " + (p1 > p2));
        Console.WriteLine("p1 < p2: " + (p1 < p2));
        Console.WriteLine("p1 >= p2: " + (p1 >= p2));
        Console.WriteLine("p1 <= p2: " + (p1 <= p2));

        Console.WriteLine("-----------");

        // Equals
        Console.WriteLine($"p3: {p3} | Hash code = {p3.GetHashCode()}");
        Console.WriteLine("p1.Equals(p3): " + p1.Equals(p3));
    }
}
