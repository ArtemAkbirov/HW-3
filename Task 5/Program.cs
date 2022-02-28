// See https://aka.ms/new-console-template for more information
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (b < a)
{
    for (int i = b; i <= a; i++)
    {
        if (i > b && i < a && i % 7 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
else 
{ 
     for (int i = a; i <= b; i++)
     {
         if (i>a && i<b && i%7==0)
         {
            Console.WriteLine(i);
         }
     }
}

