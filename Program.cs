﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+"\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArrayDescending(int[,] array){
    int swap=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                if(array[i,j]<array[i,l]){
                    swap=array[i,l];
                    array[i,l]=array[i,j];
                    array[i,j]=swap;
                }
            }
        }
        
    }
}

// int row=10;
// int columns=10;
// int[,]matrix=GetArray(row,columns);
// PrintArray(matrix);
// System.Console.WriteLine();
// PrintArrayDescending(matrix);
// PrintArray(matrix);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void SmallesAmountLine(int[,] array){
    int lineSumFirst=int.MaxValue;
    int smallerLineNumber=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int lineSumSecond=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            lineSumSecond=lineSumSecond+array[i,j];

        }
        if(lineSumFirst>=lineSumSecond){
            lineSumFirst=lineSumSecond;
            smallerLineNumber=i+1;
        }
    }
    System.Console.WriteLine("Наименьшая строка под номером {0}",smallerLineNumber);
}
int row=3;
int columns=3;
int[,]matrix=GetArray(row,columns);
PrintArray(matrix);
System.Console.WriteLine();
SmallesAmountLine(matrix);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49




// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)



// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7