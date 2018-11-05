using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.UserModels
{
    public class Customer : User
    {
        public Customer()
        {
            Role = Role.Customer;
        }

        public override User Copy(User user)
        {
            Customer customer = (Customer)user;
            Name = customer.Name;
            Address = customer.Address;
            Phone = customer.Phone;
            DateOfBirth = customer.DateOfBirth;
            Email = customer.Email;
            Gender = customer.Gender;
            return customer;
            
        }
    }
}
