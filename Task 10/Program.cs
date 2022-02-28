int a = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (a!=0)
{
    result *= 10;
    result += a % 10;
    a /= 10;
}
Console.WriteLine(result);