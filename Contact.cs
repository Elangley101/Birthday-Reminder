using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayReminder
{
    public class Contact
    {
        private string name;
        private DateTime birthdate;

        public string Name { get => name; set => name = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }

        public Contact() { }

        public Contact(string name, DateTime birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
        }
    }
}
