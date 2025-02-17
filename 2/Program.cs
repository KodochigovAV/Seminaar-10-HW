﻿// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Akk(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akk(n - 1, 1);
    else
      return Akk(n - 1, Akk(n, m - 1));
}

int answer = Akk(3, 2);

System.Console.WriteLine(answer);
