Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
    Console.WriteLine("Третьего числа нет!");
else
{
    while (number > 1000)
        number = number / 10;
    Console.WriteLine("Третье число равно " + number % 10);
}