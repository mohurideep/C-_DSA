using System;

namespace DToC{
    class DecToBin
    {
        public static int func(int n){
            if(n < 0)
            {
                return -1;
            }
            if(n==0)
            {
                return 0;
            }
            return n%2 + 10*func(n/2);
        }
    }
}