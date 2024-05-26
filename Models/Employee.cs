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

    public virtual List<Child> Children { get; set; }

    public virtual List<LeaveRequest> LeaveRequests { get; set; }

    public virtual List<ItemLoan> Loans { get; set; }

    public virtual Title Title { get; set; }

    public virtual List<Vacation> Vacations { get; set; }

    public virtual HealthCheck HealthCheck { get; set; }

    public virtual List<SickLeave> SickLeaves { get; set; }

    public virtual AccessPermission AccessPermission { get; set; }
  }
}
