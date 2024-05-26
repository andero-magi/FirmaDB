using System.ComponentModel.DataAnnotations;

namespace FirmaDB_Migration.Models
{
  public class LeaveRequest
  {
    [Key]
    public int Id { get; set; }

    public Employee Employee { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Description { get; set; }
  }
}
