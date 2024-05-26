using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class Message
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Models.Employee.Id))]
    public Employee Reciever { get; set; }

    public string Content { get; set; }
  }
}
