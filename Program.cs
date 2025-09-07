namespace Lab1_Homework_Fedotova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Задание 1");
            Console.WriteLine();
            Console.WriteLine("Введите два целых числа: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма: {num1 + num2}");
            Console.WriteLine($"Разность: {num1 - num2}");
            Console.WriteLine($"Произведение: {num1 * num2}");
            double division = num1 / num2;
            Console.WriteLine($"Частное: {division}");
            Console.WriteLine();

            //Задание 2

            Console.WriteLine("Задание 2");
            Console.WriteLine();
            Console.Write("Введите ваше имя: ");
            string name1 = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            string age1 = Console.ReadLine();
            Console.Write("Введите ваш любимый язык программирования: ");
            string favlan = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Привет, {name1}!");
            Console.WriteLine($"Тебе {age1} лет.");
            Console.WriteLine($"Твой любимый язык программирования - {favlan}.");
            Console.WriteLine();

            //Задание 3

            Console.WriteLine("Задание 3");
            Console.WriteLine();
            Console.WriteLine("Введите три коэффициента: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double f = Math.Pow((a * 5), 2) + b * 5 + c;

            Console.WriteLine();
            Console.WriteLine($"f = {f}");
            Console.WriteLine();

            //Задание 4

            Console.WriteLine("Задание 4");
            Console.WriteLine();
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите ваш город: ");
            string city = Console.ReadLine();
            Console.Write("Введите ваше любимое число: ");
            int favnum = int.Parse(Console.ReadLine());
            Console.Write("Введите температуру в °С: ");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("=== ПЕРСОНАЛЬНЫЙ ПРОФИЛЬ ===");
            Console.WriteLine();
            Console.WriteLine($"Привет, {name}!");
            Console.WriteLine($"Тебе {age} лет.");
            Console.WriteLine($"В следующем году тебе будет {age + 1}.");
            Console.WriteLine();
            Console.WriteLine($"Ты живешь в городе {city}.");
            Console.WriteLine($"Твое любимое число: {favnum} (в квадрате: {Math.Pow(favnum, 2)})");
            Console.WriteLine();
            Console.WriteLine("Температура за окном:");
            Console.WriteLine($"- В Цельсиях: {temp}°С");
            Console.WriteLine($"- В Фаренгейтах: {temp * 9 / 5 + 32}°F");
            Console.WriteLine();
            Console.WriteLine("=== КОНЕЦ ПРОФИЛЯ ===");
        }
    }
}
