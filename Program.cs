namespace SecondCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var random = new Random();
                Console.WriteLine("Enter the lower bound for the random number: ");
                var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the upper bound for the random number: ");
                var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());
                if (lowerMaxRandomBound > upperMaxRandomBound)
                {
                    (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
                }
                Console.WriteLine("Enter the size of the array: ");
                var size = Convert.ToInt32(Console.ReadLine());
                var array = new int[size];
                for (var i = 0; i < size; i++)
                {
                    array[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
                }
                Console.WriteLine("Array: ");
                foreach (var element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
                string arrayString = string.Join(" ", array);
                Console.WriteLine("Еnter three numbers to count them in array: ");
                string items = Console.ReadLine();
                int countContains = arrayString.Split(items).Length - 1;
                Console.WriteLine($"This three numbers in array repeats {countContains} times");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
