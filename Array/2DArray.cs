// TwoDArray tw = new TwoDArray(3,3);
//             tw.Insert(0,0,"a");
//             tw.Insert(0,1,"b");
//             tw.Insert(0,2,"c");
            
//             tw.Insert(1,0,"d");
//             tw.Insert(1,1,"e");
//             tw.Insert(1,2,"f");
            
//             tw.Insert(2,0,"g");
//             tw.Insert(2,1,"h");
//             tw.Insert(2,2,"i");

//             tw.Print2DArray();

using System;
class TwoDArray
{
    string [,]arr = null;
    public TwoDArray(int row,int column)
    {
        arr = new string[row,column];
    }
    public void Print2DArray()
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

    public void Insert(int row,int column, string value)
    {
        try
        {
        if(arr[row,column] == null)
        {
            arr[row,column] = value;
            Console.WriteLine("Value Inserted");
        }
        else
        Console.WriteLine("Value already Exist at this Index");
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Array Index not in scope");
        }

    }

    public void AccessCell(int row, int column)
    {
        try{
            
        Console.WriteLine("Accessing Row {0} & column {1} : Cell Value {2}",row,column,arr[row,column]);
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Incorrect Array Index");
        }
    }

    public void Search(string value)
    {
        for(int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr.GetLength(1);j++)
            {
                if(arr[i,j] == value)
                {
                Console.WriteLine("Value found at index {0},{1}",i,j);
                return;
                }
            }
        }
        Console.WriteLine("Value Not foound");
    }
}