using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class AccessPermission
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Employee.Id))]
    public int EmployeeId { get; set; }

    public string AccessLevels { get; set; }
  }
}
