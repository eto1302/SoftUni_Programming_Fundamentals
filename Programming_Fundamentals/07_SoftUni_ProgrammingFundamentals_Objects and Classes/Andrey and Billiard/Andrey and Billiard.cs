using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07_Andrey_and_Billiard
{
    public class AndreyАndBilliard
    {
        public static void Main()
        {
            int entities = int.Parse(Console.ReadLine());

            var shop = new Dictionary<string, decimal>();
            for (int entitiesCntIndex = 1; entitiesCntIndex <= entities; entitiesCntIndex++)
            {
                var s = Console.ReadLine().Split('-').ToArray();
                string product = s[0];
                decimal price = decimal.Parse(s[1]);

                if (shop.ContainsKey(product))
                {
                    shop[product] = price;
                }
                else
                {
                    shop.Add(product, price);
                }
            }

            string line = Console.ReadLine();
            List<Customer> customers = new List<Customer>();
            while (line != "end of clients")
            {
                var s = line.Split(new char[] { '-', ',' }).ToArray();

                string customerName = s[0];
                string customerProduct = s[1];
                int customerQuantity = int.Parse(s[2]);

               
                if (shop.ContainsKey(customerProduct))
                {
                    Dictionary<string, int> customerShopList = new Dictionary<string, int>
                    {
                        { customerProduct, customerQuantity }
                    };
                    decimal customerBill = shop[customerProduct] * customerQuantity;

                    var customer = new Customer(customerName, customerShopList, customerBill);

                    if (customers.Any(x => x.Name == customerName))
                    {
                        var currentCustomer = customers.First(x => x.Name == customerName);

                        if (currentCustomer.ShopList.ContainsKey(customerProduct))
                        {
                            currentCustomer.ShopList[customerProduct] += customerQuantity;
                            currentCustomer.Bill += shop[customerProduct] * customerQuantity;
                        }
                        else
                        {
                            currentCustomer.ShopList[customerProduct] = customerQuantity;
                            currentCustomer.Bill += shop[customerProduct] * customerQuantity;
                        }
                    }
                    else
                    {
                        customers.Add(customer);
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var customer in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{customer.Name}");
                foreach (var shoplist in customer.ShopList)
                {
                    var product = shoplist.Key;
                    var quantitiy = shoplist.Value;
                    Console.WriteLine($"-- {product} - {quantitiy}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {customers.Sum(x => x.Bill):f2}");
        }

        class Customer
        {
            public Customer(string name, Dictionary<string, int> shopList, decimal bill)
            {
                Name = name;
                ShopList = shopList;
                Bill = bill;
            }

            public string Name { get; set; }

            public Dictionary<string, int> ShopList { get; set; }

            public decimal Bill { get; set; }
        }
    }
}
/*
4
Cola-1.25
Sandwich-2.30
Bira-0.01
Bira-2
Toshko-Bira,3
Mira-Sandwich,1
Marto-Kola,2
end of clients
 */
