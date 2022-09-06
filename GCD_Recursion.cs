using System;

namespace GCD{
    class prg{
        public static int gcd(int a, int b){
            if(b == 0){
                return a;
            }
            return gcd(b,a%b);
        }
    }
}