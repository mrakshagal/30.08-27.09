//Pervye N chisel Fibonacci.
Console.Clear();
Console.Write("Type the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] Fibonacci(int number)
{
    int[] array= new int[number];
    array[0]= 0;
    array[1]=1;
    for (int i =2; i< number; i++)
    {
        array[i]=array[i-1] + array[i-2];
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i =0; i<array.Length; i ++)
    {
        if (i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}"); 
    }
}
Fibonacci(num);
PrintArray(Fibonacci(num));