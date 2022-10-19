// Знакомство с двумерными массивами

// Программа
int[,] matrix = new int [3,4];
FillMatrix(matrix);
PrintMatrix(matrix);


// Методы
void PrintMatrix (int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"{A[i,j]} | ");
        }
        Console.WriteLine();
    }
}

void FillMatrix (int[,] B)
{
    for (int i = 0; i < B.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            B[i,j]=new Random().Next(1,10);
        }
    }
}