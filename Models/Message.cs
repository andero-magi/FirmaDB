using System.ComponentModel.DataAnnotations;

namespace FirmaDB_Migration.Models
{
  public class Message
  {
    [Key]
    public int Id { get; set; }

    public Employee Reciever { get; set; }

    public string Content { get; set; }
  }
}
