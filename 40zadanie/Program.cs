// Prinimaet tri chisla i proveriaet mozhet li exist trójkąt so storonami that dliny 
Console.Clear();
Console.Write("Type the number of the first side: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Type the nimber of the second side: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Type the number of the third side: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a+b>c && a+c>b && c+b>a) Console.Write("This triangle can exist!");
else Console.Write("Try another numbers!");