// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число:");

int a = Convert.ToInt32(Console.ReadLine());

int count = 2;

while (count <= a)
{
    Console.WriteLine(count);
    count = count + 2;
}

if(a < 1)
{
   Console.WriteLine("Вы ввели недопустимое значение.");  
}

if(a == 1)
{
   Console.WriteLine("Четных чисел в этом диапазоне нет.");  
}

