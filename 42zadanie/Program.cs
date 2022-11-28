// Desyatichnoe chislo w dwoichnoe
Console.Clear();
int num = default;
Console.Write("Type the number: ");
// Ниже мы проверяем число на подходяшее. Знак восклицательный обозначает (не равно). Если введенное число является подходящим, то наш нам заменяется на число, введенное юзером
while (!int.TryParse(Console.ReadLine(), out num)) 
{
    Console.Write("Error. Type integer number:");
}
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
Console.Write(ConvertNumber(num));