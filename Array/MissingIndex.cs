using System;

// int[] arr = {1,2,3,4,6,7,8,9,10};

//             MissingIndex mi = new MissingIndex();
//             mi.missingIndex(arr);
class MissingIndex
{
    public void missingIndex(int []arr)
    {
        int sum1 = 0;
        int sum2 =10*11/2;

        foreach (int i in arr)
        {
            sum1 += i;
        }
        Console.WriteLine("Missing Value is {0}", sum2-sum1);
    }
}