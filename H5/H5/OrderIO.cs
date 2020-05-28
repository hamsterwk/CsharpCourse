using System;
using System.Collections.Generic;
using System.Text;

namespace H5
{
    public class OrderIO
    {
        static string[] a = { 
            "错误：该订单项已添加！", 
            "添加失败！订单已存在！", 
            "添加失败！订单为空！", 
            "请输入需要修改的订单号",
            "id不存在！",
            "\n请输入需要修改的项目编号，从1开始",
            "1:修改商品名，2:修改商品价格，3:修改商品数目，4:修改客户名，5：不需要修改，直接退出"
        };
        public static void PrintMenuModify(Order now)
        {
            Console.WriteLine(now.ToString());
            Console.WriteLine("1：增加订单项，2：删除订单项，3：修改订单项");
        }
        public static void PrintWarning(int opCode)
        {
            Console.WriteLine(a[opCode]);
        }
        public static void PrintWarning(string hint)
        {
            Console.WriteLine(hint);
        }
        public static int CheckInt(int lim=0, string input="")
        {
            int rtn;
            try
            {
                rtn = int.Parse(input);
                if (rtn < 0 || (lim != 0 && rtn > lim)) return -1;
            }
            catch
            {
                return -2;
            }
            return rtn;
        }
        public static int readInt(int lim = 0,string input="")
        {
            //if (hint != "") Console.WriteLine(hint);
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
        public static int ReadIndex(int lim)
        {
            PrintWarning(5);
            int rtn = readInt(lim);
            return rtn;
        }
        public static string ReadString(string hint="")
        {
            if (hint != "") Console.WriteLine(hint);
            return Console.ReadLine();
        }
        public static Customer ReadCustomer()
        {
            Console.WriteLine("请输入一个用户名：");
            Customer rtn = new Customer();
            rtn.name = Console.ReadLine();
            return rtn;
        } 
        public static int ReadTimes()
        {
            Console.WriteLine("请输入订单商品总数目：");
            int rtn = readInt();
            return rtn;
        }
        public static Goods ReadGoods()
        {
            Goods newGood = new Goods();
            Console.WriteLine("请输入该商品的名称");
            newGood.name = Console.ReadLine();
            Console.WriteLine("请输入该商品的购买价格：");
            newGood.price = OrderIO.readInt();
            return newGood;
        }
        public static OrderItem ReadOrderItem()
        {
            OrderItem newItem = new OrderItem();
            newItem.item = ReadGoods();
            Console.WriteLine("请输入该商品的购买数量：");
            newItem.amount = OrderIO.readInt();
            return newItem;
        }

        public static Order ReadOrder(int OrderId)
        {
            Order newOrder = new Order(OrderId);
            newOrder.customer = ReadCustomer();

            return newOrder;
        }

        public static void PrintAddOrderResult(Order newOrder, int status)
        {
            Console.Clear();
            switch (status)
            {
                case 0: { Console.WriteLine("添加成功！该订单的订单号为：" + newOrder.id); Console.WriteLine(newOrder.ToString()); break; }
                case -1: { PrintWarning(1);break; }
                case -2: { PrintWarning(2);break; }
            }
        }
        public static void PrintDelOrderResult(int status)
        {
            Console.Clear();
            switch (status)
            {
                case 0: { Console.WriteLine("删除成功！" ); break; }
                case -1: { Console.WriteLine("该订单不存在！"); break; }
                case -2: { Console.WriteLine("取消删除！"); ; break; }
            }
        }
        public static void PrintOrderList(List<Order> OrderList)
        {
            Console.WriteLine("当前订单总概况：");
            int cnt = 1;
            foreach (Order ord in OrderList)
            {
                Console.WriteLine("**********\n订单" + cnt + ":\n" + ord.ToString());
                cnt += 1;
            }
            if (OrderList.Count == 0)
            {
                Console.WriteLine("未找到结果！");
            }
        }
        public static void returnMain()
        {
            Console.WriteLine("输入任意键回到主界面");
            string buf = Console.ReadLine();
            Console.Clear();
        }
    }
}
