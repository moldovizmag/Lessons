// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using System.Runtime.Intrinsics.Arm;

using (var db = new AppDbContext())
{
    db.Database.EnsureCreated();
    NameSearch(db, "Яблоки");
}


static void AddProduct(AppDbContext db, string name, decimal price)
{
    db.Products.Add(new Product { Name = name, Price = price });
    db.SaveChanges();
}

static void ListProducts(AppDbContext db)
{
    foreach (var product in db.Products)
        Console.WriteLine($"{product.Id}: {product.Name} - {product.Price:C}");
}

static void UpdatePrice(AppDbContext db, int id, decimal price)
{
    var product = db.Products.Find(id);
    product.Price = price;
    db.SaveChanges();
}

static Product NameSearch(AppDbContext db, string name)
{
    Product product = db.Products.Where(p => p.Name.Contains(name)).First();
    Console.WriteLine($"{product.Name} - {product.Price:C}");
    return product;
}