﻿// /*/ Известно значение температуры по шкале Цельсия. Найти соответствующее  значение температуры по шкале: 
// // а) Фаренгейта; 
// //б) Кельвина.
// Для пересчета по шкале Фаренгейта необходимо исходное значение температуры умножить на 1,8 
//и к результату прибавить 32, 
// а по шкале Кельвина абсолютное значение нуля соответствует 273,15 градуса по шкале Цельсия.
//F=t*1,8+32
//K=t+273,15

Console.WriteLine("Введите температуру по Цельсию: ");
double c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Введите температура по Фарингейту: {c*1.8+32} ");
Console.WriteLine($"Введите температура по Кельвину: {c+273.15} ");