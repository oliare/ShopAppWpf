using System.ComponentModel.DataAnnotations;

public class Product
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public decimal Price { get; set; }
    public decimal? Discount { get; set; }
    public int? CategoryId { get; set; }
    public Category Category { get; set; }
    public int Quantity { get; set; }
    public bool InStock { get; set; }
}
