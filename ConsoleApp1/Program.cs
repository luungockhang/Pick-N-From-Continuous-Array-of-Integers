namespace ConsoleApp1
{
    internal class Program
    {
        const int ARRAY_SIZE = 15; // Size of Array, counts from 1
        const int NUM_OF_RESULTS = 4; // Number of Results
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
                int choose = rnd.Next(1, ARRAY_SIZE + 1);
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
            Console.WriteLine($"Choosing {NUM_OF_RESULTS} from 1 to {ARRAY_SIZE}");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}