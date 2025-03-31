using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressOfJoeMama = new Address("6849 76th E", "Albuqurque", "New Mexico", "usa");
        Coustemer joeMama = new Coustemer("Joe Mama", addressOfJoeMama);

        Address addressOfBobLee = new Address("2329 34th S", "Rexburg", "Idaho", "Zion");
        Coustemer BobLee = new Coustemer("Bob Lee", addressOfBobLee);

        Product product1 = new Product("Soap", 1002, 1.58F, 6);
        Product product2 = new Product("Razor", 1028, 8.22F, 2);
        Product product3 = new Product("Shampoo", 1008, 5.33F, 1);
        List<Product> list1 = new List<Product> {product1, product2, product3};

        Product product4 = new Product("Chips", 1425, 4.88F, 100);
        Product product5 = new Product("Monitor", 1208, 111.92F, 8);
        Product product6 = new Product("Desktop", 1008, 4432.333F, 1);
        List<Product> list2 = new List<Product> {product4, product5, product6};

        Order order1 = new Order(joeMama, list1);
        Order order2 = new Order(BobLee, list2);

        List<Order> orderList = new List<Order> {order1, order2};

        foreach(Order order in orderList)
        {
            Console.WriteLine($"Shipping Label \n{order.GetShippingLabel()}");
            Console.WriteLine($"Packing Label: \n{order.GetPackingLabel()}");
            Console.WriteLine($"Total Order Cost: ${order.CalculateTotalCost()}\n");
        }


    }
}