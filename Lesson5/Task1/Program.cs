// Вычислить факториал от натурального
// числа N рекурсивным методом.

int Fact(int n)
{
    if (n == 1 || n == 0)
    {

        //отладочный вывод на экран
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1); // нельзя стаивть !, поэтому функция Fact, так как в C# это совсем другое значение
}

Console.Write(Fact(5));