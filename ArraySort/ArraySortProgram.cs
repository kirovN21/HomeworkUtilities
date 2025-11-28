namespace ArraySort
{
    internal class ArraySortProgram
    {
        static void Main(string[] args)
        {
            //Write a method that finds the biggest element of an array. Use that method to implement sorting in descending order.

            int[] nums = { 1, 2, 3, 4, 5 };
            int[] numsCopy = (int[])nums.Clone(); //I cloned it here so I don't edit the original array values


            for (int i = 0; i < numsCopy.Length; i++)
            {
               
                int max = FindBiggestElementInArray(numsCopy);
                Console.WriteLine(max);
                ExcludeElement(numsCopy, max);

            }

        }
           
        static int FindBiggestElementInArray(int[] array)
        {
            int max = array[0];

            foreach (int element in array)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        static void ExcludeElement(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    array[i] = int.MinValue;
                    break;
                }
            }
        }
    }
}

