using System;

namespace day_1
{
    public class InsertionSorting 
    {
        public void sort()
        {
            int i,j,temp;
            int[] array = new int[5];
            
            Console.WriteLine("Enter the array values");
            
        for(i=0 ; i<=5 ; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }             

    Console.WriteLine("Before sorting");

        for(i=0 ; i<=5 ; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine("");
                for (i=1 ; i<=5 ; i++)
                {
                for (j=0 ; j<=5 ; j++)
                    {
                        if (array[i] < array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                        else 
                        {
                            j++;
                        }
                    }
                }

                Console.WriteLine("After sorting");

            for (i=0 ; i<=5 ; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}