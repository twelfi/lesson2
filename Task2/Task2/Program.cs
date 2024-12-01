namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble (Console.ReadLine());
            double sum = a + b;
            double raz = a - b;
            double proiz = a * b;
            double delen = a / b;

            Console.WriteLine($"Сумма чисел:{sum}");
            Console.WriteLine($"Произведение чисел:{proiz}");
            Console.WriteLine($"Разность чисел:{raz}");
            Console.WriteLine($"Частное чисел:{delen}");
        }
    }
}
