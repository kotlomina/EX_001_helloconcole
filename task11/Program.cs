//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72

int number = new Random().Next(100, 1000);
Console.WriteLine($"Random number is {number}");
Console.WriteLine($"The number without 2nd digit is {(number / 100) * 10 + (number % 10)}");