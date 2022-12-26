//Prinimaet poziciu elemnta w massive i govorit est li element

Console.Clear();
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMartix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}
Console.WriteLine("Type number of verse: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type the number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
void FindMatrixElement (int [,] matrix, int n, int m)
{
    
    if (n > matrix.GetLength(0) && m > matrix.GetLength(1) && n <=0 && m <=0) Console.Write("There's no such element");
    else Console.WriteLine($"[{n}, {m}] element is {matrix.GetValue(n-1,m-1)}");
}
int[,] array2d = CreateMatrixRndInt(3,4,1,9);
PrintMartix(array2d);
FindMatrixElement(array2d, n, m);