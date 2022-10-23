using Virtualdars.DesignPatterns.Decorator;

var order = new Order();
order.Products = new List<Product>
    {
        new Product {Name = "Smartphone", Price = 100},
        new Product {Name = "Tablet", Price = 100},
        new Product {Name = "Laptop", Price = 100}
    };
Console.WriteLine($"Buyurtmaning jami narxi: {order.CalculateTotalPrice()}, oddiy buyurtma.");

var preOrder = new PreOrderDecorator(order);
Console.WriteLine($"Buyurtmaning jami narxi: {preOrder.CalculateTotalPrice()}, avvaldan berilgan buyurtma.");

var memberOrder = new MemberOrderDecorator(order);
Console.WriteLine($"Buyurtmaning jami narxi: {memberOrder.CalculateTotalPrice()}, do'kon a'zosi bergan buyurtma.");

var memberPreOrder = new PreOrderDecorator(memberOrder); 
Console.WriteLine($"Buyurtmaning jami narxi: {memberPreOrder.CalculateTotalPrice()}, do'kon a'zosining avvaldan berilgan buyurtmasi."); // successive discount
Console.WriteLine();

Console.Read();