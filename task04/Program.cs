// 456 -> 6
// 782 -> 2
// 918 -> 8

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 

//Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int rezalt = number * number;

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number % 10);