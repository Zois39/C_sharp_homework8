// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] CreateRandom2DArray ()
{
    int[,] array = new int [new Random().Next(10), new Random().Next(10)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(10);
    return array;
}

int[,] SortRows2DArray (int[,] array)
{
    int temp;
    for (int j = 0; j < array.GetLength(0); j++)
        for (int k = 1; k < array.GetLength(1); k++)
            for (int i = 1; i < array.GetLength(1); i++)
                if (array[j, i] > array [j, i  - 1])
                {
                    temp = array[j, i];
                    array[j, i] = array [j, i  - 1];
                    array [j, i  - 1] = temp;
                }
    return array;
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
Show2DArray(SortRows2DArray(newArray));
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] CreateRandom2DArray ()
{
    int[,] array = new int [new Random().Next(10), new Random().Next(10)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(10);
    return array;
}

int FindRowMinSum (int[,] array)
{
    int result = 0;
    int sumMin = 0;
    int sumCurr = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        sumMin += array[0, j];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumCurr += array[i, j];
        if (sumCurr < sumMin)
        {
            sumMin = sumCurr;
            result = i;
        }
        sumCurr = 0;
    }
    return result;
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
Console.Write(FindRowMinSum(newArray));
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int[,] CreateRandom2DArray (int m, int n)
{
    int[,] array = new int [m, n];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(10);
    return array;
}

int[,] MatrixProduct (int[,] arrA, int[,] arrB)
{
    int[,] result = new int [arrA.GetLength(1), arrB.GetLength(0)];
    for (int i = 0; i < result.GetLength(1); i++)
        for (int j = 0; j < result.GetLength(0); j++)
            for (int k = 0; k < result.GetLength(1); k++)
                result[i, j] += arrA[i, k] * arrB [k, j];
    return result;
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = new Random().Next(5);
int n = new Random().Next(5);
int[,] matrixA= CreateRandom2DArray(m, n);
int[,] matrixB = CreateRandom2DArray(n, m);

Show2DArray(matrixA);
Show2DArray(matrixB);
Show2DArray(MatrixProduct(matrixA, matrixB));
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int[,,] CreateRandom3DArray()
{
    int[,,] result = new int [2, 2, 2];
    int[] uniqValue = new int[90];
    int value;
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(0); j++)
            for (int k = 0; k < result.GetLength(0); k++)
            {
                do
                    value = new Random().Next(10, 100);
                while (value == uniqValue[value - 10]);
                uniqValue[value - 10] = value;
                result[i, j, k] = value;
            }
    return result;
}

void Show3DArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
            Console.Write($"{array[i, j, k]} {(i, j, k)}    ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
Show3DArray(CreateRandom3DArray());
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void SpiralArray(int[,] arr, int i, int j, int k)
{
    if (arr[i, j] == 0)
      arr[i, j] = k;
      k++;
    if (j - 1 > 0)
        if (arr[i, j - 1] == k - 1)
            if (j + 1 < arr.GetLength(1))
                if (arr[i, j + 1] == 0)
                    SpiralArray(arr, i, j + 1, k);
                else if (arr[i + 1, j] == 0)
                    SpiralArray(arr, i + 1, j, k);
    if (i - 1 > 0)
        if (arr[i - 1, j] == k - 1)
            if (i + 1 < arr.GetLength(0))
                if (arr[i + 1, j] == 0)
                    SpiralArray(arr, i + 1, j, k);
                else if (arr[i, j - 1] == 0)
                    SpiralArray(arr, i, j - 1, k);
    if (j + 1 < arr.GetLength(1))
        if (arr[i, j + 1] == k - 1)
            if (j - 1 > 0)
                if (arr[i, j - 1] == 0)
                    SpiralArray(arr, i, j - 1, k);
                else if (arr[i - 1, j] == 0)
                    SpiralArray(arr, i - 1, j, k);
    if (i + 1 < arr.GetLength(0))
        if (arr[i + 1, j] == k - 1)
            if (i - 1 > 0)
                if (arr[i - 1, j] == 0)
                    SpiralArray(arr, i - 1, j, k);
                else if (arr[i, j + 1] == 0)
                    SpiralArray(arr, i, j + 1, k);
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < 10)
                Console.Write("0" + array[i, j] + " ");
            else
                Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] newArray = new int[6, 6];
SpiralArray(newArray, 0, 0, 1);
Show2DArray(newArray);