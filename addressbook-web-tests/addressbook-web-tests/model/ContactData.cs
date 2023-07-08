using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAddressbookTests;

namespace addressbook_web_tests
{
    public class ContactData : IEquatable<ContactData>
    {
        private string firstname;
        private string lastname;
        private string text;

        public bool Equals(ContactData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
             return (Lastname == other.Lastname) && (Firstname == other.Firstname);





        }

        public override int GetHashCode()

        {
            return Firstname.GetHashCode();
        }
        public ContactData(string firstname,string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public ContactData(string text)
        {
            this.text = text;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
               
    }
}
