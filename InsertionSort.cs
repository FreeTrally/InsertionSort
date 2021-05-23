namespace InsertionSort
{
    static class InsertionSort
    {
        public static SortComplexity Sort(int[] array)
        {
            var memoryCount = 0;
            var timeCount = 0;

            int current;
            memoryCount++;

            int compareIndex;
            memoryCount++;

            for (var i = 1; i < array.Length; i++)
            {
                memoryCount++;
                current = array[i];
                compareIndex = i - 1;

                timeCount++;
                while (compareIndex >= 0 && array[compareIndex] > current)
                {
                    timeCount++;
                    array[compareIndex + 1] = array[compareIndex];
                    compareIndex--;
                }

                array[compareIndex + 1] = current;
            }

            return new SortComplexity(memoryCount, timeCount);
        }

        public static SortComplexity SortString(string[] array)
        {
            var memoryCount = 0;
            var timeCount = 0;

            string current;
            memoryCount++;

            int compareIndex;
            memoryCount++;

            for (var i = 1; i < array.Length; i++)
            {
                memoryCount++;
                current = array[i];
                compareIndex = i - 1;

                timeCount++;
                while (compareIndex >= 0 && string.Compare(array[compareIndex], current) > 0)
                {
                    timeCount++;
                    array[compareIndex + 1] = array[compareIndex];
                    compareIndex--;
                }

                array[compareIndex + 1] = current;
            }

            return new SortComplexity(memoryCount, timeCount);
        }
    }

    public class SortComplexity
    {
        public int Memory { get; private set; }
        public int Time { get; private set; }

        public SortComplexity(int memory, int time)
        {
            Memory = memory;
            Time = time;
        }
    }
}
