using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    public static class IntExtension
    {
        //Extension Method
        public static int Reverse(this int Number)
        {
            int ReversedNumber = 0 , LastDigit;
            
            while(Number > 0)
            {
                LastDigit = Number % 10;
                ReversedNumber = ReversedNumber * 10 + LastDigit;
                Number /= 10;



            }
            return ReversedNumber;
        }
    }
}
