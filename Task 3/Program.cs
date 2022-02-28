// See https://aka.ms/new-console-template for more information
int a = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (a<0)
{
    Console.WriteLine("Вы ввели отрицательное число!!");
}
else
{
    for (int i = 1; i*i < a; i++)
    {
        result++;
    }
    Console.WriteLine(result);
}
