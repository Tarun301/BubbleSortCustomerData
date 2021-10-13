using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortCustomerDataF
{
    class Customer : IComparable<Customer>
    {
        private String name;
        private int rating;
        private String address;

        // getter methods
        public String getName()
        {
            return name;
        }

        public int getRating()
        {
            return rating;
        }

        public String getAddress()
        {
            return address;
        }

        public int CompareTo(Customer other)
        {
            return this.name.CompareTo(other.name);
        }

        public Customer(String newName, int newRating, String newAddress)
        {
            name = newName;
            rating = newRating;
            address = newAddress;
        }
    }
}
