Console.Clear();
int num = new Random().Next(100, 1000);
// int firstdigit = number / 100
// int thirddigit = number % 10
int MaxDigit(int num1)
{
    int firstdigit= num1 / 100 * 10;
    int seconddigit= num1 % 10;
    return firstdigit + seconddigit;
}
int result = MaxDigit(num);
Console.WriteLine($"{num}->{result}");



