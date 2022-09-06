using System;

// FindPair fp = new FindPair();
//             int []arr = {2,4,8,9};
//             int[] pos = fp.PairIndexFortarget(arr,10);

//             foreach (int item in pos)
//             {
//                 Console.WriteLine(item);
//             }
class FindPair
{
    public int[] PairIndexFortarget(int[] arr, int target)
    {
        for(int i=0;i<arr.Length;i++)
        {
            for(int j=0;j<arr.Length;j++)
            {
                if(arr[i]+arr[j] == target)
                {
                    return new int[] {i,j};
                }
            }
        }
        throw new ArgumentOutOfRangeException("No Values found");
    }
}