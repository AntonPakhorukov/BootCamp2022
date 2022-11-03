Console.Clear();
// Пример 1:

// int n = 5;
// int[] array = new int[n];
// //for (int i = 0; i < n; i++) {
//     array[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("[" + String.Join(", ", array) + "]");
//Console.WriteLine(array[3]);
// Сложность алгоритма "О - Натация" - количество действий, чтобы узнать конечный результат
// [4, 5, 3, 1, 2] - какое количесвто операций отребуется для определения суммы чисел в масииве? -> 5, или O(n) или O(5)
// [1, 2, 3, 4, 5] = O(n * log n) -> означает, что мы отсортировали с помощью быстрой сортировки и время работы быстрой сортировки принято обозначать (n * log n)
// ((5 + 1) / 2) * 5 = O(1)
// int summa = 0;
// for  (int i = 0; i < n; i++) {
//     summa += array[i];
// }
//Console.WriteLine(summa);

// Пример 2:

Console.Clear();
int n2 = Convert.ToInt32(Console.ReadLine());
// DateTime dt = DateTime.Now;
// for (int i = 1; i <= n2; i++) {
//     for (int j = 1; j <= n2; j++) {
//         if (i * j > 9) {
//             Console.Write(i * j + "  ");
//         } else {
//             Console.Write(i * j + "   ");
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"Время первого алгоритма = {(DateTime.Now - dt).TotalMilliseconds}");
Console.WriteLine();
DateTime dt2 = DateTime.Now;
int[,] matrix = new int [n2,n2]; // матрица
for (int i = 0; i < n2; i++) {
    for (int j = i; j < n2; j++) { //делаем привязку j к i
            matrix[i,j] = (i + 1) * (j + 1); // заполняем за один ход первую половину матрицы
            matrix[j,i] = (i + 1) * (j + 1); // заполняем за этот же ход вторую половину матрицы
    }
}
for (int i = 0; i < n2; i++) {
    for (int j = 0; j < n2; j++) {
            Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Время второго алгоритма = {(DateTime.Now - dt2).TotalMilliseconds}");
Console.WriteLine();
DateTime dt3 = DateTime.Now;
for (int i = 1; i <= n2; i++) {
    for (int j = 1; j <= n2; j++) {
        if (i * j > 9) {
            Console.Write(i * j + "  ");
        } else {
            Console.Write(i * j + "   ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Время третьего алгоритма = {(DateTime.Now - dt3).TotalMilliseconds}");
