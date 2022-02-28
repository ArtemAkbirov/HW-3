int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
a = Math.Abs(a);
b = Math.Abs(b);
while (a!=b)
{
    if (a>b)
    {
        a -= b;
    }
    else
    {
        b-= a;
    }
}
Console.WriteLine(a);