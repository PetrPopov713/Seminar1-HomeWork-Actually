// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число a ");
int a = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите число b ");
int b = Convert.ToInt32(Console.ReadLine ());
if (a>b)
    Console.WriteLine ("Максимальное число - a, минимальное число - b");
if (b>a)
    Console.WriteLine ("Максимальное число - b, минимальное число - a");


//     Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

﻿Console.WriteLine("Введите число c ");
int c = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите число d");
int d = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите число e ");
int e = Convert.ToInt32(Console.ReadLine ());
if 
  (c>d)
       if
         (c>e)
  Console.WriteLine ("Максимальное число - c");
if 
  (d>c)
       if
         (d>e)
  Console.WriteLine ("Максимальное число - d");
  if 
  (e>d)
       if
         (e>c)
  Console.WriteLine ("Максимальное число - e");

//   Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

﻿Console.WriteLine("Введите число f ");
int f = Convert.ToInt32(Console.ReadLine ());
if (f%2 == 0)
{
    Console.WriteLine("Число f - чётное");
}
 else
 {
     Console.WriteLine("Число f - нечётное");
 }

//  Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

﻿Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine ());
int M = 1;
while (M%2==0 && M<=N)
      M=M+2;
Console.WriteLine($"Четные числа от 1 до N: " + M);
