﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите  число:");

int a = Convert.ToInt32(Console.ReadLine());

int remainder = (a % 2);

if(remainder == 0 & a != 0)
  {
    Console.WriteLine("Это число четное");
  }

if(remainder == 1 || remainder == -1)
   {
      Console.WriteLine("Это число нечетное.");
   }
if(remainder == 0 & a == 0)

   {
     Console.WriteLine("Это число ноль");
   }
