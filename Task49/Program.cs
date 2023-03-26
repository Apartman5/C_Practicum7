// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int Prompt (string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] CreateOutputArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] CreateNewArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            matrix[i, j] = matrix [i,j] * matrix [i,j];
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return matrix;
}

int m = Prompt("Input string");
int n = Prompt("Input columns");
CreateNewArray(CreateOutputArray(m, n));