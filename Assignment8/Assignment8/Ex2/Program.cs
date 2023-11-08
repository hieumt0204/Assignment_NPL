namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("The int array before swapping:");
            foreach (int item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            swap<int>(ref intArray, 0, 3);

            Console.WriteLine("The int array after swapping:");
            foreach (int item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            string[] stringArray = new string[] { "Hello", "Mai", "Trong", "Hieu" };

            Console.WriteLine("The string array before swapping:");
            foreach (string item in stringArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            swap<string>(ref stringArray, 1, 2);

            Console.WriteLine("The string array after swapping:");
            foreach (string item in stringArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    
        public static void swap<T>(ref T[] array, int i, int j)
        {
            if (i >= 0 && i < array.Length && j >= 0 && j < array.Length)
            {
                T temp = array[i];

                array[i] = array[j];

                array[j] = temp;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid indices.");
            }
        }
    }
}