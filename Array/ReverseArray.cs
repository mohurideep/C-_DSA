using System;

class Reverse
{
    
static void ReverseArray(int []arr)
        {
            for(int i=0;i<arr.Length/2;i++)
            {
                int temp = arr[i];
                
                arr[i] = arr[arr.Length-i-1];
                arr[arr.Length-1-i] = temp;
                
            }
            foreach(var item in arr)
            Console.WriteLine(item.ToString());
        }
}