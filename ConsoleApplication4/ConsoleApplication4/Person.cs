using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Person
    {
        private String name;
        private String family;
        private String age;
        private String  natinalID;
        private String address;
        private String phoneNumber;

        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        
       

        public String Address
        {
            get { return address; }
            set { address = value; }
        }


        public String  NationalID
        {
            get { return natinalID; }
            set { natinalID = value; }
        }
        

        public String Age
        {
            get { return age; }
            set { age = value; }
        }


        public String Name
        {
            get { return name; }
            set { name = value; }
        }
       

        public String Family
        {
            get { return family; }
            set { family = value; }
        }
        
    }
}
