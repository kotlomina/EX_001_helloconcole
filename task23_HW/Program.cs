﻿/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;
Console.Write($"Cube of numbers from 1 to {number} is: ");
while (count <= number)
{
    Console.Write(countcount*count + " ");
    count++; 
}