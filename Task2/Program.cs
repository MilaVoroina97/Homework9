// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumOfNumbers(int M, int N)
{
    if(M > N) return 0;
    return M + SumOfNumbers( M + 1, N);   
}
try
{

    Console.WriteLine("Введите первое целое натуральное число:");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе целое натуральное число:");
    int N = Convert.ToInt32(Console.ReadLine());
    if(M > 0 && N > 0)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}: {SumOfNumbers(M,N)}");
    }
    else
    {
        Console.WriteLine("Введите, пожалуйста, положительное число, так как натуральные числа являются только положительными числами");
    }
}
catch
{
    Console.WriteLine("Введите, пожалуйста, целое натуральное число.");
}

