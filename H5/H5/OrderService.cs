using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace H5
{
    public class OrderService
    {
        public static List<Order> OrderList = new List<Order> { };
        public static int OrderId = 1;


        public static void AddOrder()
        {
            Order toAdd = new Order(OrderId);
            toAdd.customer = OrderIO.ReadCustomer();
            AddItem(toAdd);
            int status = 0;
            if (toAdd.ItemList.Count <= 0){status = -2;}
            OrderList.Add(toAdd);
            OrderId += 1;
            OrderIO.PrintAddOrderResult(toAdd,status);
        }

        public static void AddOrder(Order newOrder)
        {
            OrderList.Add(newOrder);
            OrderId += 1;
        }

        public static Order GetById(int oid)
        {
            List<Order> query = (from order in OrderList where order.id == oid select order).ToList();
            try { Order rtn = query[0]; return rtn; }
            catch { return null; }
        }
        public static void AddItem(Order now)
        {
            int numOrder = OrderIO.ReadTimes();
            for (int i = 0; i < numOrder; i++)
            {
                OrderItem newItem = OrderIO.ReadOrderItem();
                if (now.findByItem(newItem))
                {
                    OrderIO.PrintWarning(0);
                    i--;
                    continue;
                }
                else now.add(newItem);
            }
        }
        public static void DeleteItem(ref Order now)
        {
            OrderIO.PrintWarning("\n请输入需要修改的项目编号，从1开始");
            int cid = OrderIO.readInt(now.ItemList.Count);
            OrderIO.PrintWarning(now.ItemList[cid - 1].ToString());
            OrderIO.PrintWarning("1：确认删除，2：取消删除");
            int opid = OrderIO.readInt(2);
            if (opid == 2) { OrderIO.PrintWarning("取消删除!"); return; }
            now.ItemList.RemoveAt(cid - 1);
        }



        public static void ModifyOrder()
        {
            OrderIO.PrintWarning(3);
            int oid = OrderIO.readInt();
            Order now = GetById(oid);
            if (now == null) { OrderIO.PrintWarning(4); return; }
            OrderIO.PrintMenuModify(now);
            int baseOpid = OrderIO.readInt(3);
            if (baseOpid == 1) { AddItem(now); }
            else if (baseOpid == 2) { DeleteItem(ref now); }
            else
            {
                int cid = OrderIO.ReadIndex(now.ItemList.Count);
                OrderIO.PrintWarning(6);
                int opid = OrderIO.readInt(5);
                switch (opid)
                {
                    case 1: { string newName = OrderIO.ReadString("请输入新商品名："); now.ItemList[cid - 1].item.name = newName; break; }
                    case 2: { int newPrice = OrderIO.readInt(0, "请输入新价格："); now.ItemList[cid - 1].item.price = newPrice; break; }
                    case 3: { int newNum = OrderIO.readInt(0, "请输入新数目："); now.ItemList[cid - 1].amount = newNum; break; }
                    case 4: { string newName = OrderIO.ReadString("请输入新客户名："); now.customer.name = newName; break; }
                    case 5: OrderIO.PrintWarning("取消修改！"); return;
                }
            }
            OrderIO.PrintWarning("修改完毕！");
        }

        public static void DeleteOrder()
        {
            OrderIO.PrintWarning("请输入需要删除的订单号：");
            int oid = OrderIO.readInt();
            Order now = GetById(oid);
            int status = 0;
            if (now == null) { status=-1; }
            else
            {
                OrderIO.PrintWarning($"您要删除的订单是：\n\n{now.ToString()}\n\n确认请按1，取消请按2");
                oid = OrderIO.readInt(2);
                if (oid == 2)
                {
                    status = -2;
                }
                else
                {
                    OrderList.Remove(now);
                }
            }
            OrderIO.PrintDelOrderResult(status);
        }
        public static void QueryOrder()
        {
            OrderIO.PrintWarning("订单查询系统\n1：按客户查询，2：按订单号查询，3：按包含某商品名查询");
            int opid = OrderIO.readInt(3);
            List<Order> result = new List<Order>();
            switch (opid)
            {
                case 1:
                    {
                        string qName = OrderIO.ReadString("请输入用户名：");
                        result = (from order in OrderList where order.customer.name == qName select order).ToList();
                        break;
                    }
                case 2:
                    {
                        int oid = OrderIO.readInt(0,"请输入订单号：");
                        result = (from order in OrderList where order.id == oid select order).ToList();
                        break;
                    }
                case 3:
                    {
                        string qName = OrderIO.ReadString("请输入商品名：");
                        result = (from order in OrderList where order.findByName(qName) select order).ToList();
                        break;
                    }
            }
            result.Sort((o1, o2) => o2.totalPrice - o1.totalPrice);
            OrderIO.PrintOrderList(result);
        }

        public static List<Order> QueryByItem(string qText)
        {
            List<Order> result = new List<Order>();
            result= (from order in OrderList where order.findByName(qText) select order).ToList();
            return result;
        }

        public static List<Order> QueryByCustomer(string qText)
        {
            List<Order> result = new List<Order>();
            result = (from order in OrderList where order.customer.name==qText select order).ToList();
            return result;
        }

        public static Order QueryById(int id)
        {
            List<Order> result = (from order in OrderList where order.id==id select order).ToList();
            if (result.Count == 0) return null;
            return result[0];
        }

        public static void RemoveById(int index)
        {
            OrderList.Remove(QueryById(index));
        }
    }
}
