namespace Assignment_5._2._3
{
    class Program
    {
        static void PrintNumbersDescending(int n)
        {
            if (n <= 0)
                return; 
           
            Console.Write($"{n} ");

            PrintNumbersDescending(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("How many numbers to print: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Numbers from " + n + " to 1: ");
            PrintNumbersDescending(n);
            Console.WriteLine(); 
        }
    }
}