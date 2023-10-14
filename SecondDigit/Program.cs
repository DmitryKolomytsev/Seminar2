Console.Write("Введите число: ");
string numb = Console.ReadLine();
int number = Convert.ToInt32(numb);
int result = (number / 10) % 10;
Console.WriteLine($"Вторая цифра — {result}");