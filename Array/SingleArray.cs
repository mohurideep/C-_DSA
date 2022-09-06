using System;
class SingleArray
{
     public int []arr=null;
    public SingleArray(int sizeOfArray)
    {
        arr=new int [sizeOfArray];
        for(int i=0;i<arr.Length;i++)
        {
            arr[i]=Int32.MinValue;
            
        }
    }
    public void Insert(int position, int value)
    {
        try{
            if(arr[position] == Int32.MinValue)
        {
            arr[position] = value;
            Console.WriteLine("Value Inserted");
        }
        else
        {
            Console.WriteLine("Index is already fulled.");
        }
        }catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Index value outside of the range of array");
        }
    }

    public void Search(int value)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i].Equals(value))
            {
                Console.WriteLine("value is present at index {0}",i);
                
            return;
            }
        }
        Console.WriteLine("Item is not present");
    }

    public void Delete(int value)
    {
        
    }
}