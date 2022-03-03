// See https://aka.ms/new-console-template for more information


// Input: N = 5 Arr[] = { 2, 3, 4, 5, 1 } Output: 5 1 2 3 4
int[] array = new int[5] { 2, 3, 4, 5, 1 };

    var result = InversePermutation(array, array.Length);

    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
    
    static int[] InversePermutation(int[] array, int n)
    {
        
        if (n <= 0)
        {
            return new int[0];
        }
        else if (n == 1)
        {
            return array;
        }
        else
        {
            int[] inversePermutation = new int[n];

            for (int i = 0; i < n; i++)
            {
                int position = array[i];
                inversePermutation[position - 1] = n - (n - 1 - i);
            }
            return inversePermutation;
        }
    }