using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Web.Models;

public class Category
{
    [Key]
    public long Id { get; set; }
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(30)]
    [DisplayName("Category Name")]
    public string Name { get; set; }
    [DisplayName("Display Order")]
    [Range(1, 100, ErrorMessage = "Diplay Order must be between 1-100")]
    public int DisplayOrder { get; set; }
}
