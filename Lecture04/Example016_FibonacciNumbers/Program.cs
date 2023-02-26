// Выводим числа Фибоначчи

double Fibonacci(int n)
{
    if (n == 1) return 0;
    else if (n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"{i} = {Fibonacci(i)}");
}