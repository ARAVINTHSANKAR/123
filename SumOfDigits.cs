using System;

namespace day_1
{
   public class SumOfDigits
    {
       public void sum() 
        {
            Console.WriteLine("Enter an integer");
            int number = Convert.ToInt32(Console.ReadLine());
            int digit , sum = 0 , res = 0;
            String[] words = {"zero" , "one" , "two" , "three" , "four" , "five" 
                                , "six" , "seven" , "eight" , "nine" , "ten"};

            if ( number > 9 && number < 99)
            {
                while(number != 0 )
                {
                    digit = number % 10;
                    number = number / 10;
                    sum = sum + digit; 
                }
                if(sum < 10) 
                {
                    //Console.WriteLine(sum);
                    Console.WriteLine("Sum of digits are" + words[sum]);
                }
                else 
                {
                    while(sum != 0 )
                        {
                            digit = sum % 10;
                            sum = sum / 10;
                            res = res + digit;
                        }
                }
                //Console.WriteLine(res);
                    Console.WriteLine("Sum of digits are" +words[res]);
            }
            else 
            {
                 while(number != 0 )
                {
                    digit = number % 100;
                    number = number / 100;
                    sum = sum + digit;
                    
                }
                if(sum < 10) 
                {
                   // Console.WriteLine(sum);
                    Console.WriteLine("Sum of digits are" +words[sum]);
                }
                else 
                {
                    while(sum != 0 )
                        {
                            digit = sum % 10;
                            sum = sum / 10;
                            res = res + digit;
                        }
                        Console.WriteLine(res);
                    Console.WriteLine(words[res]);
                }   
            }
        }
    }
}
