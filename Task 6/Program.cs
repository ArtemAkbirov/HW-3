// See https://aka.ms/new-console-template for more information
int n = Convert.ToInt32(Console.ReadLine());
int tmp1 = 1;
int tmp2 = 1;
int result = 0;

for (int i = 3; i <= n; i++)
{
    result = tmp1 + tmp2;
    tmp1 = tmp2;
    tmp2 = result;
}
Console.WriteLine(result);