//a simple LINQ query example using Entity Framework Core for a database table named Customers.
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
}
{
    var customers = context.Customers.ToList();
    var delhiCustomers = context.Customers
        .Where(c => c.City == "Delhi")
        .ToList();
    var names = context.Customers
        .Select(c => c.Name)
        .ToList();
    var groupedByCity = context.Customers
        .GroupBy(c => c.City)
        .Select(g => new { City = g.Key, Count = g.Count() })
        .ToList();
    int id = 1;
    var customer = context.Customers
        .FirstOrDefault(c => c.Id == id);
}