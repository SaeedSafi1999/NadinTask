using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Entities;

public class Product
{
    [Key]
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public DateTime ProduceDate { get; set; }
    public string ManufactureEmail { get; set; }
    public string ManufacturePhone { get; set; }
    public bool IsAvailAble { get; set; }

    public virtual User User { get; set; }

}