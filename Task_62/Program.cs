Console.Clear();
Console.WriteLine("Программа выдаёт заполненный спирально " +
                  "двухмерный массив.");
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[,] array = new int[size, size];
Console.WriteLine();
FillSpirallyMatrix(array);
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


void FillSpirallyMatrix(int[,] matr)
{
    int i = 0;
    int j = 0;
    int n = matr.GetLength(0);
    for (int k = 1; k <= n*n; k++)
    {
        matr[i, j] = k;
        if (i <= j + 1 && i + j < n - 1) j++;
        else if (i < j && i + j >= n - 1) i++;
        else if (i >= j && i + j > n - 1) j--;
        else if (i > j+1 && i + j <= n - 1) i--;

    }
}    
              