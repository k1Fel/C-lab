namespace Task3
{
    public class Program
    {
        public static string ClassifyAge(int age)
        {
            if (age > 120 || age < 0)
            {
                return "Нереальний вік";
            }
            else if (age > 11 && age <= 17)
            {
                return "Підліток";
            }
            else if (age >= 18 && age <= 59)
            {
                return "Дорослий";
            }

            else if (age < 12)
            {
                return "Ви дитина";
            }
            else 
            { 
                return "Пенсіонер"; 
            }
             
            
        }
        static void Main(string[] args)
        {
            Console.Write("Введіть ваш вік: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(ClassifyAge(age));
        }
    }
}
