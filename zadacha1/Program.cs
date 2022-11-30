// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.WriteLine("Введите трехзначное число");

int number = int.Parse(Console.ReadLine());

int ostatok =(number/10)%10;

if ((number > 999) || (number < 100))

    Console.WriteLine("Введенное число не подходит под условие задачи");
    
else

    Console.WriteLine($"вторая цифра от числа {number} это {ostatok}");