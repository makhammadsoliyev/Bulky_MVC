using System.ComponentModel.DataAnnotations;

namespace Bulky.Web.Models;

public class Category
{
    [Key]
    public long Id { get; set; }
    [Required]
    public string Name { get; set; }
    public int DisplayOrder { get; set; }
}
