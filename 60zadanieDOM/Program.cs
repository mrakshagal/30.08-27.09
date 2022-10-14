Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Введите размер трехмерного массива: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"В`ведите длину массива (X): ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите высоту массива (Y): ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите глубину массива (Z): ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int content = x * y * z;
if (content > 90)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Элементов в массиве больше, чем уникальных натуральных двузначных чисел");
}
else
{
    int[,,] resultCoub = CreateCoubUniqueTwoDigitNumber(x, y, z, 10);
    Console.ForegroundColor = ConsoleColor.Green;
    PrintCoub(resultCoub);
}

int[,,] CreateCoubUniqueTwoDigitNumber(int rows, int columns, int depth, int num)
{
    int[,,] coub = new int[rows, columns, depth];
    for (int i = 0; i < coub.GetLength(0); i++)
    {
        for (int j = 0; j < coub.GetLength(1); j++)
        {
            for (int k = 0; k < coub.GetLength(2); k++)
            {
                coub[i, j, k] = num++;
            }

        }

    }
    return coub;
}

void PrintCoub(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ");
                Console.Write($"({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}