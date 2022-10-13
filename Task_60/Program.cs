Console.Clear();
Console.WriteLine("Программа выдаёт трёхмерный массив.");
Console.Write("Введите размер m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер z: ");
int z = int.Parse(Console.ReadLine()!);
int[,,] table = new int[m, n, z];
Console.WriteLine();
FillMatrix(table);
PrintArray(table);

void FillMatrix(int[,,] matrix)
{
    Random rand = new Random();
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            for (int k =0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rand.Next(10, 100);
            }
        }
    }
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k =0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
