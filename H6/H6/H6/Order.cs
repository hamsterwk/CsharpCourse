using System;
using System.Collections.Generic;
using System.Text;

namespace H6
{
    class Order
    {
        private int oid;
        private string cName;
        private int tot;
        public int id { get { return oid; } set { oid = value; } }
        public string customerName { get { return cName; } set { cName = value; } }
        public int totalPrice
        {
            get
            {
                int rtn = 0;
                foreach (OrderItem item in ItemList) { rtn += item.totalPrice; }
                return rtn;
            }
            set { tot = value; }
        }
        public List<OrderItem> ItemList;
        public Order(int orderId)
        {
            ItemList = new List<OrderItem>();
            oid = orderId;
            tot = 0;
        }
        public bool findByItem(OrderItem newItem)
        {
            foreach (OrderItem preItem in ItemList)
            {
                if (preItem.Equals(newItem)) { return true; }
            }
            return false;
        }
        public bool findByName(string gName)
        {
            foreach (OrderItem preItem in ItemList)
            {
                if (preItem.item.name == gName) { return true; }
            }
            return false;
        }
        public void add(OrderItem newItem)
        {
            ItemList.Add(newItem);
        }
        public override bool Equals(object obj)
        {
            Order cmp = obj as Order;
            return (cmp != null && cmp.ItemList == ItemList && cmp.customerName == customerName);
        }
        public static bool operator ==(Order a, Order b)
        {
            return object.Equals(a, b);
        }
        public static bool operator !=(Order a, Order b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            string rtn = "订单详情：\n订单号：" + oid + "\n客户名：" + customerName + "\n订单明细:";
            int i = 1;
            foreach (OrderItem item in ItemList)
            {
                rtn += $"\n+----------+\n项目{i}：" + item.ToString();
                i += 1;
            }
            rtn += "\n总价：" + totalPrice.ToString("C");
            return rtn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(oid, cName, tot, id, customerName, totalPrice, ItemList);
        }
    }
}
