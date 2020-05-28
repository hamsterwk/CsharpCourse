using System;
using System.Collections.Generic;
using System.Text;

namespace H5
{
    public class OrderItem
    {
        public Goods item;
        private int cnt;
        public OrderItem()
        {
            item = new Goods();
            cnt = 0;
        }
        public string ItemName { get {return item.name;} set { item.name = value; } }
        public int amount { get { return cnt; } set { cnt = value; } }
        public int Price { get { return item.price; } set {item.price=value; } }
        public int totalPrice { get { return amount * item.price; } }
        /*
         * 商品编号：。。。，商品名：。。。购买总数：。。。
         */
        public override string ToString()
        {
            return item.ToString() + "，购买总数：" + cnt;
        }
        public override bool Equals(object obj)
        {
            OrderItem m = obj as OrderItem;
            return m != null && item.Equals(m.item);
        }
        public override int GetHashCode()
        {
            //if (this == null) return 0;
            return ToString().GetHashCode();
        }
        public static bool operator ==(OrderItem a, OrderItem b)
        {
            return object.Equals(a, b);
        }
        public static bool operator !=(OrderItem a, OrderItem b)
        {
            return !(a == b);
        }
    }
}
