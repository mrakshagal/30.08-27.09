// Desyatichnoe chislo w dwoichnoe
Console.Clear();
Console.WriteLine("Type the number: ");
int a = Convert.ToInt32(Console.ReadLine());

int ConvertNumber(int num)
{
    int result = default;
    int count = 1;
    while (num !=0)
    {
        result = (num%2)*count +result;
        num/=2;
        count*=10;
    }
    return result; 
}
Console.Write(ConvertNumber(a));