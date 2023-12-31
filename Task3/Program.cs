﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Input first namber: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second namber: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int FunAkk(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FunAkk(n - 1, 1);
    else
      return FunAkk(n - 1, FunAkk(n, m - 1));
}

Console.WriteLine($"Akkermann function A({m},{n})={FunAkk(m, n)}");

