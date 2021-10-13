using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortCustomerDataF
{
    class BubbleSortCustomerDataF
    {
        void doBubbleSort(Customer[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j].getRating() > arr[j + 1].getRating())
                   
                    {
                        // swap temp and arr[i]
                        Customer temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

       







        void printArray(Customer[] arr)
                    {
                        int n = arr.Length;
                        for (int i = 0; i < n; ++i)
                        Console.Write(arr[i].getName() + " ");
                        Console.WriteLine();
                        Console.WriteLine();
                    }

        

        public static void Main(String[] args)
        {
            BubbleSortCustomerDataF ob = new BubbleSortCustomerDataF();
            Customer[] arr = {
            new Customer("Tama",2, "Auckland"),
            new Customer("Amelia",5,"Taranaki"),
            new Customer("Kaos", 3, "Hamilton"),
            new Customer("Karl", 4, "Papatoetoe"),
            new Customer("Carlos", 5, "Glenfield"),
            new Customer("Alicia", 2, "Whangarei"),
            new Customer("Zion", 2, "Wellington"),
            new Customer("Sara", 3, "Auckland"),
            new Customer("Bob", 4, "Papakura"),
            new Customer("Wiremu", 5, "Auckland")
            };

            Console.Write("Welcome to the Bubble Sort Customer Data: \r\n");
            Console.WriteLine("");

            Console.Write("The Unsorted array of Customers is: \r\n");
            ob.printArray(arr);

            // apply sort
            ob.doBubbleSort(arr);
            Console.Write("The Bubble is Sorted by Customer rating in ascending order: \r\n");
            ob.printArray(arr);

            Array.Reverse(arr);
            Console.Write("The Bubble is sorted by customer name in descending order: \r\n");
            ob.printArray(arr);

        }

    }
}
