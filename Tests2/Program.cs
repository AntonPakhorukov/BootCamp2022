void GetAlgoritm2(int n)
{
    for (int k = 0; k < 1000; k++)
    {
        int[,] matrix = new int[n, n]; // матрица
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            { //делаем привязку j к i
                matrix[i, j] = (i + 1) * (j + 1); // заполняем за один ход первую половину матрицы
                matrix[j, i] = (i + 1) * (j + 1); // заполняем за этот же ход вторую половину матрицы
            }
        }
        // for (int i = 0; i < n; i++)
        // {
        //     for (int j = 0; j < n; j++)
        //     {
        //         Console.Write(matrix[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }
    }
}
DateTime dt2 = DateTime.Now;
GetAlgoritm2(5);
Console.WriteLine($"Время второго алгоритма = {(DateTime.Now - dt2).TotalMilliseconds}");