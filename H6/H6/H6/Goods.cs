using System;
using System.Collections.Generic;
using System.Text;

namespace H6
{
    class Goods
    {
        private string gName;
        private int goodPrice;
        public string name { get { return gName; } set { gName = value; } }
        public int price { get { return goodPrice; } set { goodPrice = value; } }
        public override string ToString()
        {
            return "商品名：" + gName + "，单价：" + price.ToString("C");
        }
        public override bool Equals(object obj)
        {
            Goods b = obj as Goods;
            return (b != null && name == b.name && price == b.price);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public static bool operator ==(Goods a, Goods b)
        {
            return object.Equals(a, b);
        }
        public static bool operator !=(Goods a, Goods b)
        {
            return !(a == b);
        }
    }
}
