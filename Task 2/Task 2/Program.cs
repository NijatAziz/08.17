using Task_2;

var products = new List<Product>
        {
            new Product { Name = "Product 1", Price = 50, Count = 2 },
            new Product { Name = "Product 2", Price = 30, Count = 1 },
            new Product { Name = "Product 3", Price = 80, Count = 3 }
        };

var order = new Order
{
    Products = products,
    Date = DateTime.Now
};

Console.WriteLine($"Total Price after discount: {order.TotalPrice:C}");