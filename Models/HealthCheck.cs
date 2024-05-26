using System.ComponentModel.DataAnnotations;

namespace FirmaDB_Migration.Models
{
  public class HealthCheck
  {
    [Key]
    public int Id { get; set; }

    public Employee Employee { get; set; }

    public DateTime CheckDate { get; set; }

    public string Results { get; set; }
  }
}
