namespace printing_diamond_with_nested_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of lines for the upper half of the diamond: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                    Console.Write(" ");
                for (int j = 0; j < 2 * i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 0; j < n - i - 1; j++)
                    Console.Write(" ");
                for (int j = 0; j < 2 * i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
