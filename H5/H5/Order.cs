using System;
using System.Collections.Generic;
using System.Text;

namespace H5
{
    public class Order
    {
        private int oid;
        private Customer Customer;
        private int tot;
        public int id { get { return oid; } set { oid = value; } }
        public Customer customer { get { return Customer; } set { Customer = value; } }
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
            customer = new Customer();
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
            return (cmp != null && cmp.ItemList == ItemList && cmp.customer == customer);
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
            string rtn = "订单详情：\n订单号：" + oid + "\n客户名：" + customer + "\n订单明细:";
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
            var hashCode = -973131087;
            hashCode = hashCode * -1521134295 + oid.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + tot.GetHashCode();
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(customer);
            hashCode = hashCode * -1521134295 + totalPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(ItemList);
            return hashCode;
        }
    }
}
