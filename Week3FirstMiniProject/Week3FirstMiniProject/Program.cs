Dictionary<int, Order> orders = new Dictionary<int, Order>()
{
    { 1, new Order(1, "John Doe", "Laptop", 999.99m, "Shipped") },
    { 2, new Order(2, "Jane Smith", "Book", 19.99m, "Processing") },
    { 3, new Order(3, "Bob Johnson", "Headphones", 149.99m, "Delivered") },
    { 4, new Order(4, "Alice Brown", "Smartphone", 699.99m, "Cancelled") },
    { 5, new Order(5, "Charlie Wilson", "Tablet", 399.99m, "Pending") },
    { 6, new Order(6, "David Lee", "Monitor", 249.99m, "Shipped") },
    { 7, new Order(7, "Emily Davis", "Keyboard", 89.99m, "Processing") },
    { 8, new Order(8, "Frank Miller", "Mouse", 49.99m, "Delivered") },
    { 9, new Order(9, "Grace Taylor", "Printer", 199.99m, "Pending") },
    { 10, new Order(10, "Hannah Anderson", "Camera", 599.99m, "Shipped") }
};

void AddOrder(Order order)
{
    orders.Add(order.Id, order);
}

Order newOrder = new Order(11, "Ivan Petrov", "Keyboard", 79.99m, "Pending");
AddOrder(newOrder);

HashSet<string> GetUniqueCustomers()
{
    HashSet<string> uniqueCustomers = new HashSet<string>();
    uniqueCustomers = orders.Values.Select(o => o.CustomerName).ToHashSet();
    return uniqueCustomers;
}
Console.WriteLine(string.Join(", \n", GetUniqueCustomers()));

var sum = orders.Values.Sum(o => o.Price);
var average = orders.Values.Average(o => o.Price);
var moreThan = orders.Values.Count(o => o.Price > 100);
var statusCount = orders.Values.GroupBy(o => o.Status).ToDictionary(g => g.Key, g => g.Count());
foreach (var order in statusCount)
{
    Console.WriteLine($"Status: {order.Key}, Count: {order.Value}");
}
var MostExpensiveOrder = orders.Values.MaxBy(o => o.Price);
Console.WriteLine($"Total Price: {sum}");
Console.WriteLine($"Average Price: {average}");
Console.WriteLine($"Number of Orders with Price > 100: {moreThan}");
Console.WriteLine($"Most Expensive Order: {MostExpensiveOrder.Product} (${MostExpensiveOrder.Price:F2})");

var clock = new System.Diagnostics.Stopwatch();
clock.Start();
await Task.WhenAll(orders.Values.Select(order => SendOrderToServerAsync(order)));
clock.Stop();
Console.WriteLine($"Time taken to send all orders: {clock.ElapsedMilliseconds} ms");
async Task<bool> SendOrderToServerAsync(Order order)
{
    await Task.Delay(1000); // Simulate network delay
    Console.WriteLine($"Order {order.Id} sent to server.");
    return true; // Simulate successful send
}

record Order(int Id, string CustomerName, string Product, decimal Price, string Status);