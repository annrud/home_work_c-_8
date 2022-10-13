Console.Clear();
Console.WriteLine("Программа выдаёт произведение двух матриц");
Console.Write("Введите количество строк первой матрицы: ");
int countRowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int countColumnsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов второй матрицы: ");
int countColumnsB = int.Parse(Console.ReadLine()!);

int[,] arrayA = new int[countRowsA, countColumnsA];
int[,] arrayB = new int[countColumnsA, countColumnsB];
Console.WriteLine();
FillMatrix(arrayA);
Console.WriteLine("Матрица А:");
PrintMatrix(arrayA);
Console.WriteLine();
FillMatrix(arrayB);
Console.WriteLine("Матрица B:");
PrintMatrix(arrayB);
Console.WriteLine();
int[,] arrayC = MatrixProduct(arrayA, arrayB);
Console.WriteLine("Матрица C:");
PrintMatrix(arrayC);



void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
 
        Console.WriteLine();
    }
}


void FillMatrix(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
}

int[,] MatrixProduct(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            for (int k = 0; k < matrB.GetLength(0); k++)
            {
                matrC[i, j] += matrA[i, k] * matrB[k, j];
            }
        }
    }
    return matrC;
}
