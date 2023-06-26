/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Enter 3 digit number:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999)
    Console.WriteLine("Not a 3 digit number");
else
{
    num %= 100;
    num /= 10;
    Console.WriteLine($"Second digit is {num}");
}