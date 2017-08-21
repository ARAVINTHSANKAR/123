using System;

namespace day_1
{
    public class fibonacci
    {
       public void fibo() 
        {
             Console.WriteLine("Enter the limit");
             int limit = 12;
             Console.WriteLine(limit);

             Console.WriteLine("0");
             Console.WriteLine("1");

             int[] array = new int[100];
             array[0] = 0;
             array[1] = 1;

             int i;
            for (i = 2 ; i <= limit ; i++)
            {
                array[i] = array[i-1] + array[i-2];
                Console.WriteLine(array[i]);
            }

            String[] words ={"zero" , "one" , "two" , "three" , "four" , "five" ,
                             "six" , "seven" , "eight" , "nine" , "ten" ,
                             "eleven" , "twelve" , "thirteen" , "fourteen" ,
                              "fifteen" , "sixteen" , "seventeen" , "eighteen" , "ninteen" , "twenty"}; 
            String[] tens = {"", "", "twenty","thirty" , "fourty", "fifty", "sixty" , "seventy" , "eightty" , "ninety" };
            String[] hundreds = {"", "one hundred", "two hundred","three hundred" , "four hundred", "five hundred", "six hundred" , "seven hundred" , "eight hundred" , "nine hundred" };                  
            int digit,fake,d;
        
        for (i=0 ; i<=12 ; i++)
        {
            int tmp  = array[i];
            fake = tmp;
            if (tmp < 20)
            {
                Console.WriteLine(words[tmp]);
            }
            else
            if (tmp > 20 && tmp <99)
            {
                digit = tmp % 10;
                tmp = tmp / 10;
                Console.WriteLine(tens[tmp] + "" + words[digit]);
            }
            else 
            {
                digit = tmp % 100;
                tmp = tmp / 10;
                                    d = tmp % 10;
                                    digit = digit - (d * 10)  ;
                    tmp = tmp / 10;
                   Console.WriteLine(hundreds[tmp] + " " + tens[d] + " " + words[digit]);
            }
        }

        }
    }
}        