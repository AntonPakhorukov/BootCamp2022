// Быстрая сортировка через void

int[] array = { 3, 5, -2, 7, -3, 1, 0, 9 };

Console.WriteLine($"Первичный массив " + "[" + String.Join(", ", array) + "]");
void QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return;
    // int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
    // {
    //     int pivotIndex = minIndex - 1;
    //     for (int i = minIndex; i <= maxIndex; i++)
    //     {
    //         if (inputArray[i] < inputArray[maxIndex])
    //         {
    //             pivotIndex++;
    //             Swap(ref inputArray[i], ref inputArray[pivotIndex]);
    //         }
    //     }
    //     pivotIndex++;
    //     Swap(ref inputArray[pivotIndex], ref inputArray[maxIndex]);
    //     return pivotIndex;
    // }
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(ref inputArray[i], ref inputArray[pivotIndex]);
        }
    }
    pivotIndex++;
    Swap(ref inputArray[pivotIndex], ref inputArray[maxIndex]);
    return pivotIndex;
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
void Swap(ref int leftValue, ref int rightValue)
{
    int temp = leftValue;
    leftValue = rightValue;
    rightValue = temp;
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
QuickSort(array, 0, array.Length - 1);
Console.WriteLine($"Отсортированный массив " + "[" + String.Join(", ", array) + "]");