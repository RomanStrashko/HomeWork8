// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

/*Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,columns,-10,10);
PrintArray(array);
Console.WriteLine();

Sort(array);
PrintArray(array);
Console.WriteLine();


void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*int[,] array = GetArray(5, 4, 0, 10);
PrintArray(array);
Console.WriteLine();

int minsum = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    minsum += array[0,i];
}

Console.WriteLine($"Строка с наименьшей суммой -> {FindMinSumRow(array)}");

int FindMinSumRow(int[,] array)
{
    int row = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}*/


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


/*Console.Write("Введите количество строк для 1 массива: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для 1 массива: ");
int columns1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк для 2 массива: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для 2 массива: ");
int columns2 = int.Parse(Console.ReadLine()!);

if (columns1 != rows2)
{
    Console.WriteLine("Массивы умножать нельзя!");
    return;
}

int[,] array1 = GetArray(rows1, columns1, 0, 10);
int[,] array2 = GetArray(rows2, columns2, 0, 10);

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
        Console.Write(array1[i, j] + " ");
    Console.Write(" | | ");
    for (int k = 0; k < array2.GetLength(1); k++)
        Console.Write(array2[i, k] + " ");
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Произведение двух матриц ");
PrintArray(GetCompAraay(array1, array2));

int[,] GetCompAraay(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}



/*int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}*/


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

/*1 Способ
int[,,] array = new int[2, 2, 2] {{{12, 25}, {65, 11}}, {{78, 50}, {99, 83}}};
PrintArray(array);

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}");
                Console.Write($"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}*/

//2 Способ

/*int[,,] array = GetArray(2, 2, 2, 10, 99);
PrintArray(array);



int[,,] GetArray(int m, int n, int t, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, t];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < t; k++)
            {
               int number = new Random().Next(minValue, maxValue + 1);
            
                if (GetNumberArray(result, number) == false)
               {
                   result[i, j, k] = number;
               }
            }
        }
    }
    return result;
}

bool GetNumberArray(int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == num) return true;
            }
        }
    }

    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}");
                Console.Write($"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}*/


/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] array = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    {
        j++;
    }    
  else 
  if (i < j && i + j >= array.GetLength(0) - 1)
    {
        i++;
    }    
  else 
  if (i >= j && i + j > array.GetLength(1) - 1)
    {
        j--;
    }    
  else
    i--;
}

PrintArray(array);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
  










