using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

public class Product
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Precision(18, 2)]
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}