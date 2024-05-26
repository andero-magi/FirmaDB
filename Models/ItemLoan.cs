using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class ItemLoan
  {
    [Key]
    public int Id { get; set; }
    
    [ForeignKey(nameof(Models.Employee.Id))]
    public Employee Employee { get; set; }

    [ForeignKey(nameof(Models.Item.Id))]
    public Item Item { get; set; }

    public DateTime LoanDate { get; set; }

    public DateTime ReturnDate { get; set; }

    public string Comment { get; set; }
  }
}
