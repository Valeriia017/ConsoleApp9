using System;

class Shar
{
    private double r;

    public Shar()
    {
        r = 0;
    }

    public double Radius
    {
        get { return r; }
        set { r = value; }
    }

    public bool Correct()
    {
        return r > 0;
    }

    public double Area()
    {
        return 4 * Math.PI * r * r;
    }

    public double Volume()
    {
        return (4 / 3) * Math.PI * r * r * r;
    }

    public void Print()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Значення поля: " + r);
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Shar sphere = new Shar();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть значення радіуса:");
            double radius = double.Parse(Console.ReadLine());

            sphere.Radius = radius;

            sphere.Print();

            if (sphere.Correct())
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Площа поверхні кулі: " + sphere.Area());
                Console.WriteLine("Об'єм кулі: " + sphere.Volume());
            }
            else
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Об'єкт не може існувати.");
            }
        }
        catch (Exception ex)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Виникла помилка: " + ex.Message);
        }
    }
}
