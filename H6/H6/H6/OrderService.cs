using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
namespace H6
{
    [Serializable]
    class OrderService
    {
        List<Order> OrderList = new List<Order> { };
        private static int OrderId = 1;
        public OrderService() { }
        public static int readInt(int lim = 0)
        {
            int rtn = -1;
            string buf = Console.ReadLine();
            while (rtn <= 0)
            {
                try { rtn = int.Parse(buf); }
                catch { }
                if (rtn > 0 && (lim == 0 || (lim != 0 && rtn <= lim))) break;
                Console.WriteLine("输入非法，请重新输入！");
                buf = Console.ReadLine();
            }
            return rtn;
        }
        void returnMain()
        {
            Console.WriteLine("输入任意键回到主界面");
            string buf = Console.ReadLine();
            Console.Clear();
        }
        void addOrder()
        {
            Order toAdd = new Order(OrderId);
            Console.WriteLine("请输入本订单的客户名");
            toAdd.customerName = Console.ReadLine();
            addItem(ref toAdd);
            Console.Clear();
            foreach (Order preOrder in OrderList)
            {
                if (preOrder == toAdd)
                {
                    Console.WriteLine("错误：该订单已添加过完全一致的一个订单！");
                    return;
                }
            }
            if (toAdd.ItemList.Count <= 0)
            {
                Console.WriteLine("订单为空！");
                return;
            }
            OrderList.Add(toAdd);
            OrderId += 1;
            Console.WriteLine("添加成功！该订单的订单号为：" + toAdd.id);
            Console.WriteLine(toAdd.ToString());
        }
        public void print(List<Order> orderList)
        {
            Console.WriteLine("当前订单总概况：");
            int cnt = 1;
            foreach (Order ord in orderList)
            {
                Console.WriteLine("**********\n订单" + cnt + ":\n" + ord.ToString());
                cnt += 1;
            }
        }
        Order getById(int oid)
        {
            List<Order> query = (from order in OrderList where order.id == oid select order).ToList();
            try { Order rtn = query[0]; return rtn; }
            catch { return null; }
        }
        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderService));
            using (FileStream fs = new FileStream("result.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, this);
            }
        }
        void addItem(ref Order now)
        {
            Console.WriteLine("请输入需要补充的订单明细：\n请输入一个商品名，输入STOP可停止输入。");
            string buf = Console.ReadLine();
            while (buf != "STOP")
            {
                OrderItem newItem = new OrderItem();
                Goods newGood = new Goods();
                newGood.name = buf;
                Console.WriteLine("请输入该商品的购买价格：");
                newGood.price = readInt();
                newItem.item = newGood;
                Console.WriteLine("请输入该商品的购买数量：");
                newItem.amount = readInt();
                if (now.findByItem(newItem))
                {
                    Console.WriteLine("错误：该商品明细已添加过！");
                }
                else { now.add(newItem); }
                Console.WriteLine("请下一个需要补充的订单明细：\n请输入一个商品名，输入STOP可停止输入。");
                buf = Console.ReadLine();
            }
        }
        void deleteItem(ref Order now)
        {
            Console.WriteLine("\n请输入需要修改的项目编号，从1开始");
            int cid = readInt(now.ItemList.Count);
            Console.WriteLine(now.ItemList[cid - 1].ToString());
            Console.WriteLine("1：确认删除，2：取消删除");
            int opid = readInt(2);
            if (opid == 2) { Console.WriteLine("取消删除"); return; }
            now.ItemList.RemoveAt(cid - 1);
        }
        void modifyOrder()
        {
            Console.Clear();
            Console.WriteLine("请输入需要修改的订单号");
            int oid = readInt();
            Order now = getById(oid);
            if (now == null) { Console.WriteLine("id不存在！"); return; }
            Console.WriteLine(now.ToString());
            int baseOpid = -1;
            Console.WriteLine("1：增加订单项，2：删除订单项，3：修改订单项");
            baseOpid = readInt(3);
            if (baseOpid == 1) { addItem(ref now); }
            else if (baseOpid == 2) { deleteItem(ref now); }
            else
            {
                Console.WriteLine("\n请输入需要修改的项目编号，从1开始");
                int cid = readInt(now.ItemList.Count);
                Console.WriteLine("1:修改商品名，2:修改商品价格，3:修改商品数目，4:修改客户名，5：不需要修改，直接退出");
                int opid = readInt(5);
                switch (opid)
                {
                    case 1: { Console.WriteLine("请输入新商品名："); string newName = Console.ReadLine(); now.ItemList[cid - 1].item.name = newName; break; }
                    case 2: { Console.WriteLine("请输入新价格："); int newPrice = readInt(); now.ItemList[cid - 1].item.price = newPrice; break; }
                    case 3: { Console.WriteLine("请输入新数目："); int newNum = readInt(); now.ItemList[cid - 1].amount = newNum; break; }
                    case 4: { Console.WriteLine("请输入新客户名："); string newName = Console.ReadLine(); now.customerName = newName; break; }
                    case 5: Console.WriteLine("取消修改！"); return;
                }
            }
            Console.WriteLine("修改完毕！");
        }

        void deleteOrder()
        {
            Console.WriteLine("请输入需要删除的订单号：");
            int oid = readInt();
            Order now = getById(oid);
            if (now == null) { Console.WriteLine("id不存在！"); return; }
            Console.WriteLine($"您要删除的订单是：\n\n{now.ToString()}\n\n确认请按1，取消请按2");
            oid = readInt(2);
            if (oid == 2)
            {
                Console.WriteLine("取消删除！");
                return;
            }
            OrderList.Remove(now);
            Console.WriteLine("删除完毕！");
        }
        void queryOrder()
        {
            Console.WriteLine("订单查询系统\n1：按客户查询，2：按订单号查询，3：按包含某商品名查询");
            int opid = readInt(3);
            List<Order> result = new List<Order>();
            switch (opid)
            {
                case 1:
                    {
                        Console.WriteLine("请输入用户名：");
                        string qName = Console.ReadLine();
                        result = (from order in OrderList where order.customerName == qName select order).ToList();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("请输入订单号：");
                        int oid = readInt();
                        result = (from order in OrderList where order.id == oid select order).ToList();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("请输入商品名：");
                        string qName = Console.ReadLine();
                        result = (from order in OrderList where order.findByName(qName) select order).ToList();
                        break;
                    }
            }
            result.Sort((o1, o2) => o2.totalPrice - o1.totalPrice);
            print(result);
            if (result.Count == 0)
            {
                Console.WriteLine("未找到结果！");
            }
        }

        public void mainInteraction()
        {
            int opid = -1;
            while (opid != 6)
            {
                Console.WriteLine("订单查询系统：\n1：添加新订单，2：修改原订单，3：删除订单，4：查询订单，5：输出所有订单，6：退出系统");
                opid = readInt(6);
                Console.Clear();
                switch (opid)
                {
                    case 1: addOrder(); break;
                    case 2: modifyOrder(); break;
                    case 3: deleteOrder(); break;
                    case 4: queryOrder(); break;
                    case 5: print(OrderList); break;
                    case 6: Console.WriteLine("再见！"); return;
                    default: Console.WriteLine("输入非法！请重新输入！"); break;
                }
                returnMain();
            }
        }
    }
}
