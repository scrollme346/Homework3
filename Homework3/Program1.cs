internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Первая оценка");
        int oneR = Convert.ToInt32(Console.ReadLine());//пользователь вводит оценки
        Console.WriteLine("Вторая оценка");
        int twoR = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Третья оценка");
        int threeR = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Четвёрная оценка");
        int fourR = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Пятая оценка");
        int fiveR = Convert.ToInt32(Console.ReadLine());

        int sum = oneR + twoR + threeR + fourR + fiveR;//сумма
        float arith = sum / 5f;//сред арифмет

        Console.WriteLine("Скольки-бальная у вас система оценок?(5/12)");
        int Ball = Convert.ToInt32(Console.ReadLine());//делаем не особо важную переменную(конвертируем в инт)

        if ((Ball == 5 || Ball == 12) && arith >= 4)//если балл == 5 или 12 и арифмет больше 4 то
            {
                Console.WriteLine("Вы получили пропуск");
            }

        else//если ничего из этого
            {
                Console.WriteLine("К пропуску не дотянули");
            }
        Console.WriteLine($"Средний балл: {arith}");
        
    }
}
//пропускной балл
