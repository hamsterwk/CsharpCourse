using System;
using System.Collections.Generic;
using System.Text;

namespace H5
{
    public class Customer
    {
        public String name { get; set; }
        public Customer()
        {

        }
        //public string name { get { return cName; } set { cName = value; } }
        public override string ToString()
        {
            return name;
        }
        public override bool Equals(object obj)
        {
            Customer m = obj as Customer;
            return m != null && name == m.name;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public static bool operator ==(Customer a, Customer b)
        {
            return object.Equals(a,b);
        }
        public static bool operator !=(Customer a, Customer b)
        {
            return !(a == b);
        }
    }
}
