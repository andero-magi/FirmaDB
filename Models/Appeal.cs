using System.ComponentModel.DataAnnotations;

namespace FirmaDB_Migration.Models
{
  public class Appeal
  {
    [Key]
    public int Id { get; set; }

    public string Content { get; set; }
  }
}
