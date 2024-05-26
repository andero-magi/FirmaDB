using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class ItemLoan
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Employee.Id))]
    public int EmployeeId { get; set; }

    [ForeignKey(nameof(Item.Id))]
    public int ItemId { get; set; }

    public DateTime LoanDate { get; set; }

    public DateTime ReturnDate { get; set; }

    public string Comment { get; set; }
  }
}
