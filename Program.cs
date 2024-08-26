public class QuadraticEquation
{
    private double a;
    private double b;
    private double c;

    public QuadraticEquation(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public bool HasRealRoots()
    {
        double discriminant = b * b - 4 * a * c;

        return discriminant >= 0;
    }

    public void PrintRoots()
    {
        if (HasRealRoots())
        {
            double discriminant = Math.Sqrt(b * b - 4 * a * c);
            double root1 = (-b + discriminant) / (2 * a);
            double root2 = (-b - discriminant) / (2 * a);

            Console.WriteLine($"Real roots: x1 = {root1}, x2 = {root2}");
        }
        else
        {
            Console.WriteLine("No real roots.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        QuadraticEquation equation = new QuadraticEquation(1, -3, 2);
        equation.PrintRoots();
    }
}
