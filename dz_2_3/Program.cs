﻿Console.Write("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 | n == 7)
{
    Console.Write(n + "выходной день");
}
else
{
    Console.WriteLine(n + "не выходной день");
}