using System;
using System.Collections.Generic;
using Xunit;

namespace Lab4_AssertionSample
{
    public class AssertionSample
    {
        private CustomerRepo customerRepo = new CustomerRepo();

        [Fact]
        public void CompareCustomer()
        {
            var actual = customerRepo.Get();
            var expected = new Customer
            {
                Id = 2,
                Age = 18,
                Birthday = new DateTime(1990, 1, 26)
            };

            //how to assert customer?
        }

        [Fact]
        public void CompareCustomerList()
        {
            var actual = customerRepo.GetAll();
            var expected = new List<Customer>
            {
                new Customer
                {
                    Id = 3,
                    Age = 20,
                    Birthday = new DateTime(1993, 1, 2)
                },

                new Customer
                {
                    Id = 4,
                    Age = 21,
                    Birthday = new DateTime(1993, 1, 3)
                },
            };

            //how to assert customers?
        }

        [Fact]
        public void CompareComposedCustomer()
        {
            var actual = customerRepo.GetComposedCustomer();
            var expected = new Customer
            {
                Age = 30,
                Id = 11,
                Birthday = new DateTime(1999, 9, 9),
                Order = new Order { Id = 19, Price = 91 },
            };

            //how to assert composed customer?
        }

        [Fact]
        public void PartialCompare_Customer_Birthday_And_Order_Price()
        {
            var actual = customerRepo.GetComposedCustomer();

            var expected = new Customer
            {
                Birthday = new DateTime(1999, 9, 9),
                Order = new Order { Price = 91 },
            };

            //how to assert actual is equal to expected?
        }
    }

    public class CustomerRepo
    {
        public Customer Get()
        {
            return new Customer
            {
                Id = 2,
                Age = 18,
                Birthday = new DateTime(1990, 1, 26)
            };
        }

        public List<Customer> GetAll()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id = 3,
                    Age = 20,
                    Birthday = new DateTime(1993, 1, 2)
                },

                new Customer
                {
                    Id = 4,
                    Age = 21,
                    Birthday = new DateTime(1993, 1, 3)
                },
            };
        }

        public Customer GetComposedCustomer()
        {
            return new Customer
            {
                Age = 30,
                Id = 11,
                Birthday = new DateTime(1999, 9, 9),
                Order = new Order { Id = 19, Price = 91 },
            };
        }
    }

    public class Order
    {
        public int Id { get; set; }

        public int Price { get; set; }
    }

    public class Customer
    {
        public int Age { get; set; }

        public DateTime Birthday { get; set; }

        public int Id { get; set; }

        public Order Order { get; set; }
    }
}