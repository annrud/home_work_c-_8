Console.Clear();
Console.WriteLine("Программа упорядочивает элементы " +
                  "каждой строки двумерного массива.");
Console.Write("Введите количество строк: ");
int countRows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int countColumns = int.Parse(Console.ReadLine()!);
int[,] array = new int[countRows, countColumns];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();
SortRows(array);
PrintMatrix(array);


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

void SortRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int l = 0; l < matr.GetLength(1) - 1; l++)
        {
            for (int j = 0; j < matr.GetLength(1) - 1 - l; j++)
            {
                if (matr[i, j] < matr[i, j+1])
                {
                    int k = matr[i, j];
                    matr[i, j] = matr[i, j + 1];
                    matr[i, j + 1] = k;
                }
            }
        }
    }
}
