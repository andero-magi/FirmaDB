using System.ComponentModel.DataAnnotations;

namespace FirmaDB_Migration.Models
{
  public class Item
  {
    [Key]
    public int Id { get; set; }

    public int AvailableQuantity { get; set; }
    public int Type { get; set; }
    public DateTime PurchasedDate { get; set; }
    public DateTime LiquidationDate { get; set; }
    public string Description { get; set; }

    public virtual List<ItemLoan> Loans { get; set; }
  }
}
