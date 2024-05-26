using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class HealthCheck
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Employee.Id))]
    public int EmployeeId { get; set; }

    public DateTime CheckDate { get; set; }

    public string Results { get; set; }
  }
}
