namespace ConsoleApp1
{
    internal class Program
    {
        const int NUM_OF_NUMS = 15;
        const int NUM_OF_RESULTS = 4;
        static void Main(string[] args)
        {
            int[] result = new int[NUM_OF_RESULTS];
            result = FillArray(result);
            result = PickNFromNumberSequence();
            PrintResults(result);
        }

        static int[] PickNFromNumberSequence()
        {
            int[] result = new int[NUM_OF_RESULTS];
            Random rnd = new Random();
            int i = 0;
            while (i < NUM_OF_RESULTS)
            {
                int choose = rnd.Next(1, NUM_OF_NUMS + 1);
                bool matched = CheckMatched(result, choose);
                if (!matched)
                {
                    result[i] = choose;
                    i++;
                }
            }
            return result;
        }

        static int[] FillArray(int[] array)
        {
            for (int i = 0; i< array.Length; i++)
            {
                array[i] = 0;
            }
            return array;
        }

        static bool CheckMatched(int[] array, int n) {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    return true;
                }
            }
            
            return false;
        }

        static void PrintResults(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}