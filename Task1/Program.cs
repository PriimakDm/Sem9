// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.WriteLine("Input natural namber: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturNam (int n)
{
if (n > 1) NaturNam (n-1);
Console.Write(n+" ");
}
NaturNam(n);