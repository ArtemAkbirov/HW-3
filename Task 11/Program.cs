Console.Write("Введите число число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 0)
{
    Console.WriteLine("Вы ввели число равное нулю или меньше");
    return;
}

if (N % 2 == 0)
{
    for (int i = 0; i <= N; i++)
    {
        Console.WriteLine(i);
    }
}
else
{
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine(i);
    }
}
