// See https://aka.ms/new-console-template for more information
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (b < a)
{
    int t = a;
    a = b;
    b = t;
}

     for (int i = a; i <= b; i++)
     {
         if (i%7==0)
         {
            result += i;
        }
     }

Console.WriteLine(result);
