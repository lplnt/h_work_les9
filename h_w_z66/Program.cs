// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Задайте первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int Func(int n)
{
    if (n == m) return m;
    else{
    return n + Func(n - 1);
    }
}
Console.WriteLine($"Cумма чисел в промежутке между {m} и {n} = {Func(n)}");