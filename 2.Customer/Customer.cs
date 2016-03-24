using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Customer
{
    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long id;
        private string permanentAddress;
        private string mobilePhone;
        private string email;


        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Customer other)
        {
            throw new NotImplementedException();
        }
    }
}

//first name, middle name and last name, ID (EGN), permanent address, mobile phone, e-mail, list of payments and customer type. 