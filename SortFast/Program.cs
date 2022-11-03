/*
1. [1, 0, -6, 2, 5, 3, 2]
2. берем точку опоры (последний индекс): arr[6] = pivot (опорный элемент, берем или первый или последний)
3. Вызвать шаги 1,2 для массива слева от pivot и справа от pivot
4. Берем Pivot = 2, [1, 0, -6, 2] - уже отсортирован
5. Берем Pivot = -6 [1, 0, -6] -> [-6, 1, 0] 
6. Берем Pivot = 0 [1. 0] -> [0, 1]
7. Таким образом [-6, 0, 1, 2]
*/
Console.Clear();
int[] array = {0, -5, 2, 3, 5, 9, -1, 7};
Console.WriteLine($"Первичный массив [{String.Join(", ", array)}]");
int[] res = QuickSort(array, 0, array.Length - 1);
Console.Write($"Отсортированный массив [{String.Join(", ", res)}]");

int[] QuickSort(int[] inputArray, int minIndex, int maxIndex) {
    if (minIndex >= maxIndex) return inputArray;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return inputArray;
}
int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex){
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++) {
        if (inputArray[i] < inputArray[maxIndex]) {
            pivotIndex++;
            //Swap(ref inputArray[pivot], ref inputArray[i]);
            Swap(inputArray, i, pivotIndex);
        }
    }
    pivotIndex++;
    Swap(inputArray, pivotIndex, maxIndex);
    return pivotIndex;
}
// void Swap (ref int leftValue, ref int rightValue) {
//     int temp = leftValue;
//     leftValue = rightValue;
//     rightValue = temp;
// }
void Swap (int[] inputArray, int leftValue, int rightValue) {
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}