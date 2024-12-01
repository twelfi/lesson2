namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Привет, {name}!");
            Console.WriteLine($"\tВаш возраст: {age} лет");
            Console.WriteLine($"\t\tВаш рост: {height} м");
        }
    }
}