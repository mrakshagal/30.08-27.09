int [] CreateArrayRndInt (int size, int min, int max)
{
int[] array = new int [size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i]= rnd.Next(min,max+1);
}
return array;
}

void PrintArray (int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if(i< array.Length-1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
}
Console.Write("]");
}

int[] GetSumPosNegElem(int[] array)
{
int SumNeg= 0;
int SumPos = 0;
for( int i= 0; i< array.Length; i ++)
{
    if(array[i]<0) SumNeg += array[i];
    else SumPos += array[i];
}
return new int[]{SumNeg, SumPos};
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
Console.WriteLine();
int[] result= GetSumPosNegElem(arr);
Console.WriteLine($"The summary of negative digits= {result[0]}");
Console.WriteLine($"The summary of positive digits= {result[1]}");

