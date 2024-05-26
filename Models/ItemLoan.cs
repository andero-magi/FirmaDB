using System.ComponentModel.DataAnnotations;

namespace FirmaDB_Migration.Models
{
  public class ItemLoan
  {
    [Key]
    public int Id { get; set; }

    public Employee Employee { get; set; }

    public Item Item { get; set; }

    public DateTime LoanDate { get; set; }

    public DateTime ReturnDate { get; set; }

    public string Comment { get; set; }
  }
}
