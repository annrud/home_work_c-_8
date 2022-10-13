Console.Clear();
Console.WriteLine("Программа выдаёт номер строки " +
                  "с наименьшей суммой элементов " +
                  "(нумерация строк с 0)");
Console.Write("Введите количество строк: ");
int countRows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int countColumns = int.Parse(Console.ReadLine()!);
int[,] array = new int[countRows, countColumns];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();
int result = RowWithMinSum(array);
Console.WriteLine(
    "Номер строки с минимальной суммой " +
    $"значений: {result}"
);


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


int RowWithMinSum(int[,] matr)
{
    int row = 0;
    int sumMin = 0;
    int sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sumMin += matr[0, j];
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        if (sum < sumMin)
        {
            sumMin = sum;
            row = i;
        }
        sum = 0;
    }

    return row;
}
