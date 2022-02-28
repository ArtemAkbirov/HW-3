int a = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (a!=0)
{
    if ((a%10) % 2 != 0)
    {
        result++;
    }
    a/=10;
}
Console.WriteLine(result);