using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    public class Search
    {
        int[] arr = { 8, 9, 12, 15, 17, 19, 20, 21, 28 };

        public static int binarysearch(int [] arr, int value)
        {

            int start = 0; 
            int end = arr.Length - 1;
            int middle = (start + end) / 2;
            Console.WriteLine(start + " " + middle + " " + end);


            while (arr [middle] != value && start <= end)
            {
                if (value < arr[middle])
                {
                    end = middle - 1;
                } //end if 
                else
                {
                    start = middle + 1;
                }
                middle = (start + end) / 2;
                Console.WriteLine(start + " " + middle + " " + end);

            } //end while
            if (arr[middle] == value)
            {
                Console.WriteLine("The element is found at the index: " + middle);
                return middle;
            }
            else
            {
                Console.WriteLine("The element " + value + "not found");
                return -1;
            }


        }//end binarysearch


    }
}
