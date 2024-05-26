using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class Employee
  {
    [Key]
    public int Id { get; set; }

    public int PersonalCode { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string FirstName { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string LastName { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string ContactEmail { get; set; }

    [Column(TypeName = "varchar(22)")]
    public string PhoneNum { get; set; }

    public int VacationDaysBalance { get; set; }

    public List<Child> Children { get; set; }
  }
}
