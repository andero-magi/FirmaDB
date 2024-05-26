using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class Message
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Employee.Id))]
    public int RecieverId { get; set; }

    public string Content { get; set; }
  }
}
