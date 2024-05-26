using System.ComponentModel.DataAnnotations;

namespace FirmaDB_Migration.Models
{
  public class SickLeave
  {
    [Key]
    public int Id { get; set; }

    public Employee Employee { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int Days { get; set; }

    public string Description { get; set; }
  }
}
