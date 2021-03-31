using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public class Guest : IGuest
    {
        private string _name;
        private string _email;
        private string _phone;
        
        public Guest(string Name, string Email, string Phone)
        {
            _name = Name;
            _email = Email;
            _phone = Phone;
        }

        public override string ToString()
        {
            return $"Name: {_name}; Email: {_email}; Phone: {_phone}";
        }
    }
}
