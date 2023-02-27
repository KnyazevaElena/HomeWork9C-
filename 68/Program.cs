// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;

Clear();
Write("Введите M: ");
int a = int.Parse(ReadLine());
Write("Введите N: ");
int b = int.Parse(ReadLine());

WriteLine($"Функция Аккермана = {FunAkkerman(a, b)}");

int FunAkkerman(int m, int n)
{
    if (m == 0)
     {
        return n + 1;}

    if (n == 0) 
    {
        return FunAkkerman(m - 1, 1);}
        
    return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
}