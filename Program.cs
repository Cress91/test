// // Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввел пользователь.

Console.Write("Arount of numbers:");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] a = new int[n];

for(int i=0; i<n; i++)
{
    Console.Write($"A[{i + 1}] = ");
    a[i] = Convert.ToInt32(Console.ReadLine());
    
    if (a[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Arount of positive numbers : {sum}");