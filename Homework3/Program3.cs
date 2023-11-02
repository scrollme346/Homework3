internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Первое число:");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Второе число:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Уточните арифметическое действие(+,-,*,/,%-остаток)");
        string znak = Console.ReadLine();

        if (znak == "+")//если знак + 
        {
            int sum = num + num1;// то плюсуем
            Console.WriteLine($"Ваше число: {sum}");//выводим результат
        }
        else if (znak == "-") 
        {
            int minus = num - num1;
            Console.WriteLine($"Ваше число: {minus}");
        }
        else if (znak == "*") 
        {
            int mnosh = num * num1;
            Console.WriteLine($"Ваше число: {mnosh}");
        }
        else if (znak == "/")
        {
            float delen = num / num1;
            Console.WriteLine($"Ваше число: {delen}");
        }
        else if (znak == "%")
        {
            int ostat = num % num1;
            Console.WriteLine($"Остаток от числа: {ostat}");
        }
        else { Console.WriteLine("Вы чтото сделали не так"); }
    }
}
//калькулятор
