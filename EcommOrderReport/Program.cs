using EcommOrderReport.Models;

namespace EcommOrderReport
{
    class Program
    {
        public static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Ravi", City = "Ahmedabad" },
                new Customer { Id = 2, Name = "Neha", City = "Surat" },
                new Customer { Id = 3, Name = "Amit", City = "Vadodara" },
                new Customer { Id = 4, Name = "Priya", City = "Rajkot" },
                new Customer { Id = 5, Name = "Dev", City = "Himmatnagar" }
                
            };

            var orders = new List<Order>
            {
                new Order
                {
                    OrderId = 101,
                    CustomerId = 1,
                    OrderDate = new DateTime(2024, 10, 12),
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "Laptop", Price = 55000, Quantity = 1 },
                        new OrderItem { ProductName = "Mouse", Price = 500, Quantity = 2 }
                    }
                },

                new Order
                {
                    OrderId = 102,
                    CustomerId = 2,
                    OrderDate = new DateTime(2024, 11, 05),
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "Keyboard", Price = 1500, Quantity = 1 },
                        new OrderItem { ProductName = "Monitor", Price = 12000, Quantity = 1 }
                    }
                },

                new Order
                {
                    OrderId = 103,
                    CustomerId = 1,
                    OrderDate = new DateTime(2024, 12, 01),
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "USB Cable", Price = 200, Quantity = 3 }
                    }
                },

                new Order
                {
                    OrderId = 104,
                    CustomerId = 3,
                    OrderDate = new DateTime(2025, 01, 15),
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "Tablet", Price = 22000, Quantity = 1 },
                        new OrderItem { ProductName = "Cover", Price = 800, Quantity = 1 }
                    }
                }
            };
            // //Join: Join customers with their orders. Show customer name, city, order date, and total order amount.
            // var result = customers.Join(orders, c => c.Id, o => o.CustomerId, (c, o) => 
            //     new
            //     {
            //         CustomerName = c.Name,
            //         CustomerCity = c.City,
            //         OrderData = o.OrderDate,
            //         TotalAmount = o.Items.Sum(i => i.Price * i.Quantity),
            //     }).ToList();
            // foreach (var data in result)
            // {
            //     Console.WriteLine($"{data.CustomerName} - {data.CustomerCity} - {data.OrderData} - {data.TotalAmount}");
            // }
            
            
            //Top Customers: Find the top 3 customers by total spending. Show name and total.
            // var result = customers.Join(orders, c => c.Id, o => o.CustomerId, (c, o) => 
            //     new
            //     {
            //         CustomerName = c.Name,
            //         CustomerCity = c.City,
            //         OrderData = o.OrderDate,
            //         TotalAmount = o.Items.Sum(i => i.Price * i.Quantity),
            //     }).OrderByDescending(c => c.TotalAmount).Take(3).ToList();
            // foreach (var data in result)
            // {
            //     Console.WriteLine($"{data.CustomerName} - {data.CustomerCity} - {data.OrderData} - {data.TotalAmount}");
            // }
            
            //Monthly Revenue: Group orders by month (Year-Month). Show monthly revenue and order count.
            // var result = orders.GroupBy(o => new
            // {
            //     o.OrderDate.Year,
            //     o.OrderDate.Month,
            // }).Select(g => new
            //     {
            //         Year = g.Key.Year,
            //         Month = g.Key.Month,
            //         OrderCount = g.Count(),
            //         Revenue = g.Sum(order => order.Items.Sum(i => i.Price * i.Quantity))
            //     }
            //         ).OrderBy(o => o.Year).ThenBy(o => o.Month).ToList();
            //     
            //     ;
            // foreach (var data in result)
            // {
            //     Console.WriteLine($"{data.Year}/{data.Month:D2}  Orders: {data.OrderCount} Revenue: {data.Revenue}");
            // }
            
            
            //Flatten all order items across all orders. Find the most ordered products by total quantity.
            // var result = orders.SelectMany(ord => ord.Items).GroupBy(ord => ord.ProductName)
            //     .Select(ord => new
            //     {
            //         ord = ord.Key,
            //         productQty = ord.Sum(ordItem => ordItem.Quantity)
            //     }).OrderByDescending(ord => ord.productQty).ToList();
            // foreach (var order in result)
            // {
            //     Console.WriteLine($"{order.productQty} - {order.ord}");
            // }

            // var inactiveCustomers = customers
            //     .GroupJoin(
            //         orders,
            //         c => c.Id,
            //         o => o.CustomerId,
            //         (c, o) => new { Customer = c, Orders = o }
            //     )
            //     .Where(x => !x.Orders.Any())
            //     .Select(x => x.Customer.Name)
            //     .ToList();
            //
            // foreach (var item in inactiveCustomers)
            // {
            //     Console.WriteLine($"{item} has never placed an order");
            // }
            
            
            var result = customers
                .GroupBy(c => c.City)
                .Select(cityGroup => new
                {
                    City = cityGroup.Key,
                    CustomerCount = cityGroup.Count(),

                    TotalOrders = orders
                        .Count(o => cityGroup.Any(c => c.Id == o.CustomerId)),

                    TotalRevenue = orders
                        .Where(o => cityGroup.Any(c => c.Id == o.CustomerId))
                        .Sum(o => o.Items.Sum(i => i.Price * i.Quantity))
                })
                .ToList();

            foreach (var city in result)
            {
                Console.WriteLine(
                    $"{city.City} | Customers: {city.CustomerCount} | Orders: {city.TotalOrders} | Revenue: {city.TotalRevenue}"
                );
            }
        }
    }
}