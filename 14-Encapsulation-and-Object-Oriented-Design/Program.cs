// https://www.microsoft.com/net/tutorials/csharp/getting-started/encapsulation-oop

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConsoleApplication
{
    public class Order : IEquatable<Order>
    {
        public string OrderNumber { get; }
        public DateTime OrderDate { get; set; }

        public Order(string orderNumber, DateTime orderDate)
        {
            OrderNumber = orderNumber;
            OrderDate = orderDate;
        }

        public bool Equals(Order other)
        {
            return other.OrderNumber == OrderNumber;
        }
    }

    public class Customer
    {
        public string Name { get; }
        private List<Order> _orders = new List<Order>();
        private ReadOnlyCollection<Order> _ordersView;
        public ReadOnlyCollection<Order> Orders
        {
            get
            {
                if (_ordersView == null)
                {
                    _ordersView = new ReadOnlyCollection<Order>(_orders);
                }
                return _ordersView;
            }
        }

        public Customer(string name)
        {
            Name = name;
        }

        public void AddOrder(Order order)
        {
            if (order == null)
            {
                return;
            }
            else if (_orders.Contains(order))
            {
                return;
            }
            else if (order.OrderDate > DateTime.Now)
            {
                return;
            }
            else
            {
                _orders.Add(order);
            }
        }
    }
    
    public class Program
    {
        public static void Main()
        {
            var customer = new Customer("John Doe");

            customer.AddOrder(null);
            customer.AddOrder(new Order("1", DateTime.Parse("2016-12-22 16:12:00")));
            customer.AddOrder(new Order("1", DateTime.Now));
//            customer.AddOrder(new Order("2"));
            customer.AddOrder(new Order("3", DateTime.Now.AddDays(-4)));
            customer.AddOrder(new Order("4", DateTime.Now.AddDays(2)));

            printList(customer.Orders);

            customer.AddOrder(new Order("5", DateTime.Now.AddDays(-16)));

            Console.WriteLine();
            
            printList(customer.Orders);
        }
        
        private static void printList(IEnumerable<Order> orders)
        {
            foreach (Order order in orders)
            {
                Console.WriteLine(order.OrderNumber + "\t" + order.OrderDate.ToString());
            }
        }
    }
}