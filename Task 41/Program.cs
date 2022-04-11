// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите длину последовательности чисел");
int length = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) sum++;
}
Console.WriteLine("Количество чисел больше нуля равно: " + sum);

