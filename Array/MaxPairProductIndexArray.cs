// static void Main(string[] args)
//         {
//             ProductPair p = new ProductPair();
//             int []arr = {40,20,30,50};
//             Console.WriteLine( p.CheckPair(arr));
            
//         }   


class ProductPair
{
    public string CheckPair(int []arr)
    {
        int product=0;
        string pairs = null;

        for(int i=0;i<arr.Length;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[i]*arr[j]> product)
                {
                    product=arr[i]*arr[j];
                    pairs = arr[i].ToString()+" , "+arr[j].ToString();
                }
            }
        }
        return pairs;
    }
}