// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 3, n = 2 -> A(m,n) = 29;

int Akkerman(int m, int n)
{
    if (m==0) return n+1;
    else if(m > 0 && n ==0) return Akkerman(m - 1, 1);
    else return (Akkerman(m - 1, Akkerman(m, n - 1)));
}

try
{

    Console.WriteLine("Введите первое целое положительное число:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе целое положительное число:");
    int n = Convert.ToInt32(Console.ReadLine());
    if(m >= 0 && n >= 0)
    {
        Console.WriteLine($"Результат вычисления функции Аккермана : {Akkerman(m,n)}");
    }

    else
    {
        Console.WriteLine("Введите, пожалуйста, положительное число, так как по условию задачи вводимые числа должны быть положительными");
    }
}
catch
{
    Console.WriteLine("Введите, пожалуйста, целое положительное число.");
}
