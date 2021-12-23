using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookApplication
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Addresses { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public int zip { get; set; }
        public string? email { get; set; }
    }
}
