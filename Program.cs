namespace SecondCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var random = new Random(DateTime.Now.Millisecond);
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

                Console.WriteLine("Enter the number to find the elements that are less than it: ");
                var lessThanNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Elements that are less than the given number: ");
                foreach (var element in array)
                {
                    if (element < lessThanNum)
                    {
                        Console.Write(element + " ");
                    }
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
