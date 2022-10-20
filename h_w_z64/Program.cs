// // Задача 64: Задайте значение N. Напишите программу, 
// // которая выведет все натуральные числа в промежутке от N до 1. 
// // Выполнить с помощью рекурсии.
// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
int m = 1;
Console.Write("Задайте число: ");
int n = Convert.ToInt32(Console.ReadLine());    
int count = n;    
void Func(int m, int n)
{
    if (n > m)
        {
            System.Console.Write($"{count--} ");
            Func(m, n - 1);
        }
        else if (m == n)
        {
            System.Console.Write($"{count--} ");
        }
}
System.Console.Write($"Числа в промежутке между {n} и {m}: ");
Func(m, n);
Console.WriteLine();