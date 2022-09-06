using System;
class Matrix
{
    public void InputMatrixx(int [,]arr)
    {
        int n =  arr.GetLength(0);
        for(int layer=0;layer<n/2;layer++)
        {
            int first = layer;
            int last = n-1-layer;
            for(int i=first;i<last;i++)
            {
                int helper=i-first;
                int top= arr[first,i];
                arr[first,i]=arr[last-helper,first];
                arr[last-helper,first]= arr[last,last-helper];
                arr[last,last-helper]= arr[i,last];
                arr[i,last]=top;
            }
        }
    }
    public void Print2DArray(int [,]arr)
    { 
        for(int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr.GetLength(1);j++)
            {
                Console.Write(arr[i,j] +" ");
            }
            Console.WriteLine();
        }
    }
    
}