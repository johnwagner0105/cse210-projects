using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Pencil", "324A", 5, 3);
        Product product2 = new Product("Eraser", "524Z", 8, 2);
        Product product3 = new Product("Paper", "852E", 10, 3);
        Address address1 = new Address("123 Elm Street", "New York City", "NY", "USA");
        Customer customer1 = new Customer(address1, "Bob the builder");
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address("246 Oak Circle", "London", "England", "UK");
        Customer customer2 = new Customer(address2, "Big Ben");
        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Address address3 = new Address("246 Oak Circle", "Longon", "England", "UK");
        Customer customer3 = new Customer(address3, "Big Ben");
        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product3);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);
        for (int i = 0; i < orders.Count(); i++)
        {
            Console.WriteLine(@$"Order{i + 1} Total Cost: ${orders[i].CalculateTotalCost()}
{orders[i].DisplayPackingLabel()}
{orders[i].DisplayShippingLabel()}");
        }

    }
}