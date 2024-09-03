

static class Program
{
    static void Main(string[] args)
    {
        int[] ints = { 10, 1, 2, 3 };
        //Console.WriteLine(FindTwoBiggestNumbers(ints));
        SelectionSort(ints);
        PrintAllArray(ints);
        Console.WriteLine(SumOfDigits(531));
        Console.WriteLine(Power(3, 3));
    }

    static void PrintAllArray(int[] ints)
    {
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i]);
        }
    }
    static int OddSum(int[] Array)
    {
        //1
        int sum = 0;
        //       1               n          n + 1
        for (int i = 0; i < Array.Length; i++)
        {
            //1 * n   1 * n  1 * n   1 * n  1 * n
            if (Array[i] % 2 != 0) sum += Array[i];

        }
        //  1
        return sum;
        //6 n + 4
    }

    //static int OddSum2(int[] Array)
    //{
    //    // 1
    //    int sum = 0;
    //    //              n
    //    foreach (int i in Array) {
    //    {
    //          //1 * n  1 * n      1 * n
    //        if (i % 2 != 0) sum += i;

    //    }
    //    //  1
    //    return sum;
    //        // 4 n + 2
    //}


    static int FindTwoBiggestNumbers(int[] Array)
    {
        //1
        int sum = 0;
        //1
        int MaxValue = 0;
        int ThisNum = 0;
        int NextNum = 0;
        //        1            n           n     n+1
        for (int i = 0; i < Array.Length - 1; i++)
        {
            //    2
            ThisNum = Array[i];
            //      3
            NextNum = Array[i + 1];
            //    2
            if (ThisNum + NextNum > MaxValue)
            {
                //       1
                MaxValue += ThisNum;
                //       1
                MaxValue += NextNum;
            }

        }
        // 1
        return MaxValue;
        // 14 n + 4
    }

    static int FindIndexNum(int[] Array, int num)
    {
        int low = 0;
        int high = Array.Length;
        int middle = high / 2;

        while (low < high)
        {
            if (num > Array[middle]) low = middle;
            if (num < Array[middle + 1]) high = middle + 1;
            if (num == Array[middle + 1]) return middle;
        }
        return middle;
    }

    //static int FindBiggestTripel(int[] Array)
    //{
    //    int sum = 0;
    //    int MaxValue = 0;


    //}

    static int FindPair(int[] ints, int product)
    {
        for (int i = 0; i < ints.Length / 2 + 1; i++)
        {
            for (int j = ints.Length; j > 0 / 2 + 1; j--)
            {
                if (ints[i] * ints[j] == product) return 1;
            }
        }
        return 0;
    }

    static int FindCloserAndLastPair(int[] ints, int product)
    {
        int sum = 0;
        int currentNum = 0;
        int nextNum = 0;
        for (int i = ints.Length; i > 0; i--)
        {
            currentNum = ints[i];
            nextNum = ints[i + 1];
            if (currentNum * nextNum == product) return i;
        }
        return 0;
    }

    static int RecursionMultiply(int a, int b)
    {
        if (b == 0) return 0;
        return RecursionMultiply(a , b - 1) + a;
    }

    static int SumOfDigits(int number)
    {
        if (number < 10) return number;
        return SumOfDigits(number / 10) + number % 10;
    }

    static int Power(int a, int b)
    {
        if (b == 0) return 1;
        return Power(a, b - 1) * a;
    }

    //static int Reversed(int num)
    //{
    //   if (num < 10) return num;

    //    return Reversed(num / 10) 
    //}

    static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min]) min = j;
            }
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
    }


    //static int InsertSort(int[] array)
    //{
    //    for (int i = 1; i < array.Length; i++)
    //    {
    //        if (array[i] > array[i - 1] && array[i] < array[i + 1]) break;

    //        while (array[i]! >= array[i - 1])
    //        {




    //        }
    //    }
    //}


    static void buobleSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            bool flag = false;

            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    flag = true;
                }
            }
            if (!flag) break;
        }



    }
}