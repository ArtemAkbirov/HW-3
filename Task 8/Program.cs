int cub = Convert.ToInt32(Console.ReadLine());
int left = 0;
int right = cub;
int centr = 0;

if (cub < 0)
{
    Console.WriteLine("Было введено отрицатеельное число");
}

do
{
    centr = (left + right) / 2;
    if (Math.Pow(centr, 3) < cub)
    {
        left = centr;
    }
    else
    {
        right = centr;
    }
}
while (Math.Pow(centr, 3) != cub);

Console.WriteLine(centr);