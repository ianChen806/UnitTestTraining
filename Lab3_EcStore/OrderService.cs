using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab3_EcStore
{
    public class OrderService
    {
        private string _filePath = @"C:\temp\testOrders.csv";

        public void SyncBookOrders()
        {
            var orders = GetOrdersFromCsv();

            var ordersOfBook = orders.Where(x => x.Type == "Book");

            var bookDao = new BookDao();
            foreach (var order in ordersOfBook)
            {
                bookDao.Insert(order);
            }
        }

        private List<Order> GetOrdersFromCsv()
        {
            var result = new List<Order>();

            using (var sr = new StreamReader(_filePath, Encoding.UTF8))
            {
                var rowCount = 0;

                while(sr.Peek() > -1)
                {
                    rowCount++;

                    var content = sr.ReadLine();

                    // Skip CSV header line
                    if (rowCount > 1)
                    {
                        var line = content.Trim().Split(',');

                        result.Add(Mapping(line));
                    }
                }
            }

            return result;
        }

        private Order Mapping(string[] line)
        {
            return new Order
            {
                ProductName = line[0],
                Type = line[1],
                Price = Convert.ToInt32(line[2]),
                CustomerName = line[3]
            };
        }
    }
}