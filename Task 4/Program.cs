// See https://aka.ms/new-console-template for more information
int a = Convert.ToInt32(Console.ReadLine());
int result = 0;

    for (int i = 1; i<a; i++)
    {
        if (a % i == 0)
            {
                result = i;
            }
    }
Console.WriteLine(result);
