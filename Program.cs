using System;
 

namespace Reverse_Array
{
    public class ReverseArray
    {
        class Program
        {
            static void Main()
            {
                int i;
                int n = 10;
                double[] a = new double[100];

                Console.Write("\n\n Please input 10 numbers to 2 decimal places. \n\n For Example: 1.00 \n\n");
                for(i=0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    a[i] = Convert.ToDouble(Console.ReadLine()); //takes ten inputs
                }

                Console.Write("\n\n The values stored in the array are : \n "); // prints values in order
                for(i=0; i < n; i++)
                {
                    Console.Write("{0} ", a[i]);
                }

                Console.Write("\n\n The values stored in the array in reverse order are : \n"); //prints values in reverse order
                for(i=n-1; i>=0; i--)
                {
                    Console.Write("{0} ", a[i], "\n\n");
                }
                 
                    }
        }
    }

}