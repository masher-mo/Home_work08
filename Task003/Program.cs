/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 7); 
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("Введите размеры матриц: ");
int[,] matrixZ = new int[size, size];
int[,] matrixY = new int[size, size];
FillArrayRandomNumbers(matrixZ);
FillArrayRandomNumbers(matrixY);
int[,] matrixN = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int m = 0; m < size; m++)
        {
            matrixN[i, j] = matrixN[i, j] + (matrixZ[i, m] * matrixY[m, j]);
        }
    }
}
Console.WriteLine("Матрица - Z");
PrintArray(matrixZ);
Console.WriteLine();
Console.WriteLine("Матрица - Y");
PrintArray(matrixY);
Console.WriteLine();
Console.WriteLine("Произведение матриц Z*Y");
PrintArray(matrixN);

