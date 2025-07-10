//Ecommerce system

using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; }
    public string Name { get; }
    public double Price { get; }
    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
    public void Display()
    {
        Console.WriteLine($"ID: {Id} | Name: {Name} | Price: ₹{Price:F2}");
    }
}
class CartItem
{
    public Product Product { get; }
    public int Quantity { get; set; }
    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
    public double GetTotalPrice()
    {
        return Product.Price * Quantity;
    }
    public void Display()
    {
        Console.WriteLine($"{Product.Name} x{Quantity} = ₹{GetTotalPrice():F2}");
    }
}
class Cart
{
    private List<CartItem> items = new List<CartItem>();
    public void AddItem(Product product, int quantity)
    {
        foreach (var item in items)
        {
            if (item.Product.Id == product.Id)
            {
                item.Quantity += quantity;
                return;
            }
        }
        items.Add(new CartItem(product, quantity));
    }
    public void ViewCart()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Cart is empty.");
            return;
        }
        Console.WriteLine("Your Cart:");
        foreach (var item in items)
        {
            item.Display();
        }
        Console.WriteLine($"Total: ₹{GetTotal():F2}");
    }
    public double GetTotal()
    {
        double total = 0;
        foreach (var item in items)
        {
            total += item.GetTotalPrice();
        }
        return total;
    }
    public List<CartItem> GetItems()
    {
        return new List<CartItem>(items); // Return a copy
    }
    public void Clear()
    {
        items.Clear();
    }
    public bool IsEmpty()
    {
        return items.Count == 0;
    }
}
class Order
{
    private static int orderCount = 0;
    private int orderId;
    private List<CartItem> items;
    private double total;
    public Order(List<CartItem> items, double total)
    {
        orderId = ++orderCount;
        this.items = new List<CartItem>(items);
        this.total = total;
    }
    public void Display()
    {
        Console.WriteLine($"Order ID: {orderId}");
        foreach (var item in items)
        {
            item.Display();
        }
        Console.WriteLine($"Total Amount: ₹{total:F2}");
    }
}
class ECommerceSystem
{
    static void Main()
    {
        List<Product> catalog = new List<Product>
        {
            new Product(1, "Samsung M33", 20000),
            new Product(2, "HP Laptop", 50000),
            new Product(3, "Reebok Shoes", 2000),
            new Product(4, "LED TV", 30000)
        };
        Cart cart = new Cart();
        List<Order> orderHistory = new List<Order>();
        while (true)
        {
            Console.WriteLine("\n--- E-Commerce System ---");
            Console.WriteLine("1. View Products");
            Console.WriteLine("2. Add to Cart");
            Console.WriteLine("3. View Cart");
            Console.WriteLine("4. Place Order");
            Console.WriteLine("5. View Orders");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Available Products:");
                    foreach (var product in catalog)
                    {
                        product.Display();
                    }
                    break;

                case 2:
                    Console.Write("Enter Product ID: ");
                    int pid = int.Parse(Console.ReadLine());
                    Console.Write("Enter Quantity: ");
                    int qty = int.Parse(Console.ReadLine());

                    Product selected = catalog.Find(p => p.Id == pid);
                    if (selected != null)
                    {
                        cart.AddItem(selected, qty);
                        Console.WriteLine("Added to cart!");
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                    break;

                case 3:
                    cart.ViewCart();
                    break;

                case 4:
                    if (cart.IsEmpty())
                    {
                        Console.WriteLine("Cart is empty.");
                    }
                    else
                    {
                        Order order = new Order(cart.GetItems(), cart.GetTotal());
                        orderHistory.Add(order);
                        Console.WriteLine("Order placed successfully!");
                        order.Display();
                        cart.Clear();
                    }
                    break;

                case 5:
                    if (orderHistory.Count == 0)
                    {
                        Console.WriteLine("No orders placed yet.");
                    }
                    else
                    {
                        foreach (var order in orderHistory)
                        {
                            order.Display();
                            Console.WriteLine("-----");
                        }
                    }
                    break;

                case 6:
                    Console.WriteLine("Thank you for shopping!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}