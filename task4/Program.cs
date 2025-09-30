namespace Task4
{
    public class Program
    {
        public static bool IsValidTriangle(double a, double b, double c) 
        {
            
            if (a + b > c && b + c > a && a + c > b) return true;
            else return false;
            
        }
        public static double GetPerimeter(double a, double b, double c) 
        { 
            double perimeter = 0;
            return perimeter = a + b + c;
        }
        public static double GetArea(double a, double b, double c) 
        {
            double p = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static string GetTriangleType(double a, double b, double c) 
        {
            if (a == b && b == c)
                return "рівносторонній";
            else if (a == b || b == c || a == c)
                return "рівнобедрений";
            else if (Math.Abs(a * a + b * b - c * c) < 1e-6 || //попросив в гпт умови за якої трикутник прямокутний Xd
                     Math.Abs(a * a + c * c - b * b) < 1e-6 ||
                     Math.Abs(b * b + c * c - a * a) < 1e-6)
                return "прямокутний";
            else
                return "довільний"; 
        }

        static void Main(string[] args)
        {
            Console.Write("Введіть сторону a: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Введіть сторону b: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Введіть сторону c: ");
            double c = int.Parse(Console.ReadLine());
            if (IsValidTriangle(a, b, c))
            {
                Console.WriteLine($"Периметр = {GetPerimeter(a, b, c)}");
                Console.WriteLine($"Площа = {GetArea(a, b, c):F2}");
                Console.WriteLine($"Тип: {GetTriangleType(a, b, c)}");
            }
            else
            {
                Console.WriteLine("Трикутник не існує!");
            }
        }
    }
}
