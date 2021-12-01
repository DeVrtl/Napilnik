namespace Napilnik1
{
    class ExampleTask2
    {
        public static int FindCorrectArrayIndex(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == element)
                    return i;

            return -1;
        }
    }
}
