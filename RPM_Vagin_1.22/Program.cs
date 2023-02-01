namespace RPM_Vagin_1._22;
public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("a) Введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("б) Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"а) значение функции y = 7x^2 - 3x + 6 = {GetY(x)}");
            Console.WriteLine($"б) значение функции x = 12a^2 + 7a - 16 = {GetX(a)}");
        }
        catch
        {
            Console.WriteLine("Вы ввели не число");
        }
    }

    private static double GetY(double x)
    {
        return 7 * Math.Pow(x, 2) - 3 * x + 6;
    }

    private static double GetX(double a)
    {
       return 12 * Math.Pow(a, 2) + 7 * a - 16;
    }
}
