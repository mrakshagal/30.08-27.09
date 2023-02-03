
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of strings: ");
            int n = int.Parse(Console.ReadLine());

            string[] strings = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter string " + (i + 1) + ": ");
                strings[i] = Console.ReadLine();
            }

            string[] shortStrings = GetShortStrings(strings);

            Console.WriteLine("Strings with length less than or equal to 3:");
            foreach (string shortString in shortStrings)
            {
                Console.WriteLine(shortString);
            }
        }

        static string[] GetShortStrings(string[] strings)
        {
            int count = 0;
            foreach (string str in strings)
            {
                if (str.Length <= 3)
                {
                    count++;
                }
            }

            string[] shortStrings = new string[count];
            int index = 0;
            foreach (string str in strings)
            {
                if (str.Length <= 3)
                {
                    shortStrings[index] = str;
                    index++;
                }
            }

            return shortStrings;
        }
    }
}

