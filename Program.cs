//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// void InputMatrix(double[,] matrix)
// {
//     Random r = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             matrix[i,j] = r.NextDouble() * 20;
//             Console.Write($"{matrix[i,j]} \t");
//             }
//             Console.WriteLine();
//             }
// }


// Console.Write("Введите размер массива: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// double[,] matrix = new double[size[0], size[1]];
// InputMatrix(matrix);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// void InputMatrix(int[,] matrix)
// {
//     Console.WriteLine("Массив: ");
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             matrix[i,j] = new Random().Next(-10, 10);
//             Console.Write($"{matrix[i,j]} \t");
//             }
//             Console.WriteLine();
//             }
// }

// void FindElement(int[,] matrix, int[] index, int[] size){
//     if (index[0] < 0 || index[0] > size[0] || index[1] < 0 || index[1] > size[1])
//         Console.Write($"Такого элемента нет!");
//     else Console.Write($"Элемент {index[0]} {index[1]} = {matrix[index[0]-1,index[1]-1]}");
// }

// Console.Write("Введите размер массива: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.Write("Введите индекс элемента: ");
// int[] index = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// FindElement(matrix, index, size);

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void InputMatrix(int[,] matrix)
{
    Console.WriteLine("Массив: ");
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(-10, 10);
            Console.Write($"{matrix[i,j]} \t");
            }
            Console.WriteLine();
            }
}

void Count(int[,] matrix,  int[] size){
    for(int k = 0; k < size[1]; k++){
        double sum = 0;
        for(int i = 0; i < size[0]; i++){
            sum+=matrix[i,k];
        }
        Console.Write($"\nСреднне арифмитическое {k+1} столбика = {sum/size[0]}");
    }
}

Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Count(matrix, size);