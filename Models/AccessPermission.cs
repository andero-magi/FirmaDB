using System.ComponentModel.DataAnnotations;

namespace FirmaDB_Migration.Models
{
  public class AccessPermission
  {
    [Key]
    public int Id { get; set; }

    public Employee Employee { get; set; }

    public string AccessLevels { get; set; }
  }
}
