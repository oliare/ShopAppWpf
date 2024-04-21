using System.ComponentModel.DataAnnotations;

public class Worker
{
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    public decimal Salary { get; set; }
    [Required, MaxLength(30)]
    public string Email { get; set; }
    [Required, MaxLength(13)]
    public string PhoneNumber { get; set; }
    public int PositionId { get; set; }
    public Position Position { get; set; }
    public int ShopId { get; set; }
    public Shop Shop { get; set; }
}
