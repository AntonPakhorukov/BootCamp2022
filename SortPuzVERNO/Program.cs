/* Сортировка пузырьком:
[3, 1, 5, 0, 7, 9, 8]
[3, 1]
[1, 3, 5, 0, 7, 9, 8]
[3, 5]
[5, 0]
[1, 3, 0, 5, 7, 9, 8]
[1, 0, 3, 5, 7, 9, 8]
[0, 1, 3, 5, 7, 9, 8]
[0, 1, 3, 5, 7, 8, 9]
*/

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("      Начальный массив: " + "[" + string.Join(", ", array) + "]");
for (int i = 0; i < array.Length; i++) {
    for (int j = 0; j < array.Length - 1 - i; j++) { // можно добавить -i, чтобы не проверчл последние макс числа
        if (array[j] > array[j + 1]) {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + " Промежуточный массив: " + "[" + string.Join(", ", array) + "]");
}
Console.WriteLine();
Console.WriteLine("Конечный массив: " + "[" + string.Join(", ", array) + "]");