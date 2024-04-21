using System.ComponentModel.DataAnnotations;

public class Shop
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required, MaxLength(50)]
    public string Address { get; set; }
    public int CityId { get; set; }
    public City City { get; set; }
    public int? ParkingArea { get; set; }

    public ICollection<Worker> Workers { get; set; }
}
