using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class Vacation
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Models.Employee.Id))]
    public Employee Employee { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int Days { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string Reason { get; set; }
  }
}
