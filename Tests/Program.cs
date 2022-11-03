void GetAlgoritm1(int n)
{
    for (int k = 0; k < 1000; k++)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i * j > 9)
                {
                    Console.Write(i * j + "  ");
                }
                else
                {
                    Console.Write(i * j + "   ");
                }
            }
            Console.WriteLine();
        }
    }
}
DateTime dt1 = DateTime.Now;
GetAlgoritm1(5);
    Console.WriteLine($"Время первого алгоритма = {(DateTime.Now - dt1).TotalMilliseconds}");