using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class Child
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Employee.Id))]
    public int EmployeeId { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string FirstName { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string LastName { get; set; }

    public int PersonalCode { get; set; }
  }
}
