// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> ""1, 2, 3, 4, 5""

//M = 4; N = 8. -> ""4, 6, 7, 8""

string OrderOfNumbers(int M, int N)
{
    if(M > N) return "";
    return OrderOfNumbers(M,N-1) + " " + Convert.ToString(N); 
}
try
{

    Console.WriteLine("Введите первое целое натуральное число:");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе целое натуральное число:");
    int N = Convert.ToInt32(Console.ReadLine());
    if(M > 0 && N > 0)
    {
        Console.WriteLine($"Все натуральные числа в промежутке от M до N : {OrderOfNumbers(M,N)}");
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