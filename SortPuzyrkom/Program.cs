/*
Сортировка методом выбора:

[6, 15, 2, 9, -3]
min = 6
6 -> 15, 6 < 15
6 -> 2, 6 > 2
min = 2
2 -> 9, 2 < 9
2 -> -3, 2 > -3
min = -3
[-3, 6, 15, 2, 9]
[6, 15, 2, 9]
min = 6
6 < 15
6 > 2
min = 2
2 < 9
[-3, 2, 6, 15, 9]
min = 6
6 < 15
6 < 9
[-3, 2, 6, 15, 9]
min = 15
15 > 9
[-3, 2, 6, 9, 15]
*/
/*
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
// Заполнение массива
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("[" + String.Join(", ", array) + "]");
Console.WriteLine();
// Сортировка массива
for (int j = 0; j < n - 1; j++)
{
    int minIndex = j;
    for (int k = j + 1; k < n; k++)
    {
        if (array[k] < array[minIndex]) {
            minIndex = k;
        }
        int temp;
        temp = array[minIndex];
        array[minIndex] = array[j];
        array[j] = temp;
    }
}
Console.WriteLine("[" + String.Join(", ", array) + "]");
*/

/*
char[] array = new char[5];
for (int i = 0; i < 5; i++)
{
    array[i] = Convert.ToChar(Console.Read());
}
Console.WriteLine("[" + String.Join("", array) + "]");
*/

string[] array = new string[5];
for (int i = 0; i < 5; i++)
{
    array[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine();
// Сортировка массива
for (int j = 0; j < 4; j++)
{
    int minIndex = j;
    for (int k = j + 1; k < 5; k++)
    {
        if (array[k].Length < array[minIndex].Length) {
            minIndex = k;
        }
        string temp;
        temp = array[minIndex];
        array[minIndex] = array[j];
        array[j] = temp;
    }
}
Console.WriteLine("[" + string.Join(", ", array) + "]");