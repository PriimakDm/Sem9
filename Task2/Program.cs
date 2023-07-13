// Задайте значения m и n. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от m до n.

Console.WriteLine("Input first natural namber: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input another natural namber: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int SumNatElements(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;
    else if (n == 0) return (m * (m + 1)) / 2;
    else if (m == n) return m;
    else if (n < m) return n + SumNatElements(m, n + 1);
    else if (m < n) return n + SumNatElements(m, n - 1);
    else return n + SumNatElements(m, n + 1);
}
Console.WriteLine($"Sum of elements: {SumNatElements(m, n)}");
