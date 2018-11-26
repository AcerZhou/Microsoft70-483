using System;
using System.Collections.Generic;

namespace Microsoft70_483
{
    public class IComparableExample
    {
        public static void Example()
        {
            List<Order> orders = new List<Order>
            {
                new Order { Created = new DateTime(2012, 12, 1 )},
                new Order { Created = new DateTime(2012, 1, 6 )},
                new Order { Created = new DateTime(2012, 7, 8 )},
                new Order { Created = new DateTime(2012, 2, 20 )},
            };
            orders.Sort();
            orders.ForEach(o => Console.WriteLine(o.Created.ToString()));
        }
    }

    class Order : IComparable
    {
        public DateTime Created { get; set; }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Order o = obj as Order;
            if (o == null)
            {
                throw new ArgumentException("Object is not an Order");
            }
            return this.Created.CompareTo(o.Created);
        }
    }

}
