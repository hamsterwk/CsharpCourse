using System;
using System.Collections.Generic;
using System.Text;

namespace H6
{
    class Customer
    {
        private string cName;
        public string name { get { return cName; } set { cName = value; } }
        public override string ToString()
        {
            return "买家姓名：" + cName;
        }
        public override bool Equals(object obj)
        {
            Customer m = obj as Customer;
            return m != null && name == m.name;
        }
        public override int GetHashCode()
        {
            return cName.GetHashCode();
        }
        public static bool operator ==(Customer a, Customer b)
        {
            if (a == null) return (b == null) ? true : false;
            return a.Equals(b);
        }
        public static bool operator !=(Customer a, Customer b)
        {
            return !(a == b);
        }
    }
}
