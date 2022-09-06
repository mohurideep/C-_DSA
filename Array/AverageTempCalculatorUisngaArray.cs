using System;

//   {
//       inside main method
//       Console.WriteLine("Please Enter Total No. of Days of Temperature");
//             int days =Convert.ToInt32(Console.ReadLine());
//             AverageTemp average = new AverageTemp(days);
//             for(int i=0;i<days;i++)
//             {
//                 Console.WriteLine("Please Enter the Max Temp for Day {0}",i+1);
//                 int ipTemp = Convert.ToInt32(Console.ReadLine());
//                 average.InsertTemp(i,ipTemp);
//             }
//             Console.WriteLine("Average Temperature for {0} days is {1}",days,average.CalculateTemp());
//             Console.WriteLine("{0} Temperature is above Average Temperature",average.AboveAverage());
//   }
class  AverageTemp
{
    int[] Temp=null;
    public AverageTemp(int size)
    {
        Temp=new int[size];
    }

    public void InsertTemp(int index,int InsertTemp)
    {
        
            Temp[index] = InsertTemp;
    }
    public double CalculateTemp()
    {
        double avgTemp =0;
        for(int i=0;i<Temp.Length;i++)
        {
            avgTemp += Temp[i];
        }
        return avgTemp/Temp.Length;
    }

    public int AboveAverage()
    {
        for(int i=0;i<Temp.Length;i++)
        {
            if(Temp[i]> CalculateTemp())
            {
                return Temp[i];
            }
        }
        return 0;
    }
}