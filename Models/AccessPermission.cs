using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class AccessPermission
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Models.Employee.Id))]
    public Employee Employee { get; set; }

    public string AccessLevels { get; set; }
  }
}
