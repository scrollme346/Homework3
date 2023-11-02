internal class Program
{
    private static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)// если процентный остаток num равняется нулю то
        {
            int mnosh = num * 3;// num умножаем на три
            Console.WriteLine($"Ваше число {num} делится на 2(и является четным) \nУмноженое на три: {mnosh}");//выводим результат
        }
        else//если не делится
        {
            float delen = num / 2f;//делим на два
            Console.WriteLine($"Ваше число {num} не делится на два (и не является четным) \nРазделенно на два: {delen}");// выводим результат
        }
    }
}
//парное или не парное
