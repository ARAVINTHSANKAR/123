using System;

namespace day_3
{
   public class Overloading
    {
        public void convert(String a , String b)
        {
            //int sum = a + b;
            Console.WriteLine(a +" " + b);
        } 
        public void convert(int a , int b , int c)
        {
            string st1 = Convert.ToString(a);
            string st2 = Convert.ToString(c);
            string st3 = Convert.ToString(b);
            String sum = st1 + st2 + st3;
            Console.WriteLine(sum);
        }
    } 
}

